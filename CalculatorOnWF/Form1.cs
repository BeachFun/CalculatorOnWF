using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace CalculatorOnWF
{
	public partial class Calcutator : Form
	{
		private Thread SerialPort = new Thread(SerialPortHandler);
		public Calcutator()
		{
			InitializeComponent();
		}
		private static void SerialPortHandler()
		{

		}

		private void oneBUTTON_Click(object sender, EventArgs e)
		{
			backend.WritingNumber(int.Parse((sender as Button).Text));
			label2.Text = backend.GetNumstr;
		}

		private void twoBUTTON_Click(object sender, EventArgs e)
		{
			backend.WritingNumber(int.Parse((sender as Button).Text));
			label2.Text = backend.GetNumstr;

		}

		private void threeBUTTON_Click(object sender, EventArgs e)
		{
			backend.WritingNumber(int.Parse((sender as Button).Text));
			label2.Text = backend.GetNumstr;

		}

		private void fourBUTTON_Click(object sender, EventArgs e)
		{
			backend.WritingNumber(int.Parse((sender as Button).Text));
			label2.Text = backend.GetNumstr;

		}

		private void fiveBUTTON_Click(object sender, EventArgs e)
		{
			backend.WritingNumber(int.Parse((sender as Button).Text));
			label2.Text = backend.GetNumstr;

		}

		private void sixBUTTON_Click(object sender, EventArgs e)
		{
			backend.WritingNumber(int.Parse((sender as Button).Text));
			label2.Text = backend.GetNumstr;

		}

		public void sevenBUTTON_Click(object sender, EventArgs e)
		{
			backend.WritingNumber(int.Parse((sender as Button).Text));
			label2.Text = backend.GetNumstr;

		}

		private void eightBUTTON_Click(object sender, EventArgs e)
		{
			backend.WritingNumber(int.Parse((sender as Button).Text));
			label1.Text = backend.OutputExample();
			label2.Text = backend.GetNumstr;

		}

		private void nineBUTTON_Click(object sender, EventArgs e)
		{
			backend.WritingNumber(int.Parse((sender as Button).Text));
			label1.Text = backend.OutputExample();
			label2.Text = backend.GetNumstr;

		}

		private void zeroBUTTON_Click(object sender, EventArgs e)
		{
			backend.WritingNumber(int.Parse((sender as Button).Text));
			label1.Text = backend.OutputExample();
			label2.Text = backend.GetNumstr;

		}

		private void deleteBUTTON_Click(object sender, EventArgs e)
		{
			backend.Erase();
			label1.Text = backend.OutputExample();
			label2.Text = backend.GetNumstr;

		}

		private void plusBUTTON_Click(object sender, EventArgs e)
		{
			backend.Enter(char.Parse((sender as Button).Text));
			label1.Text = backend.OutputExample();
			label2.Text = backend.GetNumstr;
		}

		private void minusBUTTON_Click(object sender, EventArgs e)
		{
			backend.Enter(char.Parse((sender as Button).Text));
			label1.Text = backend.OutputExample();
			label2.Text = backend.GetNumstr;

		}

		private void multiplyBUTTON_Click(object sender, EventArgs e)
		{
			backend.Enter(char.Parse((sender as Button).Text));
			label1.Text = backend.OutputExample();
			label2.Text = backend.GetNumstr;

		}

		private void divideBUTTON_Click(object sender, EventArgs e)
		{
			backend.Enter(char.Parse((sender as Button).Text));
			label1.Text = backend.OutputExample();
			label2.Text = backend.GetNumstr;

		}

		private void C_BUTTON_Click(object sender, EventArgs e)
		{
			backend.Clear();
			label1.Text = backend.OutputExample();
			label2.Text = backend.GetNumstr;
		}

		private void commaBUTTON_Click(object sender, EventArgs e)
		{
			backend.WriteComma();
			label1.Text = backend.OutputExample();
			label2.Text = backend.GetNumstr;
		}

		private void CE_BUTTON_Click(object sender, EventArgs e)
		{
			backend.ClearNumber();
			label1.Text = backend.OutputExample();
			label2.Text = backend.GetNumstr;
		}

		private void changeTheNumberSignBUTTON_Click(object sender, EventArgs e)
		{
			backend.ChangeSignOfNumber();
			label1.Text = backend.OutputExample();
			label2.Text = backend.GetNumstr;
		}

		private void precentBUTTON_Click(object sender, EventArgs e)
		{
			backend.OnePrecentFromNumber();
			label1.Text = backend.OutputExample();
			label2.Text = backend.GetNumstr;
		}

		private void OneDivideByNumberBUTTON_Click(object sender, EventArgs e)
		{
			backend.OneDivideByNumber();
			label1.Text = backend.OutputExample();
			label2.Text = backend.GetNumstr;
		}

		private void RaiseNumberBUTTON_Click(object sender, EventArgs e)
		{
			backend.RaiseNumber();
			label1.Text = backend.OutputExample();
			label2.Text = backend.GetNumstr;
		}

		private void RadicalNumberBUTTON_Click(object sender, EventArgs e)
		{
			backend.RadicalNumber();
			label1.Text = backend.OutputExample();
			label2.Text = backend.GetNumstr;
		}

		private void equalBUTTON_Click(object sender, EventArgs e)
		{
			label1.Text = backend.Equal();
			label2.Text = backend.GetNumstr;
		}

        private void Calcutator_MouseEnter(object sender, EventArgs e)
        {

        }
    }
}
