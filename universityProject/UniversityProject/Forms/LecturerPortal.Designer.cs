namespace UniversityProject
{
    partial class LecturerPortal
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.AddGrade = new System.Windows.Forms.Button();
            this.numericUpDownID = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownGrade = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGrade)).BeginInit();
            this.SuspendLayout();
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(12, 12);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 23);
            this.logoutButton.TabIndex = 11;
            this.logoutButton.Text = "LOGOUT";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 166);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(776, 272);
            this.dataGridView.TabIndex = 12;
            // 
            // AddGrade
            // 
            this.AddGrade.Location = new System.Drawing.Point(344, 80);
            this.AddGrade.Name = "AddGrade";
            this.AddGrade.Size = new System.Drawing.Size(75, 23);
            this.AddGrade.TabIndex = 13;
            this.AddGrade.Text = "AddGrade";
            this.AddGrade.UseVisualStyleBackColor = true;
            this.AddGrade.Click += new System.EventHandler(this.AddGrade_Click);
            // 
            // numericUpDownID
            // 
            this.numericUpDownID.Location = new System.Drawing.Point(13, 81);
            this.numericUpDownID.Name = "numericUpDownID";
            this.numericUpDownID.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownID.TabIndex = 14;
            // 
            // numericUpDownGrade
            // 
            this.numericUpDownGrade.Location = new System.Drawing.Point(184, 81);
            this.numericUpDownGrade.Name = "numericUpDownGrade";
            this.numericUpDownGrade.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownGrade.TabIndex = 14;
            // 
            // LecturerPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numericUpDownGrade);
            this.Controls.Add(this.numericUpDownID);
            this.Controls.Add(this.AddGrade);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.logoutButton);
            this.Name = "LecturerPortal";
            this.Text = "LecturerPortal";
            this.Load += new System.EventHandler(this.LecturerPortal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGrade)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button AddGrade;
        private System.Windows.Forms.NumericUpDown numericUpDownID;
        private System.Windows.Forms.NumericUpDown numericUpDownGrade;
    }
}