﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiometricsTest.Helpers
{
    internal class GraphicsManager
    {
        public static void DrawLine(Control frm, Color color, int x, int y, int x1, int y1, int thickness)
        {
            Graphics graphicsObj;
            graphicsObj = frm.CreateGraphics();
            Pen myPen = new Pen(color, thickness);
            graphicsObj.DrawLine(myPen, x, y, x1, y1);
        }
    }
}
