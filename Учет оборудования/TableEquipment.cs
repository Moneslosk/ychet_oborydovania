using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;
using System.Reflection;

namespace Учет_оборудования
{
	public partial class TableEquipment : Form
	{
		public TableEquipment()
		{
			InitializeComponent();
		}

		private DataTable dbdatasrt;
		private void оборудованиеBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.оборудованиеBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.database_equipment_accountingDataSet);

		}


		private void TableEquipment_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'database_equipment_accountingDataSet.Оборудование' table. You can move, or remove it, as needed.
			this.оборудованиеTableAdapter.Fill(this.database_equipment_accountingDataSet.Оборудование);

		}

		private void button1_Click(object sender, EventArgs e)
		{
			for (int col = 0; col < оборудованиеDataGridView.ColumnCount; col++)
			for (int row = 0; row < оборудованиеDataGridView.RowCount - 1; row++)
				оборудованиеDataGridView[col, row].Style.BackColor = Color.White;
			for (int col = 0; col < оборудованиеDataGridView.ColumnCount; col++)
			for (int row = 0; row < оборудованиеDataGridView.RowCount - 1; row++)
				if (оборудованиеDataGridView[col, row].Value.ToString().IndexOf(textBox1.Text, StringComparison.OrdinalIgnoreCase) >= 0)
				{
					for (int Q = 0; Q < оборудованиеDataGridView.ColumnCount; Q++)
						оборудованиеDataGridView[Q, row].Style.BackColor = Color.Khaki;
				}
			for (int col = 0; col < оборудованиеDataGridView.ColumnCount; col++)
			for (int row = 0; row < оборудованиеDataGridView.RowCount - 1; row++)
				if (оборудованиеDataGridView[col, row].Value.ToString().IndexOf(textBox1.Text, StringComparison.OrdinalIgnoreCase) >= 0)
					оборудованиеDataGridView[col, row].Style.BackColor = Color.Orange;
			textBox1.Clear();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			for (int col = 0; col < оборудованиеDataGridView.ColumnCount; col++)
			for (int row = 0; row < оборудованиеDataGridView.RowCount - 1; row++)
				оборудованиеDataGridView[col, row].Style.BackColor = Color.White;
		}

		public void exportToWord(DataGridView DGV, string filename, string name)
		{
			if (DGV.Rows.Count != 0)
			{
				int RowCount = DGV.Rows.Count;
				int ColumnCount = DGV.Columns.Count;
				Object[,] DataArray = new object[RowCount + 1, ColumnCount + 1];

				//add rows
				int r = 0;
				for (int c = 0; c <= ColumnCount - 1; c++)
				{
					for (r = 0; r <= RowCount - 1; r++)
					{
						DataArray[r, c] = DGV.Rows[r].Cells[c].Value;
					} //end row loop
				} //end column loop

				Word.Document oDoc = new Word.Document();
				oDoc.Application.Visible = true;

				oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;


				dynamic oRange = oDoc.Content.Application.Selection.Range;
				string oTemp = "";
				for (r = 0; r <= RowCount - 1; r++)
				{
					for (int c = 0; c <= ColumnCount - 1; c++)
					{
						oTemp = oTemp + DataArray[r, c] + "\t";

					}
				}

				oRange.Text = oTemp;
				object oMissing = Missing.Value;
				object Separator = Word.WdTableFieldSeparator.wdSeparateByTabs;
				object ApplyBorders = true;
				object AutoFit = true;
				object AutoFitBehavior = Word.WdAutoFitBehavior.wdAutoFitContent;

				oRange.ConvertToTable(ref Separator, ref RowCount, ref ColumnCount,
									  Type.Missing, Type.Missing, ref ApplyBorders,
									  Type.Missing, Type.Missing, Type.Missing,
									  Type.Missing, Type.Missing, Type.Missing,
									  Type.Missing, ref AutoFit, ref AutoFitBehavior, Type.Missing);

				oRange.Select();

				oDoc.Application.Selection.Tables[1].Select();
				oDoc.Application.Selection.Tables[1].Rows.AllowBreakAcrossPages = 0;
				oDoc.Application.Selection.Tables[1].Rows.Alignment = 0;
				oDoc.Application.Selection.Tables[1].Rows[1].Select();
				oDoc.Application.Selection.InsertRowsAbove(1);
				oDoc.Application.Selection.Tables[1].Rows[1].Select();

				oDoc.Application.Selection.Tables[1].Rows[1].Range.Bold = 1;
				oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Name = "Tahoma";
				oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Size = 14;

				for (int c = 0; c <= ColumnCount - 1; c++)
				{
					oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = DGV.Columns[c].HeaderText;
				}

				oDoc.Application.Selection.Tables[1].Rows[1].Select();
				oDoc.Application.Selection.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;

				foreach (Word.Section section in oDoc.Application.ActiveDocument.Sections)
				{
					Word.Range headerRange = section.Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
					headerRange.Fields.Add(headerRange, Word.WdFieldType.wdFieldPage);
					headerRange.Text = name;
					headerRange.Font.Size = 16;
					headerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
				}


				oDoc.SaveAs(filename, ref oMissing, ref oMissing, ref oMissing,
	ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing,
	ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing,
	ref oMissing, ref oMissing);

			}
		}
		private void button3_Click(object sender, EventArgs e)
		{
			SaveFileDialog sfd = new SaveFileDialog();

			sfd.Filter = "Word Documents (*.docx)|*.docx";

			sfd.FileName = "Оборудование.docx";

			if (sfd.ShowDialog() == DialogResult.OK)
			{
				string ter = "Оборудование";
				exportToWord(оборудованиеDataGridView, sfd.FileName, ter);
			}
		}
		public void exportToExcel(DataGridView dgv)
		{
			var dia = new SaveFileDialog();
			dia.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			dia.Filter = "Excel Worksheets (*.xlsx)|*.xlsx|xls file (*.xls)|*.xls|All files (*.*)|*.*";
			dia.FileName = "Оборудование.xlsx";
			if (dia.ShowDialog(this) == DialogResult.OK)
			{
				Excel.Application excelapp = new Excel.Application();
				Excel.Workbook workbook = excelapp.Workbooks.Add();
				Excel.Worksheet worksheet = (Excel.Worksheet)workbook.ActiveSheet;

				int currentCol = 0;
				for (int j = 0; j < dgv.ColumnCount; j++)
				{
					if (dgv.Columns[j].Visible)
					{
						worksheet.Rows[1].Columns[currentCol + 1] = dgv.Columns[j].HeaderText;
					}
					else
					{
						currentCol -= 1;
					}
					currentCol++;
				}

				int currentRow = 0;
				for (int i = 1; i < dgv.RowCount + 1; i++)
				{
					currentRow++;
					currentCol = 0;
					for (int j = 1; j < dgv.ColumnCount + 1; j++)
					{
						currentCol++;
						if (dgv.Rows[i - 1].Visible)
						{
							if (dgv.Columns[j - 1].Visible)
							{
								worksheet.Rows[currentRow + 1].Columns[currentCol] = dgv.Rows[i - 1].Cells[j - 1].Value;
							}
							else
							{
								currentCol -= 1;
							}
						}
						else
						{
							currentRow -= 1;
						}
					}
				}

				excelapp.AlertBeforeOverwriting = false;
				workbook.SaveAs(dia.FileName);
				excelapp.Quit();
			}
		}
		private void button4_Click(object sender, EventArgs e)
		{
			exportToExcel(оборудованиеDataGridView);
		}
		private System.Windows.Forms.DataGridViewColumn COL;
		private void button5_Click(object sender, EventArgs e)
		{
			COL = new System.Windows.Forms.DataGridViewColumn();
			switch (listBox1.SelectedIndex)
			{
				case 0:
					COL = dataGridViewTextBoxColumn2;
					break;
				case 1:
					COL = dataGridViewTextBoxColumn3;
					break;
				case 2:
					COL = dataGridViewTextBoxColumn4;
					break;
				case 3:
					COL = dataGridViewTextBoxColumn5;
					break;
				case 4:
					COL = dataGridViewTextBoxColumn6;
					break;
                case 5:
                    COL = dataGridViewTextBoxColumn7;
                    break;
                case 6:
                    COL = dataGridViewTextBoxColumn8;
                    break;
                case 7:
                    COL = dataGridViewTextBoxColumn9;
                    break;
                case 8:
                    COL = dataGridViewTextBoxColumn10;
                    break;
            
            }

            if (radioButton1.Checked == true)
            {
                оборудованиеDataGridView.Sort(COL, System.ComponentModel.ListSortDirection.Ascending);
            }
            else
                оборудованиеDataGridView.Sort(COL, System.ComponentModel.ListSortDirection.Descending);




        }

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			
			
		}

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button5.Enabled = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            оборудованиеBindingSource.Filter = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            оборудованиеBindingSource.Filter = "Название_оборудования='" + comboBox1.Text + "'";
        }
    }
}
