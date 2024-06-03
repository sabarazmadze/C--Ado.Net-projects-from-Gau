namespace MoviesProject.Forms
{
    partial class DirectorsCRUD
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
            this.Exec = new System.Windows.Forms.Button();
            this.IDInput = new System.Windows.Forms.NumericUpDown();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Back = new System.Windows.Forms.Button();
            this.LastNameInput = new System.Windows.Forms.TextBox();
            this.FirstNameInput = new System.Windows.Forms.TextBox();
            this.labelNationality = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.NationalityDropdown = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.IDInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Exec
            // 
            this.Exec.Location = new System.Drawing.Point(12, 136);
            this.Exec.Name = "Exec";
            this.Exec.Size = new System.Drawing.Size(392, 23);
            this.Exec.TabIndex = 27;
            this.Exec.Text = "Exec";
            this.Exec.UseVisualStyleBackColor = true;
            // 
            // IDInput
            // 
            this.IDInput.Location = new System.Drawing.Point(101, 14);
            this.IDInput.Name = "IDInput";
            this.IDInput.Size = new System.Drawing.Size(303, 20);
            this.IDInput.TabIndex = 26;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 194);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(392, 244);
            this.dataGridView.TabIndex = 25;
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(12, 165);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(392, 23);
            this.Back.TabIndex = 24;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // LastNameInput
            // 
            this.LastNameInput.Location = new System.Drawing.Point(101, 67);
            this.LastNameInput.Name = "LastNameInput";
            this.LastNameInput.Size = new System.Drawing.Size(303, 20);
            this.LastNameInput.TabIndex = 22;
            // 
            // FirstNameInput
            // 
            this.FirstNameInput.Location = new System.Drawing.Point(101, 40);
            this.FirstNameInput.Name = "FirstNameInput";
            this.FirstNameInput.Size = new System.Drawing.Size(303, 20);
            this.FirstNameInput.TabIndex = 23;
            // 
            // labelNationality
            // 
            this.labelNationality.AutoSize = true;
            this.labelNationality.Location = new System.Drawing.Point(12, 98);
            this.labelNationality.Name = "labelNationality";
            this.labelNationality.Size = new System.Drawing.Size(65, 13);
            this.labelNationality.TabIndex = 17;
            this.labelNationality.Text = "Nationality : ";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(12, 71);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(64, 13);
            this.labelLastName.TabIndex = 18;
            this.labelLastName.Text = "Last Name :";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(12, 44);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(63, 13);
            this.labelFirstName.TabIndex = 19;
            this.labelFirstName.Text = "First Name :";
            this.labelFirstName.Click += new System.EventHandler(this.labelEmal_Click);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(12, 18);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(24, 13);
            this.labelID.TabIndex = 20;
            this.labelID.Text = "ID :";
            // 
            // NationalityDropdown
            // 
            this.NationalityDropdown.FormattingEnabled = true;
            this.NationalityDropdown.Location = new System.Drawing.Point(101, 95);
            this.NationalityDropdown.Name = "NationalityDropdown";
            this.NationalityDropdown.Size = new System.Drawing.Size(303, 21);
            this.NationalityDropdown.TabIndex = 28;
            // 
            // DirectorsCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 450);
            this.Controls.Add(this.NationalityDropdown);
            this.Controls.Add(this.Exec);
            this.Controls.Add(this.IDInput);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.LastNameInput);
            this.Controls.Add(this.FirstNameInput);
            this.Controls.Add(this.labelNationality);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.labelID);
            this.Name = "DirectorsCRUD";
            this.Text = "Director Editor";
            this.Load += new System.EventHandler(this.DirectorsCRUD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IDInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exec;
        private System.Windows.Forms.NumericUpDown IDInput;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.TextBox LastNameInput;
        private System.Windows.Forms.TextBox FirstNameInput;
        private System.Windows.Forms.Label labelNationality;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.ComboBox NationalityDropdown;
    }
}