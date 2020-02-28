namespace Учет_оборудования
{
	partial class Supplier
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
			System.Windows.Forms.Label наименование_поставщикаLabel;
			System.Windows.Forms.Label адрес_поставщикаLabel;
			System.Windows.Forms.Label номер_телефона_поставщикаLabel;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Supplier));
			this.database_equipment_accountingDataSet = new Учет_оборудования.Database_equipment_accountingDataSet();
			this.поставщикBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.поставщикTableAdapter = new Учет_оборудования.Database_equipment_accountingDataSetTableAdapters.ПоставщикTableAdapter();
			this.tableAdapterManager = new Учет_оборудования.Database_equipment_accountingDataSetTableAdapters.TableAdapterManager();
			this.поставщикBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
			this.поставщикBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.наименование_поставщикаTextBox = new System.Windows.Forms.TextBox();
			this.адрес_поставщикаTextBox = new System.Windows.Forms.TextBox();
			this.номер_телефона_поставщикаTextBox = new System.Windows.Forms.TextBox();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			наименование_поставщикаLabel = new System.Windows.Forms.Label();
			адрес_поставщикаLabel = new System.Windows.Forms.Label();
			номер_телефона_поставщикаLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.database_equipment_accountingDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.поставщикBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.поставщикBindingNavigator)).BeginInit();
			this.поставщикBindingNavigator.SuspendLayout();
			this.SuspendLayout();
			// 
			// наименование_поставщикаLabel
			// 
			наименование_поставщикаLabel.AutoSize = true;
			наименование_поставщикаLabel.BackColor = System.Drawing.Color.Transparent;
			наименование_поставщикаLabel.Font = new System.Drawing.Font("Algerian", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			наименование_поставщикаLabel.Location = new System.Drawing.Point(75, 82);
			наименование_поставщикаLabel.Name = "наименование_поставщикаLabel";
			наименование_поставщикаLabel.Size = new System.Drawing.Size(230, 21);
			наименование_поставщикаLabel.TabIndex = 3;
			наименование_поставщикаLabel.Text = "Наименование поставщика:";
			// 
			// адрес_поставщикаLabel
			// 
			адрес_поставщикаLabel.AutoSize = true;
			адрес_поставщикаLabel.BackColor = System.Drawing.Color.Transparent;
			адрес_поставщикаLabel.Font = new System.Drawing.Font("Algerian", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			адрес_поставщикаLabel.Location = new System.Drawing.Point(143, 124);
			адрес_поставщикаLabel.Name = "адрес_поставщикаLabel";
			адрес_поставщикаLabel.Size = new System.Drawing.Size(162, 21);
			адрес_поставщикаLabel.TabIndex = 5;
			адрес_поставщикаLabel.Text = "Адрес поставщика:";
			// 
			// номер_телефона_поставщикаLabel
			// 
			номер_телефона_поставщикаLabel.AutoSize = true;
			номер_телефона_поставщикаLabel.BackColor = System.Drawing.Color.Transparent;
			номер_телефона_поставщикаLabel.Font = new System.Drawing.Font("Algerian", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			номер_телефона_поставщикаLabel.Location = new System.Drawing.Point(54, 169);
			номер_телефона_поставщикаLabel.Name = "номер_телефона_поставщикаLabel";
			номер_телефона_поставщикаLabel.Size = new System.Drawing.Size(251, 21);
			номер_телефона_поставщикаLabel.TabIndex = 7;
			номер_телефона_поставщикаLabel.Text = "Номер телефона поставщика:";
			// 
			// database_equipment_accountingDataSet
			// 
			this.database_equipment_accountingDataSet.DataSetName = "Database_equipment_accountingDataSet";
			this.database_equipment_accountingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// поставщикBindingSource
			// 
			this.поставщикBindingSource.DataMember = "Поставщик";
			this.поставщикBindingSource.DataSource = this.database_equipment_accountingDataSet;
			// 
			// поставщикTableAdapter
			// 
			this.поставщикTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.UpdateOrder = Учет_оборудования.Database_equipment_accountingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			this.tableAdapterManager.КатегорииTableAdapter = null;
			this.tableAdapterManager.ОборудованиеTableAdapter = null;
			this.tableAdapterManager.ПоставкаTableAdapter = null;
			this.tableAdapterManager.ПоставщикTableAdapter = this.поставщикTableAdapter;
			this.tableAdapterManager.СкладTableAdapter = null;
			this.tableAdapterManager.СотрудникиTableAdapter = null;
			// 
			// поставщикBindingNavigator
			// 
			this.поставщикBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.поставщикBindingNavigator.BindingSource = this.поставщикBindingSource;
			this.поставщикBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.поставщикBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.поставщикBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.поставщикBindingNavigatorSaveItem});
			this.поставщикBindingNavigator.Location = new System.Drawing.Point(0, 0);
			this.поставщикBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.поставщикBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.поставщикBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.поставщикBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.поставщикBindingNavigator.Name = "поставщикBindingNavigator";
			this.поставщикBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.поставщикBindingNavigator.Size = new System.Drawing.Size(613, 25);
			this.поставщикBindingNavigator.TabIndex = 0;
			this.поставщикBindingNavigator.Text = "bindingNavigator1";
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
			// поставщикBindingNavigatorSaveItem
			// 
			this.поставщикBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.поставщикBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("поставщикBindingNavigatorSaveItem.Image")));
			this.поставщикBindingNavigatorSaveItem.Name = "поставщикBindingNavigatorSaveItem";
			this.поставщикBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
			this.поставщикBindingNavigatorSaveItem.Text = "Save Data";
			this.поставщикBindingNavigatorSaveItem.Click += new System.EventHandler(this.поставщикBindingNavigatorSaveItem_Click);
			// 
			// наименование_поставщикаTextBox
			// 
			this.наименование_поставщикаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.поставщикBindingSource, "Наименование_поставщика", true));
			this.наименование_поставщикаTextBox.Font = new System.Drawing.Font("Algerian", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.наименование_поставщикаTextBox.Location = new System.Drawing.Point(311, 79);
			this.наименование_поставщикаTextBox.Name = "наименование_поставщикаTextBox";
			this.наименование_поставщикаTextBox.Size = new System.Drawing.Size(185, 33);
			this.наименование_поставщикаTextBox.TabIndex = 4;
			// 
			// адрес_поставщикаTextBox
			// 
			this.адрес_поставщикаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.поставщикBindingSource, "Адрес_поставщика", true));
			this.адрес_поставщикаTextBox.Font = new System.Drawing.Font("Algerian", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.адрес_поставщикаTextBox.Location = new System.Drawing.Point(311, 121);
			this.адрес_поставщикаTextBox.Name = "адрес_поставщикаTextBox";
			this.адрес_поставщикаTextBox.Size = new System.Drawing.Size(185, 33);
			this.адрес_поставщикаTextBox.TabIndex = 6;
			// 
			// номер_телефона_поставщикаTextBox
			// 
			this.номер_телефона_поставщикаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.поставщикBindingSource, "Номер_телефона_поставщика", true));
			this.номер_телефона_поставщикаTextBox.Font = new System.Drawing.Font("Algerian", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.номер_телефона_поставщикаTextBox.Location = new System.Drawing.Point(311, 166);
			this.номер_телефона_поставщикаTextBox.Name = "номер_телефона_поставщикаTextBox";
			this.номер_телефона_поставщикаTextBox.Size = new System.Drawing.Size(185, 33);
			this.номер_телефона_поставщикаTextBox.TabIndex = 8;
			// 
			// button4
			// 
			this.button4.Font = new System.Drawing.Font("Algerian", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.Location = new System.Drawing.Point(336, 263);
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
			this.button3.Location = new System.Drawing.Point(336, 224);
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
			this.button2.Location = new System.Drawing.Point(217, 224);
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
			this.button1.Location = new System.Drawing.Point(217, 263);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(113, 33);
			this.button1.TabIndex = 29;
			this.button1.Text = "Сохранить";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button8
			// 
			this.button8.BackgroundImage = global::Учет_оборудования.Properties.Resources._1486348529_back_backwards_repeat_arrows_arrow_80455;
			this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button8.Font = new System.Drawing.Font("Algerian", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button8.Location = new System.Drawing.Point(123, 232);
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
			this.button7.Location = new System.Drawing.Point(502, 232);
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
			this.button6.Location = new System.Drawing.Point(170, 232);
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
			this.button5.Location = new System.Drawing.Point(455, 232);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(41, 56);
			this.button5.TabIndex = 33;
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// Supplier
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Учет_оборудования.Properties.Resources._15f8153cb5f61ff9bfad853c2966eb6d;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(613, 328);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(наименование_поставщикаLabel);
			this.Controls.Add(this.наименование_поставщикаTextBox);
			this.Controls.Add(адрес_поставщикаLabel);
			this.Controls.Add(this.адрес_поставщикаTextBox);
			this.Controls.Add(номер_телефона_поставщикаLabel);
			this.Controls.Add(this.номер_телефона_поставщикаTextBox);
			this.Controls.Add(this.поставщикBindingNavigator);
			this.Name = "Supplier";
			this.Text = "Supplier";
			this.Load += new System.EventHandler(this.Supplier_Load);
			((System.ComponentModel.ISupportInitialize)(this.database_equipment_accountingDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.поставщикBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.поставщикBindingNavigator)).EndInit();
			this.поставщикBindingNavigator.ResumeLayout(false);
			this.поставщикBindingNavigator.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Database_equipment_accountingDataSet database_equipment_accountingDataSet;
		private System.Windows.Forms.BindingSource поставщикBindingSource;
		private Database_equipment_accountingDataSetTableAdapters.ПоставщикTableAdapter поставщикTableAdapter;
		private Database_equipment_accountingDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.BindingNavigator поставщикBindingNavigator;
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
		private System.Windows.Forms.ToolStripButton поставщикBindingNavigatorSaveItem;
		private System.Windows.Forms.TextBox наименование_поставщикаTextBox;
		private System.Windows.Forms.TextBox адрес_поставщикаTextBox;
		private System.Windows.Forms.TextBox номер_телефона_поставщикаTextBox;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
	}
}