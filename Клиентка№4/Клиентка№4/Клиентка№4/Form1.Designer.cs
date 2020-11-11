namespace Клиентка_4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.klientDataSet = new Клиентка_4.klientDataSet();
            this.деталиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.деталиTableAdapter = new Клиентка_4.klientDataSetTableAdapters.ДеталиTableAdapter();
            this.tableAdapterManager = new Клиентка_4.klientDataSetTableAdapters.TableAdapterManager();
            this.производителиTableAdapter = new Клиентка_4.klientDataSetTableAdapters.ПроизводителиTableAdapter();
            this.деталиBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.деталиBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.деталиDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.производит = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.производителиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.производителиBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.деталиBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.деталиBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.klientDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.деталиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.деталиBindingNavigator)).BeginInit();
            this.деталиBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.деталиDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.производителиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.производителиBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.деталиBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.деталиBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // klientDataSet
            // 
            this.klientDataSet.DataSetName = "klientDataSet";
            this.klientDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // деталиBindingSource
            // 
            this.деталиBindingSource.DataMember = "Детали";
            this.деталиBindingSource.DataSource = this.klientDataSet;
            // 
            // деталиTableAdapter
            // 
            this.деталиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Клиентка_4.klientDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АвторизацияTableAdapter = null;
            this.tableAdapterManager.ДеталиTableAdapter = this.деталиTableAdapter;
            this.tableAdapterManager.ДолжностьTableAdapter = null;
            this.tableAdapterManager.ЗаказTableAdapter = null;
            this.tableAdapterManager.КлиентыTableAdapter = null;
            this.tableAdapterManager.МаркаTableAdapter = null;
            this.tableAdapterManager.МодельTableAdapter = null;
            this.tableAdapterManager.ПоставкаTableAdapter = null;
            this.tableAdapterManager.ПоставщикTableAdapter = null;
            this.tableAdapterManager.Прием_на_работуTableAdapter = null;
            this.tableAdapterManager.ПроизводителиTableAdapter = this.производителиTableAdapter;
            this.tableAdapterManager.СкладTableAdapter = null;
            this.tableAdapterManager.СотрудникTableAdapter = null;
            // 
            // производителиTableAdapter
            // 
            this.производителиTableAdapter.ClearBeforeFill = true;
            // 
            // деталиBindingNavigator
            // 
            this.деталиBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.деталиBindingNavigator.BindingSource = this.деталиBindingSource;
            this.деталиBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.деталиBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.деталиBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.деталиBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.деталиBindingNavigatorSaveItem});
            this.деталиBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.деталиBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.деталиBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.деталиBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.деталиBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.деталиBindingNavigator.Name = "деталиBindingNavigator";
            this.деталиBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.деталиBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.деталиBindingNavigator.TabIndex = 0;
            this.деталиBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // деталиBindingNavigatorSaveItem
            // 
            this.деталиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.деталиBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("деталиBindingNavigatorSaveItem.Image")));
            this.деталиBindingNavigatorSaveItem.Name = "деталиBindingNavigatorSaveItem";
            this.деталиBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.деталиBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.деталиBindingNavigatorSaveItem.Click += new System.EventHandler(this.деталиBindingNavigatorSaveItem_Click);
            // 
            // деталиDataGridView
            // 
            this.деталиDataGridView.AutoGenerateColumns = false;
            this.деталиDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.деталиDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.производит,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.деталиDataGridView.DataSource = this.деталиBindingSource;
            this.деталиDataGridView.Location = new System.Drawing.Point(0, 30);
            this.деталиDataGridView.Name = "деталиDataGridView";
            this.деталиDataGridView.RowTemplate.Height = 24;
            this.деталиDataGridView.Size = new System.Drawing.Size(800, 275);
            this.деталиDataGridView.TabIndex = 1;
            this.деталиDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.деталиDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Код";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // производит
            // 
            this.производит.DataPropertyName = "ID-Proizvoditeli";
            this.производит.DataSource = this.производителиBindingSource;
            this.производит.DisplayMember = "ID-Proizvoditeli";
            this.производит.HeaderText = "производит";
            this.производит.Name = "производит";
            this.производит.ValueMember = "Код";
            // 
            // производителиBindingSource
            // 
            this.производителиBindingSource.DataMember = "Производители";
            this.производителиBindingSource.DataSource = this.klientDataSet;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Товар";
            this.dataGridViewTextBoxColumn2.HeaderText = "Товар";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Цена";
            this.dataGridViewTextBoxColumn3.HeaderText = "Цена";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ID-Proizvoditeli";
            this.dataGridViewTextBoxColumn4.HeaderText = "ID-Proizvoditeli";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(306, 441);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 70;
            this.label3.Text = "Цена";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(306, 407);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 69;
            this.label2.Text = "Товар";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(306, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 68;
            this.label1.Text = "Производитель";
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.деталиBindingSource, "Цена", true));
            this.textBox3.Location = new System.Drawing.Point(455, 438);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(219, 22);
            this.textBox3.TabIndex = 65;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.деталиBindingSource, "Товар", true));
            this.textBox2.Location = new System.Drawing.Point(455, 407);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(219, 22);
            this.textBox2.TabIndex = 64;
            this.textBox2.Text = "\r\n";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(143, 350);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(119, 36);
            this.button5.TabIndex = 63;
            this.button5.Text = "Добавить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(30, 421);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 52);
            this.button4.TabIndex = 61;
            this.button4.Text = "V";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(30, 350);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 52);
            this.button3.TabIndex = 62;
            this.button3.Text = "/\\";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(143, 435);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 38);
            this.button2.TabIndex = 60;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(143, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 37);
            this.button1.TabIndex = 59;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.деталиBindingSource, "ID-Proizvoditeli", true));
            this.comboBox1.DataSource = this.производителиBindingSource1;
            this.comboBox1.DisplayMember = "ID-Proizvoditeli";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(455, 372);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(219, 24);
            this.comboBox1.TabIndex = 71;
            this.comboBox1.ValueMember = "Код";
            // 
            // производителиBindingSource1
            // 
            this.производителиBindingSource1.DataMember = "Производители";
            this.производителиBindingSource1.DataSource = this.klientDataSet;
            // 
            // деталиBindingSource1
            // 
            this.деталиBindingSource1.DataMember = "Детали";
            this.деталиBindingSource1.DataSource = this.klientDataSet;
            // 
            // деталиBindingSource2
            // 
            this.деталиBindingSource2.DataMember = "Детали";
            this.деталиBindingSource2.DataSource = this.klientDataSet;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Клиентка_4.Properties.Resources.main_background;
            this.ClientSize = new System.Drawing.Size(800, 526);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.деталиDataGridView);
            this.Controls.Add(this.деталиBindingNavigator);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Детали";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.klientDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.деталиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.деталиBindingNavigator)).EndInit();
            this.деталиBindingNavigator.ResumeLayout(false);
            this.деталиBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.деталиDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.производителиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.производителиBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.деталиBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.деталиBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private klientDataSet klientDataSet;
        private System.Windows.Forms.BindingSource деталиBindingSource;
        private klientDataSetTableAdapters.ДеталиTableAdapter деталиTableAdapter;
        private klientDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator деталиBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton деталиBindingNavigatorSaveItem;
        private klientDataSetTableAdapters.ПроизводителиTableAdapter производителиTableAdapter;
        private System.Windows.Forms.BindingSource производителиBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource деталиBindingSource1;
        private System.Windows.Forms.BindingSource деталиBindingSource2;
        private System.Windows.Forms.BindingSource производителиBindingSource1;
        public System.Windows.Forms.DataGridView деталиDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn производит;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}