/*
 * Created by SharpDevelop.
 * User: oferh
 * Date: 24-May-16
 * Time: 13:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
namespace hidato.Cells
{
	/// <summary>
	/// Description of userControlHiveCells.
	/// </summary>
	
	public partial class userControlHiveCells : UserControl
	{
		private hivesContainer m_hc;
		private const int REC_SIZE = 20;
		private const int SPACES_BETWEEN_OBJ = REC_SIZE+8;
		public userControlHiveCells(hivesContainer hc)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			m_hc=hc;
			InitializeComponent();
			
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		protected override void OnPaint(PaintEventArgs pe)
		{
		   // Call the OnPaint method of the base class.
		   base.OnPaint(pe);
		
		   // Declare and instantiate a new pen.
		   System.Drawing.Pen myPen = new System.Drawing.Pen(Color.Aqua);
		   Size recSize = new Size(REC_SIZE,REC_SIZE);
		   bool spacerFlag = false;
		   System.Drawing.Font drawFont = new System.Drawing.Font( "Arial", Convert.ToInt32(REC_SIZE/2));
    System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
		   int spacer = m_hc.totalRows - m_hc.size;
		   Point myLoc = new Point(spacer*(SPACES_BETWEEN_OBJ/2) , this.Location.Y);
		   // Draw an aqua rectangle in the rectangle represented by the control.
			foreach (List<hiveCell> row in m_hc.allRows) {
				//ROW	
				foreach (hiveCell  h in row) {
					//draw cell
					pe.Graphics.DrawRectangle(myPen, new Rectangle(myLoc, recSize));
					pe.Graphics.DrawString(h.Value.ToString(),drawFont,drawBrush,myLoc.X,myLoc.Y);

					//update location
					myLoc.Offset (SPACES_BETWEEN_OBJ,0);
				}
				if (spacer <= 0 && !spacerFlag)
				{
					spacerFlag =true;
				}
				if (spacerFlag){spacer++;}else{spacer--;}
				
				myLoc.Offset( -myLoc.X+(spacer*(SPACES_BETWEEN_OBJ/2)), SPACES_BETWEEN_OBJ);
				
				//end of row 
			}
		   
		   
		}
		private void drawText()
		{
			System.Drawing.Graphics formGraphics = this.CreateGraphics();
    string drawString = "Sample Text";
    System.Drawing.Font drawFont = new System.Drawing.Font(
        "Arial", 16);
    System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
    float x = 150.0f;
    float y = 50.0f;
    formGraphics.DrawString(drawString, drawFont, drawBrush, x, y);
		}
	}
}
