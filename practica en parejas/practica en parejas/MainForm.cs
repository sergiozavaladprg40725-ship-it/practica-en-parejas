/*
 * Created by SharpDevelop.
 * User: CC2_PC50
 * Date: 04/11/2026
 * Time: 08:09 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace practica_en_parejas
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnIngresarClick(object sender, EventArgs e)
		{
			if (txtUsuario.Text == "Usuario1" && txtContraseña.Text == "xdd")
	        {
	            FrmMenu menu = new FrmMenu();
	            menu.Show();
	            this.Hide();
	        }
	        else
	        {
	            MessageBox.Show("Usuario o contraseña incorrectos");
	        }
			}
	}
}
