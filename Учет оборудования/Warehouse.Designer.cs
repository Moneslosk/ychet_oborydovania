namespace Учет_оборудования
{
	partial class Warehouse
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.Label адрес_складLabel;
			System.Windows.Forms.Label номер_телефона_складаLabel;
			this.database_equipment_accountingDataSet = new Учет_оборудования.Database_equipment_accountingDataSet();
			this.складBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.складTableAdapter = new Учет_оборудования.Database_equipment_accountingDataSetTableAdapters.СкладTableAdapter();
			this.tableAdapterManager = new Учет_оборудования.Database_equipment_accountingDataSetTableAdapters.TableAdapterManager();
			this.складBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.адрес_складTextBox = new System.Windows.Forms.TextBox();
			this.номер_телефона_складаTextBox = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			адрес_складLabel = new System.Windows.Forms.Label();
			номер_телефона_складаLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.database_equipment_accountingDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.складBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.складBindingNavigator)).BeginInit();
			this.складBindingNavigator.SuspendLayout();
			this.SuspendLayout();
			// 
			// адрес_складLabel
			// 
			адрес_складLabel.AutoSize = true;
			адрес_складLabel.BackColor = System.Drawing.Color.Transparent;
			адрес_складLabel.Font = new System.Drawing.Font("Algerian", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			адрес_складLabel.Location = new System.Drawing.Point(33, 40);
			адрес_складLabel.Name = "адрес_складLabel";
			адрес_складLabel.Size = new System.Drawing.Size(253, 21);
			адрес_складLabel.TabIndex = 4;
			адрес_складLabel.Text = "Город расположения склада: ";
			// 
			// номер_телефона_складаLabel
			// 
			номер_телефона_складаLabel.AutoSize = true;
			номер_телефона_складаLabel.BackColor = System.Drawing.Color.Transparent;
			номер_телефона_складаLabel.Font = new System.Drawing.Font("Algerian", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			номер_телефона_складаLabel.Location = new System.Drawing.Point(72, 77);
			номер_телефона_складаLabel.Name = "номер_телефона_складаLabel";
			номер_телефона_складаLabel.Size = new System.Drawing.Size(214, 21);
			номер_телефона_складаLabel.TabIndex = 6;
			номер_телефона_складаLabel.Text = "Номер телефона склада:";
			// 
			// database_equipment_accountingDataSet
			// 
			this.database_equipment_accountingDataSet.DataSetName = "Database_equipment_accountingDataSet";
			this.database_equipment_accountingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// складBindingSource
			// 
			this.складBindingSource.DataMember = "Склад";
			this.складBindingSource.DataSource = this.database_equipment_accountingDataSet;
			// 
			// складTableAdapter
			// 
			this.складTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.UpdateOrder = Учет_оборудования.Database_equipment_accountingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			this.tableAdapterManager.КатегорииTableAdapter = null;
			this.tableAdapterManager.ОборудованиеTableAdapter = null;
			this.tableAdapterManager.ПоставкаTableAdapter = null;
			this.tableAdapterManager.ПоставщикTableAdapter = null;
			this.tableAdapterManager.СкладTableAdapter = this.складTableAdapter;
			this.tableAdapterManager.СотрудникиTableAdapter = null;
			// 
			// складBindingNavigator
			// 
			this.складBindingNavigator.AddNewItem = null;
			this.складBindingNavigator.BindingSource = this.складBindingSource;
			this.складBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.складBindingNavigator.DeleteItem = null;
			this.складBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem});
			this.складBindingNavigator.Location = new System.Drawing.Point(0, 0);
			this.складBindingNavigator.MoveFirstItem = null;
			this.складBindingNavigator.MoveLastItem = null;
			this.складBindingNavigator.MoveNextItem = null;
			this.складBindingNavigator.MovePreviousItem = null;
			this.складBindingNavigator.Name = "складBindingNavigator";
			this.складBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.складBindingNavigator.Size = new System.Drawing.Size(493, 25);
			this.складBindingNavigator.TabIndex = 0;
			this.складBindingNavigator.Text = "bindingNavigator1";
			// 
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
			this.bindingNavigatorCountItem.Text = "of {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
			// 
			// bindingNavigatorPositionItem
			// 
			this.bindingNavigatorPositionItem.AccessibleName = "Position";
			this.bindingNavigatorPositionItem.AutoSize = false;
			this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
			this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
			this.bindingNavigatorPositionItem.Text = "0";
			this.bindingNavigatorPositionItem.ToolTipText = "Current position";
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Algerian", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(128, 157);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(113, 33);
			this.button1.TabIndex = 2;
			this.button1.Text = "Сохранить";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// адрес_складTextBox
			// 
			this.адрес_складTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.складBindingSource, "Адрес_склад", true));
			this.адрес_складTextBox.Font = new System.Drawing.Font("Algerian", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.адрес_складTextBox.Location = new System.Drawing.Point(292, 40);
			this.адрес_складTextBox.Name = "адрес_складTextBox";
			this.адрес_складTextBox.Size = new System.Drawing.Size(128, 29);
			this.адрес_складTextBox.TabIndex = 5;
			// 
			// номер_телефона_складаTextBox
			// 
			this.номер_телефона_складаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.складBindingSource, "Номер_телефона_склада", true));
			this.номер_телефона_складаTextBox.Font = new System.Drawing.Font("Algerian", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.номер_телефона_складаTextBox.Location = new System.Drawing.Point(292, 75);
			this.номер_телефона_складаTextBox.MaxLength = 12;
			this.номер_телефона_складаTextBox.Name = "номер_телефона_складаTextBox";
			this.номер_телефона_складаTextBox.Size = new System.Drawing.Size(128, 25);
			this.номер_телефона_складаTextBox.TabIndex = 7;
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Algerian", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(128, 118);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(113, 33);
			this.button2.TabIndex = 8;
			this.button2.Text = "Добавить";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Algerian", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(247, 118);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(113, 33);
			this.button3.TabIndex = 9;
			this.button3.Text = "Таблица";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Font = new System.Drawing.Font("Algerian", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.Location = new System.Drawing.Point(247, 157);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(113, 33);
			this.button4.TabIndex = 10;
			this.button4.Text = "Удалить";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button8
			// 
			this.button8.BackgroundImage = global::Учет_оборудования.Properties.Resources._1486348529_back_backwards_repeat_arrows_arrow_80455;
			this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button8.Font = new System.Drawing.Font("Algerian", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button8.Location = new System.Drawing.Point(34, 126);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(41, 56);
			this.button8.TabIndex = 14;
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.button8_Click);
			// 
			// button7
			// 
			this.button7.BackgroundImage = global::Учет_оборудования.Properties.Resources._1486348528_forward_arrows_arrow_front_go_80452;
			this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button7.Font = new System.Drawing.Font("Algerian", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button7.Location = new System.Drawing.Point(413, 126);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(41, 56);
			this.button7.TabIndex = 13;
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// button6
			// 
			this.button6.BackgroundImage = global::Учет_оборудования.Properties.Resources.arrow_back_ios_119432;
			this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button6.Font = new System.Drawing.Font("Algerian", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button6.Location = new System.Drawing.Point(81, 126);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(41, 56);
			this.button6.TabIndex = 12;
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// button5
			// 
			this.button5.BackgroundImage = global::Учет_оборудования.Properties.Resources.navigate_next_118888;
			this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button5.Font = new System.Drawing.Font("Algerian", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.Location = new System.Drawing.Point(366, 126);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(41, 56);
			this.button5.TabIndex = 11;
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// Warehouse
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Учет_оборудования.Properties.Resources._15f8153cb5f61ff9bfad853c2966eb6d;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(493, 226);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(адрес_складLabel);
			this.Controls.Add(this.адрес_складTextBox);
			this.Controls.Add(номер_телефона_складаLabel);
			this.Controls.Add(this.номер_телефона_складаTextBox);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.складBindingNavigator);
			this.Name = "Warehouse";
			this.Text = "Warehouse";
			this.Load += new System.EventHandler(this.Warehouse_Load);
			((System.ComponentModel.ISupportInitialize)(this.database_equipment_accountingDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.складBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.складBindingNavigator)).EndInit();
			this.складBindingNavigator.ResumeLayout(false);
			this.складBindingNavigator.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Database_equipment_accountingDataSet database_equipment_accountingDataSet;
		private System.Windows.Forms.BindingSource складBindingSource;
		private Database_equipment_accountingDataSetTableAdapters.СкладTableAdapter складTableAdapter;
		private Database_equipment_accountingDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.BindingNavigator складBindingNavigator;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox адрес_складTextBox;
		private System.Windows.Forms.TextBox номер_телефона_складаTextBox;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
	}
}