
namespace SUPERCALCULADORA
{
	partial class MainForm
	{
		/// <summary>
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
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
		/// </summary>
		private void InitializeComponent()
		{
			this.SuspendLayout();

			// MainForm
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Gray;
			this.ClientSize = new System.Drawing.Size(288, 361);
			this.Name = "MainForm";
			this.Text = "SUPERCALCULADORA";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyDown);
			this.ResumeLayout(false);

		}
	}
}

//aqui sao alguns dos codigos que a IDE gera, eh isso sdushuhdaush