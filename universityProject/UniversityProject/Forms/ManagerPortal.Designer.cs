namespace UniversityProject
{
    partial class ManagerPortal
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
            this.logoutButton = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteUserToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addLecturerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteLecturerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateLecturorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllLecturersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteStundet = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewAllStudents = new System.Windows.Forms.ToolStripMenuItem();
            this.AddStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(12, 12);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 23);
            this.logoutButton.TabIndex = 12;
            this.logoutButton.Text = "LOGOUT";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(105, 12);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(178, 24);
            this.menuStrip.TabIndex = 13;
            this.menuStrip.Text = "menuStrip";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteUserToolStripMenuItem1,
            this.toolStripMenuItem1});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // deleteUserToolStripMenuItem1
            // 
            this.deleteUserToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addLecturerToolStripMenuItem,
            this.deleteLecturerToolStripMenuItem,
            this.updateLecturorToolStripMenuItem,
            this.viewAllLecturersToolStripMenuItem});
            this.deleteUserToolStripMenuItem1.Name = "deleteUserToolStripMenuItem1";
            this.deleteUserToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.deleteUserToolStripMenuItem1.Text = "Lecturer";
            // 
            // addLecturerToolStripMenuItem
            // 
            this.addLecturerToolStripMenuItem.Name = "addLecturerToolStripMenuItem";
            this.addLecturerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addLecturerToolStripMenuItem.Text = "Add Lecturer";
            this.addLecturerToolStripMenuItem.Click += new System.EventHandler(this.addLecturerToolStripMenuItem_Click);
            // 
            // deleteLecturerToolStripMenuItem
            // 
            this.deleteLecturerToolStripMenuItem.Name = "deleteLecturerToolStripMenuItem";
            this.deleteLecturerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteLecturerToolStripMenuItem.Text = "Delete Lecturer";
            this.deleteLecturerToolStripMenuItem.Click += new System.EventHandler(this.deleteLecturerToolStripMenuItem_Click);
            // 
            // updateLecturorToolStripMenuItem
            // 
            this.updateLecturorToolStripMenuItem.Name = "updateLecturorToolStripMenuItem";
            this.updateLecturorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateLecturorToolStripMenuItem.Text = "Update Lecturer";
            this.updateLecturorToolStripMenuItem.Click += new System.EventHandler(this.updateLecturorToolStripMenuItem_Click);
            // 
            // viewAllLecturersToolStripMenuItem
            // 
            this.viewAllLecturersToolStripMenuItem.Name = "viewAllLecturersToolStripMenuItem";
            this.viewAllLecturersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewAllLecturersToolStripMenuItem.Text = "View all Lecturers";
            this.viewAllLecturersToolStripMenuItem.Click += new System.EventHandler(this.viewAllLecturersToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddStudent,
            this.DeleteStundet,
            this.UpdateStudent,
            this.ViewAllStudents});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "Students";
            // 
            // DeleteStundet
            // 
            this.DeleteStundet.Name = "DeleteStundet";
            this.DeleteStundet.Size = new System.Drawing.Size(180, 22);
            this.DeleteStundet.Text = "Delete Student";
            this.DeleteStundet.Click += new System.EventHandler(this.DeleteStundet_Click);
            // 
            // UpdateStudent
            // 
            this.UpdateStudent.Name = "UpdateStudent";
            this.UpdateStudent.Size = new System.Drawing.Size(180, 22);
            this.UpdateStudent.Text = "Update Student";
            this.UpdateStudent.Click += new System.EventHandler(this.UpdateStudent_Click);
            // 
            // ViewAllStudents
            // 
            this.ViewAllStudents.Name = "ViewAllStudents";
            this.ViewAllStudents.Size = new System.Drawing.Size(180, 22);
            this.ViewAllStudents.Text = "View all Students";
            this.ViewAllStudents.Click += new System.EventHandler(this.ViewAllStudents_Click);
            // 
            // AddStudent
            // 
            this.AddStudent.Name = "AddStudent";
            this.AddStudent.Size = new System.Drawing.Size(180, 22);
            this.AddStudent.Text = "Add Student";
            this.AddStudent.Click += new System.EventHandler(this.AddStudent_Click);
            // 
            // ManagerPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 485);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.logoutButton);
            this.Name = "ManagerPortal";
            this.Text = "ManagerPortal";
            this.Load += new System.EventHandler(this.ManagerPortal_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteUserToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addLecturerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteLecturerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateLecturorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllLecturersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem DeleteStundet;
        private System.Windows.Forms.ToolStripMenuItem UpdateStudent;
        private System.Windows.Forms.ToolStripMenuItem ViewAllStudents;
        private System.Windows.Forms.ToolStripMenuItem AddStudent;
    }
}