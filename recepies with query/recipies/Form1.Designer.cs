using System.Windows.Forms;

namespace recipies
{
    partial class Form1
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
            this.dgvRecipes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtInstructions = new System.Windows.Forms.TextBox();
            this.numServings = new System.Windows.Forms.NumericUpDown();
            this.numPrepTime = new System.Windows.Forms.NumericUpDown();
            this.numCookTime = new System.Windows.Forms.NumericUpDown();
            this.numTotalTime = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.numRecipeId = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numServings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrepTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCookTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRecipeId)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRecipes
            // 
            this.dgvRecipes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecipes.Location = new System.Drawing.Point(10, 319);
            this.dgvRecipes.Name = "dgvRecipes";
            this.dgvRecipes.RowTemplate.Height = 25;
            this.dgvRecipes.Size = new System.Drawing.Size(894, 283);
            this.dgvRecipes.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Instructions";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Servings";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "PrepTime";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "CookTime";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "TotalTime";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(85, 44);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(86, 20);
            this.txtTitle.TabIndex = 2;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(85, 77);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(86, 20);
            this.txtDescription.TabIndex = 2;
            // 
            // txtInstructions
            // 
            this.txtInstructions.Location = new System.Drawing.Point(85, 107);
            this.txtInstructions.Name = "txtInstructions";
            this.txtInstructions.Size = new System.Drawing.Size(86, 20);
            this.txtInstructions.TabIndex = 2;
            // 
            // numServings
            // 
            this.numServings.Location = new System.Drawing.Point(85, 143);
            this.numServings.Name = "numServings";
            this.numServings.Size = new System.Drawing.Size(86, 20);
            this.numServings.TabIndex = 2;
            // 
            // numPrepTime
            // 
            this.numPrepTime.Location = new System.Drawing.Point(85, 172);
            this.numPrepTime.Name = "numPrepTime";
            this.numPrepTime.Size = new System.Drawing.Size(86, 20);
            this.numPrepTime.TabIndex = 2;
            // 
            // numCookTime
            // 
            this.numCookTime.Location = new System.Drawing.Point(85, 199);
            this.numCookTime.Name = "numCookTime";
            this.numCookTime.Size = new System.Drawing.Size(86, 20);
            this.numCookTime.TabIndex = 2;
            // 
            // numTotalTime
            // 
            this.numTotalTime.Location = new System.Drawing.Point(85, 229);
            this.numTotalTime.Name = "numTotalTime";
            this.numTotalTime.Size = new System.Drawing.Size(86, 20);
            this.numTotalTime.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(10, 270);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(64, 20);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(85, 270);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(64, 20);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(154, 270);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(64, 20);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "\"Recipe ID";
            // 
            // numRecipeId
            // 
            this.numRecipeId.Location = new System.Drawing.Point(85, 20);
            this.numRecipeId.Name = "numRecipeId";
            this.numRecipeId.Size = new System.Drawing.Size(86, 20);
            this.numRecipeId.TabIndex = 2;
            this.numRecipeId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRecipeId_KeyDown_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 614);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.numTotalTime);
            this.Controls.Add(this.numCookTime);
            this.Controls.Add(this.numPrepTime);
            this.Controls.Add(this.numServings);
            this.Controls.Add(this.txtInstructions);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.numRecipeId);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvRecipes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numServings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrepTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCookTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRecipeId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvRecipes;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtTitle;
        private TextBox txtDescription;
        private TextBox txtInstructions;
        private NumericUpDown numServings;
        private NumericUpDown numPrepTime;
        private NumericUpDown numCookTime;
        private NumericUpDown numTotalTime;
        private Button btnSave;
        private Button btnUpdate;
        private Button btnDelete;
        private Label label8;
        private NumericUpDown numRecipeId;
    }
}
