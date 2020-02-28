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
	public partial class Staff : Form
	{
		public Staff()
		{
			InitializeComponent();
		}

		private void сотрудникиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.сотрудникиBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.database_equipment_accountingDataSet);

		}

		private void Staff_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'database_equipment_accountingDataSet.Склад' table. You can move, or remove it, as needed.
			this.складTableAdapter.Fill(this.database_equipment_accountingDataSet.Склад);
			// TODO: This line of code loads data into the 'database_equipment_accountingDataSet.Сотрудники' table. You can move, or remove it, as needed.
			this.сотрудникиTableAdapter.Fill(this.database_equipment_accountingDataSet.Сотрудники);

		}


		private void button2_Click_1(object sender, EventArgs e)
		{
			this.сотрудникиBindingSource.AddNew();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.сотрудникиBindingSource.EndEdit();
			this.сотрудникиTableAdapter.Update(this.database_equipment_accountingDataSet.Сотрудники);
		}

		private void button4_Click(object sender, EventArgs e)
		{
			this.сотрудникиBindingSource.RemoveCurrent();
			this.сотрудникиTableAdapter.Update(this.database_equipment_accountingDataSet.Сотрудники);
		}

		private void button5_Click(object sender, EventArgs e)
		{
			this.сотрудникиBindingSource.MoveNext();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			this.сотрудникиBindingSource.MoveLast();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			this.сотрудникиBindingSource.MovePrevious();
		}

		private void button8_Click(object sender, EventArgs e)
		{
			this.сотрудникиBindingSource.MoveFirst();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			TableStaff TableStaff = new TableStaff();
			TableStaff.ShowDialog();
		}
	}
}
