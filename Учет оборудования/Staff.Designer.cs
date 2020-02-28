namespace Учет_оборудования
{
	partial class Staff
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
			System.Windows.Forms.Label idd_СкладаLabel;
			System.Windows.Forms.Label номер_паспортаLabel;
			System.Windows.Forms.Label фамилияLabel;
			System.Windows.Forms.Label имяLabel;
			System.Windows.Forms.Label отчествоLabel;
			System.Windows.Forms.Label должностьLabel;
			System.Windows.Forms.Label адрес_сотрудникаLabel;
			System.Windows.Forms.Label номер_телефона_сотрудникаLabel;
			this.database_equipment_accountingDataSet = new Учет_оборудования.Database_equipment_accountingDataSet();
			this.сотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.сотрудникиTableAdapter = new Учет_оборудования.Database_equipment_accountingDataSetTableAdapters.СотрудникиTableAdapter();
			this.tableAdapterManager = new Учет_оборудования.Database_equipment_accountingDataSetTableAdapters.TableAdapterManager();
			this.складTableAdapter = new Учет_оборудования.Database_equipment_accountingDataSetTableAdapters.СкладTableAdapter();
			this.сотрудникиBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.номер_паспортаTextBox = new System.Windows.Forms.TextBox();
			this.фамилияTextBox = new System.Windows.Forms.TextBox();
			this.имяTextBox = new System.Windows.Forms.TextBox();
			this.отчествоTextBox = new System.Windows.Forms.TextBox();
			this.должностьTextBox = new System.Windows.Forms.TextBox();
			this.адрес_сотрудникаTextBox = new System.Windows.Forms.TextBox();
			this.номер_телефона_сотрудникаTextBox = new System.Windows.Forms.TextBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.складBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.складBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.button8 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			idd_СкладаLabel = new System.Windows.Forms.Label();
			номер_паспортаLabel = new System.Windows.Forms.Label();
			фамилияLabel = new System.Windows.Forms.Label();
			имяLabel = new System.Windows.Forms.Label();
			отчествоLabel = new System.Windows.Forms.Label();
			должностьLabel = new System.Windows.Forms.Label();
			адрес_сотрудникаLabel = new System.Windows.Forms.Label();
			номер_телефона_сотрудникаLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.database_equipment_accountingDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingNavigator)).BeginInit();
			this.сотрудникиBindingNavigator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.складBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.складBindingSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// idd_СкладаLabel
			// 
			idd_СкладаLabel.AutoSize = true;
			idd_СкладаLabel.BackColor = System.Drawing.Color.Transparent;
			idd_СкладаLabel.Font = new System.Drawing.Font("Algerian", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			idd_СкладаLabel.Location = new System.Drawing.Point(13, 77);
			idd_СкладаLabel.Name = "idd_СкладаLabel";
			idd_СкладаLabel.Size = new System.Drawing.Size(194, 21);
			idd_СкладаLabel.TabIndex = 4;
			idd_СкладаLabel.Text = "Расположение склада:";
			// 
			// номер_паспортаLabel
			// 
			номер_паспортаLabel.AutoSize = true;
			номер_паспортаLabel.BackColor = System.Drawing.Color.Transparent;
			номер_паспортаLabel.Font = new System.Drawing.Font("Algerian", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			номер_паспортаLabel.Location = new System.Drawing.Point(61, 43);
			номер_паспортаLabel.Name = "номер_паспортаLabel";
			номер_паспортаLabel.Size = new System.Drawing.Size(146, 21);
			номер_паспортаLabel.TabIndex = 6;
			номер_паспортаLabel.Text = "Номер паспорта:";
			// 
			// фамилияLabel
			// 
			фамилияLabel.AutoSize = true;
			фамилияLabel.BackColor = System.Drawing.Color.Transparent;
			фамилияLabel.Font = new System.Drawing.Font("Algerian", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			фамилияLabel.Location = new System.Drawing.Point(328, 47);
			фамилияLabel.Name = "фамилияLabel";
			фамилияLabel.Size = new System.Drawing.Size(88, 21);
			фамилияLabel.TabIndex = 8;
			фамилияLabel.Text = "Фамилия:";
			// 
			// имяLabel
			// 
			имяLabel.AutoSize = true;
			имяLabel.BackColor = System.Drawing.Color.Transparent;
			имяLabel.Font = new System.Drawing.Font("Algerian", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			имяLabel.Location = new System.Drawing.Point(367, 82);
			имяLabel.Name = "имяLabel";
			имяLabel.Size = new System.Drawing.Size(49, 21);
			имяLabel.TabIndex = 10;
			имяLabel.Text = "Имя:";
			// 
			// отчествоLabel
			// 
			отчествоLabel.AutoSize = true;
			отчествоLabel.BackColor = System.Drawing.Color.Transparent;
			отчествоLabel.Font = new System.Drawing.Font("Algerian", 14.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			отчествоLabel.Location = new System.Drawing.Point(318, 117);
			отчествоLabel.Name = "отчествоLabel";
			отчествоLabel.Size = new System.Drawing.Size(98, 22);
			отчествоLabel.TabIndex = 12;
			отчествоLabel.Text = "Отчество:";
			// 
			// должностьLabel
			// 
			должностьLabel.AutoSize = true;
			должностьLabel.BackColor = System.Drawing.Color.Transparent;
			должностьLabel.Font = new System.Drawing.Font("Algerian", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			должностьLabel.Location = new System.Drawing.Point(310, 166);
			должностьLabel.Name = "должностьLabel";
			должностьLabel.Size = new System.Drawing.Size(106, 21);
			должностьLabel.TabIndex = 14;
			должностьLabel.Text = "Должность:";
			// 
			// адрес_сотрудникаLabel
			// 
			адрес_сотрудникаLabel.AutoSize = true;
			адрес_сотрудникаLabel.BackColor = System.Drawing.Color.Transparent;
			адрес_сотрудникаLabel.Font = new System.Drawing.Font("Algerian", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			адрес_сотрудникаLabel.Location = new System.Drawing.Point(257, 207);
			адрес_сотрудникаLabel.Name = "адрес_сотрудникаLabel";
			адрес_сотрудникаLabel.Size = new System.Drawing.Size(159, 21);
			адрес_сотрудникаLabel.TabIndex = 16;
			адрес_сотрудникаLabel.Text = "Адрес сотрудника:";
			// 
			// номер_телефона_сотрудникаLabel
			// 
			номер_телефона_сотрудникаLabel.AutoSize = true;
			номер_телефона_сотрудникаLabel.BackColor = System.Drawing.Color.Transparent;
			номер_телефона_сотрудникаLabel.Font = new System.Drawing.Font("Algerian", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			номер_телефона_сотрудникаLabel.Location = new System.Drawing.Point(166, 247);
			номер_телефона_сотрудникаLabel.Name = "номер_телефона_сотрудникаLabel";
			номер_телефона_сотрудникаLabel.Size = new System.Drawing.Size(248, 21);
			номер_телефона_сотрудникаLabel.TabIndex = 18;
			номер_телефона_сотрудникаLabel.Text = "Номер телефона сотрудника:";
			// 
			// database_equipment_accountingDataSet
			// 
			this.database_equipment_accountingDataSet.DataSetName = "Database_equipment_accountingDataSet";
			this.database_equipment_accountingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// сотрудникиBindingSource
			// 
			this.сотрудникиBindingSource.DataMember = "Сотрудники";
			this.сотрудникиBindingSource.DataSource = this.database_equipment_accountingDataSet;
			// 
			// сотрудникиTableAdapter
			// 
			this.сотрудникиTableAdapter.ClearBeforeFill = true;
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
			this.tableAdapterManager.СотрудникиTableAdapter = this.сотрудникиTableAdapter;
			// 
			// складTableAdapter
			// 
			this.складTableAdapter.ClearBeforeFill = true;
			// 
			// сотрудникиBindingNavigator
			// 
			this.сотрудникиBindingNavigator.AddNewItem = null;
			this.сотрудникиBindingNavigator.BindingSource = this.сотрудникиBindingSource;
			this.сотрудникиBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.сотрудникиBindingNavigator.DeleteItem = null;
			this.сотрудникиBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem});
			this.сотрудникиBindingNavigator.Location = new System.Drawing.Point(0, 0);
			this.сотрудникиBindingNavigator.MoveFirstItem = null;
			this.сотрудникиBindingNavigator.MoveLastItem = null;
			this.сотрудникиBindingNavigator.MoveNextItem = null;
			this.сотрудникиBindingNavigator.MovePreviousItem = null;
			this.сотрудникиBindingNavigator.Name = "сотрудникиBindingNavigator";
			this.сотрудникиBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.сотрудникиBindingNavigator.Size = new System.Drawing.Size(685, 25);
			this.сотрудникиBindingNavigator.TabIndex = 0;
			this.сотрудникиBindingNavigator.Text = "bindingNavigator1";
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
			// номер_паспортаTextBox
			// 
			this.номер_паспортаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "Номер_паспорта", true));
			this.номер_паспортаTextBox.Font = new System.Drawing.Font("Algerian", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.номер_паспортаTextBox.Location = new System.Drawing.Point(213, 43);
			this.номер_паспортаTextBox.Name = "номер_паспортаTextBox";
			this.номер_паспортаTextBox.Size = new System.Drawing.Size(100, 25);
			this.номер_паспортаTextBox.TabIndex = 7;
			// 
			// фамилияTextBox
			// 
			this.фамилияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "Фамилия", true));
			this.фамилияTextBox.Font = new System.Drawing.Font("Algerian", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.фамилияTextBox.Location = new System.Drawing.Point(422, 43);
			this.фамилияTextBox.Name = "фамилияTextBox";
			this.фамилияTextBox.Size = new System.Drawing.Size(214, 29);
			this.фамилияTextBox.TabIndex = 9;
			// 
			// имяTextBox
			// 
			this.имяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "Имя", true));
			this.имяTextBox.Font = new System.Drawing.Font("Algerian", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.имяTextBox.Location = new System.Drawing.Point(422, 78);
			this.имяTextBox.Name = "имяTextBox";
			this.имяTextBox.Size = new System.Drawing.Size(214, 29);
			this.имяTextBox.TabIndex = 11;
			// 
			// отчествоTextBox
			// 
			this.отчествоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "Отчество", true));
			this.отчествоTextBox.Font = new System.Drawing.Font("Algerian", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.отчествоTextBox.Location = new System.Drawing.Point(422, 117);
			this.отчествоTextBox.Name = "отчествоTextBox";
			this.отчествоTextBox.Size = new System.Drawing.Size(214, 29);
			this.отчествоTextBox.TabIndex = 13;
			// 
			// должностьTextBox
			// 
			this.должностьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "Должность", true));
			this.должностьTextBox.Font = new System.Drawing.Font("Algerian", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.должностьTextBox.Location = new System.Drawing.Point(422, 158);
			this.должностьTextBox.Name = "должностьTextBox";
			this.должностьTextBox.Size = new System.Drawing.Size(214, 29);
			this.должностьTextBox.TabIndex = 15;
			// 
			// адрес_сотрудникаTextBox
			// 
			this.адрес_сотрудникаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "Адрес_сотрудника", true));
			this.адрес_сотрудникаTextBox.Font = new System.Drawing.Font("Algerian", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.адрес_сотрудникаTextBox.Location = new System.Drawing.Point(422, 199);
			this.адрес_сотрудникаTextBox.Name = "адрес_сотрудникаTextBox";
			this.адрес_сотрудникаTextBox.Size = new System.Drawing.Size(214, 29);
			this.адрес_сотрудникаTextBox.TabIndex = 17;
			// 
			// номер_телефона_сотрудникаTextBox
			// 
			this.номер_телефона_сотрудникаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "Номер_телефона_сотрудника", true));
			this.номер_телефона_сотрудникаTextBox.Font = new System.Drawing.Font("Algerian", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.номер_телефона_сотрудникаTextBox.Location = new System.Drawing.Point(422, 239);
			this.номер_телефона_сотрудникаTextBox.Name = "номер_телефона_сотрудникаTextBox";
			this.номер_телефона_сотрудникаTextBox.Size = new System.Drawing.Size(214, 29);
			this.номер_телефона_сотрудникаTextBox.TabIndex = 19;
			// 
			// comboBox1
			// 
			this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.сотрудникиBindingSource, "Idd_Склада", true));
			this.comboBox1.DataSource = this.складBindingSource;
			this.comboBox1.DisplayMember = "Адрес_склад";
			this.comboBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(213, 76);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(100, 27);
			this.comboBox1.TabIndex = 20;
			this.comboBox1.ValueMember = "ID_Склада";
			// 
			// складBindingSource
			// 
			this.складBindingSource.DataMember = "Склад";
			this.складBindingSource.DataSource = this.database_equipment_accountingDataSet;
			// 
			// складBindingSource1
			// 
			this.складBindingSource1.DataMember = "Склад";
			this.складBindingSource1.DataSource = this.database_equipment_accountingDataSet;
			// 
			// button8
			// 
			this.button8.BackgroundImage = global::Учет_оборудования.Properties.Resources._1486348529_back_backwards_repeat_arrows_arrow_80455;
			this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button8.Font = new System.Drawing.Font("Algerian", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button8.Location = new System.Drawing.Point(99, 290);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(41, 56);
			this.button8.TabIndex = 28;
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.button8_Click);
			// 
			// button7
			// 
			this.button7.BackgroundImage = global::Учет_оборудования.Properties.Resources._1486348528_forward_arrows_arrow_front_go_80452;
			this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button7.Font = new System.Drawing.Font("Algerian", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button7.Location = new System.Drawing.Point(478, 290);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(41, 56);
			this.button7.TabIndex = 27;
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// button6
			// 
			this.button6.BackgroundImage = global::Учет_оборудования.Properties.Resources.arrow_back_ios_119432;
			this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button6.Font = new System.Drawing.Font("Algerian", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button6.Location = new System.Drawing.Point(146, 290);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(41, 56);
			this.button6.TabIndex = 26;
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// button5
			// 
			this.button5.BackgroundImage = global::Учет_оборудования.Properties.Resources.navigate_next_118888;
			this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button5.Font = new System.Drawing.Font("Algerian", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.Location = new System.Drawing.Point(431, 290);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(41, 56);
			this.button5.TabIndex = 25;
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button4
			// 
			this.button4.Font = new System.Drawing.Font("Algerian", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.Location = new System.Drawing.Point(312, 321);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(113, 33);
			this.button4.TabIndex = 24;
			this.button4.Text = "Удалить";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Algerian", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(312, 282);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(113, 33);
			this.button3.TabIndex = 23;
			this.button3.Text = "Таблица";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Algerian", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(193, 282);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(113, 33);
			this.button2.TabIndex = 22;
			this.button2.Text = "Добавить";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click_1);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Algerian", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(193, 321);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(113, 33);
			this.button1.TabIndex = 21;
			this.button1.Text = "Сохранить";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Staff
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Учет_оборудования.Properties.Resources._15f8153cb5f61ff9bfad853c2966eb6d;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(685, 385);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(idd_СкладаLabel);
			this.Controls.Add(номер_паспортаLabel);
			this.Controls.Add(this.номер_паспортаTextBox);
			this.Controls.Add(фамилияLabel);
			this.Controls.Add(this.фамилияTextBox);
			this.Controls.Add(имяLabel);
			this.Controls.Add(this.имяTextBox);
			this.Controls.Add(отчествоLabel);
			this.Controls.Add(this.отчествоTextBox);
			this.Controls.Add(должностьLabel);
			this.Controls.Add(this.должностьTextBox);
			this.Controls.Add(адрес_сотрудникаLabel);
			this.Controls.Add(this.адрес_сотрудникаTextBox);
			this.Controls.Add(номер_телефона_сотрудникаLabel);
			this.Controls.Add(this.номер_телефона_сотрудникаTextBox);
			this.Controls.Add(this.сотрудникиBindingNavigator);
			this.Name = "Staff";
			this.Text = "Staff";
			this.Load += new System.EventHandler(this.Staff_Load);
			((System.ComponentModel.ISupportInitialize)(this.database_equipment_accountingDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingNavigator)).EndInit();
			this.сотрудникиBindingNavigator.ResumeLayout(false);
			this.сотрудникиBindingNavigator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.складBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.складBindingSource1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Database_equipment_accountingDataSet database_equipment_accountingDataSet;
		private System.Windows.Forms.BindingSource сотрудникиBindingSource;
		private Database_equipment_accountingDataSetTableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter;
		private Database_equipment_accountingDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.BindingNavigator сотрудникиBindingNavigator;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
		private Database_equipment_accountingDataSetTableAdapters.СкладTableAdapter складTableAdapter;
		private System.Windows.Forms.TextBox номер_паспортаTextBox;
		private System.Windows.Forms.TextBox фамилияTextBox;
		private System.Windows.Forms.TextBox имяTextBox;
		private System.Windows.Forms.TextBox отчествоTextBox;
		private System.Windows.Forms.TextBox должностьTextBox;
		private System.Windows.Forms.TextBox адрес_сотрудникаTextBox;
		private System.Windows.Forms.TextBox номер_телефона_сотрудникаTextBox;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.BindingSource складBindingSource;
		private System.Windows.Forms.BindingSource складBindingSource1;
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