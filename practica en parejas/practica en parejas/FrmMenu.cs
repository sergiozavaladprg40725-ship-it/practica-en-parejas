/*
 * Created by SharpDevelop.
 * User: CC2_PC50
 * Date: 04/11/2026
 * Time: 08:13 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace practica_en_parejas
{
	/// <summary>
	/// Description of FrmMenu.
	/// </summary>
	public partial class FrmMenu : Form
	{
		public FrmMenu()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnSalirClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
