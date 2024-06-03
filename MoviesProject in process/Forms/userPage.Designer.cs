namespace MoviesProject.Forms
{
    partial class userPage
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movieReviewsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addReviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listReviewsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listMoviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movieCategoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listCategoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createDirectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directorsListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDirectorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteDirectorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(357, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.movieReviewsToolStripMenuItem,
            this.moviesToolStripMenuItem,
            this.movieCategoriesToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // movieReviewsToolStripMenuItem
            // 
            this.movieReviewsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addReviewToolStripMenuItem,
            this.listReviewsToolStripMenuItem});
            this.movieReviewsToolStripMenuItem.Name = "movieReviewsToolStripMenuItem";
            this.movieReviewsToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.movieReviewsToolStripMenuItem.Text = "Movie Reviews";
            // 
            // addReviewToolStripMenuItem
            // 
            this.addReviewToolStripMenuItem.Name = "addReviewToolStripMenuItem";
            this.addReviewToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.addReviewToolStripMenuItem.Text = "Add Reviews";
            this.addReviewToolStripMenuItem.Click += new System.EventHandler(this.addReviewToolStripMenuItem_Click);
            // 
            // listReviewsToolStripMenuItem
            // 
            this.listReviewsToolStripMenuItem.Name = "listReviewsToolStripMenuItem";
            this.listReviewsToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.listReviewsToolStripMenuItem.Text = "List Reviews";
            this.listReviewsToolStripMenuItem.Click += new System.EventHandler(this.listReviewsToolStripMenuItem_Click);
            // 
            // moviesToolStripMenuItem
            // 
            this.moviesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listMoviesToolStripMenuItem});
            this.moviesToolStripMenuItem.Name = "moviesToolStripMenuItem";
            this.moviesToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.moviesToolStripMenuItem.Text = "Movies";
            // 
            // listMoviesToolStripMenuItem
            // 
            this.listMoviesToolStripMenuItem.Name = "listMoviesToolStripMenuItem";
            this.listMoviesToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.listMoviesToolStripMenuItem.Text = "List Movies";
            this.listMoviesToolStripMenuItem.Click += new System.EventHandler(this.listMoviesToolStripMenuItem_Click);
            // 
            // movieCategoriesToolStripMenuItem
            // 
            this.movieCategoriesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listCategoriesToolStripMenuItem});
            this.movieCategoriesToolStripMenuItem.Name = "movieCategoriesToolStripMenuItem";
            this.movieCategoriesToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.movieCategoriesToolStripMenuItem.Text = "Movie Categories";
            // 
            // listCategoriesToolStripMenuItem
            // 
            this.listCategoriesToolStripMenuItem.Name = "listCategoriesToolStripMenuItem";
            this.listCategoriesToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.listCategoriesToolStripMenuItem.Text = "List Categories";
            this.listCategoriesToolStripMenuItem.Click += new System.EventHandler(this.listCategoriesToolStripMenuItem_Click);
            // 
            // createDirectorToolStripMenuItem
            // 
            this.createDirectorToolStripMenuItem.Name = "createDirectorToolStripMenuItem";
            this.createDirectorToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.createDirectorToolStripMenuItem.Text = "Add Directors";
            this.createDirectorToolStripMenuItem.Click += new System.EventHandler(this.createDirectorToolStripMenuItem_Click);
            // 
            // directorsListToolStripMenuItem
            // 
            this.directorsListToolStripMenuItem.Name = "directorsListToolStripMenuItem";
            this.directorsListToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.directorsListToolStripMenuItem.Text = "List Directors";
            this.directorsListToolStripMenuItem.Click += new System.EventHandler(this.directorsListToolStripMenuItem_Click);
            // 
            // updateDirectorsToolStripMenuItem
            // 
            this.updateDirectorsToolStripMenuItem.Name = "updateDirectorsToolStripMenuItem";
            this.updateDirectorsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateDirectorsToolStripMenuItem.Text = "Update Directors";
            this.updateDirectorsToolStripMenuItem.Click += new System.EventHandler(this.updateDirectorsToolStripMenuItem_Click);
            // 
            // deleteDirectorsToolStripMenuItem
            // 
            this.deleteDirectorsToolStripMenuItem.Name = "deleteDirectorsToolStripMenuItem";
            this.deleteDirectorsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteDirectorsToolStripMenuItem.Text = "Delete Directors";
            this.deleteDirectorsToolStripMenuItem.Click += new System.EventHandler(this.deleteDirectorsToolStripMenuItem_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(12, 27);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(333, 263);
            this.logoutButton.TabIndex = 1;
            this.logoutButton.Text = "Log Out";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // userPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 302);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "userPage";
            this.Text = "User Page";
            this.Load += new System.EventHandler(this.userPage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movieReviewsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moviesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createDirectorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem directorsListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateDirectorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteDirectorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movieCategoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addReviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listReviewsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listMoviesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listCategoriesToolStripMenuItem;
        private System.Windows.Forms.Button logoutButton;
    }
}