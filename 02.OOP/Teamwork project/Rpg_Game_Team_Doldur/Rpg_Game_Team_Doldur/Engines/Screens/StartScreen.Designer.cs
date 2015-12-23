using System.Drawing;
using System.Windows.Forms;

namespace Rpg_Game_Team_Doldur.Engines.Screens
{
    partial class StartScreen
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
            this.startGameButton = new System.Windows.Forms.Button();
            this.exitGameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startGameButton
            // 
            this.startGameButton.Location = new System.Drawing.Point(72, 96);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(144, 38);
            this.startGameButton.TabIndex = 0;
            this.startGameButton.Text = "Start game";
            this.startGameButton.UseVisualStyleBackColor = true;
            this.startGameButton.Click += new System.EventHandler(this.startGameButton_Click);
            // 
            // exitGameButton
            // 
            this.exitGameButton.Location = new System.Drawing.Point(102, 171);
            this.exitGameButton.Name = "exitGameButton";
            this.exitGameButton.Size = new System.Drawing.Size(87, 27);
            this.exitGameButton.TabIndex = 1;
            this.exitGameButton.Text = "Exit";
            this.exitGameButton.UseVisualStyleBackColor = true;
            this.exitGameButton.Click += new System.EventHandler(this.exitGameButton_Click);
            // 
            // StartScreen
            // 
            this.BackgroundImage = Image.FromFile("../../randomImage.jpg");
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.exitGameButton);
            this.Controls.Add(this.startGameButton);
            this.Name = "StartScreen";
            this.Text = "StartScreen";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button startGameButton;
        private System.Windows.Forms.Button exitGameButton;
    }
}