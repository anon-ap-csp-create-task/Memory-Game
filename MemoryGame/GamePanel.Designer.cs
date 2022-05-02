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
            this.title = new System.Windows.Forms.Label();
            this.functionBtn = new System.Windows.Forms.Button();
            this.replayBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.ForeColor = System.Drawing.Color.DodgerBlue;
            this.score.Location = new System.Drawing.Point(86, 162);
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
            this.score_number.Location = new System.Drawing.Point(173, 162);
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
            this.bestScore_number.Location = new System.Drawing.Point(173, 247);
            this.bestScore_number.Name = "bestScore_number";
            this.bestScore_number.Size = new System.Drawing.Size(25, 25);
            this.bestScore_number.TabIndex = 3;
            this.bestScore_number.Text = "0";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Lucida Console", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.MidnightBlue;
            this.title.Location = new System.Drawing.Point(113, 87);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(121, 29);
            this.title.TabIndex = 4;
            this.title.Text = "Memory";
            // 
            // functionBtn
            // 
            this.functionBtn.Font = new System.Drawing.Font("Goudy Stout", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.functionBtn.Location = new System.Drawing.Point(77, 359);
            this.functionBtn.Name = "functionBtn";
            this.functionBtn.Size = new System.Drawing.Size(155, 43);
            this.functionBtn.TabIndex = 5;
            this.functionBtn.Text = "Start";
            this.functionBtn.UseVisualStyleBackColor = true;
            this.functionBtn.Click += new System.EventHandler(this.FunctionBtn_Click);
            // 
            // replayBtn
            // 
            this.replayBtn.Font = new System.Drawing.Font("Ideal Sans Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.replayBtn.Location = new System.Drawing.Point(104, 300);
            this.replayBtn.Name = "replayBtn";
            this.replayBtn.Size = new System.Drawing.Size(94, 41);
            this.replayBtn.TabIndex = 6;
            this.replayBtn.Text = "Replay";
            this.replayBtn.UseVisualStyleBackColor = true;
            this.replayBtn.Click += new System.EventHandler(this.ReplayBtn_Click);
            // 
            // GamePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(319, 446);
            this.Controls.Add(this.replayBtn);
            this.Controls.Add(this.functionBtn);
            this.Controls.Add(this.title);
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
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button functionBtn;
        private System.Windows.Forms.Button replayBtn;
    }
}