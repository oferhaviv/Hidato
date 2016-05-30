/*
 * Created by SharpDevelop.
 * User: oferh
 * Date: 23-May-16
 * Time: 21:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

using hidato.Cells;
using System.Windows.Forms;

namespace hidato
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public hivesContainer main = new hivesContainer(5);
		public MainForm()
		{
			
				
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			main.updateCell(2,3,39);
			main.updateCell(3,2,22);
			main.updateCell(3,3,41);
			main.updateCell(3,6,45);
			

			main.printHive();
			
			hidato.Cells.userControlHiveCells cellsDrawing = new userControlHiveCells(main);
			cellsDrawing.Location = new System.Drawing.Point(5,5);
			cellsDrawing.Name = "cd";
			this.Controls.Add(cellsDrawing);
			
		}
	}
}
