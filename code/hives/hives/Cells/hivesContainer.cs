/*
 * Created by SharpDevelop.
 * User: oferh
 * Date: 23-May-16
 * Time: 21:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace hidato.Cells
{
	/// <summary>
	/// Description of Hive.
	/// </summary>
	public class hivesContainer
	{
		private int m_totalCells;
		//private List<List<hiveCell>> allRows = new List<List<hiveCell>>();
		internal List<List<hiveCell>> allRows = new List<List<hiveCell>>();
		private int m_maxValue;
		private int m_size;
		public hivesContainer(int size)
		{
			//create skeleton of hives
			//long calculation m_totalCells = (size*(2*size+(size-1)))-(2*size-1);
			m_size =size;
			m_totalCells = 3*(size*size-size)+1;
			m_maxValue = 2*size-1;
			//create rows
			for (int i = 1; i <= m_maxValue; i++) {
				//create row with length of row
				int rowMax = rowCount (i);
				System.Diagnostics.Debug.Print ("row {0}: max in lines {1}" ,i,rowMax );
//				create row collention
				List<hiveCell> thisRow = new List<hiveCell>();
				
				for (int j = 1; j <= rowMax; j++) {
					//create single hive
					hiveCell h = new hiveCell();
					thisRow.Add(h);
				}
				//add thisRow to allRows
				allRows.Add (thisRow);
			}
			
		}
		
		public int size
		{ get{return m_size;}}
		public int totalRows
		{get{return m_maxValue;}}
		public int count
		{get{return m_totalCells;}}
		
		public void updateCell(int row, int col, int value)
		{
			//check if value exists
			allRows[row-1][col-1].Value = value;
			
		}
		public hiveCell getFirstInRow(int row)
		{
			if (row > m_maxValue) {throw new Exception(Resource.ROW_MAX);}
			return allRows[row-1][0];
			
		}
		public hiveCell getLastInRow(int row)
		{
			if (row > m_maxValue) {throw new Exception(Resource.ROW_MAX);}
			
				return allRows[row-1][this.rowCount(row)];
			
		}
		public int rowCount(int rowNumber)
		{
			if (rowNumber > m_maxValue) throw new Exception(Resource.ROW_MAX);
			int myIndex = rowNumber;
			if (rowNumber-m_size > 0) {
				myIndex = rowNumber - ((rowNumber - m_size)*2);
			}
			return (m_size + myIndex-1);
 		}
		public void printHive()
		{

			Debug.Print ("Hive size {0}, total rows {1}, total cells {2}",m_size,m_maxValue,m_totalCells);
			foreach (List<hiveCell> row in allRows) {
				string printRow="";
				foreach (hiveCell  h in row) {
					printRow += "<" + h.Value + "> ";
				}
				Debug.Print( printRow);
			}
		}
		
	}
}

