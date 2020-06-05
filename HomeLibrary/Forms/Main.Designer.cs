namespace HomeLibrary
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.sort = new System.Windows.Forms.Button();
            this.parameters = new System.Windows.Forms.Panel();
            this.sortTypeParams = new System.Windows.Forms.GroupBox();
            this.downSortParam = new System.Windows.Forms.RadioButton();
            this.upSortParam = new System.Windows.Forms.RadioButton();
            this.availParams = new System.Windows.Forms.GroupBox();
            this.allParam = new System.Windows.Forms.RadioButton();
            this.nonAvailParam = new System.Windows.Forms.RadioButton();
            this.availParam = new System.Windows.Forms.RadioButton();
            this.sizeParam = new System.Windows.Forms.RadioButton();
            this.yearParam = new System.Windows.Forms.RadioButton();
            this.publishParam = new System.Windows.Forms.RadioButton();
            this.authorParam = new System.Windows.Forms.RadioButton();
            this.titleParam = new System.Windows.Forms.RadioButton();
            this.departParamLabel = new System.Windows.Forms.Label();
            this.departParamText = new System.Windows.Forms.ComboBox();
            this.standardSort = new System.Windows.Forms.Button();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolPanel = new System.Windows.Forms.ToolStrip();
            this.instructionTool = new System.Windows.Forms.ToolStripButton();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.listPanel = new System.Windows.Forms.Panel();
            this.bookListGrid = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Avail = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.publisherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearOfPublishingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fromWhereDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editBook = new System.Windows.Forms.Button();
            this.addBook = new System.Windows.Forms.Button();
            this.invent = new System.Windows.Forms.Button();
            this.leftPanel.SuspendLayout();
            this.parameters.SuspendLayout();
            this.sortTypeParams.SuspendLayout();
            this.availParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            this.toolPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.listPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookListGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.leftPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.leftPanel.Controls.Add(this.sort);
            this.leftPanel.Controls.Add(this.parameters);
            this.leftPanel.Controls.Add(this.standardSort);
            this.leftPanel.Location = new System.Drawing.Point(12, 28);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(303, 421);
            this.leftPanel.TabIndex = 0;
            // 
            // sort
            // 
            this.sort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sort.Location = new System.Drawing.Point(3, 326);
            this.sort.Name = "sort";
            this.sort.Size = new System.Drawing.Size(295, 45);
            this.sort.TabIndex = 2;
            this.sort.TabStop = false;
            this.sort.Text = "Сортувати";
            this.sort.UseVisualStyleBackColor = true;
            this.sort.Click += new System.EventHandler(this.Sort);
            // 
            // parameters
            // 
            this.parameters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.parameters.AutoScroll = true;
            this.parameters.Controls.Add(this.sortTypeParams);
            this.parameters.Controls.Add(this.availParams);
            this.parameters.Controls.Add(this.sizeParam);
            this.parameters.Controls.Add(this.yearParam);
            this.parameters.Controls.Add(this.publishParam);
            this.parameters.Controls.Add(this.authorParam);
            this.parameters.Controls.Add(this.titleParam);
            this.parameters.Controls.Add(this.departParamLabel);
            this.parameters.Controls.Add(this.departParamText);
            this.parameters.Location = new System.Drawing.Point(3, 3);
            this.parameters.Name = "parameters";
            this.parameters.Size = new System.Drawing.Size(295, 317);
            this.parameters.TabIndex = 1;
            // 
            // sortTypeParams
            // 
            this.sortTypeParams.Controls.Add(this.downSortParam);
            this.sortTypeParams.Controls.Add(this.upSortParam);
            this.sortTypeParams.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortTypeParams.Location = new System.Drawing.Point(3, 356);
            this.sortTypeParams.Name = "sortTypeParams";
            this.sortTypeParams.Size = new System.Drawing.Size(267, 92);
            this.sortTypeParams.TabIndex = 15;
            this.sortTypeParams.TabStop = false;
            this.sortTypeParams.Text = "Тип сортування";
            // 
            // downSortParam
            // 
            this.downSortParam.AutoSize = true;
            this.downSortParam.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.downSortParam.Location = new System.Drawing.Point(6, 59);
            this.downSortParam.Name = "downSortParam";
            this.downSortParam.Size = new System.Drawing.Size(108, 25);
            this.downSortParam.TabIndex = 1;
            this.downSortParam.Text = "Спадаюче";
            this.downSortParam.UseVisualStyleBackColor = true;
            // 
            // upSortParam
            // 
            this.upSortParam.AutoSize = true;
            this.upSortParam.Checked = true;
            this.upSortParam.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.upSortParam.Location = new System.Drawing.Point(6, 28);
            this.upSortParam.Name = "upSortParam";
            this.upSortParam.Size = new System.Drawing.Size(114, 25);
            this.upSortParam.TabIndex = 0;
            this.upSortParam.TabStop = true;
            this.upSortParam.Text = "Зростаюче";
            this.upSortParam.UseVisualStyleBackColor = true;
            // 
            // availParams
            // 
            this.availParams.Controls.Add(this.allParam);
            this.availParams.Controls.Add(this.nonAvailParam);
            this.availParams.Controls.Add(this.availParam);
            this.availParams.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.availParams.Location = new System.Drawing.Point(3, 223);
            this.availParams.Name = "availParams";
            this.availParams.Size = new System.Drawing.Size(267, 127);
            this.availParams.TabIndex = 14;
            this.availParams.TabStop = false;
            this.availParams.Text = "Наявність";
            // 
            // allParam
            // 
            this.allParam.AutoSize = true;
            this.allParam.Checked = true;
            this.allParam.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.allParam.Location = new System.Drawing.Point(6, 90);
            this.allParam.Name = "allParam";
            this.allParam.Size = new System.Drawing.Size(52, 25);
            this.allParam.TabIndex = 2;
            this.allParam.TabStop = true;
            this.allParam.Text = "Усі";
            this.allParam.UseVisualStyleBackColor = true;
            // 
            // nonAvailParam
            // 
            this.nonAvailParam.AutoSize = true;
            this.nonAvailParam.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nonAvailParam.Location = new System.Drawing.Point(6, 59);
            this.nonAvailParam.Name = "nonAvailParam";
            this.nonAvailParam.Size = new System.Drawing.Size(173, 25);
            this.nonAvailParam.TabIndex = 1;
            this.nonAvailParam.Text = "Немає в наявності";
            this.nonAvailParam.UseVisualStyleBackColor = true;
            // 
            // availParam
            // 
            this.availParam.AutoSize = true;
            this.availParam.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.availParam.Location = new System.Drawing.Point(6, 28);
            this.availParam.Name = "availParam";
            this.availParam.Size = new System.Drawing.Size(137, 25);
            this.availParam.TabIndex = 0;
            this.availParam.Text = "Є в наявності";
            this.availParam.UseVisualStyleBackColor = true;
            // 
            // sizeParam
            // 
            this.sizeParam.AutoSize = true;
            this.sizeParam.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sizeParam.Location = new System.Drawing.Point(3, 191);
            this.sizeParam.Name = "sizeParam";
            this.sizeParam.Size = new System.Drawing.Size(192, 26);
            this.sizeParam.TabIndex = 13;
            this.sizeParam.Text = "Кількість сторінок";
            this.sizeParam.UseVisualStyleBackColor = true;
            // 
            // yearParam
            // 
            this.yearParam.AutoSize = true;
            this.yearParam.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yearParam.Location = new System.Drawing.Point(3, 159);
            this.yearParam.Name = "yearParam";
            this.yearParam.Size = new System.Drawing.Size(134, 26);
            this.yearParam.TabIndex = 12;
            this.yearParam.Text = "Рік видання";
            this.yearParam.UseVisualStyleBackColor = true;
            // 
            // publishParam
            // 
            this.publishParam.AutoSize = true;
            this.publishParam.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.publishParam.Location = new System.Drawing.Point(3, 127);
            this.publishParam.Name = "publishParam";
            this.publishParam.Size = new System.Drawing.Size(144, 26);
            this.publishParam.TabIndex = 11;
            this.publishParam.Text = "Видавництво";
            this.publishParam.UseVisualStyleBackColor = true;
            // 
            // authorParam
            // 
            this.authorParam.AutoSize = true;
            this.authorParam.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorParam.Location = new System.Drawing.Point(3, 95);
            this.authorParam.Name = "authorParam";
            this.authorParam.Size = new System.Drawing.Size(80, 26);
            this.authorParam.TabIndex = 10;
            this.authorParam.Text = "Автор";
            this.authorParam.UseVisualStyleBackColor = true;
            // 
            // titleParam
            // 
            this.titleParam.AutoSize = true;
            this.titleParam.Checked = true;
            this.titleParam.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleParam.Location = new System.Drawing.Point(3, 63);
            this.titleParam.Name = "titleParam";
            this.titleParam.Size = new System.Drawing.Size(80, 26);
            this.titleParam.TabIndex = 9;
            this.titleParam.TabStop = true;
            this.titleParam.Text = "Назва";
            this.titleParam.UseVisualStyleBackColor = true;
            // 
            // departParamLabel
            // 
            this.departParamLabel.AutoSize = true;
            this.departParamLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.departParamLabel.Location = new System.Drawing.Point(3, 3);
            this.departParamLabel.Name = "departParamLabel";
            this.departParamLabel.Size = new System.Drawing.Size(162, 22);
            this.departParamLabel.TabIndex = 8;
            this.departParamLabel.Text = "Розділ бібліотеки";
            // 
            // departParamText
            // 
            this.departParamText.FormattingEnabled = true;
            this.departParamText.Location = new System.Drawing.Point(3, 28);
            this.departParamText.MaxDropDownItems = 10;
            this.departParamText.Name = "departParamText";
            this.departParamText.Size = new System.Drawing.Size(267, 29);
            this.departParamText.TabIndex = 7;
            this.departParamText.TabStop = false;
            // 
            // standardSort
            // 
            this.standardSort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.standardSort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.standardSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.standardSort.Location = new System.Drawing.Point(3, 377);
            this.standardSort.Name = "standardSort";
            this.standardSort.Size = new System.Drawing.Size(295, 39);
            this.standardSort.TabIndex = 0;
            this.standardSort.TabStop = false;
            this.standardSort.Text = "Початковий список";
            this.standardSort.UseVisualStyleBackColor = true;
            this.standardSort.Click += new System.EventHandler(this.StandardState);
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataSource = typeof(HomeLibrary.Book);
            // 
            // toolPanel
            // 
            this.toolPanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instructionTool});
            this.toolPanel.Location = new System.Drawing.Point(0, 0);
            this.toolPanel.Name = "toolPanel";
            this.toolPanel.Size = new System.Drawing.Size(884, 25);
            this.toolPanel.TabIndex = 1;
            this.toolPanel.Text = "toolStrip1";
            // 
            // instructionTool
            // 
            this.instructionTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.instructionTool.Image = ((System.Drawing.Image)(resources.GetObject("instructionTool.Image")));
            this.instructionTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.instructionTool.Name = "instructionTool";
            this.instructionTool.Size = new System.Drawing.Size(139, 22);
            this.instructionTool.Text = "Інструкція користувача";
            this.instructionTool.Click += new System.EventHandler(this.InstructionToolClick);
            // 
            // rightPanel
            // 
            this.rightPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rightPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rightPanel.Controls.Add(this.invent);
            this.rightPanel.Controls.Add(this.listPanel);
            this.rightPanel.Controls.Add(this.editBook);
            this.rightPanel.Controls.Add(this.addBook);
            this.rightPanel.Location = new System.Drawing.Point(321, 28);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(551, 421);
            this.rightPanel.TabIndex = 2;
            // 
            // listPanel
            // 
            this.listPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listPanel.AutoScroll = true;
            this.listPanel.Controls.Add(this.bookListGrid);
            this.listPanel.Location = new System.Drawing.Point(3, 3);
            this.listPanel.Name = "listPanel";
            this.listPanel.Size = new System.Drawing.Size(543, 368);
            this.listPanel.TabIndex = 2;
            // 
            // bookListGrid
            // 
            this.bookListGrid.AllowUserToAddRows = false;
            this.bookListGrid.AllowUserToDeleteRows = false;
            this.bookListGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bookListGrid.AutoGenerateColumns = false;
            this.bookListGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bookListGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.bookListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookListGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Author,
            this.Department,
            this.Avail,
            this.publisherDataGridViewTextBoxColumn,
            this.yearOfPublishingDataGridViewTextBoxColumn,
            this.sizeDataGridViewTextBoxColumn,
            this.fromWhereDataGridViewTextBoxColumn,
            this.rateDataGridViewTextBoxColumn});
            this.bookListGrid.DataSource = this.bookBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bookListGrid.DefaultCellStyle = dataGridViewCellStyle4;
            this.bookListGrid.Location = new System.Drawing.Point(3, 3);
            this.bookListGrid.MultiSelect = false;
            this.bookListGrid.Name = "bookListGrid";
            this.bookListGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bookListGrid.Size = new System.Drawing.Size(537, 362);
            this.bookListGrid.TabIndex = 0;
            this.bookListGrid.TabStop = false;
            this.bookListGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GetBookInfo);
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "Назва";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // Author
            // 
            this.Author.DataPropertyName = "Author";
            this.Author.HeaderText = "Автор";
            this.Author.Name = "Author";
            this.Author.ReadOnly = true;
            // 
            // Department
            // 
            this.Department.DataPropertyName = "Department";
            this.Department.HeaderText = "Розділ";
            this.Department.Name = "Department";
            this.Department.ReadOnly = true;
            // 
            // Avail
            // 
            this.Avail.DataPropertyName = "Avail";
            this.Avail.HeaderText = "Наявність";
            this.Avail.Name = "Avail";
            this.Avail.ReadOnly = true;
            // 
            // publisherDataGridViewTextBoxColumn
            // 
            this.publisherDataGridViewTextBoxColumn.DataPropertyName = "Publisher";
            this.publisherDataGridViewTextBoxColumn.HeaderText = "Publisher";
            this.publisherDataGridViewTextBoxColumn.Name = "publisherDataGridViewTextBoxColumn";
            this.publisherDataGridViewTextBoxColumn.Visible = false;
            // 
            // yearOfPublishingDataGridViewTextBoxColumn
            // 
            this.yearOfPublishingDataGridViewTextBoxColumn.DataPropertyName = "YearOfPublishing";
            this.yearOfPublishingDataGridViewTextBoxColumn.HeaderText = "YearOfPublishing";
            this.yearOfPublishingDataGridViewTextBoxColumn.Name = "yearOfPublishingDataGridViewTextBoxColumn";
            this.yearOfPublishingDataGridViewTextBoxColumn.Visible = false;
            // 
            // sizeDataGridViewTextBoxColumn
            // 
            this.sizeDataGridViewTextBoxColumn.DataPropertyName = "Size";
            this.sizeDataGridViewTextBoxColumn.HeaderText = "Size";
            this.sizeDataGridViewTextBoxColumn.Name = "sizeDataGridViewTextBoxColumn";
            this.sizeDataGridViewTextBoxColumn.Visible = false;
            // 
            // fromWhereDataGridViewTextBoxColumn
            // 
            this.fromWhereDataGridViewTextBoxColumn.DataPropertyName = "FromWhere";
            this.fromWhereDataGridViewTextBoxColumn.HeaderText = "FromWhere";
            this.fromWhereDataGridViewTextBoxColumn.Name = "fromWhereDataGridViewTextBoxColumn";
            this.fromWhereDataGridViewTextBoxColumn.Visible = false;
            // 
            // rateDataGridViewTextBoxColumn
            // 
            this.rateDataGridViewTextBoxColumn.DataPropertyName = "Rate";
            this.rateDataGridViewTextBoxColumn.HeaderText = "Rate";
            this.rateDataGridViewTextBoxColumn.Name = "rateDataGridViewTextBoxColumn";
            this.rateDataGridViewTextBoxColumn.Visible = false;
            // 
            // editBook
            // 
            this.editBook.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.editBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBook.Location = new System.Drawing.Point(193, 377);
            this.editBook.Name = "editBook";
            this.editBook.Size = new System.Drawing.Size(175, 39);
            this.editBook.TabIndex = 1;
            this.editBook.TabStop = false;
            this.editBook.Text = "Редагування";
            this.editBook.UseVisualStyleBackColor = true;
            this.editBook.Click += new System.EventHandler(this.EditBook);
            // 
            // addBook
            // 
            this.addBook.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBook.Location = new System.Drawing.Point(3, 377);
            this.addBook.Name = "addBook";
            this.addBook.Size = new System.Drawing.Size(184, 39);
            this.addBook.TabIndex = 0;
            this.addBook.TabStop = false;
            this.addBook.Text = "Додати книгу";
            this.addBook.UseVisualStyleBackColor = true;
            this.addBook.Click += new System.EventHandler(this.AddBook);
            // 
            // invent
            // 
            this.invent.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.invent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.invent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.invent.Location = new System.Drawing.Point(374, 377);
            this.invent.Name = "invent";
            this.invent.Size = new System.Drawing.Size(172, 39);
            this.invent.TabIndex = 3;
            this.invent.TabStop = false;
            this.invent.Text = "Наявні книги";
            this.invent.UseVisualStyleBackColor = true;
            this.invent.Click += new System.EventHandler(this.Inventorization);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.toolPanel);
            this.Controls.Add(this.leftPanel);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Особиста бібліотека";
            this.leftPanel.ResumeLayout(false);
            this.parameters.ResumeLayout(false);
            this.parameters.PerformLayout();
            this.sortTypeParams.ResumeLayout(false);
            this.sortTypeParams.PerformLayout();
            this.availParams.ResumeLayout(false);
            this.availParams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            this.toolPanel.ResumeLayout(false);
            this.toolPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.listPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bookListGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.ToolStrip toolPanel;
        private System.Windows.Forms.ToolStripButton instructionTool;
        private System.Windows.Forms.Button standardSort;
        private System.Windows.Forms.Panel parameters;
        private System.Windows.Forms.Button sort;
        private System.Windows.Forms.ComboBox departParamText;
        private System.Windows.Forms.Label departParamLabel;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Button editBook;
        private System.Windows.Forms.Button addBook;
        private System.Windows.Forms.Panel listPanel;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private System.Windows.Forms.DataGridView bookListGrid;
        private System.Windows.Forms.GroupBox sortTypeParams;
        private System.Windows.Forms.RadioButton downSortParam;
        private System.Windows.Forms.RadioButton upSortParam;
        private System.Windows.Forms.GroupBox availParams;
        private System.Windows.Forms.RadioButton allParam;
        private System.Windows.Forms.RadioButton nonAvailParam;
        private System.Windows.Forms.RadioButton availParam;
        private System.Windows.Forms.RadioButton sizeParam;
        private System.Windows.Forms.RadioButton yearParam;
        private System.Windows.Forms.RadioButton publishParam;
        private System.Windows.Forms.RadioButton authorParam;
        private System.Windows.Forms.RadioButton titleParam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Avail;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearOfPublishingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fromWhereDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button invent;
    }
}