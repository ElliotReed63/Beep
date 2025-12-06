namespace Forms_Prototype
{
    partial class PokemonSelection
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
            tb_Pokemon = new TextBox();
            SearchButton = new Button();
            lb_Pokemon = new ListBox();
            Select = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(135, 81);
            label1.Name = "label1";
            label1.Size = new Size(123, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter Pokemon Name";
            // 
            // tb_Pokemon
            // 
            tb_Pokemon.Location = new Point(302, 78);
            tb_Pokemon.Name = "tb_Pokemon";
            tb_Pokemon.Size = new Size(145, 23);
            tb_Pokemon.TabIndex = 1;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(483, 113);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(102, 56);
            SearchButton.TabIndex = 2;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // lb_Pokemon
            // 
            lb_Pokemon.FormattingEnabled = true;
            lb_Pokemon.Location = new Point(263, 184);
            lb_Pokemon.Name = "lb_Pokemon";
            lb_Pokemon.Size = new Size(205, 109);
            lb_Pokemon.TabIndex = 3;
            lb_Pokemon.SelectedIndexChanged += lb_Pokemon_SelectedIndexChanged;
            // 
            // Select
            // 
            Select.Location = new Point(489, 299);
            Select.Name = "Select";
            Select.Size = new Size(96, 57);
            Select.TabIndex = 4;
            Select.Text = "Select";
            Select.UseVisualStyleBackColor = true;
            Select.Click += Select_Click;
            // 
            // PokemonSelection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Select);
            Controls.Add(lb_Pokemon);
            Controls.Add(SearchButton);
            Controls.Add(tb_Pokemon);
            Controls.Add(label1);
            Name = "PokemonSelection";
            Text = "PokemonSelection";
            Load += PokemonSelection_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tb_Pokemon;
        private Button SearchButton;
        private ListBox lb_Pokemon;
        private Button Select;
    }
}