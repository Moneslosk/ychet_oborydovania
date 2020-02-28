namespace Учет_оборудования
{
	partial class Supply
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
			System.Windows.Forms.Label id_ПоставщикаLabel;
			System.Windows.Forms.Label idd_ОборудованияLabel;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Supply));
			this.database_equipment_accountingDataSet = new Учет_оборудования.Database_equipment_accountingDataSet();
			this.поставкаBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.поставкаTableAdapter = new Учет_оборудования.Database_equipment_accountingDataSetTableAdapters.ПоставкаTableAdapter();
			this.tableAdapterManager = new Учет_оборудования.Database_equipment_accountingDataSetTableAdapters.TableAdapterManager();
			this.оборудованиеTableAdapter = new Учет_оборудования.Database_equipment_accountingDataSetTableAdapters.ОборудованиеTableAdapter();
			this.поставщикTableAdapter = new Учет_оборудования.Database_equipment_accountingDataSetTableAdapters.ПоставщикTableAdapter();
			this.поставкаBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
			this.поставкаBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.поставщикBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.оборудованиеBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.button8 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			id_ПоставщикаLabel = new System.Windows.Forms.Label();
			idd_ОборудованияLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.database_equipment_accountingDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.поставкаBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.поставкаBindingNavigator)).BeginInit();
			this.поставкаBindingNavigator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.поставщикBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.оборудованиеBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// id_ПоставщикаLabel
			// 
			id_ПоставщикаLabel.AutoSize = true;
			id_ПоставщикаLabel.BackColor = System.Drawing.Color.Transparent;
			id_ПоставщикаLabel.Font = new System.Drawing.Font("Algerian", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			id_ПоставщикаLabel.Location = new System.Drawing.Point(60, 94);
			id_ПоставщикаLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
			id_ПоставщикаLabel.Name = "id_ПоставщикаLabel";
			id_ПоставщикаLabel.Size = new System.Drawing.Size(137, 21);
			id_ПоставщикаLabel.TabIndex = 3;
			id_ПоставщикаLabel.Text = "Id Поставщика:";
			// 
			// idd_ОборудованияLabel
			// 
			idd_ОборудованияLabel.AutoSize = true;
			idd_ОборудованияLabel.BackColor = System.Drawing.Color.Transparent;
			idd_ОборудованияLabel.Font = new System.Drawing.Font("Algerian", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			idd_ОборудованияLabel.Location = new System.Drawing.Point(28, 53);
			idd_ОборудованияLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
			idd_ОборудованияLabel.Name = "idd_ОборудованияLabel";
			idd_ОборудованияLabel.Size = new System.Drawing.Size(168, 21);
			idd_ОборудованияLabel.TabIndex = 5;
			idd_ОборудованияLabel.Text = "Idd Оборудования:";
			// 
			// database_equipment_accountingDataSet
			// 
			this.database_equipment_accountingDataSet.DataSetName = "Database_equipment_accountingDataSet";
			this.database_equipment_accountingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// поставкаBindingSource
			// 
			this.поставкаBindingSource.DataMember = "Поставка";
			this.поставкаBindingSource.DataSource = this.database_equipment_accountingDataSet;
			// 
			// поставкаTableAdapter
			// 
			this.поставкаTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.UpdateOrder = Учет_оборудования.Database_equipment_accountingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			this.tableAdapterManager.КатегорииTableAdapter = null;
			this.tableAdapterManager.ОборудованиеTableAdapter = this.оборудованиеTableAdapter;
			this.tableAdapterManager.ПоставкаTableAdapter = this.поставкаTableAdapter;
			this.tableAdapterManager.ПоставщикTableAdapter = this.поставщикTableAdapter;
			this.tableAdapterManager.СкладTableAdapter = null;
			this.tableAdapterManager.СотрудникиTableAdapter = null;
			// 
			// оборудованиеTableAdapter
			// 
			this.оборудованиеTableAdapter.ClearBeforeFill = true;
			// 
			// поставщикTableAdapter
			// 
			this.поставщикTableAdapter.ClearBeforeFill = true;
			// 
			// поставкаBindingNavigator
			// 
			this.поставкаBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.поставкаBindingNavigator.BindingSource = this.поставкаBindingSource;
			this.поставкаBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.поставкаBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.поставкаBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.поставкаBindingNavigatorSaveItem});
			this.поставкаBindingNavigator.Location = new System.Drawing.Point(0, 0);
			this.поставкаBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.поставкаBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.поставкаBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.поставкаBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.поставкаBindingNavigator.Name = "поставкаBindingNavigator";
			this.поставкаBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
			this.поставкаBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.поставкаBindingNavigator.Size = new System.Drawing.Size(542, 25);
			this.поставкаBindingNavigator.TabIndex = 0;
			this.поставкаBindingNavigator.Text = "bindingNavigator1";
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
			this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(104, 23);
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
			// поставкаBindingNavigatorSaveItem
			// 
			this.поставкаBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.поставкаBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("поставкаBindingNavigatorSaveItem.Image")));
			this.поставкаBindingNavigatorSaveItem.Name = "поставкаBindingNavigatorSaveItem";
			this.поставкаBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
			this.поставкаBindingNavigatorSaveItem.Text = "Save Data";
			this.поставкаBindingNavigatorSaveItem.Click += new System.EventHandler(this.поставкаBindingNavigatorSaveItem_Click);
			// 
			// comboBox2
			// 
			this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.поставкаBindingSource, "Id_Поставщика", true));
			this.comboBox2.DataSource = this.поставщикBindingSource;
			this.comboBox2.DisplayMember = "Наименование_поставщика";
			this.comboBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(210, 89);
			this.comboBox2.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(258, 27);
			this.comboBox2.TabIndex = 5;
			this.comboBox2.ValueMember = "ID_Поставщика";
			// 
			// поставщикBindingSource
			// 
			this.поставщикBindingSource.DataMember = "Поставщик";
			this.поставщикBindingSource.DataSource = this.database_equipment_accountingDataSet;
			// 
			// оборудованиеBindingSource
			// 
			this.оборудованиеBindingSource.DataMember = "Оборудование";
			this.оборудованиеBindingSource.DataSource = this.database_equipment_accountingDataSet;
			// 
			// button8
			// 
			this.button8.BackgroundImage = global::Учет_оборудования.Properties.Resources._1486348529_back_backwards_repeat_arrows_arrow_80455;
			this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button8.Font = new System.Drawing.Font("Algerian", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button8.Location = new System.Drawing.Point(79, 149);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(41, 56);
			this.button8.TabIndex = 36;
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.button8_Click);
			// 
			// button7
			// 
			this.button7.BackgroundImage = global::Учет_оборудования.Properties.Resources._1486348528_forward_arrows_arrow_front_go_80452;
			this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button7.Font = new System.Drawing.Font("Algerian", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button7.Location = new System.Drawing.Point(458, 149);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(41, 56);
			this.button7.TabIndex = 35;
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// button6
			// 
			this.button6.BackgroundImage = global::Учет_оборудования.Properties.Resources.arrow_back_ios_119432;
			this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button6.Font = new System.Drawing.Font("Algerian", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button6.Location = new System.Drawing.Point(126, 149);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(41, 56);
			this.button6.TabIndex = 34;
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// button5
			// 
			this.button5.BackgroundImage = global::Учет_оборудования.Properties.Resources.navigate_next_118888;
			this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button5.Font = new System.Drawing.Font("Algerian", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.Location = new System.Drawing.Point(411, 149);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(41, 56);
			this.button5.TabIndex = 33;
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button4
			// 
			this.button4.Font = new System.Drawing.Font("Algerian", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.Location = new System.Drawing.Point(292, 180);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(113, 33);
			this.button4.TabIndex = 32;
			this.button4.Text = "Удалить";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Algerian", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(292, 141);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(113, 33);
			this.button3.TabIndex = 31;
			this.button3.Text = "Таблица";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Algerian", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(173, 141);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(113, 33);
			this.button2.TabIndex = 30;
			this.button2.Text = "Добавить";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Algerian", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(173, 180);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(113, 33);
			this.button1.TabIndex = 29;
			this.button1.Text = "Сохранить";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// comboBox1
			// 
			this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.поставкаBindingSource, "Idd_Оборудования", true));
			this.comboBox1.DataSource = this.оборудованиеBindingSource;
			this.comboBox1.DisplayMember = "Название_оборудования";
			this.comboBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(210, 52);
			this.comboBox1.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(258, 27);
			this.comboBox1.TabIndex = 37;
			this.comboBox1.ValueMember = "ID_Оборудования";
			// 
			// Supply
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Учет_оборудования.Properties.Resources._15f8153cb5f61ff9bfad853c2966eb6d;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(542, 257);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(idd_ОборудованияLabel);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(id_ПоставщикаLabel);
			this.Controls.Add(this.поставкаBindingNavigator);
			this.Font = new System.Drawing.Font("Algerian", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
			this.Name = "Supply";
			this.Text = "Supply";
			this.Load += new System.EventHandler(this.Supply_Load);
			((System.ComponentModel.ISupportInitialize)(this.database_equipment_accountingDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.поставкаBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.поставкаBindingNavigator)).EndInit();
			this.поставкаBindingNavigator.ResumeLayout(false);
			this.поставкаBindingNavigator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.поставщикBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.оборудованиеBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Database_equipment_accountingDataSet database_equipment_accountingDataSet;
		private System.Windows.Forms.BindingSource поставкаBindingSource;
		private Database_equipment_accountingDataSetTableAdapters.ПоставкаTableAdapter поставкаTableAdapter;
		private Database_equipment_accountingDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.BindingNavigator поставкаBindingNavigator;
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
		private System.Windows.Forms.ToolStripButton поставкаBindingNavigatorSaveItem;
		private Database_equipment_accountingDataSetTableAdapters.ОборудованиеTableAdapter оборудованиеTableAdapter;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.BindingSource оборудованиеBindingSource;
		private Database_equipment_accountingDataSetTableAdapters.ПоставщикTableAdapter поставщикTableAdapter;
		private System.Windows.Forms.BindingSource поставщикBindingSource;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ComboBox comboBox1;
	}
}