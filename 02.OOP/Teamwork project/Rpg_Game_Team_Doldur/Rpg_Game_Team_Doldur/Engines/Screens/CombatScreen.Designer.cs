namespace Rpg_Game_Team_Doldur.Engines.Screens
{
    partial class CombatScreen
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
            this.attackButton = new System.Windows.Forms.Button();
            this.defendButton = new System.Windows.Forms.Button();
            this.playerAttackPoints = new System.Windows.Forms.Label();
            this.playerHealthPoints = new System.Windows.Forms.Label();
            this.enemyAttackPoints = new System.Windows.Forms.Label();
            this.enemyHealthPoints = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // attackButton
            // 
            this.attackButton.Location = new System.Drawing.Point(164, 133);
            this.attackButton.Name = "attackButton";
            this.attackButton.Size = new System.Drawing.Size(75, 23);
            this.attackButton.TabIndex = 0;
            this.attackButton.Text = "Attack";
            this.attackButton.UseVisualStyleBackColor = true;
            this.attackButton.Click += new System.EventHandler(this.attackButton_Click);
            // 
            // defendButton
            // 
            this.defendButton.Location = new System.Drawing.Point(303, 133);
            this.defendButton.Name = "defendButton";
            this.defendButton.Size = new System.Drawing.Size(75, 23);
            this.defendButton.TabIndex = 1;
            this.defendButton.Text = "Defend";
            this.defendButton.UseVisualStyleBackColor = true;
            this.defendButton.Click += new System.EventHandler(this.defendButton_Click);
            // 
            // playerAttackPoints
            // 
            this.playerAttackPoints.AutoSize = true;
            this.playerAttackPoints.Location = new System.Drawing.Point(215, 208);
            this.playerAttackPoints.Name = "playerAttackPoints";
            this.playerAttackPoints.Size = new System.Drawing.Size(84, 13);
            this.playerAttackPoints.TabIndex = 2;
            this.playerAttackPoints.Text = "Player\'s damage";
            // 
            // playerHealthPoints
            // 
            this.playerHealthPoints.AutoSize = true;
            this.playerHealthPoints.Location = new System.Drawing.Point(215, 256);
            this.playerHealthPoints.Name = "playerHealthPoints";
            this.playerHealthPoints.Size = new System.Drawing.Size(75, 13);
            this.playerHealthPoints.TabIndex = 3;
            this.playerHealthPoints.Text = "Player\'s health";
            // 
            // enemyAttackPoints
            // 
            this.enemyAttackPoints.AutoSize = true;
            this.enemyAttackPoints.Location = new System.Drawing.Point(489, 208);
            this.enemyAttackPoints.Name = "enemyAttackPoints";
            this.enemyAttackPoints.Size = new System.Drawing.Size(87, 13);
            this.enemyAttackPoints.TabIndex = 4;
            this.enemyAttackPoints.Text = "Enemy\'s damage";
            // 
            // enemyHealthPoints
            // 
            this.enemyHealthPoints.AutoSize = true;
            this.enemyHealthPoints.Location = new System.Drawing.Point(491, 256);
            this.enemyHealthPoints.Name = "enemyHealthPoints";
            this.enemyHealthPoints.Size = new System.Drawing.Size(78, 13);
            this.enemyHealthPoints.TabIndex = 5;
            this.enemyHealthPoints.Text = "Enemy\'s health";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Playe\'s damage:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Player\'s health:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(396, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Enemy\'s damage:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(396, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Enemy\'s health:";
            // 
            // CombatScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enemyHealthPoints);
            this.Controls.Add(this.enemyAttackPoints);
            this.Controls.Add(this.playerHealthPoints);
            this.Controls.Add(this.playerAttackPoints);
            this.Controls.Add(this.defendButton);
            this.Controls.Add(this.attackButton);
            this.Name = "CombatScreen";
            this.Text = "CombatScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button attackButton;
        private System.Windows.Forms.Button defendButton;
        private System.Windows.Forms.Label playerAttackPoints;
        private System.Windows.Forms.Label playerHealthPoints;
        public System.Windows.Forms.Label enemyAttackPoints;
        private System.Windows.Forms.Label enemyHealthPoints;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}