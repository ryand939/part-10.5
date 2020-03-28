using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace part_10._5
{
	public partial class StudentViewer : Form
	{
		public StudentViewer()
		{
			InitializeComponent();
		}

		private void button1_Paint(object sender, PaintEventArgs e)
		{
			var borderColor = Color.Black;
			var borderStyle = ButtonBorderStyle.Outset;
			var borderWidth = 2;

			ControlPaint.DrawBorder(
								e.Graphics,
								new Rectangle(0, 0, btn_Quit.Width, btn_Quit.Height),
								borderColor,
								borderWidth,
								borderStyle,
								borderColor,
								borderWidth,
								borderStyle,
								borderColor,
								borderWidth,
								borderStyle = ButtonBorderStyle.Inset, //right side
								borderColor,
								borderWidth,
								borderStyle = ButtonBorderStyle.Inset); //bottom side
		}
	}
}
