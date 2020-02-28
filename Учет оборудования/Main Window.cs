using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Учет_оборудования
{
	public partial class Form1 : Form
	{
		Timer timer = new Timer();
		private int counter = 0;
		public Form1()
		{
			InitializeComponent();

			
		}
		
		private  void Form1_Load(object sender, EventArgs e)
		{
			button1.BackColor = default(Color);
			button2.BackColor = default(Color);
			button3.BackColor = default(Color);
			button4.BackColor = default(Color);
			button5.BackColor = default(Color);
			button6.BackColor = default(Color);
			this.label5.BackColor = Color.Transparent;
			this.label3.BackColor = Color.Transparent;
			this.label4.BackColor = Color.Transparent;
			this.label6.BackColor = Color.Transparent;
			this.pictureBox1.BackColor = Color.Transparent;
			this.pictureBox2.BackColor = Color.Transparent;
			this.pictureBox3.BackColor = Color.Transparent;
			this.pictureBox4.BackColor = Color.Transparent;
			this.pictureBox5.BackColor = Color.Transparent;
			this.pictureBox6.BackColor = Color.Transparent;
			this.pictureBox7.BackColor = Color.Transparent;
			this.pictureBox8.BackColor = Color.Transparent;
			this.pictureBox9.BackColor = Color.Transparent;
			this.pictureBox10.BackColor = Color.Transparent;
			this.pictureBox11.BackColor = Color.Transparent;
			this.pictureBox12.BackColor = Color.Transparent;


		}

		private void button1_Click(object sender, EventArgs e)
		{
			Warehouse warehouse = new Warehouse();
			warehouse.ShowDialog();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Staff Staff = new Staff();
			Staff.ShowDialog();
		}

		private void button1_MouseEnter(object sender, EventArgs e)
		{
			button1.BackColor = Color.LemonChiffon;
		}

		private void button1_MouseLeave(object sender, EventArgs e)
		{
			button1.BackColor = default(Color);
		}

		private void button2_MouseEnter(object sender, EventArgs e)
		{
			button2.BackColor = Color.LemonChiffon;
		}

		private void button2_MouseLeave(object sender, EventArgs e)
		{
			button2.BackColor = default(Color);
		}

		private void button3_MouseEnter(object sender, EventArgs e)
		{
			button3.BackColor = Color.LemonChiffon;
		}

		private void button3_MouseLeave(object sender, EventArgs e)
		{
			button3.BackColor = default(Color);
		}

		private void button4_MouseEnter(object sender, EventArgs e)
		{
			button4.BackColor = Color.LemonChiffon;
		}

		private void button4_MouseLeave(object sender, EventArgs e)
		{
			button4.BackColor = default(Color);
		}

		private void button5_MouseEnter(object sender, EventArgs e)
		{
			button5.BackColor = Color.LemonChiffon;
		}

		private void button5_MouseLeave(object sender, EventArgs e)
		{
			button5.BackColor = default(Color);
		}

		private void button6_MouseEnter(object sender, EventArgs e)
		{
			button6.BackColor = Color.LemonChiffon;
		}

		private void button6_MouseLeave(object sender, EventArgs e)
		{
			button6.BackColor = default(Color);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Supplier Supplier = new Supplier();
			Supplier.ShowDialog();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			Equipment Equipment = new Equipment();
			Equipment.ShowDialog();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			Сategories Сategories = new Сategories();
			Сategories.ShowDialog();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			Supply Supply = new Supply();
			Supply.ShowDialog();
		}



		private void timer3_Tick(object sender, EventArgs e)
		{
			int h = DateTime.Now.Hour;
			int m = DateTime.Now.Minute;
			int s = DateTime.Now.Second;

			string time = "";


			if (h < 10)
			{
				time += "0" + h;
			}
			else
			{
				time += h;
			}

			time += ":";

			if (m < 10)
			{
				time += "0" + m;
			}
			else
			{
				time += m;
			}

			time += ":";

			if (s < 10)
			{
				time += "0" + s;
			}
			else
			{
				time += s;
			}
			label3.Text = time;
			string data = "";

			int day = DateTime.Now.Day;
			int month = DateTime.Now.Month;
			int year = DateTime.Now.Year;

			if (day < 10)
			{
				data += "0" + day;
			}
			else
			{
				data += day;
			}
			data += ".";
			if (month < 10)
			{
				data += "0" + month;
			}
			else
			{
				data += month;
			}
			data += ".";
			data += year;
			label4.Text = data;
		}
	}
}
