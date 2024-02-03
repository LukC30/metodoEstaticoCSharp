using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SUPERCALCULADORA
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{

			InitializeComponent();

		}
		
		
		public Label visor = new Label();
		public Button btn0 = new Button();
		public Button btn1 = new Button();
		public Button btn2 = new Button();
		public Button btn3 = new Button();
		public Button btn4 = new Button();
		public Button btn5 = new Button();
		public Button btn6 = new Button();
		public Button btn7 = new Button();
		public Button btn8 = new Button();
		public Button btn9 = new Button();
		public Button btnvir = new Button();
		public Button btnsoma = new Button();
		public Button btnsub = new Button();
		public Button btnmul = new Button();
		public Button btndiv = new Button();
		public Button btnenter = new Button();
		
		
		void MainFormLoad(object sender, EventArgs e)
		{
			// visor da calc
			
			this.KeyPreview = true;
			visor.Parent = this;
			visor.Size = new Size(260, 100);
			visor.Font = new Font("Lucida Sans", 35f);
			visor.Top = 23;
			visor.Left = 16;
			visor.BackColor = System.Drawing.Color.White;
			visor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			visor.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			visor.Text = "oioi";
			
			
			//buttons
			
			
			btn0.Parent = this;
			btn0.Text = "0";
			btn0.Top = 300;
			btn0.Left = 16;
			btn0.Size = new Size(100, 45);
			btn0.BackColor = System.Drawing.Color.White;
			
			
			btn1.Parent = this;
			btn1.AutoSize = false;
			btn1.Text = "1";
			btn1.Top = btn0.Top - 45;
			btn1.Left = 16;
			btn1.Size = new Size(45, 45);
			btn1.BackColor = System.Drawing.Color.White;
			
			
			btn2.Parent = this;
			btn2.Text = "2";
			btn2.Top = btn1.Top;
			btn2.Left = btn1.Left + 55;
			btn2.Size = new Size(45, 45);
			btn2.BackColor = System.Drawing.Color.White;
			
		
			btn3.Parent = this;
			btn3.Text = "3";
			btn3.Top = btn1.Top;
			btn3.Left = btn2.Left + 55;
			btn3.Size = new Size(45, 45);
			btn3.BackColor = System.Drawing.Color.White;
			
			
			btn4.Parent = this;
			btn4.Text = "4";
			btn4.Top = btn1.Top - 45; 
			btn4.Left = btn1.Left;
			btn4.Size = new Size(45, 45);
			btn4.BackColor = System.Drawing.Color.White;
			
			
			btn5.Parent = this;
			btn5.Text = "5";
			btn5.Top = btn4.Top;
			btn5.Left = btn2.Left;
			btn5.Size = new Size(45, 45);
			btn5.BackColor = System.Drawing.Color.White;
			
			
			btn6.Parent = this;
			btn6.Text = "6";
			btn6.Top = btn5.Top;
			btn6.Left = btn3.Left;
			btn6.Size = new Size(45, 45);
			btn6.BackColor = System.Drawing.Color.White;
			
			btn7.Parent = this;
			btn7.Text = "7";
			btn7.Top = btn4.Top - 45;
			btn7.Left = btn1.Left;
			btn7.Size = new Size(45, 45);
			btn7.BackColor = System.Drawing.Color.White;
			
			btn8.Parent = this;
			btn8.Text = "8";
			btn8.Top = btn7.Top;
			btn8.Left = btn5.Left;
			btn8.Size = new Size(45, 45);
			btn8.BackColor = System.Drawing.Color.White;
			
			btn9.Parent = this;
			btn9.Text = "9";
			btn9.Top = btn8.Top;
			btn9.Left = btn6.Left;
			btn9.Size = new Size (45,45);
			btn9.BackColor = System.Drawing.Color.White;
			
			btnvir.Parent = this;
			btnvir.Text = ",";
			btnvir.Top = btn0.Top;
			btnvir.Left = btn3.Left;
			btnvir.Size = new Size(45,45);
			btnvir.BackColor = System.Drawing.Color.White;
			
			
			
			
		}
		void MainFormKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.NumPad0 || e.KeyCode == Keys.D0) {
				
			
			}
			
			
			
			
		}
		
		
		
	}
}


//rapaz q jogasso esse da coreia viu, menino son joga mt bola