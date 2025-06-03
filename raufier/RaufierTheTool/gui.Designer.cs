/*
 * Created by SharpDevelop.
 * User: Francesco
 * Date: 2025. 05. 31.
 * Time: 19:49
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace RaufierTheTool
{
	partial class Ablak
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label serverIpLabel;
		private System.Windows.Forms.TextBox serverIpInput;
		
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
			this.serverIpLabel = new System.Windows.Forms.Label();
			this.serverIpInput = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// serverIpLabel
			// 
			this.serverIpLabel.ForeColor = System.Drawing.Color.Black;
			this.serverIpLabel.Location = new System.Drawing.Point(12, 9);
			this.serverIpLabel.Name = "serverIpLabel";
			this.serverIpLabel.Size = new System.Drawing.Size(100, 23);
			this.serverIpLabel.TabIndex = 0;
			this.serverIpLabel.Text = "Server IP:";
			// 
			// serverIpInput
			// 
			this.serverIpInput.Location = new System.Drawing.Point(71, 6);
			this.serverIpInput.Name = "serverIpInput";
			this.serverIpInput.Size = new System.Drawing.Size(206, 20);
			this.serverIpInput.TabIndex = 1;
			// 
			// Ablak
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1265, 624);
			this.Controls.Add(this.serverIpInput);
			this.Controls.Add(this.serverIpLabel);
			this.Name = "Ablak";
			this.Text = "Raufier | ©2025 Francis Studios";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
