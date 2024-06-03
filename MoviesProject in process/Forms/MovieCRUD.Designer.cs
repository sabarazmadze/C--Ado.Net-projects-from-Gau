namespace MoviesProject.Forms
{
    partial class MovieCRUD
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
            this.DirectorIDInput = new System.Windows.Forms.TextBox();
            this.TitleInput = new System.Windows.Forms.TextBox();
            this.MovieCatInput = new System.Windows.Forms.TextBox();
            this.labelDirectorID = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelMovieCat = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.labelDuration = new System.Windows.Forms.Label();
            this.DurationInput = new System.Windows.Forms.NumericUpDown();
            this.YearInput = new System.Windows.Forms.TextBox();
            this.labelReleaseYear = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IDInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DurationInput)).BeginInit();
            this.SuspendLayout();
            // 
            // Exec
            // 
            this.Exec.Location = new System.Drawing.Point(12, 176);
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
            this.dataGridView.Location = new System.Drawing.Point(12, 234);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(392, 244);
            this.dataGridView.TabIndex = 25;
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(12, 205);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(392, 23);
            this.Back.TabIndex = 24;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // DirectorIDInput
            // 
            this.DirectorIDInput.Location = new System.Drawing.Point(101, 94);
            this.DirectorIDInput.Name = "DirectorIDInput";
            this.DirectorIDInput.Size = new System.Drawing.Size(303, 20);
            this.DirectorIDInput.TabIndex = 21;
            // 
            // TitleInput
            // 
            this.TitleInput.Location = new System.Drawing.Point(101, 67);
            this.TitleInput.Name = "TitleInput";
            this.TitleInput.Size = new System.Drawing.Size(303, 20);
            this.TitleInput.TabIndex = 22;
            // 
            // MovieCatInput
            // 
            this.MovieCatInput.Location = new System.Drawing.Point(101, 40);
            this.MovieCatInput.Name = "MovieCatInput";
            this.MovieCatInput.Size = new System.Drawing.Size(303, 20);
            this.MovieCatInput.TabIndex = 23;
            // 
            // labelDirectorID
            // 
            this.labelDirectorID.AutoSize = true;
            this.labelDirectorID.Location = new System.Drawing.Point(12, 98);
            this.labelDirectorID.Name = "labelDirectorID";
            this.labelDirectorID.Size = new System.Drawing.Size(64, 13);
            this.labelDirectorID.TabIndex = 17;
            this.labelDirectorID.Text = "Director ID :";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(12, 71);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(33, 13);
            this.labelTitle.TabIndex = 18;
            this.labelTitle.Text = "Title :";
            // 
            // labelMovieCat
            // 
            this.labelMovieCat.AutoSize = true;
            this.labelMovieCat.Location = new System.Drawing.Point(12, 44);
            this.labelMovieCat.Name = "labelMovieCat";
            this.labelMovieCat.Size = new System.Drawing.Size(87, 13);
            this.labelMovieCat.TabIndex = 19;
            this.labelMovieCat.Text = "Movie Category :";
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
            // labelDuration
            // 
            this.labelDuration.AutoSize = true;
            this.labelDuration.Location = new System.Drawing.Point(12, 125);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(53, 13);
            this.labelDuration.TabIndex = 28;
            this.labelDuration.Text = "Duration :";
            // 
            // DurationInput
            // 
            this.DurationInput.Location = new System.Drawing.Point(101, 121);
            this.DurationInput.Name = "DurationInput";
            this.DurationInput.Size = new System.Drawing.Size(303, 20);
            this.DurationInput.TabIndex = 30;
            // 
            // YearInput
            // 
            this.YearInput.Location = new System.Drawing.Point(101, 147);
            this.YearInput.Name = "YearInput";
            this.YearInput.Size = new System.Drawing.Size(303, 20);
            this.YearInput.TabIndex = 32;
            // 
            // labelReleaseYear
            // 
            this.labelReleaseYear.AutoSize = true;
            this.labelReleaseYear.Location = new System.Drawing.Point(12, 151);
            this.labelReleaseYear.Name = "labelReleaseYear";
            this.labelReleaseYear.Size = new System.Drawing.Size(77, 13);
            this.labelReleaseYear.TabIndex = 31;
            this.labelReleaseYear.Text = "Release Year :";
            // 
            // MovieCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 488);
            this.Controls.Add(this.YearInput);
            this.Controls.Add(this.labelReleaseYear);
            this.Controls.Add(this.DurationInput);
            this.Controls.Add(this.labelDuration);
            this.Controls.Add(this.Exec);
            this.Controls.Add(this.IDInput);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.DirectorIDInput);
            this.Controls.Add(this.TitleInput);
            this.Controls.Add(this.MovieCatInput);
            this.Controls.Add(this.labelDirectorID);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelMovieCat);
            this.Controls.Add(this.labelID);
            this.Name = "MovieCRUD";
            this.Text = "Movies Editor";
            this.Load += new System.EventHandler(this.MovieCRUD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IDInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DurationInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exec;
        private System.Windows.Forms.NumericUpDown IDInput;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.TextBox DirectorIDInput;
        private System.Windows.Forms.TextBox TitleInput;
        private System.Windows.Forms.TextBox MovieCatInput;
        private System.Windows.Forms.Label labelDirectorID;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelMovieCat;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.NumericUpDown DurationInput;
        private System.Windows.Forms.TextBox YearInput;
        private System.Windows.Forms.Label labelReleaseYear;
    }
}