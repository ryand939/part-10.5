using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace part_10._5
{

	/// <summary>
	/// 
	/// For this assignment, i will run the a second form on a seperate thread.
	/// This will enable the user to interact with both forms simultaneously.
	/// 
	/// </summary>


	public partial class Main : Form
	{
		public static List<Student> studentsObjList = new List<Student>();

		public static List<string> currentItems = new List<string>();

		Thread studentViewer;

		public Main()
		{
			InitializeComponent();
			currentItems.Clear();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			studentsObjList.Add((new Student( "Fred",     "Flintstone" )));
			studentsObjList.Add((new Student( "Wilma",    "Flintstone" )));
			studentsObjList.Add((new Student( "John",     "Johnson"    )));
			studentsObjList.Add((new Student( "Rachel",   "Appleseed"  )));
			studentsObjList.Add((new Student( "Santiago", "Lopez"      )));

			for(int x = 0; x < studentsObjList.Count; x++)
			{
				lstNames.Items.Add(studentsObjList[x].FirstName + " " + studentsObjList[x].LastName);
			}           
			// set up the mirror list for searchbox
			for (int x = 0; x < lstNames.Items.Count; x++)
			{
				currentItems.Add(lstNames.Items[x].ToString());
			}
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			lblCurrentSelection.Text = "";
			string search = txtSearch.Text.ToLower().Trim();
			lstNames.Items.Clear();

			// if there is text in the box
			if (search != "")
			{
				// check every item in the mirrored list to see if it contains the same text
				for (int i = 0; i < currentItems.Count; i++)
				{
					// if the mirrored list contains the search, add that index to the lstNames
					if (currentItems[i].ToLower().Contains(search))
					{
						lstNames.Items.Add(currentItems[i]);
					}
				}
			}
			// if there is NO text in the box, make all the entries appear
			else
			{
				for (int x = 0; x < currentItems.Count; x++)
				{
					lstNames.Items.Add(currentItems[x]);
				}
			}


		}

		private void btn_Quit_Paint(object sender, PaintEventArgs e)
		{
			var borderColor = Color.Black;
			var borderStyle = ButtonBorderStyle.Outset;
			var borderWidth = 2;

			ControlPaint.DrawBorder(
								e.Graphics,
								new Rectangle(0, 0, btnOpenSV.Width, btnOpenSV.Height),
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

		private void btnOpenSV_MouseDown(object sender, MouseEventArgs e)
		{
			btnOpenSV.Image = null;
		}

		private void btnOpenSV_MouseUp(object sender, MouseEventArgs e)
		{
			btnOpenSV.Image = Properties.Resources.chrome_eQbkOh3eCb;
		}

		private void lstNames_DrawItem(object sender, DrawItemEventArgs e)
		{

			e.DrawBackground();
			var myFont = new Font("Verdana", 8, FontStyle.Bold);
			bool isItemSelected = ((e.State & DrawItemState.Selected) == DrawItemState.Selected);
			int itemIndex = e.Index;
			if (itemIndex >= 0 && itemIndex < lstNames.Items.Count)
			{
				Graphics g = e.Graphics;

				// Background Color (condition) ? [true path] : [false path];
				SolidBrush backgroundColorBrush = new SolidBrush((isItemSelected) ? Color.FromArgb(82, 82, 82) : Color.FromArgb(64, 64, 64));
				g.FillRectangle(backgroundColorBrush, e.Bounds);

				// Set text color
				string itemText = lstNames.Items[itemIndex].ToString();


				// (condition) ? [true path] : [false path]; -> changes colour depending on what is selected
				SolidBrush itemTextColorBrush = (isItemSelected) ? new SolidBrush(Color.FromArgb(179, 226, 46)) : new SolidBrush(Color.FromArgb(240, 240, 240));
				g.DrawString(itemText, myFont, itemTextColorBrush, lstNames.GetItemRectangle(itemIndex).Location);

				// Clean up
				backgroundColorBrush.Dispose();
				itemTextColorBrush.Dispose();
			}

			e.DrawFocusRectangle();

		}

		private void borderForLst_Paint(object sender, PaintEventArgs e)
		{
			var borderStyleTopLeft = ButtonBorderStyle.Outset;
			var borderStyleBottomRight = ButtonBorderStyle.Inset;
			var borderWidth = 2; //default
			var borderColor = Color.Black;

			ControlPaint.DrawBorder(
								e.Graphics,
								new Rectangle(0, 0, borderForLst.Width, borderForLst.Height),
								borderColor,//left
								borderWidth,
								borderStyleTopLeft,
								borderColor,//top
								borderWidth,
								borderStyleTopLeft,
								borderColor,//right
								borderWidth,
								borderStyleBottomRight,
								borderColor,//left
								borderWidth,
								borderStyleBottomRight);

		}


		private void btnOpenSV_Click(object sender, EventArgs e)
		{

		}

		private void lstNames_SelectedIndexChanged(object sender, EventArgs e)
		{
			// update label
			lblCurrentSelection.Text = lstNames.SelectedItem.ToString();
		}
	}
}
