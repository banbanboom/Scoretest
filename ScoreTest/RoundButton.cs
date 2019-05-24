using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace ScoreTest
{
    public class RoundButton : Button
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            //pevent.Graphics.FillEllipse(Brushes.Plum, this.ClientRectangle);
            //return;


            GraphicsPath grpath = new GraphicsPath();

            Rectangle newRectangle = this.ClientRectangle;
            this.ClientRectangle.Inflate(-10, -10);

            pevent.Graphics.DrawEllipse(Pens.Red, newRectangle);
            newRectangle.Inflate(1, 1);

            grpath.AddEllipse(newRectangle);
            this.Region = new Region(grpath);
            base.OnPaint(pevent);



        }
    }
}
