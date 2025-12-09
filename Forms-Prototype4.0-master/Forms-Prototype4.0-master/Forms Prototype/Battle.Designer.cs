namespace Forms_Prototype
{
    partial class Battle
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
            TeamListBox = new ListBox();
            SuspendLayout();
            //
            // TeamListBox
            //
            TeamListBox.FormattingEnabled = true;
            TeamListBox.Location = new Point(269, 100);
            TeamListBox.Name = "TeamListBox";
            TeamListBox.Size = new Size(257, 214);
            TeamListBox.TabIndex = 0;
            //
            // Battle
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TeamListBox);
            Name = "Battle";
            Text = "Battle";
            ResumeLayout(false);
        }

        #endregion

        private ListBox TeamListBox;
    }
}