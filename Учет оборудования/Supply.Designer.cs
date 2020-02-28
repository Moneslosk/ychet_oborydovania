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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Supply));
            System.Windows.Forms.Label idd_ОборудованияLabel;
            this.database_equipment_accountingDataSet = new Учет_оборудования.Database_equipment_accountingDataSet();
            this.поставкаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.поставкаTableAdapter = new Учет_оборудования.Database_equipment_accountingDataSetTableAdapters.ПоставкаTableAdapter();
            this.tableAdapterManager = new Учет_оборудования.Database_equipment_accountingDataSetTableAdapters.TableAdapterManager();
            this.оборудованиеTableAdapter = new Учет_оборудования.Database_equipment_accountingDataSetTableAdapters.ОборудованиеTableAdapter();
            this.поставщикTableAdapter = new Учет_оборудования.Database_equipment_accountingDataSetTableAdapters.ПоставщикTableAdapter();
            this.поставкаBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            resources.ApplyResources(id_ПоставщикаLabel, "id_ПоставщикаLabel");
            id_ПоставщикаLabel.BackColor = System.Drawing.Color.Transparent;
            id_ПоставщикаLabel.Name = "id_ПоставщикаLabel";
            // 
            // idd_ОборудованияLabel
            // 
            resources.ApplyResources(idd_ОборудованияLabel, "idd_ОборудованияLabel");
            idd_ОборудованияLabel.BackColor = System.Drawing.Color.Transparent;
            idd_ОборудованияLabel.Name = "idd_ОборудованияLabel";
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
            this.поставкаBindingNavigator.AddNewItem = null;
            this.поставкаBindingNavigator.BindingSource = this.поставкаBindingSource;
            this.поставкаBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.поставкаBindingNavigator.DeleteItem = null;
            this.поставкаBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1});
            resources.ApplyResources(this.поставкаBindingNavigator, "поставкаBindingNavigator");
            this.поставкаBindingNavigator.MoveFirstItem = null;
            this.поставкаBindingNavigator.MoveLastItem = null;
            this.поставкаBindingNavigator.MoveNextItem = null;
            this.поставкаBindingNavigator.MovePreviousItem = null;
            this.поставкаBindingNavigator.Name = "поставкаBindingNavigator";
            this.поставкаBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            resources.ApplyResources(this.bindingNavigatorCountItem, "bindingNavigatorCountItem");
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            resources.ApplyResources(this.bindingNavigatorSeparator, "bindingNavigatorSeparator");
            // 
            // bindingNavigatorPositionItem
            // 
            resources.ApplyResources(this.bindingNavigatorPositionItem, "bindingNavigatorPositionItem");
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            resources.ApplyResources(this.bindingNavigatorSeparator1, "bindingNavigatorSeparator1");
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.поставкаBindingSource, "Id_Поставщика", true));
            this.comboBox2.DataSource = this.поставщикBindingSource;
            this.comboBox2.DisplayMember = "Наименование_поставщика";
            resources.ApplyResources(this.comboBox2, "comboBox2");
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Name = "comboBox2";
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
            resources.ApplyResources(this.button8, "button8");
            this.button8.Name = "button8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.BackgroundImage = global::Учет_оборудования.Properties.Resources._1486348528_forward_arrows_arrow_front_go_80452;
            resources.ApplyResources(this.button7, "button7");
            this.button7.Name = "button7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackgroundImage = global::Учет_оборудования.Properties.Resources.arrow_back_ios_119432;
            resources.ApplyResources(this.button6, "button6");
            this.button6.Name = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::Учет_оборудования.Properties.Resources.navigate_next_118888;
            resources.ApplyResources(this.button5, "button5");
            this.button5.Name = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            resources.ApplyResources(this.button4, "button4");
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.поставкаBindingSource, "Idd_Оборудования", true));
            this.comboBox1.DataSource = this.оборудованиеBindingSource;
            this.comboBox1.DisplayMember = "Название_оборудования";
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.ValueMember = "ID_Оборудования";
            // 
            // treeView1
            // 
            resources.ApplyResources(this.treeView1, "treeView1");
            this.treeView1.Name = "treeView1";
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // Supply
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Учет_оборудования.Properties.Resources._15f8153cb5f61ff9bfad853c2966eb6d;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.treeView1);
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Supply";
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
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
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
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox textBox1;
    }
}