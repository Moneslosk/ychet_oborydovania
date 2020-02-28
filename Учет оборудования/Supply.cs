using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Учет_оборудования
{
	public partial class Supply : Form
	{
		public Supply()
		{
			InitializeComponent();
		}

		private void поставкаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.поставкаBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.database_equipment_accountingDataSet);

		}

		private void Supply_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'database_equipment_accountingDataSet.Поставщик' table. You can move, or remove it, as needed.
			this.поставщикTableAdapter.Fill(this.database_equipment_accountingDataSet.Поставщик);
			// TODO: This line of code loads data into the 'database_equipment_accountingDataSet.Оборудование' table. You can move, or remove it, as needed.
			this.оборудованиеTableAdapter.Fill(this.database_equipment_accountingDataSet.Оборудование);
			// TODO: This line of code loads data into the 'database_equipment_accountingDataSet.Поставка' table. You can move, or remove it, as needed.
			this.поставкаTableAdapter.Fill(this.database_equipment_accountingDataSet.Поставка);

		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.поставкаBindingSource.AddNew();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			this.поставкаBindingSource.RemoveCurrent();
			this.поставкаTableAdapter.Update(this.database_equipment_accountingDataSet.Поставка);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.поставкаBindingSource.EndEdit();
			this.поставкаTableAdapter.Update(this.database_equipment_accountingDataSet.Поставка);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			TableSupply TableSupply = new TableSupply();
			TableSupply.ShowDialog();
		}

		private void button8_Click(object sender, EventArgs e)
		{
			this.поставкаBindingSource.MoveFirst();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			this.поставкаBindingSource.MovePrevious();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			this.поставкаBindingSource.MoveNext();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			this.поставкаBindingSource.MoveLast();
		}
	}
}
