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
	public partial class Warehouse : Form
	{ 
		public Warehouse()
		{
			InitializeComponent();
		}

		private void складBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.складBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.database_equipment_accountingDataSet);

		}

		private void Warehouse_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'database_equipment_accountingDataSet.Склад' table. You can move, or remove it, as needed.
			this.складTableAdapter.Fill(this.database_equipment_accountingDataSet.Склад);
			
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.складBindingSource.EndEdit();
			this.складTableAdapter.Update(this.database_equipment_accountingDataSet.Склад);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.складBindingSource.AddNew();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			TableWarehouse TableWarehouse = new TableWarehouse();
			TableWarehouse.ShowDialog();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			this.складBindingSource.RemoveCurrent();
			this.складTableAdapter.Update(this.database_equipment_accountingDataSet.Склад);
		}

		private void button5_Click(object sender, EventArgs e)
		{
			this.складBindingSource.MoveNext();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			this.складBindingSource.MovePrevious();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			this.складBindingSource.MoveLast();
		}

		private void button8_Click(object sender, EventArgs e)
		{
			this.складBindingSource.MoveFirst();
		}
	}
}
