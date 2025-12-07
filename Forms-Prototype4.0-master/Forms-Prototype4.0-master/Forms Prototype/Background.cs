using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_Prototype
{
    public partial class Background : BaseGUI
    {
        public Background()
        {
            InitializeComponent();
            this.Shown += LeaderboardForm_Shown;
            ConfigureTransparentButtons();
        }
        private void LeaderboardForm_Shown(object sender, EventArgs e)
        {
            // OPTIONAL: Only if you need the background on startup.
            // LoadBackground();
        }


        private void Background_Load(object sender, EventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {
            ApplyBackground(1);
        }
        private void ApplyBackground(int imageId)
        {
            PokemonDatabase database = new PokemonDatabase();
            (Image img, byte[] beep) = database.SelectBackground(imageId);

            BaseGUI.SetSharedBackground(img, ImageLayout.Stretch);
            ApplySharedBackground();

            if (img != null)
            {
                ApplyButtonImage(button1, img);
                ApplyButtonImage(button2, img);
                ApplyButtonImage(button3, img);
            }
        }
        private static void ApplyButtonImage(Button button, Image background)
        {
            button.BackgroundImage = background;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ApplyBackground(2);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ApplyBackground(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.ShowDialog();
            this.Close();
        }

        private void ConfigureTransparentButtons()
        {
            ConfigureTransparentButton(button1);
            ConfigureTransparentButton(button2);
            ConfigureTransparentButton(button3);
        }

        private static void ConfigureTransparentButton(Button button)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button.BackColor = Color.Transparent;
            button.UseVisualStyleBackColor = false;
            button.ForeColor = Color.White;
            button.Paint += DrawButtonBackgroundFromForm;
        }

        private static void RefreshTransparentButtons()
        {
            // Force a repaint so the pseudo-transparent effect uses the latest background.
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is Background backgroundForm)
                {
                    backgroundForm.button1?.Invalidate();
                    backgroundForm.button2?.Invalidate();
                    backgroundForm.button3?.Invalidate();
                }
            }
        }

        private static void DrawButtonBackgroundFromForm(object? sender, PaintEventArgs e)
        {
            if (sender is not Button button)
            {
                return;
            }

            Form? form = button.FindForm();
            Image? img = form?.BackgroundImage;

            if (form == null || img == null || form.ClientSize.Width == 0 || form.ClientSize.Height == 0)
            {
                return;
            }

            Rectangle destRect = button.ClientRectangle;

            if (form.BackgroundImageLayout == ImageLayout.Stretch)
            {
                float xScale = (float)img.Width / form.ClientSize.Width;
                float yScale = (float)img.Height / form.ClientSize.Height;

                RectangleF srcRect = new RectangleF(
                    button.Left * xScale,
                    button.Top * yScale,
                    button.Width * xScale,
                    button.Height * yScale);

                e.Graphics.DrawImage(img, destRect, srcRect, GraphicsUnit.Pixel);
            }
            else
            {
                // Fallback: fill with the form's background color.
                using SolidBrush brush = new SolidBrush(form.BackColor);
                e.Graphics.FillRectangle(brush, destRect);
            }

            TextRenderer.DrawText(
                e.Graphics,
                button.Text,
                button.Font,
                destRect,
                button.ForeColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis);
        }
    }
}
