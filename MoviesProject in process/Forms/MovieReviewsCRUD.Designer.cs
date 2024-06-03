namespace MoviesProject.Forms
{
    partial class MovieReviewsCRUD
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
            this.ScoreInput = new System.Windows.Forms.TextBox();
            this.MovieIDInput = new System.Windows.Forms.TextBox();
            this.labelReviewDate = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelMovieID = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.reviewDateSelector = new System.Windows.Forms.DateTimePicker();
            this.labelComment = new System.Windows.Forms.Label();
            this.CommentInput = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.IDInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Exec
            // 
            this.Exec.Location = new System.Drawing.Point(12, 248);
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
            this.dataGridView.Location = new System.Drawing.Point(12, 306);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(392, 244);
            this.dataGridView.TabIndex = 25;
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(12, 277);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(392, 23);
            this.Back.TabIndex = 24;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // ScoreInput
            // 
            this.ScoreInput.Location = new System.Drawing.Point(101, 67);
            this.ScoreInput.Name = "ScoreInput";
            this.ScoreInput.Size = new System.Drawing.Size(303, 20);
            this.ScoreInput.TabIndex = 22;
            // 
            // MovieIDInput
            // 
            this.MovieIDInput.Location = new System.Drawing.Point(101, 40);
            this.MovieIDInput.Name = "MovieIDInput";
            this.MovieIDInput.Size = new System.Drawing.Size(303, 20);
            this.MovieIDInput.TabIndex = 23;
            // 
            // labelReviewDate
            // 
            this.labelReviewDate.AutoSize = true;
            this.labelReviewDate.Location = new System.Drawing.Point(12, 98);
            this.labelReviewDate.Name = "labelReviewDate";
            this.labelReviewDate.Size = new System.Drawing.Size(75, 13);
            this.labelReviewDate.TabIndex = 17;
            this.labelReviewDate.Text = "Review Date :";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(12, 71);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(41, 13);
            this.labelScore.TabIndex = 18;
            this.labelScore.Text = "Score :";
            // 
            // labelMovieID
            // 
            this.labelMovieID.AutoSize = true;
            this.labelMovieID.Location = new System.Drawing.Point(12, 44);
            this.labelMovieID.Name = "labelMovieID";
            this.labelMovieID.Size = new System.Drawing.Size(56, 13);
            this.labelMovieID.TabIndex = 19;
            this.labelMovieID.Text = "Movie ID :";
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
            // reviewDateSelector
            // 
            this.reviewDateSelector.Location = new System.Drawing.Point(101, 95);
            this.reviewDateSelector.Name = "reviewDateSelector";
            this.reviewDateSelector.Size = new System.Drawing.Size(303, 20);
            this.reviewDateSelector.TabIndex = 28;
            // 
            // labelComment
            // 
            this.labelComment.AutoSize = true;
            this.labelComment.Location = new System.Drawing.Point(12, 129);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(57, 13);
            this.labelComment.TabIndex = 29;
            this.labelComment.Text = "Comment :";
            // 
            // CommentInput
            // 
            this.CommentInput.Location = new System.Drawing.Point(101, 126);
            this.CommentInput.Name = "CommentInput";
            this.CommentInput.Size = new System.Drawing.Size(303, 96);
            this.CommentInput.TabIndex = 31;
            this.CommentInput.Text = "";
            // 
            // MovieReviewsCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 562);
            this.Controls.Add(this.CommentInput);
            this.Controls.Add(this.labelComment);
            this.Controls.Add(this.reviewDateSelector);
            this.Controls.Add(this.Exec);
            this.Controls.Add(this.IDInput);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.ScoreInput);
            this.Controls.Add(this.MovieIDInput);
            this.Controls.Add(this.labelReviewDate);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelMovieID);
            this.Controls.Add(this.labelID);
            this.Name = "MovieReviewsCRUD";
            this.Text = "Movie Reviews Editor";
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
        private System.Windows.Forms.TextBox ScoreInput;
        private System.Windows.Forms.TextBox MovieIDInput;
        private System.Windows.Forms.Label labelReviewDate;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelMovieID;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.DateTimePicker reviewDateSelector;
        private System.Windows.Forms.Label labelComment;
        private System.Windows.Forms.RichTextBox CommentInput;
    }
}