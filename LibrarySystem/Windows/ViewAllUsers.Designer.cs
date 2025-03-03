namespace LibrarySystem.Windows
{
    partial class ViewAllUsers
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.type_selection = new System.Windows.Forms.ComboBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.search_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_prev = new System.Windows.Forms.Button();
            this.count_pagination = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.count_total = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.count_not_available = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.count_available = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.type_selection);
            this.panel1.Controls.Add(this.btn_search);
            this.panel1.Controls.Add(this.btn_reset);
            this.panel1.Controls.Add(this.search_text);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 86);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(796, 364);
            this.panel2.TabIndex = 1;
            // 
            // type_selection
            // 
            this.type_selection.FormattingEnabled = true;
            this.type_selection.Location = new System.Drawing.Point(15, 52);
            this.type_selection.Name = "type_selection";
            this.type_selection.Size = new System.Drawing.Size(191, 21);
            this.type_selection.TabIndex = 33;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.SystemColors.Info;
            this.btn_search.Enabled = false;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(212, 24);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(62, 22);
            this.btn_search.TabIndex = 32;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.SystemColors.Info;
            this.btn_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.Location = new System.Drawing.Point(212, 51);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(62, 22);
            this.btn_reset.TabIndex = 31;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = false;
            // 
            // search_text
            // 
            this.search_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.search_text.Location = new System.Drawing.Point(15, 26);
            this.search_text.Name = "search_text";
            this.search_text.Size = new System.Drawing.Size(191, 20);
            this.search_text.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "User Search";
            // 
            // panel7
            // 
            this.panel7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel7.Controls.Add(this.btn_next);
            this.panel7.Controls.Add(this.btn_prev);
            this.panel7.Controls.Add(this.count_pagination);
            this.panel7.Location = new System.Drawing.Point(333, 20);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(198, 53);
            this.panel7.TabIndex = 34;
            // 
            // btn_next
            // 
            this.btn_next.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_next.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_next.Enabled = false;
            this.btn_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_next.Location = new System.Drawing.Point(101, 20);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(91, 23);
            this.btn_next.TabIndex = 3;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = false;
            // 
            // btn_prev
            // 
            this.btn_prev.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_prev.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_prev.Enabled = false;
            this.btn_prev.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prev.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_prev.Location = new System.Drawing.Point(4, 20);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(91, 23);
            this.btn_prev.TabIndex = 2;
            this.btn_prev.Text = "Previous";
            this.btn_prev.UseVisualStyleBackColor = false;
            // 
            // count_pagination
            // 
            this.count_pagination.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.count_pagination.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.count_pagination.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.count_pagination.Location = new System.Drawing.Point(4, 6);
            this.count_pagination.Name = "count_pagination";
            this.count_pagination.Size = new System.Drawing.Size(188, 13);
            this.count_pagination.TabIndex = 13;
            this.count_pagination.Text = "50/3000";
            this.count_pagination.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.Controls.Add(this.count_total);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.count_available);
            this.panel6.Controls.Add(this.count_not_available);
            this.panel6.Location = new System.Drawing.Point(588, 17);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(205, 56);
            this.panel6.TabIndex = 30;
            // 
            // count_total
            // 
            this.count_total.AutoSize = true;
            this.count_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.count_total.Location = new System.Drawing.Point(12, 32);
            this.count_total.Name = "count_total";
            this.count_total.Size = new System.Drawing.Size(49, 13);
            this.count_total.TabIndex = 8;
            this.count_total.Text = "200000";
            this.count_total.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total Count";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // count_not_available
            // 
            this.count_not_available.AutoSize = true;
            this.count_not_available.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.count_not_available.Location = new System.Drawing.Point(141, 32);
            this.count_not_available.Name = "count_not_available";
            this.count_not_available.Size = new System.Drawing.Size(49, 13);
            this.count_not_available.TabIndex = 10;
            this.count_not_available.Text = "200000";
            this.count_not_available.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(141, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Users";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // count_available
            // 
            this.count_available.AutoSize = true;
            this.count_available.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.count_available.Location = new System.Drawing.Point(79, 32);
            this.count_available.Name = "count_available";
            this.count_available.Size = new System.Drawing.Size(49, 13);
            this.count_available.TabIndex = 9;
            this.count_available.Text = "200000";
            this.count_available.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Staff";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(796, 364);
            this.dataGridView1.TabIndex = 0;
            // 
            // ViewAllUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(796, 450);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ViewAllUsers";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "All Users";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox type_selection;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.TextBox search_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.TextBox count_pagination;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label count_total;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label count_available;
        private System.Windows.Forms.Label count_not_available;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}