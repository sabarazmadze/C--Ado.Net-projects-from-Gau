namespace MoviesProject.Forms
{
    partial class NationalitiesCRUD
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
            this.NationalityInput = new System.Windows.Forms.TextBox();
            this.nationalityLabel = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IDInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Exec
            // 
            this.Exec.Location = new System.Drawing.Point(12, 66);
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
            this.dataGridView.Location = new System.Drawing.Point(12, 124);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(392, 244);
            this.dataGridView.TabIndex = 25;
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(12, 95);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(392, 23);
            this.Back.TabIndex = 24;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // NationalityInput
            // 
            this.NationalityInput.Location = new System.Drawing.Point(101, 40);
            this.NationalityInput.Name = "NationalityInput";
            this.NationalityInput.Size = new System.Drawing.Size(303, 20);
            this.NationalityInput.TabIndex = 23;
            // 
            // nationalityLabel
            // 
            this.nationalityLabel.AutoSize = true;
            this.nationalityLabel.Location = new System.Drawing.Point(12, 44);
            this.nationalityLabel.Name = "nationalityLabel";
            this.nationalityLabel.Size = new System.Drawing.Size(62, 13);
            this.nationalityLabel.TabIndex = 19;
            this.nationalityLabel.Text = "Nationality :";
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
            // NationalitiesCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 383);
            this.Controls.Add(this.Exec);
            this.Controls.Add(this.IDInput);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.NationalityInput);
            this.Controls.Add(this.nationalityLabel);
            this.Controls.Add(this.labelID);
            this.Name = "NationalitiesCRUD";
            this.Text = "Nationalities Editor";
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
        private System.Windows.Forms.TextBox NationalityInput;
        private System.Windows.Forms.Label nationalityLabel;
        private System.Windows.Forms.Label labelID;
    }
}