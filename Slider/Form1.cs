using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slider
{
    public partial class Form1 : Form
    {
        bool isMotionIsDone;
        public Form1()
        {
            InitializeComponent();

            panel1.MouseEnter += async (s, e) =>
            {
                while(!isMotionIsDone && panel2.Location.X < panel1.Location.X + panel1.Width - 20)
                {
                    isMotionIsDone = true;
                    await Task.Delay(1);
                    panel2.Location = new Point(panel2.Location.X + (panel2.Width - panel2.Location.X + panel1.Location.X) / 18, panel2.Location.Y);
                    isMotionIsDone = false;
                }
            };

            panel2.MouseEnter += async (s, e) =>
            {
                while(!isMotionIsDone && panel2.Location.X > panel1.Location.X + 20)
                {
                    isMotionIsDone = true;
                    await Task.Delay(1);
                    panel2.Location = new Point(panel2.Location.X - (panel2.Location.X - panel1.Location.X + 20) / 18, panel2.Location.Y);
                    isMotionIsDone = false;
                }
            };
        }

    }
}
