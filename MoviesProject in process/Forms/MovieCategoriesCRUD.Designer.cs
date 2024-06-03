namespace MoviesProject.Forms
{
    partial class MovieCategoriesCRUD
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
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.CategoryInput = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.IDInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Exec
            // 
            this.Exec.Location = new System.Drawing.Point(12, 68);
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
            this.dataGridView.Location = new System.Drawing.Point(12, 126);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(392, 244);
            this.dataGridView.TabIndex = 25;
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(12, 97);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(392, 23);
            this.Back.TabIndex = 24;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(12, 44);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(58, 13);
            this.labelCategory.TabIndex = 19;
            this.labelCategory.Text = "Category : ";
            this.labelCategory.Click += new System.EventHandler(this.labelEmal_Click);
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
            // CategoryInput
            // 
            this.CategoryInput.FormattingEnabled = true;
            this.CategoryInput.Location = new System.Drawing.Point(101, 40);
            this.CategoryInput.Name = "CategoryInput";
            this.CategoryInput.Size = new System.Drawing.Size(303, 21);
            this.CategoryInput.TabIndex = 28;
            // 
            // MovieCategoriesCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(420, 385);
            this.Controls.Add(this.CategoryInput);
            this.Controls.Add(this.Exec);
            this.Controls.Add(this.IDInput);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.labelID);
            this.Name = "MovieCategoriesCRUD";
            this.Text = "Movie Categories Editor";
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
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.ComboBox CategoryInput;
    }
}