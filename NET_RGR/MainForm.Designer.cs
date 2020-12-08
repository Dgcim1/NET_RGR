namespace NET_RGR
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericStart = new System.Windows.Forms.NumericUpDown();
            this.numericEnd = new System.Windows.Forms.NumericUpDown();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonAbort = new System.Windows.Forms.Button();
            this.listViewLakes = new System.Windows.Forms.ListView();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLocation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderBasinDistrict = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderRiverBasin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSquare = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageParser = new System.Windows.Forms.TabPage();
            this.panelParseSetting = new System.Windows.Forms.Panel();
            this.buttonClearListView = new System.Windows.Forms.Button();
            this.buttonLoadingIntoDB = new System.Windows.Forms.Button();
            this.tabPageDB = new System.Windows.Forms.TabPage();
            this.lakesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.lakesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nET_RGRDataSet = new NET_RGR.NET_RGRDataSet();
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
            this.lakesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.lakesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lakesTableAdapter = new NET_RGR.NET_RGRDataSetTableAdapters.LakesTableAdapter();
            this.tableAdapterManager = new NET_RGR.NET_RGRDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.numericStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEnd)).BeginInit();
            this.tabControlMain.SuspendLayout();
            this.tabPageParser.SuspendLayout();
            this.panelParseSetting.SuspendLayout();
            this.tabPageDB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lakesBindingNavigator)).BeginInit();
            this.lakesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lakesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nET_RGRDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lakesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Начальная страница";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Конечная страница";
            // 
            // numericStart
            // 
            this.numericStart.Location = new System.Drawing.Point(6, 25);
            this.numericStart.Maximum = new decimal(new int[] {
            919,
            0,
            0,
            0});
            this.numericStart.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericStart.Name = "numericStart";
            this.numericStart.Size = new System.Drawing.Size(120, 20);
            this.numericStart.TabIndex = 3;
            this.numericStart.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericEnd
            // 
            this.numericEnd.Location = new System.Drawing.Point(6, 64);
            this.numericEnd.Maximum = new decimal(new int[] {
            919,
            0,
            0,
            0});
            this.numericEnd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericEnd.Name = "numericEnd";
            this.numericEnd.Size = new System.Drawing.Size(120, 20);
            this.numericEnd.TabIndex = 4;
            this.numericEnd.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(6, 90);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(120, 23);
            this.buttonStart.TabIndex = 5;
            this.buttonStart.Text = "Старт";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonAbort
            // 
            this.buttonAbort.Location = new System.Drawing.Point(6, 119);
            this.buttonAbort.Name = "buttonAbort";
            this.buttonAbort.Size = new System.Drawing.Size(120, 23);
            this.buttonAbort.TabIndex = 6;
            this.buttonAbort.Text = "Прервать";
            this.buttonAbort.UseVisualStyleBackColor = true;
            this.buttonAbort.Click += new System.EventHandler(this.buttonAbort_Click);
            // 
            // listViewLakes
            // 
            this.listViewLakes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewLakes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderLocation,
            this.columnHeaderBasinDistrict,
            this.columnHeaderRiverBasin,
            this.columnHeaderSquare});
            this.listViewLakes.FullRowSelect = true;
            this.listViewLakes.GridLines = true;
            this.listViewLakes.HideSelection = false;
            this.listViewLakes.Location = new System.Drawing.Point(6, 6);
            this.listViewLakes.Name = "listViewLakes";
            this.listViewLakes.Size = new System.Drawing.Size(644, 410);
            this.listViewLakes.TabIndex = 7;
            this.listViewLakes.UseCompatibleStateImageBehavior = false;
            this.listViewLakes.View = System.Windows.Forms.View.Details;
            this.listViewLakes.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listViewLakes_KeyUp);
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Название";
            this.columnHeaderName.Width = 100;
            // 
            // columnHeaderLocation
            // 
            this.columnHeaderLocation.Text = "Местоположение";
            this.columnHeaderLocation.Width = 150;
            // 
            // columnHeaderBasinDistrict
            // 
            this.columnHeaderBasinDistrict.Text = "Бассейновый округ";
            this.columnHeaderBasinDistrict.Width = 150;
            // 
            // columnHeaderRiverBasin
            // 
            this.columnHeaderRiverBasin.Text = "Речной бассейн";
            this.columnHeaderRiverBasin.Width = 150;
            // 
            // columnHeaderSquare
            // 
            this.columnHeaderSquare.Text = "Площадь км2";
            this.columnHeaderSquare.Width = 88;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageParser);
            this.tabControlMain.Controls.Add(this.tabPageDB);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(800, 450);
            this.tabControlMain.TabIndex = 8;
            // 
            // tabPageParser
            // 
            this.tabPageParser.Controls.Add(this.panelParseSetting);
            this.tabPageParser.Controls.Add(this.listViewLakes);
            this.tabPageParser.Location = new System.Drawing.Point(4, 22);
            this.tabPageParser.Name = "tabPageParser";
            this.tabPageParser.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageParser.Size = new System.Drawing.Size(792, 424);
            this.tabPageParser.TabIndex = 0;
            this.tabPageParser.Text = "Парсер";
            this.tabPageParser.UseVisualStyleBackColor = true;
            // 
            // panelParseSetting
            // 
            this.panelParseSetting.Controls.Add(this.buttonClearListView);
            this.panelParseSetting.Controls.Add(this.buttonLoadingIntoDB);
            this.panelParseSetting.Controls.Add(this.label1);
            this.panelParseSetting.Controls.Add(this.numericStart);
            this.panelParseSetting.Controls.Add(this.buttonAbort);
            this.panelParseSetting.Controls.Add(this.numericEnd);
            this.panelParseSetting.Controls.Add(this.label2);
            this.panelParseSetting.Controls.Add(this.buttonStart);
            this.panelParseSetting.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelParseSetting.Location = new System.Drawing.Point(653, 3);
            this.panelParseSetting.Name = "panelParseSetting";
            this.panelParseSetting.Size = new System.Drawing.Size(136, 418);
            this.panelParseSetting.TabIndex = 8;
            // 
            // buttonClearListView
            // 
            this.buttonClearListView.Location = new System.Drawing.Point(6, 179);
            this.buttonClearListView.Name = "buttonClearListView";
            this.buttonClearListView.Size = new System.Drawing.Size(120, 23);
            this.buttonClearListView.TabIndex = 8;
            this.buttonClearListView.Text = "Очистить таблицу";
            this.buttonClearListView.UseVisualStyleBackColor = true;
            this.buttonClearListView.Click += new System.EventHandler(this.buttonClearListView_Click);
            // 
            // buttonLoadingIntoDB
            // 
            this.buttonLoadingIntoDB.Location = new System.Drawing.Point(6, 149);
            this.buttonLoadingIntoDB.Name = "buttonLoadingIntoDB";
            this.buttonLoadingIntoDB.Size = new System.Drawing.Size(120, 23);
            this.buttonLoadingIntoDB.TabIndex = 7;
            this.buttonLoadingIntoDB.Text = "Загрузка в БД";
            this.buttonLoadingIntoDB.UseVisualStyleBackColor = true;
            this.buttonLoadingIntoDB.Click += new System.EventHandler(this.buttonLoadingIntoDB_Click);
            // 
            // tabPageDB
            // 
            this.tabPageDB.Controls.Add(this.lakesBindingNavigator);
            this.tabPageDB.Controls.Add(this.lakesDataGridView);
            this.tabPageDB.Location = new System.Drawing.Point(4, 22);
            this.tabPageDB.Name = "tabPageDB";
            this.tabPageDB.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDB.Size = new System.Drawing.Size(792, 424);
            this.tabPageDB.TabIndex = 1;
            this.tabPageDB.Text = "База данных";
            this.tabPageDB.UseVisualStyleBackColor = true;
            // 
            // lakesBindingNavigator
            // 
            this.lakesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.lakesBindingNavigator.BindingSource = this.lakesBindingSource;
            this.lakesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.lakesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.lakesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.lakesBindingNavigatorSaveItem});
            this.lakesBindingNavigator.Location = new System.Drawing.Point(3, 3);
            this.lakesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.lakesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.lakesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.lakesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.lakesBindingNavigator.Name = "lakesBindingNavigator";
            this.lakesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.lakesBindingNavigator.Size = new System.Drawing.Size(786, 25);
            this.lakesBindingNavigator.TabIndex = 9;
            this.lakesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // lakesBindingSource
            // 
            this.lakesBindingSource.DataMember = "Lakes";
            this.lakesBindingSource.DataSource = this.nET_RGRDataSet;
            // 
            // nET_RGRDataSet
            // 
            this.nET_RGRDataSet.DataSetName = "NET_RGRDataSet";
            this.nET_RGRDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
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
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // lakesBindingNavigatorSaveItem
            // 
            this.lakesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lakesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("lakesBindingNavigatorSaveItem.Image")));
            this.lakesBindingNavigatorSaveItem.Name = "lakesBindingNavigatorSaveItem";
            this.lakesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.lakesBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.lakesBindingNavigatorSaveItem.Click += new System.EventHandler(this.lakesBindingNavigatorSaveItem_Click);
            // 
            // lakesDataGridView
            // 
            this.lakesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lakesDataGridView.AutoGenerateColumns = false;
            this.lakesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lakesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.lakesDataGridView.DataSource = this.lakesBindingSource;
            this.lakesDataGridView.Location = new System.Drawing.Point(0, 31);
            this.lakesDataGridView.Name = "lakesDataGridView";
            this.lakesDataGridView.Size = new System.Drawing.Size(789, 390);
            this.lakesDataGridView.TabIndex = 0;
            this.lakesDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.lakesDataGridView_DataError);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.HeaderText = "name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "location";
            this.dataGridViewTextBoxColumn3.HeaderText = "location";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "basinDistrict";
            this.dataGridViewTextBoxColumn4.HeaderText = "basinDistrict";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "riverBasin";
            this.dataGridViewTextBoxColumn5.HeaderText = "riverBasin";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "square";
            this.dataGridViewTextBoxColumn6.HeaderText = "square";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // lakesTableAdapter
            // 
            this.lakesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LakesTableAdapter = this.lakesTableAdapter;
            this.tableAdapterManager.UpdateOrder = NET_RGR.NET_RGRDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlMain);
            this.Name = "MainForm";
            this.Text = "РГР";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEnd)).EndInit();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageParser.ResumeLayout(false);
            this.panelParseSetting.ResumeLayout(false);
            this.panelParseSetting.PerformLayout();
            this.tabPageDB.ResumeLayout(false);
            this.tabPageDB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lakesBindingNavigator)).EndInit();
            this.lakesBindingNavigator.ResumeLayout(false);
            this.lakesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lakesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nET_RGRDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lakesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericStart;
        private System.Windows.Forms.NumericUpDown numericEnd;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonAbort;
        private System.Windows.Forms.ListView listViewLakes;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderLocation;
        private System.Windows.Forms.ColumnHeader columnHeaderBasinDistrict;
        private System.Windows.Forms.ColumnHeader columnHeaderRiverBasin;
        private System.Windows.Forms.ColumnHeader columnHeaderSquare;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageParser;
        private System.Windows.Forms.TabPage tabPageDB;
        private System.Windows.Forms.Panel panelParseSetting;
        private System.Windows.Forms.Button buttonLoadingIntoDB;
        private NET_RGRDataSet nET_RGRDataSet;
        private System.Windows.Forms.BindingSource lakesBindingSource;
        private NET_RGRDataSetTableAdapters.LakesTableAdapter lakesTableAdapter;
        private NET_RGRDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator lakesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton lakesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView lakesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button buttonClearListView;
    }
}