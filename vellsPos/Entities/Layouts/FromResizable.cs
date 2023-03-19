using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vellsPos.Entities.Layouts
{
    internal class FromResizable
    {
        public void resizeControl(Rectangle r, Control c, float ofs, Form form, Rectangle rzForm)
        {
            float xRatio = (float)(form.ClientRectangle.Width) / (float)(rzForm.Width);
            float yRatio = (float)(form.ClientRectangle.Height) / (float)(rzForm.Height);

            float newX = r.Location.X * xRatio;
            float newY = r.Location.Y * yRatio;

            c.Location = new Point((int)newX, (int)newY);
            c.Width = (int)(r.Width * xRatio);
            c.Height = (int)(r.Height * yRatio);

            float ratio = xRatio;

            if (xRatio >= yRatio)
            {
                ratio = yRatio;
            }

            float newFontSize = ofs * ratio;
            Font newFont = new Font(c.Font.FontFamily, newFontSize);
            c.Font = newFont;
        }
    }
}
