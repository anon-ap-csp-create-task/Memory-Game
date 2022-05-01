namespace MemoryGame
{
    partial class GameScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameScreen));
            this.greenBtn = new System.Windows.Forms.Button();
            this.redBtn = new System.Windows.Forms.Button();
            this.blueBtn = new System.Windows.Forms.Button();
            this.yelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // greenBtn
            // 
            this.greenBtn.BackColor = System.Drawing.Color.Lime;
            this.greenBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.greenBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.greenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.greenBtn.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greenBtn.Location = new System.Drawing.Point(12, 12);
            this.greenBtn.Name = "greenBtn";
            this.greenBtn.Size = new System.Drawing.Size(127, 85);
            this.greenBtn.TabIndex = 0;
            this.greenBtn.Text = "Green";
            this.greenBtn.UseVisualStyleBackColor = false;
            this.greenBtn.Click += new System.EventHandler(this.greenBtn_Click);
            // 
            // redBtn
            // 
            this.redBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(4)))), ((int)(((byte)(45)))));
            this.redBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.redBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.redBtn.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redBtn.Location = new System.Drawing.Point(145, 12);
            this.redBtn.Name = "redBtn";
            this.redBtn.Size = new System.Drawing.Size(136, 85);
            this.redBtn.TabIndex = 1;
            this.redBtn.Text = "Red";
            this.redBtn.UseVisualStyleBackColor = false;
            this.redBtn.Click += new System.EventHandler(this.redBtn_Click);
            // 
            // blueBtn
            // 
            this.blueBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.blueBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.blueBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.blueBtn.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueBtn.Location = new System.Drawing.Point(145, 103);
            this.blueBtn.Name = "blueBtn";
            this.blueBtn.Size = new System.Drawing.Size(136, 83);
            this.blueBtn.TabIndex = 2;
            this.blueBtn.Text = "Blue";
            this.blueBtn.UseVisualStyleBackColor = false;
            this.blueBtn.Click += new System.EventHandler(this.blueBtn_Click);
            // 
            // yelBtn
            // 
            this.yelBtn.BackColor = System.Drawing.Color.Yellow;
            this.yelBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.yelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.yelBtn.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yelBtn.Location = new System.Drawing.Point(12, 103);
            this.yelBtn.Name = "yelBtn";
            this.yelBtn.Size = new System.Drawing.Size(127, 81);
            this.yelBtn.TabIndex = 3;
            this.yelBtn.Text = "Yellow";
            this.yelBtn.UseVisualStyleBackColor = false;
            this.yelBtn.Click += new System.EventHandler(this.yelBtn_Click);
            // 
            // GameScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(293, 198);
            this.Controls.Add(this.yelBtn);
            this.Controls.Add(this.blueBtn);
            this.Controls.Add(this.redBtn);
            this.Controls.Add(this.greenBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameScreen";
            this.Text = "Memory Game";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameScreen_FormClosing);
            this.Load += new System.EventHandler(this.GameScreen_Load);
            this.SizeChanged += new System.EventHandler(this.GameScreen_SizeChanged);
            this.Move += new System.EventHandler(this.gameScreen_Move);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button greenBtn;
        private System.Windows.Forms.Button redBtn;
        private System.Windows.Forms.Button blueBtn;
        private System.Windows.Forms.Button yelBtn;
    }
}