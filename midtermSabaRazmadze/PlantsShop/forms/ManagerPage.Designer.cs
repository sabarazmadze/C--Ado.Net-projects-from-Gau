namespace PlantsShop.forms
{
    partial class ManagerPage
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
            this.LogOut = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.feturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.sv = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.s_e = new System.Windows.Forms.ToolStripMenuItem();
            this.S_R = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sun_v = new System.Windows.Forms.ToolStripMenuItem();
            this.sun_add = new System.Windows.Forms.ToolStripMenuItem();
            this.sun_e = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.G_a = new System.Windows.Forms.ToolStripMenuItem();
            this.groupsViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plantAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plantEditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plantAddPhotoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plantRemoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wateringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wateringViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wateringAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wateringRemoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wateringUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupsRemoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupsEditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LogOut
            // 
            this.LogOut.Location = new System.Drawing.Point(12, 12);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(75, 23);
            this.LogOut.TabIndex = 24;
            this.LogOut.Text = "LogOut";
            this.LogOut.UseVisualStyleBackColor = true;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.feturesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(112, 12);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(183, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // feturesToolStripMenuItem
            // 
            this.feturesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productsToolStripMenuItem});
            this.feturesToolStripMenuItem.Name = "feturesToolStripMenuItem";
            this.feturesToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.feturesToolStripMenuItem.Text = "fetures";
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem5,
            this.toolStripMenuItem1,
            this.groupToolStripMenuItem,
            this.plantsToolStripMenuItem,
            this.wateringToolStripMenuItem});
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.productsToolStripMenuItem.Text = "products";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sv,
            this.toolStripMenuItem8,
            this.s_e,
            this.S_R});
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem5.Text = "Soils";
            // 
            // sv
            // 
            this.sv.Name = "sv";
            this.sv.Size = new System.Drawing.Size(180, 22);
            this.sv.Text = "Soil view";
            this.sv.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem8.Text = "Soil add";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.toolStripMenuItem8_Click);
            // 
            // s_e
            // 
            this.s_e.Name = "s_e";
            this.s_e.Size = new System.Drawing.Size(180, 22);
            this.s_e.Text = "Soil edit";
            this.s_e.Click += new System.EventHandler(this.s_e_Click);
            // 
            // S_R
            // 
            this.S_R.Name = "S_R";
            this.S_R.Size = new System.Drawing.Size(180, 22);
            this.S_R.Text = "Soil remove";
            this.S_R.Click += new System.EventHandler(this.S_R_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sun_v,
            this.sun_add,
            this.sun_e,
            this.toolStripMenuItem6});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "Sunlight";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // sun_v
            // 
            this.sun_v.Name = "sun_v";
            this.sun_v.Size = new System.Drawing.Size(180, 22);
            this.sun_v.Text = " Sunlight view";
            this.sun_v.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // sun_add
            // 
            this.sun_add.Name = "sun_add";
            this.sun_add.Size = new System.Drawing.Size(180, 22);
            this.sun_add.Text = "Sunlight add";
            this.sun_add.Click += new System.EventHandler(this.sun_add_Click);
            // 
            // sun_e
            // 
            this.sun_e.Name = "sun_e";
            this.sun_e.Size = new System.Drawing.Size(180, 22);
            this.sun_e.Text = "Sunlight edit";
            this.sun_e.Click += new System.EventHandler(this.sun_e_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem6.Text = "Sunlight move";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // groupToolStripMenuItem
            // 
            this.groupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.G_a,
            this.groupsViewToolStripMenuItem,
            this.groupsRemoveToolStripMenuItem,
            this.groupsEditToolStripMenuItem});
            this.groupToolStripMenuItem.Name = "groupToolStripMenuItem";
            this.groupToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.groupToolStripMenuItem.Text = "group";
            // 
            // G_a
            // 
            this.G_a.Name = "G_a";
            this.G_a.Size = new System.Drawing.Size(180, 22);
            this.G_a.Text = "groups add";
            this.G_a.Click += new System.EventHandler(this.G_a_Click);
            // 
            // groupsViewToolStripMenuItem
            // 
            this.groupsViewToolStripMenuItem.Name = "groupsViewToolStripMenuItem";
            this.groupsViewToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.groupsViewToolStripMenuItem.Text = "groups view ";
            this.groupsViewToolStripMenuItem.Click += new System.EventHandler(this.groupsViewToolStripMenuItem_Click);
            // 
            // plantsToolStripMenuItem
            // 
            this.plantsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.plantAddToolStripMenuItem,
            this.plantEditToolStripMenuItem,
            this.plantAddPhotoToolStripMenuItem,
            this.plantRemoveToolStripMenuItem});
            this.plantsToolStripMenuItem.Name = "plantsToolStripMenuItem";
            this.plantsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.plantsToolStripMenuItem.Text = "plants";
            this.plantsToolStripMenuItem.Click += new System.EventHandler(this.plantsToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewToolStripMenuItem.Text = "plant view";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
            // 
            // plantAddToolStripMenuItem
            // 
            this.plantAddToolStripMenuItem.Name = "plantAddToolStripMenuItem";
            this.plantAddToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.plantAddToolStripMenuItem.Text = "plant add";
            this.plantAddToolStripMenuItem.Click += new System.EventHandler(this.plantAddToolStripMenuItem_Click);
            // 
            // plantEditToolStripMenuItem
            // 
            this.plantEditToolStripMenuItem.Name = "plantEditToolStripMenuItem";
            this.plantEditToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.plantEditToolStripMenuItem.Text = "plant edit";
            this.plantEditToolStripMenuItem.Click += new System.EventHandler(this.plantEditToolStripMenuItem_Click);
            // 
            // plantAddPhotoToolStripMenuItem
            // 
            this.plantAddPhotoToolStripMenuItem.Name = "plantAddPhotoToolStripMenuItem";
            this.plantAddPhotoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.plantAddPhotoToolStripMenuItem.Text = "plant add photo";
            this.plantAddPhotoToolStripMenuItem.Click += new System.EventHandler(this.plantAddPhotoToolStripMenuItem_Click);
            // 
            // plantRemoveToolStripMenuItem
            // 
            this.plantRemoveToolStripMenuItem.Name = "plantRemoveToolStripMenuItem";
            this.plantRemoveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.plantRemoveToolStripMenuItem.Text = "plant remove";
            this.plantRemoveToolStripMenuItem.Click += new System.EventHandler(this.plantRemoveToolStripMenuItem_Click);
            // 
            // wateringToolStripMenuItem
            // 
            this.wateringToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wateringViewToolStripMenuItem,
            this.wateringAddToolStripMenuItem,
            this.wateringRemoveToolStripMenuItem,
            this.wateringUpdateToolStripMenuItem});
            this.wateringToolStripMenuItem.Name = "wateringToolStripMenuItem";
            this.wateringToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.wateringToolStripMenuItem.Text = "watering ";
            this.wateringToolStripMenuItem.Click += new System.EventHandler(this.wateringToolStripMenuItem_Click);
            // 
            // wateringViewToolStripMenuItem
            // 
            this.wateringViewToolStripMenuItem.Name = "wateringViewToolStripMenuItem";
            this.wateringViewToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.wateringViewToolStripMenuItem.Text = "watering  view";
            this.wateringViewToolStripMenuItem.Click += new System.EventHandler(this.wateringViewToolStripMenuItem_Click);
            // 
            // wateringAddToolStripMenuItem
            // 
            this.wateringAddToolStripMenuItem.Name = "wateringAddToolStripMenuItem";
            this.wateringAddToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.wateringAddToolStripMenuItem.Text = "watering  add";
            this.wateringAddToolStripMenuItem.Click += new System.EventHandler(this.wateringAddToolStripMenuItem_Click);
            // 
            // wateringRemoveToolStripMenuItem
            // 
            this.wateringRemoveToolStripMenuItem.Name = "wateringRemoveToolStripMenuItem";
            this.wateringRemoveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.wateringRemoveToolStripMenuItem.Text = "watering  remove ";
            this.wateringRemoveToolStripMenuItem.Click += new System.EventHandler(this.wateringRemoveToolStripMenuItem_Click);
            // 
            // wateringUpdateToolStripMenuItem
            // 
            this.wateringUpdateToolStripMenuItem.Name = "wateringUpdateToolStripMenuItem";
            this.wateringUpdateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.wateringUpdateToolStripMenuItem.Text = "watering  update ";
            this.wateringUpdateToolStripMenuItem.Click += new System.EventHandler(this.wateringUpdateToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 370);
            this.dataGridView1.TabIndex = 26;
            // 
            // groupsRemoveToolStripMenuItem
            // 
            this.groupsRemoveToolStripMenuItem.Name = "groupsRemoveToolStripMenuItem";
            this.groupsRemoveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.groupsRemoveToolStripMenuItem.Text = "groups remove";
            this.groupsRemoveToolStripMenuItem.Click += new System.EventHandler(this.groupsRemoveToolStripMenuItem_Click);
            // 
            // groupsEditToolStripMenuItem
            // 
            this.groupsEditToolStripMenuItem.Name = "groupsEditToolStripMenuItem";
            this.groupsEditToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.groupsEditToolStripMenuItem.Text = "groups edit";
            this.groupsEditToolStripMenuItem.Click += new System.EventHandler(this.groupsEditToolStripMenuItem_Click);
            // 
            // ManagerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ManagerPage";
            this.Text = "ManagerPage";
            this.Load += new System.EventHandler(this.ManagerPage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogOut;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem feturesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem G_a;
        private System.Windows.Forms.ToolStripMenuItem plantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plantAddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plantEditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plantAddPhotoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plantRemoveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sun_v;
        private System.Windows.Forms.ToolStripMenuItem sun_add;
        private System.Windows.Forms.ToolStripMenuItem sun_e;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem sv;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem s_e;
        private System.Windows.Forms.ToolStripMenuItem S_R;
        private System.Windows.Forms.ToolStripMenuItem groupsViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wateringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wateringViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wateringAddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wateringRemoveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wateringUpdateToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem groupsRemoveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupsEditToolStripMenuItem;
    }
}