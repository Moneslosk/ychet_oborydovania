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
	public partial class Supplier : Form
	{
		public Supplier()
		{
			InitializeComponent();
		}

		private void поставщикBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.поставщикBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.database_equipment_accountingDataSet);

		}

		private void Supplier_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'database_equipment_accountingDataSet.Поставщик' table. You can move, or remove it, as needed.
			this.поставщикTableAdapter.Fill(this.database_equipment_accountingDataSet.Поставщик);

		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.поставщикBindingSource.AddNew();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			this.поставщикBindingSource.RemoveCurrent();
			this.поставщикTableAdapter.Update(this.database_equipment_accountingDataSet.Поставщик);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.поставщикBindingSource.EndEdit();
			this.поставщикTableAdapter.Update(this.database_equipment_accountingDataSet.Поставщик);
		}

		private void button8_Click(object sender, EventArgs e)
		{
			this.поставщикBindingSource.MoveFirst();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			this.поставщикBindingSource.MovePrevious();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			this.поставщикBindingSource.MoveNext();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			this.поставщикBindingSource.MoveLast();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			TableSupplier TableSupplier = new TableSupplier();
			TableSupplier.ShowDialog();
		}
	}
}
