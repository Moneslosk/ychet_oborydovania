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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Supplier));
            System.Windows.Forms.Label адрес_поставщикаLabel;
            System.Windows.Forms.Label номер_телефона_поставщикаLabel;
            this.database_equipment_accountingDataSet = new Учет_оборудования.Database_equipment_accountingDataSet();
            this.поставщикBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.поставщикTableAdapter = new Учет_оборудования.Database_equipment_accountingDataSetTableAdapters.ПоставщикTableAdapter();
            this.tableAdapterManager = new Учет_оборудования.Database_equipment_accountingDataSetTableAdapters.TableAdapterManager();
            this.поставщикBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
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
            resources.ApplyResources(наименование_поставщикаLabel, "наименование_поставщикаLabel");
            наименование_поставщикаLabel.BackColor = System.Drawing.Color.Transparent;
            наименование_поставщикаLabel.Name = "наименование_поставщикаLabel";
            // 
            // адрес_поставщикаLabel
            // 
            resources.ApplyResources(адрес_поставщикаLabel, "адрес_поставщикаLabel");
            адрес_поставщикаLabel.BackColor = System.Drawing.Color.Transparent;
            адрес_поставщикаLabel.Name = "адрес_поставщикаLabel";
            // 
            // номер_телефона_поставщикаLabel
            // 
            resources.ApplyResources(номер_телефона_поставщикаLabel, "номер_телефона_поставщикаLabel");
            номер_телефона_поставщикаLabel.BackColor = System.Drawing.Color.Transparent;
            номер_телефона_поставщикаLabel.Name = "номер_телефона_поставщикаLabel";
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
            resources.ApplyResources(this.поставщикBindingNavigator, "поставщикBindingNavigator");
            this.поставщикBindingNavigator.AddNewItem = null;
            this.поставщикBindingNavigator.BindingSource = this.поставщикBindingSource;
            this.поставщикBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.поставщикBindingNavigator.DeleteItem = null;
            this.поставщикBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem});
            this.поставщикBindingNavigator.MoveFirstItem = null;
            this.поставщикBindingNavigator.MoveLastItem = null;
            this.поставщикBindingNavigator.MoveNextItem = null;
            this.поставщикBindingNavigator.MovePreviousItem = null;
            this.поставщикBindingNavigator.Name = "поставщикBindingNavigator";
            this.поставщикBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            // 
            // bindingNavigatorCountItem
            // 
            resources.ApplyResources(this.bindingNavigatorCountItem, "bindingNavigatorCountItem");
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            // 
            // bindingNavigatorPositionItem
            // 
            resources.ApplyResources(this.bindingNavigatorPositionItem, "bindingNavigatorPositionItem");
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            // 
            // наименование_поставщикаTextBox
            // 
            resources.ApplyResources(this.наименование_поставщикаTextBox, "наименование_поставщикаTextBox");
            this.наименование_поставщикаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.поставщикBindingSource, "Наименование_поставщика", true));
            this.наименование_поставщикаTextBox.Name = "наименование_поставщикаTextBox";
            // 
            // адрес_поставщикаTextBox
            // 
            resources.ApplyResources(this.адрес_поставщикаTextBox, "адрес_поставщикаTextBox");
            this.адрес_поставщикаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.поставщикBindingSource, "Адрес_поставщика", true));
            this.адрес_поставщикаTextBox.Name = "адрес_поставщикаTextBox";
            // 
            // номер_телефона_поставщикаTextBox
            // 
            resources.ApplyResources(this.номер_телефона_поставщикаTextBox, "номер_телефона_поставщикаTextBox");
            this.номер_телефона_поставщикаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.поставщикBindingSource, "Номер_телефона_поставщика", true));
            this.номер_телефона_поставщикаTextBox.Name = "номер_телефона_поставщикаTextBox";
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
            // button8
            // 
            resources.ApplyResources(this.button8, "button8");
            this.button8.BackgroundImage = global::Учет_оборудования.Properties.Resources._1486348529_back_backwards_repeat_arrows_arrow_80455;
            this.button8.Name = "button8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            resources.ApplyResources(this.button7, "button7");
            this.button7.BackgroundImage = global::Учет_оборудования.Properties.Resources._1486348528_forward_arrows_arrow_front_go_80452;
            this.button7.Name = "button7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            resources.ApplyResources(this.button6, "button6");
            this.button6.BackgroundImage = global::Учет_оборудования.Properties.Resources.arrow_back_ios_119432;
            this.button6.Name = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            resources.ApplyResources(this.button5, "button5");
            this.button5.BackgroundImage = global::Учет_оборудования.Properties.Resources.navigate_next_118888;
            this.button5.Name = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Supplier
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Учет_оборудования.Properties.Resources._15f8153cb5f61ff9bfad853c2966eb6d;
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Supplier";
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
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
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