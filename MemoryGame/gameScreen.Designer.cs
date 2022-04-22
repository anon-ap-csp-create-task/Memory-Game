namespace MemoryGame
{
    partial class gameScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gameScreen));
            this.greenBtn = new System.Windows.Forms.Button();
            this.redBtn = new System.Windows.Forms.Button();
            this.blueBtn = new System.Windows.Forms.Button();
            this.yelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // greenBtn
            // 
            this.greenBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.greenBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.greenBtn.Location = new System.Drawing.Point(12, 12);
            this.greenBtn.Name = "greenBtn";
            this.greenBtn.Size = new System.Drawing.Size(127, 85);
            this.greenBtn.TabIndex = 0;
            this.greenBtn.Text = "Green";
            this.greenBtn.UseVisualStyleBackColor = true;
            // 
            // redBtn
            // 
            this.redBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.redBtn.Location = new System.Drawing.Point(145, 12);
            this.redBtn.Name = "redBtn";
            this.redBtn.Size = new System.Drawing.Size(131, 85);
            this.redBtn.TabIndex = 1;
            this.redBtn.Text = "Red";
            this.redBtn.UseVisualStyleBackColor = true;
            // 
            // blueBtn
            // 
            this.blueBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.blueBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.blueBtn.Location = new System.Drawing.Point(145, 103);
            this.blueBtn.Name = "blueBtn";
            this.blueBtn.Size = new System.Drawing.Size(131, 81);
            this.blueBtn.TabIndex = 2;
            this.blueBtn.Text = "Blue";
            this.blueBtn.UseVisualStyleBackColor = true;
            // 
            // yelBtn
            // 
            this.yelBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.yelBtn.Location = new System.Drawing.Point(12, 103);
            this.yelBtn.Name = "yelBtn";
            this.yelBtn.Size = new System.Drawing.Size(127, 81);
            this.yelBtn.TabIndex = 3;
            this.yelBtn.Text = "Yellow";
            this.yelBtn.UseVisualStyleBackColor = true;
            // 
            // gameScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(293, 198);
            this.Controls.Add(this.yelBtn);
            this.Controls.Add(this.blueBtn);
            this.Controls.Add(this.redBtn);
            this.Controls.Add(this.greenBtn);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "gameScreen";
            this.Text = "Memory Game";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MainApp_Load);
            this.SizeChanged += new System.EventHandler(this.MainApp_SizeChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button greenBtn;
        private System.Windows.Forms.Button redBtn;
        private System.Windows.Forms.Button blueBtn;
        private System.Windows.Forms.Button yelBtn;
    }
}