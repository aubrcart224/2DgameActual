namespace _2Dgame
{
    partial class menuScreen
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
            this.playButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.textLable = new System.Windows.Forms.Label();
            this.textLable2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(337, 266);
            this.playButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(100, 28);
            this.playButton.TabIndex = 0;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(337, 346);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(100, 28);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // textLable
            // 
            this.textLable.AutoSize = true;
            this.textLable.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLable.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textLable.Location = new System.Drawing.Point(196, 122);
            this.textLable.Name = "textLable";
            this.textLable.Size = new System.Drawing.Size(393, 27);
            this.textLable.TabIndex = 2;
            this.textLable.Text = "Welcome To The Wolrds Hardest Game ";
            // 
            // textLable2
            // 
            this.textLable2.AutoSize = true;
            this.textLable2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLable2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textLable2.Location = new System.Drawing.Point(211, 452);
            this.textLable2.Name = "textLable2";
            this.textLable2.Size = new System.Drawing.Size(341, 27);
            this.textLable2.TabIndex = 3;
            this.textLable2.Text = "Click Play To Start Or Exit To Leave";
            // 
            // menuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.Controls.Add(this.textLable2);
            this.Controls.Add(this.textLable);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.playButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "menuScreen";
            this.Size = new System.Drawing.Size(800, 738);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label textLable;
        private System.Windows.Forms.Label textLable2;
    }
}
