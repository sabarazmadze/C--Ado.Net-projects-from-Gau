namespace PlantsShop.forms
{
    partial class CRUD
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
            this.ID = new System.Windows.Forms.NumericUpDown();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Back = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Exec
            // 
            this.Exec.Location = new System.Drawing.Point(12, 71);
            this.Exec.Name = "Exec";
            this.Exec.Size = new System.Drawing.Size(392, 23);
            this.Exec.TabIndex = 16;
            this.Exec.Text = "Exec";
            this.Exec.UseVisualStyleBackColor = true;
            this.Exec.Click += new System.EventHandler(this.Exec_Click);
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(101, 14);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(303, 20);
            this.ID.TabIndex = 15;
            this.ID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ID_KeyDown);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 129);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(392, 244);
            this.dataGridView.TabIndex = 14;
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(12, 100);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(392, 23);
            this.Back.TabIndex = 13;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(101, 40);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(303, 20);
            this.textBoxName.TabIndex = 12;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(12, 44);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(39, 13);
            this.name.TabIndex = 8;
            this.name.Text = "name :";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(12, 18);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(24, 13);
            this.labelID.TabIndex = 9;
            this.labelID.Text = "ID :";
            // 
            // CRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 382);
            this.Controls.Add(this.Exec);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.name);
            this.Controls.Add(this.labelID);
            this.Name = "CRUD";
            this.Text = "CRUD";
            this.Load += new System.EventHandler(this.CRUD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exec;
        private System.Windows.Forms.NumericUpDown ID;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label labelID;
    }
}