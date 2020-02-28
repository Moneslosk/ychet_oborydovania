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
	public partial class Equipment : Form
	{
		public Equipment()
		{
			InitializeComponent();
		}

		private void оборудованиеBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.оборудованиеBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.database_equipment_accountingDataSet);

		}

		private void Equipment_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'database_equipment_accountingDataSet1.Категории' table. You can move, or remove it, as needed.
			this.категорииTableAdapter.Fill(this.database_equipment_accountingDataSet1.Категории);
			// TODO: This line of code loads data into the 'database_equipment_accountingDataSet.Поставка' table. You can move, or remove it, as needed.
			this.поставкаTableAdapter.Fill(this.database_equipment_accountingDataSet.Поставка);
			// TODO: This line of code loads data into the 'database_equipment_accountingDataSet.Категории' table. You can move, or remove it, as needed.
			this.категорииTableAdapter.Fill(this.database_equipment_accountingDataSet.Категории);
			// TODO: This line of code loads data into the 'database_equipment_accountingDataSet.Поставщик' table. You can move, or remove it, as needed.
			this.поставщикTableAdapter.Fill(this.database_equipment_accountingDataSet.Поставщик);
			// TODO: This line of code loads data into the 'database_equipment_accountingDataSet.Склад' table. You can move, or remove it, as needed.
			this.складTableAdapter.Fill(this.database_equipment_accountingDataSet.Склад);
			// TODO: This line of code loads data into the 'database_equipment_accountingDataSet.Оборудование' table. You can move, or remove it, as needed.
			this.оборудованиеTableAdapter.Fill(this.database_equipment_accountingDataSet.Оборудование);

		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.оборудованиеBindingSource.AddNew();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			this.оборудованиеBindingSource.RemoveCurrent();
			this.оборудованиеTableAdapter.Update(this.database_equipment_accountingDataSet.Оборудование);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.оборудованиеBindingSource.EndEdit();
			this.оборудованиеTableAdapter.Update(this.database_equipment_accountingDataSet.Оборудование);
		}

		private void button8_Click(object sender, EventArgs e)
		{
			this.оборудованиеBindingSource.MoveFirst();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			this.оборудованиеBindingSource.MovePrevious();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			this.оборудованиеBindingSource.MoveNext();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			this.оборудованиеBindingSource.MoveLast();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			TableEquipment TableEquipment = new TableEquipment();
			TableEquipment.ShowDialog();
		}
	}
}
