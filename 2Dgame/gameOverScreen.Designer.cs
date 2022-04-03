namespace _2Dgame
{
    partial class gameOverScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gameOverLable = new System.Windows.Forms.Label();
            this.menuButton = new System.Windows.Forms.Button();
            this.thanksLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameOverLable
            // 
            this.gameOverLable.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOverLable.ForeColor = System.Drawing.SystemColors.Control;
            this.gameOverLable.Location = new System.Drawing.Point(157, 164);
            this.gameOverLable.Name = "gameOverLable";
            this.gameOverLable.Size = new System.Drawing.Size(488, 117);
            this.gameOverLable.TabIndex = 0;
            this.gameOverLable.Text = "label1";
            // 
            // menuButton
            // 
            this.menuButton.Location = new System.Drawing.Point(359, 344);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(75, 23);
            this.menuButton.TabIndex = 1;
            this.menuButton.Text = "Menu";
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // thanksLable
            // 
            this.thanksLable.AutoSize = true;
            this.thanksLable.BackColor = System.Drawing.Color.Transparent;
            this.thanksLable.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thanksLable.ForeColor = System.Drawing.SystemColors.Control;
            this.thanksLable.Location = new System.Drawing.Point(306, 434);
            this.thanksLable.Name = "thanksLable";
            this.thanksLable.Size = new System.Drawing.Size(191, 27);
            this.thanksLable.TabIndex = 2;
            this.thanksLable.Text = "Thanks For Playing";
            // 
            // gameOverScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.Controls.Add(this.thanksLable);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.gameOverLable);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "gameOverScreen";
            this.Size = new System.Drawing.Size(800, 738);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameOverScreen_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gameOverLable;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Label thanksLable;
    }
}
