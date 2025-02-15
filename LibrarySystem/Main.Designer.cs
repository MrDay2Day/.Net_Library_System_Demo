namespace LibrarySystem
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.main_menu = new System.Windows.Forms.MenuStrip();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mbtn_view_all_books = new System.Windows.Forms.ToolStripMenuItem();
            this.mbtn_add_book = new System.Windows.Forms.ToolStripMenuItem();
            this.userManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mbtn_view_all_users = new System.Windows.Forms.ToolStripMenuItem();
            this.mbtn_add_user = new System.Windows.Forms.ToolStripMenuItem();
            this.mbtn_user_name = new System.Windows.Forms.ToolStripMenuItem();
            this.mbtn_logout = new System.Windows.Forms.ToolStripMenuItem();
            this.mbtb_user_account = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_login = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.login_panel = new System.Windows.Forms.Panel();
            this.main_menu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.login_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_menu
            // 
            this.main_menu.BackColor = System.Drawing.SystemColors.Window;
            this.main_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mbtn_user_name,
            this.booksToolStripMenuItem,
            this.userManagementToolStripMenuItem});
            this.main_menu.Location = new System.Drawing.Point(0, 0);
            this.main_menu.Name = "main_menu";
            this.main_menu.Size = new System.Drawing.Size(804, 24);
            this.main_menu.TabIndex = 1;
            this.main_menu.Text = "menuStrip1";
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mbtn_add_book,
            this.mbtn_view_all_books});
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.booksToolStripMenuItem.Text = "Books";
            // 
            // mbtn_view_all_books
            // 
            this.mbtn_view_all_books.Name = "mbtn_view_all_books";
            this.mbtn_view_all_books.Size = new System.Drawing.Size(180, 22);
            this.mbtn_view_all_books.Text = "View All";
            this.mbtn_view_all_books.Click += new System.EventHandler(this.mbtn_view_all_books_Click);
            // 
            // mbtn_add_book
            // 
            this.mbtn_add_book.Name = "mbtn_add_book";
            this.mbtn_add_book.Size = new System.Drawing.Size(180, 22);
            this.mbtn_add_book.Text = "Add Book";
            // 
            // userManagementToolStripMenuItem
            // 
            this.userManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mbtn_add_user,
            this.mbtn_view_all_users});
            this.userManagementToolStripMenuItem.Name = "userManagementToolStripMenuItem";
            this.userManagementToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.userManagementToolStripMenuItem.Text = "User Management";
            // 
            // mbtn_view_all_users
            // 
            this.mbtn_view_all_users.Name = "mbtn_view_all_users";
            this.mbtn_view_all_users.Size = new System.Drawing.Size(180, 22);
            this.mbtn_view_all_users.Text = "View All";
            // 
            // mbtn_add_user
            // 
            this.mbtn_add_user.Name = "mbtn_add_user";
            this.mbtn_add_user.Size = new System.Drawing.Size(180, 22);
            this.mbtn_add_user.Text = "Add User";
            // 
            // mbtn_user_name
            // 
            this.mbtn_user_name.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mbtb_user_account,
            this.mbtn_logout});
            this.mbtn_user_name.Name = "mbtn_user_name";
            this.mbtn_user_name.Size = new System.Drawing.Size(72, 20);
            this.mbtn_user_name.Text = "{{-USER-}}";
            // 
            // mbtn_logout
            // 
            this.mbtn_logout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.mbtn_logout.ForeColor = System.Drawing.Color.IndianRed;
            this.mbtn_logout.Name = "mbtn_logout";
            this.mbtn_logout.Size = new System.Drawing.Size(180, 22);
            this.mbtn_logout.Text = "Logout";
            // 
            // mbtb_user_account
            // 
            this.mbtb_user_account.Name = "mbtb_user_account";
            this.mbtb_user_account.Size = new System.Drawing.Size(180, 22);
            this.mbtb_user_account.Text = "User Account";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.btn_login);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(257, 104);
            this.panel1.MaximumSize = new System.Drawing.Size(290, 230);
            this.panel1.MinimumSize = new System.Drawing.Size(290, 230);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 230);
            this.panel1.TabIndex = 3;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_login.Location = new System.Drawing.Point(106, 180);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(61, 139);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(167, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(61, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Library System";
            // 
            // login_panel
            // 
            this.login_panel.Controls.Add(this.panel1);
            this.login_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.login_panel.Location = new System.Drawing.Point(0, 24);
            this.login_panel.Name = "login_panel";
            this.login_panel.Size = new System.Drawing.Size(804, 437);
            this.login_panel.TabIndex = 4;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.login_panel);
            this.Controls.Add(this.main_menu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.main_menu;
            this.MinimumSize = new System.Drawing.Size(820, 500);
            this.Name = "Main";
            this.ShowIcon = false;
            this.Text = "Library Service";
            this.main_menu.ResumeLayout(false);
            this.main_menu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.login_panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip main_menu;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mbtn_view_all_books;
        private System.Windows.Forms.ToolStripMenuItem mbtn_add_book;
        private System.Windows.Forms.ToolStripMenuItem userManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mbtn_view_all_users;
        private System.Windows.Forms.ToolStripMenuItem mbtn_add_user;
        private System.Windows.Forms.ToolStripMenuItem mbtn_user_name;
        private System.Windows.Forms.ToolStripMenuItem mbtb_user_account;
        private System.Windows.Forms.ToolStripMenuItem mbtn_logout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel login_panel;
    }
}

