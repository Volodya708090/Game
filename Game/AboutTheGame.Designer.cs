namespace Game
{
    partial class AboutTheGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutTheGame));
            this.TeamWork = new System.Windows.Forms.Label();
            this.Developers = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Luck = new System.Windows.Forms.Button();
            this.Prize = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TeamWork
            // 
            this.TeamWork.AutoSize = true;
            this.TeamWork.BackColor = System.Drawing.Color.Transparent;
            this.TeamWork.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TeamWork.Location = new System.Drawing.Point(110, 47);
            this.TeamWork.Name = "TeamWork";
            this.TeamWork.Size = new System.Drawing.Size(270, 43);
            this.TeamWork.TabIndex = 0;
            this.TeamWork.Text = "Над игрой работали:";
            // 
            // Developers
            // 
            this.Developers.AutoSize = true;
            this.Developers.BackColor = System.Drawing.Color.Transparent;
            this.Developers.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Developers.Location = new System.Drawing.Point(110, 108);
            this.Developers.Name = "Developers";
            this.Developers.Size = new System.Drawing.Size(269, 43);
            this.Developers.TabIndex = 1;
            this.Developers.Text = "Володька и Ванчелла";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Mistral", 18F);
            this.label3.Location = new System.Drawing.Point(408, 398);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(357, 43);
            this.label3.TabIndex = 2;
            this.label3.Text = "РЕЛИЗ НЕ ДЛЯ ПРОДАЖИ";
            // 
            // Luck
            // 
            this.Luck.BackColor = System.Drawing.Color.White;
            this.Luck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Luck.Location = new System.Drawing.Point(156, 270);
            this.Luck.Name = "Luck";
            this.Luck.Size = new System.Drawing.Size(223, 41);
            this.Luck.TabIndex = 3;
            this.Luck.Text = "Испытать удачу";
            this.Luck.UseVisualStyleBackColor = false;
            this.Luck.Click += new System.EventHandler(this.Luck_Click);
            // 
            // Prize
            // 
            this.Prize.AutoSize = true;
            this.Prize.BackColor = System.Drawing.Color.Transparent;
            this.Prize.Font = new System.Drawing.Font("Mistral", 18F);
            this.Prize.Location = new System.Drawing.Point(110, 195);
            this.Prize.Name = "Prize";
            this.Prize.Size = new System.Drawing.Size(349, 43);
            this.Prize.TabIndex = 4;
            this.Prize.Text = "Подарок от разработчиков";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Game.Properties.Resources.Володя_скример;
            this.pictureBox1.Location = new System.Drawing.Point(-5, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(812, 453);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(806, 450);
            this.ControlBox = false;
            this.Controls.Add(this.Prize);
            this.Controls.Add(this.Luck);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Developers);
            this.Controls.Add(this.TeamWork);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TeamWork;
        private System.Windows.Forms.Label Developers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Luck;
        private System.Windows.Forms.Label Prize;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}