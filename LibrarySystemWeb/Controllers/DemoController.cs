using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LibrarySystemWeb.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DemoController : ControllerBase
    {
        // ✅ Simple GET: /api/demo
        [HttpGet]
        public ActionResult<ApiResponse<string>> SimpleGet()
        {
            return Ok(new ApiResponse<string>("Hello from Simple GET!"));
        }

        // ✅ GET with route parameters: /api/demo/value1/value2
        [HttpGet("{var1}/{var2}")]
        public ActionResult<ApiResponse<RouteParamsResponse>> GetWithRouteParams(string var1, string var2)
        {
            var result = new RouteParamsResponse
            {
                Var1 = var1,
                Var2 = var2
            };
            return Ok(new ApiResponse<RouteParamsResponse>(result));
        }

        // ✅ GET with multiple dynamic route segments: /api/demo/multi/one/two/three
        [HttpGet("multi/{*vars}")]
        public ActionResult<ApiResponse<MultiVarsResponse>> GetWithMultipleVars(string vars)
        {
            var segments = vars.Split('/', System.StringSplitOptions.RemoveEmptyEntries);
            var result = new MultiVarsResponse
            {
                Count = segments.Length,
                Values = segments
            };
            return Ok(new ApiResponse<MultiVarsResponse>(result));
        }

        // ✅ GET with query parameter: /api/demo/search?name=Book
        [HttpGet("search")]
        public ActionResult<ApiResponse<SearchResponse>> GetWithQuery([FromQuery] string name)
        {
            var result = new SearchResponse
            {
                SearchTerm = name
            };
            return Ok(new ApiResponse<SearchResponse>(result));
        }

        // ✅ Simple POST: /api/demo
        [HttpPost]
        public ActionResult<ApiResponse<Product>> SimplePost([FromBody] Product product)
        {
            return Ok(new ApiResponse<Product>(product));
        }

        // ✅ GET accessing Bearer Token and setting response headers: /api/demo/secure
        [HttpGet("secure")]
        public ActionResult<ApiResponse<SecureResponse>> GetWithHeaders()
        {
            var authHeader = Request.Headers["Authorization"].ToString();

            if (string.IsNullOrEmpty(authHeader) || !authHeader.StartsWith("Bearer "))
            {
                return Unauthorized(new ApiResponse<string>("Missing or invalid Authorization header."));
            }

            var token = authHeader.Substring("Bearer ".Length);

            Response.Headers.Add("X-Custom-Header", "This is a custom response header");

            var result = new SecureResponse
            {
                Token = token
            };
            return Ok(new ApiResponse<SecureResponse>(result));
        }
    }

    // ✅ Generic API Response Wrapper
    public class ApiResponse<T>
    {
        public bool Success { get; set; } = true;
        public T Data { get; set; }
        public string Message { get; set; }

        public ApiResponse(T data, string message = null)
        {
            Data = data;
            Message = message ?? "Request successful.";
        }
    }

    // ✅ Product Model
    public class Product
    {
        public int Id { get; set; }
        public double Cost { get; set; }
        public string Name { get; set; }
    }

    // ✅ Response Models
    public class RouteParamsResponse
    {
        public string Var1 { get; set; }
        public string Var2 { get; set; }
    }

    public class MultiVarsResponse
    {
        public int Count { get; set; }
        public IEnumerable<string> Values { get; set; }
    }

    public class SearchResponse
    {
        public string SearchTerm { get; set; }
    }

    public class SecureResponse
    {
        public string Token { get; set; }
    }
}
