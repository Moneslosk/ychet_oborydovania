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
	public partial class Сategories : Form
	{
		public Сategories()
		{
			InitializeComponent();
		}

		private void категорииBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.категорииBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.database_equipment_accountingDataSet);

		}

		private void Сategories_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'database_equipment_accountingDataSet.Категории' table. You can move, or remove it, as needed.
			this.категорииTableAdapter.Fill(this.database_equipment_accountingDataSet.Категории);

		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.категорииBindingSource.AddNew();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			this.категорииBindingSource.RemoveCurrent();
			this.категорииTableAdapter.Update(this.database_equipment_accountingDataSet.Категории);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.категорииBindingSource.EndEdit();
			this.категорииTableAdapter.Update(this.database_equipment_accountingDataSet.Категории);
		}

		private void button8_Click(object sender, EventArgs e)
		{
			this.категорииBindingSource.MoveFirst();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			this.категорииBindingSource.MovePrevious();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			this.категорииBindingSource.MoveNext();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			this.категорииBindingSource.MoveLast();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			TableCategories TableCategories = new TableCategories();
			TableCategories.ShowDialog();
		}
	}
}
