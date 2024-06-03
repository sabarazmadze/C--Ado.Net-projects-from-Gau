namespace PlantsShop.forms
{
    partial class CRUD_Plant
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
            this.PlantName = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelEmal = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.GroupId = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.wateringId = new System.Windows.Forms.NumericUpDown();
            this.soilId = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.sunlightId = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.group = new System.Windows.Forms.Label();
            this.watering = new System.Windows.Forms.Label();
            this.soil = new System.Windows.Forms.Label();
            this.sunlight = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wateringId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soilId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sunlightId)).BeginInit();
            this.SuspendLayout();
            // 
            // Exec
            // 
            this.Exec.Location = new System.Drawing.Point(12, 194);
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
            this.dataGridView.Location = new System.Drawing.Point(12, 252);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(392, 244);
            this.dataGridView.TabIndex = 14;
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(12, 223);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(392, 23);
            this.Back.TabIndex = 13;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // PlantName
            // 
            this.PlantName.Location = new System.Drawing.Point(101, 40);
            this.PlantName.Name = "PlantName";
            this.PlantName.Size = new System.Drawing.Size(303, 20);
            this.PlantName.TabIndex = 12;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(12, 71);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(34, 13);
            this.labelPassword.TabIndex = 7;
            this.labelPassword.Text = "group";
            this.labelPassword.Click += new System.EventHandler(this.labelPassword_Click);
            // 
            // labelEmal
            // 
            this.labelEmal.AutoSize = true;
            this.labelEmal.Location = new System.Drawing.Point(12, 44);
            this.labelEmal.Name = "labelEmal";
            this.labelEmal.Size = new System.Drawing.Size(59, 13);
            this.labelEmal.TabIndex = 8;
            this.labelEmal.Text = "PlantName";
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
            // GroupId
            // 
            this.GroupId.Location = new System.Drawing.Point(101, 68);
            this.GroupId.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.GroupId.Name = "GroupId";
            this.GroupId.Size = new System.Drawing.Size(69, 20);
            this.GroupId.TabIndex = 17;
            this.GroupId.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.GroupId.ValueChanged += new System.EventHandler(this.GroupId_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "watering";
            this.label1.Click += new System.EventHandler(this.labelPassword_Click);
            // 
            // wateringId
            // 
            this.wateringId.Location = new System.Drawing.Point(101, 94);
            this.wateringId.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.wateringId.Name = "wateringId";
            this.wateringId.Size = new System.Drawing.Size(69, 20);
            this.wateringId.TabIndex = 17;
            this.wateringId.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.wateringId.ValueChanged += new System.EventHandler(this.wateringId_ValueChanged);
            // 
            // soilId
            // 
            this.soilId.Location = new System.Drawing.Point(101, 120);
            this.soilId.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.soilId.Name = "soilId";
            this.soilId.Size = new System.Drawing.Size(69, 20);
            this.soilId.TabIndex = 19;
            this.soilId.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.soilId.ValueChanged += new System.EventHandler(this.soilId_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "soil";
            // 
            // sunlightId
            // 
            this.sunlightId.Location = new System.Drawing.Point(101, 146);
            this.sunlightId.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sunlightId.Name = "sunlightId";
            this.sunlightId.Size = new System.Drawing.Size(69, 20);
            this.sunlightId.TabIndex = 21;
            this.sunlightId.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sunlightId.ValueChanged += new System.EventHandler(this.sunlightId_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "sunlight";
            // 
            // group
            // 
            this.group.AutoSize = true;
            this.group.Location = new System.Drawing.Point(176, 71);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(34, 13);
            this.group.TabIndex = 22;
            this.group.Text = "group";
            // 
            // watering
            // 
            this.watering.AutoSize = true;
            this.watering.Location = new System.Drawing.Point(177, 97);
            this.watering.Name = "watering";
            this.watering.Size = new System.Drawing.Size(47, 13);
            this.watering.TabIndex = 23;
            this.watering.Text = "watering";
            // 
            // soil
            // 
            this.soil.AutoSize = true;
            this.soil.Location = new System.Drawing.Point(180, 126);
            this.soil.Name = "soil";
            this.soil.Size = new System.Drawing.Size(22, 13);
            this.soil.TabIndex = 24;
            this.soil.Text = "soil";
            // 
            // sunlight
            // 
            this.sunlight.AutoSize = true;
            this.sunlight.Location = new System.Drawing.Point(177, 152);
            this.sunlight.Name = "sunlight";
            this.sunlight.Size = new System.Drawing.Size(43, 13);
            this.sunlight.TabIndex = 25;
            this.sunlight.Text = "sunlight";
            // 
            // CRUD_Plant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 508);
            this.Controls.Add(this.sunlight);
            this.Controls.Add(this.soil);
            this.Controls.Add(this.watering);
            this.Controls.Add(this.group);
            this.Controls.Add(this.sunlightId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.soilId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.wateringId);
            this.Controls.Add(this.GroupId);
            this.Controls.Add(this.Exec);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PlantName);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelEmal);
            this.Controls.Add(this.labelID);
            this.Name = "CRUD_Plant";
            this.Text = "CRUD_Plant";
            this.Load += new System.EventHandler(this.CRUD_Plant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wateringId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soilId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sunlightId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exec;
        private System.Windows.Forms.NumericUpDown ID;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.TextBox PlantName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelEmal;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.NumericUpDown GroupId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown wateringId;
        private System.Windows.Forms.NumericUpDown soilId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown sunlightId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label group;
        private System.Windows.Forms.Label watering;
        private System.Windows.Forms.Label soil;
        private System.Windows.Forms.Label sunlight;
    }
}