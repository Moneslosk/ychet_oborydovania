namespace Учет_оборудования
{
	partial class Form1
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
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.складBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.database_equipment_accountingDataSet = new Учет_оборудования.Database_equipment_accountingDataSet();
			this.databaseequipmentaccountingDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.складTableAdapter = new Учет_оборудования.Database_equipment_accountingDataSetTableAdapters.СкладTableAdapter();
			this.tableAdapterManager = new Учет_оборудования.Database_equipment_accountingDataSetTableAdapters.TableAdapterManager();
			this.поставщикTableAdapter = new Учет_оборудования.Database_equipment_accountingDataSetTableAdapters.ПоставщикTableAdapter();
			this.поставщикBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			this.timer3 = new System.Windows.Forms.Timer(this.components);
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.pictureBox11 = new System.Windows.Forms.PictureBox();
			this.pictureBox10 = new System.Windows.Forms.PictureBox();
			this.pictureBox9 = new System.Windows.Forms.PictureBox();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox12 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.складBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.database_equipment_accountingDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.databaseequipmentaccountingDataSetBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.поставщикBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Algerian", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.button1.Location = new System.Drawing.Point(193, 17);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(149, 40);
			this.button1.TabIndex = 0;
			this.button1.Text = "Склад";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
			this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Algerian", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.button2.Location = new System.Drawing.Point(193, 73);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(149, 40);
			this.button2.TabIndex = 1;
			this.button2.Text = "Сотрудники";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			this.button2.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
			this.button2.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Algerian", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.button3.Location = new System.Drawing.Point(193, 129);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(149, 40);
			this.button3.TabIndex = 2;
			this.button3.Text = "Поставщик";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			this.button3.MouseEnter += new System.EventHandler(this.button3_MouseEnter);
			this.button3.MouseLeave += new System.EventHandler(this.button3_MouseLeave);
			// 
			// button4
			// 
			this.button4.Font = new System.Drawing.Font("Algerian", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.button4.Location = new System.Drawing.Point(193, 184);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(149, 40);
			this.button4.TabIndex = 3;
			this.button4.Text = "Оборудование";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			this.button4.MouseEnter += new System.EventHandler(this.button4_MouseEnter);
			this.button4.MouseLeave += new System.EventHandler(this.button4_MouseLeave);
			// 
			// button5
			// 
			this.button5.Font = new System.Drawing.Font("Algerian", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.button5.Location = new System.Drawing.Point(193, 242);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(149, 40);
			this.button5.TabIndex = 4;
			this.button5.Text = "Категории";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			this.button5.MouseEnter += new System.EventHandler(this.button5_MouseEnter);
			this.button5.MouseLeave += new System.EventHandler(this.button5_MouseLeave);
			// 
			// button6
			// 
			this.button6.Font = new System.Drawing.Font("Algerian", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.button6.Location = new System.Drawing.Point(193, 299);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(149, 40);
			this.button6.TabIndex = 5;
			this.button6.Text = "Поставка";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			this.button6.MouseEnter += new System.EventHandler(this.button6_MouseEnter);
			this.button6.MouseLeave += new System.EventHandler(this.button6_MouseLeave);
			// 
			// складBindingSource
			// 
			this.складBindingSource.DataMember = "Склад";
			this.складBindingSource.DataSource = this.database_equipment_accountingDataSet;
			// 
			// database_equipment_accountingDataSet
			// 
			this.database_equipment_accountingDataSet.DataSetName = "Database_equipment_accountingDataSet";
			this.database_equipment_accountingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// databaseequipmentaccountingDataSetBindingSource
			// 
			this.databaseequipmentaccountingDataSetBindingSource.DataSource = this.database_equipment_accountingDataSet;
			this.databaseequipmentaccountingDataSetBindingSource.Position = 0;
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
			this.tableAdapterManager.ПоставщикTableAdapter = this.поставщикTableAdapter;
			this.tableAdapterManager.СкладTableAdapter = this.складTableAdapter;
			this.tableAdapterManager.СотрудникиTableAdapter = null;
			// 
			// поставщикTableAdapter
			// 
			this.поставщикTableAdapter.ClearBeforeFill = true;
			// 
			// поставщикBindingSource
			// 
			this.поставщикBindingSource.DataMember = "Поставщик";
			this.поставщикBindingSource.DataSource = this.database_equipment_accountingDataSet;
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 450;
			// 
			// timer2
			// 
			this.timer2.Enabled = true;
			this.timer2.Interval = 450;
			// 
			// timer3
			// 
			this.timer3.Enabled = true;
			this.timer3.Interval = 1000;
			this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Algerian", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.label3.Location = new System.Drawing.Point(90, 362);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(81, 21);
			this.label3.TabIndex = 8;
			this.label3.Text = "Загрузка";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Algerian", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.label4.Location = new System.Drawing.Point(257, 362);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(81, 21);
			this.label4.TabIndex = 9;
			this.label4.Text = "Загрузка";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Algerian", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.label5.Location = new System.Drawing.Point(12, 362);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(72, 21);
			this.label5.TabIndex = 10;
			this.label5.Text = "Время :";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Algerian", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.label6.Location = new System.Drawing.Point(190, 362);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(61, 21);
			this.label6.TabIndex = 11;
			this.label6.Text = "Дата :";
			// 
			// pictureBox11
			// 
			this.pictureBox11.Image = global::Учет_оборудования.Properties.Resources.magnifying_glass_search_find_icon_131794;
			this.pictureBox11.Location = new System.Drawing.Point(144, 299);
			this.pictureBox11.Name = "pictureBox11";
			this.pictureBox11.Size = new System.Drawing.Size(43, 40);
			this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox11.TabIndex = 22;
			this.pictureBox11.TabStop = false;
			// 
			// pictureBox10
			// 
			this.pictureBox10.Image = global::Учет_оборудования.Properties.Resources.drawers_icon_131790;
			this.pictureBox10.Location = new System.Drawing.Point(348, 17);
			this.pictureBox10.Name = "pictureBox10";
			this.pictureBox10.Size = new System.Drawing.Size(43, 40);
			this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox10.TabIndex = 21;
			this.pictureBox10.TabStop = false;
			// 
			// pictureBox9
			// 
			this.pictureBox9.Image = global::Учет_оборудования.Properties.Resources.drawers_icon_131790;
			this.pictureBox9.Location = new System.Drawing.Point(144, 17);
			this.pictureBox9.Name = "pictureBox9";
			this.pictureBox9.Size = new System.Drawing.Size(43, 40);
			this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox9.TabIndex = 20;
			this.pictureBox9.TabStop = false;
			// 
			// pictureBox8
			// 
			this.pictureBox8.Image = global::Учет_оборудования.Properties.Resources.books_icon_131785;
			this.pictureBox8.Location = new System.Drawing.Point(348, 242);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(43, 40);
			this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox8.TabIndex = 19;
			this.pictureBox8.TabStop = false;
			// 
			// pictureBox7
			// 
			this.pictureBox7.Image = global::Учет_оборудования.Properties.Resources.books_icon_131785;
			this.pictureBox7.Location = new System.Drawing.Point(144, 242);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(43, 40);
			this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox7.TabIndex = 18;
			this.pictureBox7.TabStop = false;
			// 
			// pictureBox6
			// 
			this.pictureBox6.Image = global::Учет_оборудования.Properties.Resources.smartphone_icon_131802;
			this.pictureBox6.Location = new System.Drawing.Point(348, 184);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(43, 40);
			this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox6.TabIndex = 17;
			this.pictureBox6.TabStop = false;
			// 
			// pictureBox5
			// 
			this.pictureBox5.Image = global::Учет_оборудования.Properties.Resources.smartphone_icon_131802;
			this.pictureBox5.Location = new System.Drawing.Point(144, 184);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(43, 40);
			this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox5.TabIndex = 16;
			this.pictureBox5.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = global::Учет_оборудования.Properties.Resources.customer_person_people_man_you_1625;
			this.pictureBox4.Location = new System.Drawing.Point(348, 129);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(43, 40);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox4.TabIndex = 15;
			this.pictureBox4.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = global::Учет_оборудования.Properties.Resources.customer_person_people_man_you_1625;
			this.pictureBox3.Location = new System.Drawing.Point(144, 129);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(43, 40);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 14;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::Учет_оборудования.Properties.Resources.person_paper_id_card_profile_user_icon_131800;
			this.pictureBox2.Location = new System.Drawing.Point(348, 73);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(43, 40);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 13;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Учет_оборудования.Properties.Resources.person_paper_id_card_profile_user_icon_131800;
			this.pictureBox1.Location = new System.Drawing.Point(144, 73);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(43, 40);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 12;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox12
			// 
			this.pictureBox12.Image = global::Учет_оборудования.Properties.Resources.magnifying_glass_search_find_icon_131794;
			this.pictureBox12.Location = new System.Drawing.Point(348, 299);
			this.pictureBox12.Name = "pictureBox12";
			this.pictureBox12.Size = new System.Drawing.Size(43, 40);
			this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox12.TabIndex = 23;
			this.pictureBox12.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Учет_оборудования.Properties.Resources._15f8153cb5f61ff9bfad853c2966eb6d;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(546, 386);
			this.Controls.Add(this.pictureBox12);
			this.Controls.Add(this.pictureBox11);
			this.Controls.Add(this.pictureBox10);
			this.Controls.Add(this.pictureBox9);
			this.Controls.Add(this.pictureBox8);
			this.Controls.Add(this.pictureBox7);
			this.Controls.Add(this.pictureBox6);
			this.Controls.Add(this.pictureBox5);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "Главное меню";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.складBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.database_equipment_accountingDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.databaseequipmentaccountingDataSetBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.поставщикBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.BindingSource databaseequipmentaccountingDataSetBindingSource;
		private Database_equipment_accountingDataSet database_equipment_accountingDataSet;
		private System.Windows.Forms.BindingSource складBindingSource;
		private Database_equipment_accountingDataSetTableAdapters.СкладTableAdapter складTableAdapter;
		private Database_equipment_accountingDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private Database_equipment_accountingDataSetTableAdapters.ПоставщикTableAdapter поставщикTableAdapter;
		private System.Windows.Forms.BindingSource поставщикBindingSource;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Timer timer2;
		private System.Windows.Forms.Timer timer3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.PictureBox pictureBox7;
		private System.Windows.Forms.PictureBox pictureBox8;
		private System.Windows.Forms.PictureBox pictureBox9;
		private System.Windows.Forms.PictureBox pictureBox10;
		private System.Windows.Forms.PictureBox pictureBox11;
		private System.Windows.Forms.PictureBox pictureBox12;
	}
}

