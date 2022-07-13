namespace MVPWinForms.Views.Blogs
{
    partial class FrmBlogs
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
            this.components = new System.ComponentModel.Container();
            this.tableBlogs = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.UpdateBlog = new System.Windows.Forms.Button();
            this.DeleteBlog = new System.Windows.Forms.Button();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.lblURL = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtBlogId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tableBlogs)).BeginInit();
            this.SuspendLayout();
            // 
            // tableBlogs
            // 
            this.tableBlogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableBlogs.Location = new System.Drawing.Point(12, 99);
            this.tableBlogs.Name = "tableBlogs";
            this.tableBlogs.RowTemplate.Height = 25;
            this.tableBlogs.Size = new System.Drawing.Size(776, 339);
            this.tableBlogs.TabIndex = 0;
            this.tableBlogs.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tableBlogs_MouseClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddBlog_Click);
            // 
            // UpdateBlog
            // 
            this.UpdateBlog.Location = new System.Drawing.Point(12, 41);
            this.UpdateBlog.Name = "UpdateBlog";
            this.UpdateBlog.Size = new System.Drawing.Size(75, 23);
            this.UpdateBlog.TabIndex = 2;
            this.UpdateBlog.Text = "Update";
            this.UpdateBlog.UseVisualStyleBackColor = true;
            this.UpdateBlog.Click += new System.EventHandler(this.UpdateBlog_Click);
            // 
            // DeleteBlog
            // 
            this.DeleteBlog.Location = new System.Drawing.Point(12, 70);
            this.DeleteBlog.Name = "DeleteBlog";
            this.DeleteBlog.Size = new System.Drawing.Size(75, 23);
            this.DeleteBlog.TabIndex = 3;
            this.DeleteBlog.Text = "Delete";
            this.DeleteBlog.UseVisualStyleBackColor = true;
            this.DeleteBlog.Click += new System.EventHandler(this.DeleteBlog_Click);
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(150, 41);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(272, 23);
            this.txtURL.TabIndex = 5;
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Location = new System.Drawing.Point(116, 44);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(28, 15);
            this.lblURL.TabIndex = 7;
            this.lblURL.Text = "URL";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.frmBlogsViewer_Load);
            // 
            // txtBlogId
            // 
            this.txtBlogId.Location = new System.Drawing.Point(150, 12);
            this.txtBlogId.Name = "txtBlogId";
            this.txtBlogId.Size = new System.Drawing.Size(58, 23);
            this.txtBlogId.TabIndex = 8;
            // 
            // FrmBlogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBlogId);
            this.Controls.Add(this.lblURL);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.DeleteBlog);
            this.Controls.Add(this.UpdateBlog);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableBlogs);
            this.Name = "FrmBlogs";
            this.Text = "frmBlogsViewer";
            this.Load += new System.EventHandler(this.frmBlogsViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableBlogs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DataGridView tableBlogs;
        private Button button1;
        private Button UpdateBlog;
        private Button DeleteBlog;
        private TextBox txtURL;
        private Label lblURL;
        private System.Windows.Forms.Timer timer1;
        public TextBox txtBlogId;
    }
}