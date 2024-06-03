namespace PlantsShop.forms
{
    partial class LogInOptions
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
            this.LogInAsUser = new System.Windows.Forms.Button();
            this.LogInAsManager = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LogInAsUser
            // 
            this.LogInAsUser.Location = new System.Drawing.Point(143, 36);
            this.LogInAsUser.Name = "LogInAsUser";
            this.LogInAsUser.Size = new System.Drawing.Size(143, 23);
            this.LogInAsUser.TabIndex = 1;
            this.LogInAsUser.Text = "LogInAsUser";
            this.LogInAsUser.UseVisualStyleBackColor = true;
            this.LogInAsUser.Click += new System.EventHandler(this.LogInAsUser_Click);
            // 
            // LogInAsManager
            // 
            this.LogInAsManager.Location = new System.Drawing.Point(15, 36);
            this.LogInAsManager.Name = "LogInAsManager";
            this.LogInAsManager.Size = new System.Drawing.Size(109, 23);
            this.LogInAsManager.TabIndex = 2;
            this.LogInAsManager.Text = "LogInAsManager";
            this.LogInAsManager.UseVisualStyleBackColor = true;
            this.LogInAsManager.Click += new System.EventHandler(this.LogInAsManager_Click);
            // 
            // LogInOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 98);
            this.Controls.Add(this.LogInAsUser);
            this.Controls.Add(this.LogInAsManager);
            this.Name = "LogInOptions";
            this.Text = "LogInOptions";
            this.Load += new System.EventHandler(this.LogInOptions_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LogInAsUser;
        private System.Windows.Forms.Button LogInAsManager;
    }
}