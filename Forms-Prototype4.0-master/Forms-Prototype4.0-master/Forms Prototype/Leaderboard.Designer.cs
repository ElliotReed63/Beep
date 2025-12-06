namespace Forms_Prototype
{
    partial class Leaderboard
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
            label1 = new Label();
            LeaderboardLB = new ListBox();
            button1 = new Button();
            ShowLeaderboard = new Button();
            label2 = new Label();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F);
            label1.Location = new Point(290, 9);
            label1.Name = "label1";
            label1.Size = new Size(210, 46);
            label1.TabIndex = 0;
            label1.Text = "Leaderboard";
            label1.Click += label1_Click;
            // 
            // LeaderboardLB
            // 
            LeaderboardLB.FormattingEnabled = true;
            LeaderboardLB.Location = new Point(12, 130);
            LeaderboardLB.Name = "LeaderboardLB";
            LeaderboardLB.Size = new Size(190, 184);
            LeaderboardLB.TabIndex = 1;
            LeaderboardLB.SelectedIndexChanged += LeaderboardLB_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(25, 17);
            button1.Name = "button1";
            button1.Size = new Size(99, 63);
            button1.TabIndex = 2;
            button1.Text = "Menu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ShowLeaderboard
            // 
            ShowLeaderboard.Location = new Point(12, 96);
            ShowLeaderboard.Name = "ShowLeaderboard";
            ShowLeaderboard.Size = new Size(190, 28);
            ShowLeaderboard.TabIndex = 3;
            ShowLeaderboard.Text = "Show Leaderboard";
            ShowLeaderboard.UseVisualStyleBackColor = true;
            ShowLeaderboard.Click += ShowLeaderboard_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(296, 55);
            label2.Name = "label2";
            label2.Size = new Size(195, 28);
            label2.TabIndex = 4;
            label2.Text = "(Under Maintenance)";
            // 
            // button2
            // 
            button2.Location = new Point(400, 101);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(344, 207);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(444, 240);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Leaderboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(ShowLeaderboard);
            Controls.Add(button1);
            Controls.Add(LeaderboardLB);
            Controls.Add(label1);
            Name = "Leaderboard";
            Text = "Leaderboard";
            Load += Leaderboard_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox LeaderboardLB;
        private Button button1;
        private Button ShowLeaderboard;
        private Label label2;
        private Button button2;
        private DataGridView dataGridView1;
    }
}