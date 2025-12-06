namespace Forms_Prototype
{
    partial class Menu
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
            button1 = new Button();
            button2 = new Button();
            Backgrounds = new Button();
            Leaderboard = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(169, 197);
            button1.Name = "button1";
            button1.Size = new Size(142, 107);
            button1.TabIndex = 0;
            button1.Text = "Player VS Player";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(495, 197);
            button2.Name = "button2";
            button2.Size = new Size(142, 107);
            button2.TabIndex = 1;
            button2.Text = "Player VS Computer";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Backgrounds
            // 
            Backgrounds.Location = new Point(12, 25);
            Backgrounds.Name = "Backgrounds";
            Backgrounds.Size = new Size(102, 62);
            Backgrounds.TabIndex = 5;
            Backgrounds.Text = "Backgrounds";
            Backgrounds.Click += Backgrounds_Click;
            // 
            // Leaderboard
            // 
            Leaderboard.Location = new Point(686, 15);
            Leaderboard.Name = "Leaderboard";
            Leaderboard.Size = new Size(102, 62);
            Leaderboard.TabIndex = 3;
            Leaderboard.Text = "Leaderboard";
            Leaderboard.UseVisualStyleBackColor = true;
            Leaderboard.Click += Leaderboard_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15F);
            textBox1.Location = new Point(252, 25);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(294, 34);
            textBox1.TabIndex = 4;
            textBox1.Text = "Pokemon \r\nBattle Simulator\r\n";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(Leaderboard);
            Controls.Add(Backgrounds);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Menu";
            Text = "Menu";
            Load += Menu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button Backgrounds;
        private Button Leaderboard;
        private TextBox textBox1;
    }
}