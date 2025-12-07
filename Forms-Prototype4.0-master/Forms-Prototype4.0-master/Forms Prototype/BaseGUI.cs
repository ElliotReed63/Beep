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
    public partial class BaseGUI : Form
    {
        private static Image _sharedBackgroundImage;
        private static ImageLayout _sharedBackgroundLayout = ImageLayout.Stretch;

        public BaseGUI()
        {
            InitializeComponent();
            ApplySharedBackground();
        }

        protected void ApplySharedBackground()
        {
            if (_sharedBackgroundImage != null)
            {
                BackgroundImage = _sharedBackgroundImage;
                BackgroundImageLayout = _sharedBackgroundLayout;
            }
        }

        public static void SetSharedBackground(Image backgroundImage, ImageLayout imageLayout)
        {
            _sharedBackgroundImage = backgroundImage;
            _sharedBackgroundLayout = imageLayout;
        }
    }
}
