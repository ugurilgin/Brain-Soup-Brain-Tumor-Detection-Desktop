using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrainSoup
{
    public class MyColorTable : ProfessionalColorTable
    {
        public override Color ToolStripDropDownBackground
        {
            get
            {
                return Color.FromArgb(0, 97,193);
            }
        }

        public override Color ImageMarginGradientBegin
        {
            get
            {
                return Color.FromArgb(0, 97, 193);
            }
        }

        public override Color ImageMarginGradientMiddle
        {
            get
            {
                return Color.FromArgb(0, 97, 193);
            }
        }

        public override Color ImageMarginGradientEnd
        {
            get
            {
                return Color.FromArgb(0, 97, 193);
            }
        }

        public override Color MenuBorder
        {
            get
            {
                return Color.FromArgb(0, 97, 193);
            }
        }

        public override Color MenuItemBorder
        {
            get
            {
                return Color.FromArgb(0, 97, 193);
            }
        }

        public override Color MenuItemSelected
        {
            get
            {
                return Color.FromArgb(30, 137, 233);
            }
        }

        public override Color MenuStripGradientBegin
        {
            get
            {
                return Color.FromArgb(0, 97, 193);
            }
        }

        public override Color MenuStripGradientEnd
        {
            get
            {
                return Color.FromArgb(0, 97, 193);
            }
        }

        public override Color MenuItemSelectedGradientBegin
        {
            get
            {
                return Color.FromArgb(30, 137, 233);
            }
        }

        public override Color MenuItemSelectedGradientEnd
        {
            get
            {
                return Color.FromArgb(30, 137, 233);
            }
        }

        public override Color MenuItemPressedGradientBegin
        {
            get
            {
                return Color.FromArgb(0, 97, 193);
            }
        }

        public override Color MenuItemPressedGradientEnd
        {
            get
            {
                return Color.FromArgb(0, 97, 193);
            }
        }
    }
}
