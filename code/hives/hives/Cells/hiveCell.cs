/*
 * Created by SharpDevelop.
 * User: oferh
 * Date: 23-May-16
 * Time: 21:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace hidato.Cells
{
	/// <summary>
	/// Description of Hive.
	/// </summary>
	public class hiveCell
	{

		private int m_value=0;

		public hiveCell() : this(0)
		{
			
		}
		public hiveCell(int cellValue)
		{m_value=cellValue;}

		public int Value
		{
			get
			{ return m_value;}
			internal set {m_value =value;}
		}

	}
}
