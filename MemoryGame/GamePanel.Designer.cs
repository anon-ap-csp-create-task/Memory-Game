namespace MemoryGame
{
    partial class GamePanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GamePanel));
            this.score = new System.Windows.Forms.Label();
            this.bestScore = new System.Windows.Forms.Label();
            this.score_number = new System.Windows.Forms.Label();
            this.bestScore_number = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.ForeColor = System.Drawing.Color.DodgerBlue;
            this.score.Location = new System.Drawing.Point(67, 162);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(81, 25);
            this.score.TabIndex = 0;
            this.score.Text = "Score:";
            // 
            // bestScore
            // 
            this.bestScore.AutoSize = true;
            this.bestScore.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bestScore.ForeColor = System.Drawing.Color.DodgerBlue;
            this.bestScore.Location = new System.Drawing.Point(43, 247);
            this.bestScore.Name = "bestScore";
            this.bestScore.Size = new System.Drawing.Size(130, 25);
            this.bestScore.TabIndex = 1;
            this.bestScore.Text = "Best score:";
            // 
            // score_number
            // 
            this.score_number.AutoSize = true;
            this.score_number.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_number.ForeColor = System.Drawing.Color.Purple;
            this.score_number.Location = new System.Drawing.Point(154, 162);
            this.score_number.Name = "score_number";
            this.score_number.Size = new System.Drawing.Size(25, 25);
            this.score_number.TabIndex = 2;
            this.score_number.Text = "0";
            // 
            // bestScore_number
            // 
            this.bestScore_number.AutoSize = true;
            this.bestScore_number.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bestScore_number.ForeColor = System.Drawing.Color.Purple;
            this.bestScore_number.Location = new System.Drawing.Point(179, 247);
            this.bestScore_number.Name = "bestScore_number";
            this.bestScore_number.Size = new System.Drawing.Size(25, 25);
            this.bestScore_number.TabIndex = 3;
            this.bestScore_number.Text = "0";
            // 
            // GamePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(319, 446);
            this.Controls.Add(this.bestScore_number);
            this.Controls.Add(this.score_number);
            this.Controls.Add(this.bestScore);
            this.Controls.Add(this.score);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GamePanel";
            this.Text = "Game Controls";
            this.Load += new System.EventHandler(this.GamePanel_Load);
            this.Move += new System.EventHandler(this.GamePanel_Move);
            this.Resize += new System.EventHandler(this.GamePanel_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label bestScore;
        private System.Windows.Forms.Label score_number;
        private System.Windows.Forms.Label bestScore_number;
    }
}