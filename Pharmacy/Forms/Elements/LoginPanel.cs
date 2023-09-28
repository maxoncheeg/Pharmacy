using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy.Forms.Elements
{
	internal class LoginPanel : Panel
	{
		public static GraphicsPath RoundedRect(Rectangle bounds, int radius)
		{
			int diameter = radius * 2;
			Size size = new Size(diameter, diameter);
			Rectangle arc = new Rectangle(bounds.Location, size);
			GraphicsPath path = new GraphicsPath();

			if (radius == 0)
			{
				path.AddRectangle(bounds);
				return path;
			}

			// top left arc  
			path.AddArc(arc, 180, 90);

			// top right arc  
			arc.X = bounds.Right - diameter;
			path.AddArc(arc, 270, 90);

			// bottom right arc  
			arc.Y = bounds.Bottom - diameter;
			path.AddArc(arc, 0, 90);

			// bottom left arc 
			arc.X = bounds.Left;
			path.AddArc(arc, 90, 90);

			path.CloseFigure();
			return path;
		}


		protected override void OnPaint(PaintEventArgs e)
		{
			Color color = Color.FromArgb(172, 167, 167);

			BackColor = Color.Transparent;

			e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

			Rectangle gradientRectangle = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
			Brush brush = new LinearGradientBrush(gradientRectangle, color, color, 0.0f);

			using (GraphicsPath path = RoundedRect(gradientRectangle, 10))
			{
				e.Graphics.FillPath(brush, path);
			}

			base.OnPaint(e);
		}
	}
}
