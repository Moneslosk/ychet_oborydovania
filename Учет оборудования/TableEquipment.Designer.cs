namespace Учет_оборудования
{
	partial class TableEquipment
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableEquipment));
			this.database_equipment_accountingDataSet = new Учет_оборудования.Database_equipment_accountingDataSet();
			this.оборудованиеBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.оборудованиеTableAdapter = new Учет_оборудования.Database_equipment_accountingDataSetTableAdapters.ОборудованиеTableAdapter();
			this.tableAdapterManager = new Учет_оборудования.Database_equipment_accountingDataSetTableAdapters.TableAdapterManager();
			this.оборудованиеBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.оборудованиеBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.оборудованиеBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.оборудованиеDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.button5 = new System.Windows.Forms.Button();
			this.listBox1 = new System.Windows.Forms.ListBox();
			((System.ComponentModel.ISupportInitialize)(this.database_equipment_accountingDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.оборудованиеBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.оборудованиеBindingNavigator)).BeginInit();
			this.оборудованиеBindingNavigator.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.оборудованиеBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.оборудованиеDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// database_equipment_accountingDataSet
			// 
			this.database_equipment_accountingDataSet.DataSetName = "Database_equipment_accountingDataSet";
			this.database_equipment_accountingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// оборудованиеBindingSource
			// 
			this.оборудованиеBindingSource.DataMember = "Оборудование";
			this.оборудованиеBindingSource.DataSource = this.database_equipment_accountingDataSet;
			// 
			// оборудованиеTableAdapter
			// 
			this.оборудованиеTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.UpdateOrder = Учет_оборудования.Database_equipment_accountingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			this.tableAdapterManager.КатегорииTableAdapter = null;
			this.tableAdapterManager.ОборудованиеTableAdapter = this.оборудованиеTableAdapter;
			this.tableAdapterManager.ПоставкаTableAdapter = null;
			this.tableAdapterManager.ПоставщикTableAdapter = null;
			this.tableAdapterManager.СкладTableAdapter = null;
			this.tableAdapterManager.СотрудникиTableAdapter = null;
			// 
			// оборудованиеBindingNavigator
			// 
			this.оборудованиеBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.оборудованиеBindingNavigator.BindingSource = this.оборудованиеBindingSource;
			this.оборудованиеBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.оборудованиеBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.оборудованиеBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.оборудованиеBindingNavigatorSaveItem});
			this.оборудованиеBindingNavigator.Location = new System.Drawing.Point(0, 0);
			this.оборудованиеBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.оборудованиеBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.оборудованиеBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.оборудованиеBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.оборудованиеBindingNavigator.Name = "оборудованиеBindingNavigator";
			this.оборудованиеBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.оборудованиеBindingNavigator.Size = new System.Drawing.Size(980, 25);
			this.оборудованиеBindingNavigator.TabIndex = 0;
			this.оборудованиеBindingNavigator.Text = "bindingNavigator1";
			// 
			// bindingNavigatorAddNewItem
			// 
			this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
			this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
			this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorAddNewItem.Text = "Add new";
			// 
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
			this.bindingNavigatorCountItem.Text = "of {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
			// 
			// bindingNavigatorDeleteItem
			// 
			this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
			this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
			this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorDeleteItem.Text = "Delete";
			// 
			// bindingNavigatorMoveFirstItem
			// 
			this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
			this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
			this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveFirstItem.Text = "Move first";
			// 
			// bindingNavigatorMovePreviousItem
			// 
			this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
			this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
			this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMovePreviousItem.Text = "Move previous";
			// 
			// bindingNavigatorSeparator
			// 
			this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
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
			// bindingNavigatorSeparator1
			// 
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
			this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorMoveNextItem
			// 
			this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
			this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
			this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveNextItem.Text = "Move next";
			// 
			// bindingNavigatorMoveLastItem
			// 
			this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
			this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
			this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveLastItem.Text = "Move last";
			// 
			// bindingNavigatorSeparator2
			// 
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// оборудованиеBindingNavigatorSaveItem
			// 
			this.оборудованиеBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.оборудованиеBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("оборудованиеBindingNavigatorSaveItem.Image")));
			this.оборудованиеBindingNavigatorSaveItem.Name = "оборудованиеBindingNavigatorSaveItem";
			this.оборудованиеBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
			this.оборудованиеBindingNavigatorSaveItem.Text = "Save Data";
			this.оборудованиеBindingNavigatorSaveItem.Click += new System.EventHandler(this.оборудованиеBindingNavigatorSaveItem_Click);
			// 
			// button4
			// 
			this.button4.Font = new System.Drawing.Font("Algerian", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.button4.Location = new System.Drawing.Point(461, 215);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(241, 33);
			this.button4.TabIndex = 13;
			this.button4.Text = "Экспорт таблицы в Excel";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Algerian", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.button3.Location = new System.Drawing.Point(461, 176);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(241, 33);
			this.button3.TabIndex = 12;
			this.button3.Text = "Экспорт таблицы в Word";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Location = new System.Drawing.Point(461, 28);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(241, 139);
			this.panel1.TabIndex = 11;
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Algerian", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.button2.Location = new System.Drawing.Point(19, 99);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(202, 33);
			this.button2.TabIndex = 5;
			this.button2.Text = "Очистить";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Algerian", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.button1.Location = new System.Drawing.Point(73, 60);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(95, 33);
			this.button1.TabIndex = 4;
			this.button1.Text = "Найти";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Algerian", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.label1.Location = new System.Drawing.Point(91, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 21);
			this.label1.TabIndex = 2;
			this.label1.Text = "Поиск";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(19, 34);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(202, 20);
			this.textBox1.TabIndex = 3;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// оборудованиеBindingSource1
			// 
			this.оборудованиеBindingSource1.DataMember = "Оборудование";
			this.оборудованиеBindingSource1.DataSource = this.database_equipment_accountingDataSet;
			// 
			// оборудованиеDataGridView
			// 
			this.оборудованиеDataGridView.AutoGenerateColumns = false;
			this.оборудованиеDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.оборудованиеDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
			this.оборудованиеDataGridView.DataSource = this.оборудованиеBindingSource;
			this.оборудованиеDataGridView.Location = new System.Drawing.Point(12, 28);
			this.оборудованиеDataGridView.Name = "оборудованиеDataGridView";
			this.оборудованиеDataGridView.Size = new System.Drawing.Size(443, 220);
			this.оборудованиеDataGridView.TabIndex = 13;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Оборудования";
			this.dataGridViewTextBoxColumn1.HeaderText = "ID_Оборудования";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "Id_Склада";
			this.dataGridViewTextBoxColumn2.HeaderText = "Id_Склада";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "Количество";
			this.dataGridViewTextBoxColumn3.HeaderText = "Количество";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "Изготовитель";
			this.dataGridViewTextBoxColumn4.HeaderText = "Изготовитель";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "Название_оборудования";
			this.dataGridViewTextBoxColumn5.HeaderText = "Название_оборудования";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.DataPropertyName = "id_Категории";
			this.dataGridViewTextBoxColumn6.HeaderText = "id_Категории";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			// 
			// dataGridViewTextBoxColumn7
			// 
			this.dataGridViewTextBoxColumn7.DataPropertyName = "Процессор";
			this.dataGridViewTextBoxColumn7.HeaderText = "Процессор";
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			// 
			// dataGridViewTextBoxColumn8
			// 
			this.dataGridViewTextBoxColumn8.DataPropertyName = "Оперативная_память";
			this.dataGridViewTextBoxColumn8.HeaderText = "Оперативная_память";
			this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
			// 
			// dataGridViewTextBoxColumn9
			// 
			this.dataGridViewTextBoxColumn9.DataPropertyName = "Аккумулятор";
			this.dataGridViewTextBoxColumn9.HeaderText = "Аккумулятор";
			this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
			// 
			// dataGridViewTextBoxColumn10
			// 
			this.dataGridViewTextBoxColumn10.DataPropertyName = "Разрешение_экрана";
			this.dataGridViewTextBoxColumn10.HeaderText = "Разрешение_экрана";
			this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(708, 166);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(75, 23);
			this.button5.TabIndex = 14;
			this.button5.Text = "button5";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Items.AddRange(new object[] {
            "ID_Оборудования",
            "Id_Склада",
            "Количество",
            "Изготовитель",
            "Название_оборудования",
            "id_Категории",
            "Процессор",
            "Оперативная_память",
            "Аккумулятор",
            "Разрешение_экрана"});
			this.listBox1.Location = new System.Drawing.Point(708, 26);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(136, 134);
			this.listBox1.TabIndex = 15;
			// 
			// TableEquipment
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Учет_оборудования.Properties.Resources._15f8153cb5f61ff9bfad853c2966eb6d;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(980, 282);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.оборудованиеDataGridView);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.оборудованиеBindingNavigator);
			this.Name = "TableEquipment";
			this.Text = "TableEquipment";
			this.Load += new System.EventHandler(this.TableEquipment_Load);
			((System.ComponentModel.ISupportInitialize)(this.database_equipment_accountingDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.оборудованиеBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.оборудованиеBindingNavigator)).EndInit();
			this.оборудованиеBindingNavigator.ResumeLayout(false);
			this.оборудованиеBindingNavigator.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.оборудованиеBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.оборудованиеDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Database_equipment_accountingDataSet database_equipment_accountingDataSet;
		private System.Windows.Forms.BindingSource оборудованиеBindingSource;
		private Database_equipment_accountingDataSetTableAdapters.ОборудованиеTableAdapter оборудованиеTableAdapter;
		private Database_equipment_accountingDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.BindingNavigator оборудованиеBindingNavigator;
		private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
		private System.Windows.Forms.ToolStripButton оборудованиеBindingNavigatorSaveItem;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.BindingSource оборудованиеBindingSource1;
		private System.Windows.Forms.DataGridView оборудованиеDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.ListBox listBox1;
	}
}