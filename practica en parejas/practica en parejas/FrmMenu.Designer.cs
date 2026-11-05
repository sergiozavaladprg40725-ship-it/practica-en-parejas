/*
 * Created by SharpDevelop.
 * User: CC2_PC50
 * Date: 04/11/2026
 * Time: 08:13 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace practica_en_parejas
{
	partial class FrmMenu
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.btnDAP = new System.Windows.Forms.Button();
			this.btnDentrepuntos = new System.Windows.Forms.Button();
			this.btnCoordenadas = new System.Windows.Forms.Button();
			this.btnSalir = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(53, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(178, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Menu Principal";
			// 
			// btnDAP
			// 
			this.btnDAP.Location = new System.Drawing.Point(49, 72);
			this.btnDAP.Name = "btnDAP";
			this.btnDAP.Size = new System.Drawing.Size(182, 23);
			this.btnDAP.TabIndex = 1;
			this.btnDAP.Text = "Dolares a pesos y pesos a dolares";
			this.btnDAP.UseVisualStyleBackColor = true;
			// 
			// btnDentrepuntos
			// 
			this.btnDentrepuntos.Location = new System.Drawing.Point(49, 119);
			this.btnDentrepuntos.Name = "btnDentrepuntos";
			this.btnDentrepuntos.Size = new System.Drawing.Size(182, 23);
			this.btnDentrepuntos.TabIndex = 2;
			this.btnDentrepuntos.Text = "Distancia entre dos puntos";
			this.btnDentrepuntos.UseVisualStyleBackColor = true;
			// 
			// btnCoordenadas
			// 
			this.btnCoordenadas.Location = new System.Drawing.Point(49, 168);
			this.btnCoordenadas.Name = "btnCoordenadas";
			this.btnCoordenadas.Size = new System.Drawing.Size(182, 23);
			this.btnCoordenadas.TabIndex = 3;
			this.btnCoordenadas.Text = "Calculo de coordenadas";
			this.btnCoordenadas.UseVisualStyleBackColor = true;
			// 
			// btnSalir
			// 
			this.btnSalir.Location = new System.Drawing.Point(181, 226);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(91, 23);
			this.btnSalir.TabIndex = 4;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.BtnSalirClick);
			// 
			// FrmMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.btnCoordenadas);
			this.Controls.Add(this.btnDentrepuntos);
			this.Controls.Add(this.btnDAP);
			this.Controls.Add(this.label1);
			this.Name = "FrmMenu";
			this.Text = "FrmMenu";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Button btnCoordenadas;
		private System.Windows.Forms.Button btnDentrepuntos;
		private System.Windows.Forms.Button btnDAP;
		private System.Windows.Forms.Label label1;
	}
}
