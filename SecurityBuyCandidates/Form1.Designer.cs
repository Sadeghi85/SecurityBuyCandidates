namespace SecurityBuyCandidates
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chbAll = new System.Windows.Forms.CheckBox();
            this.nudMaxGrowthDays = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudMaxAvgGrowthPercent = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.nudMinGrowthDays = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SecurityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecurityDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarketType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecurityGroupTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrowthDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrowthPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvgGrowthPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuyerStrength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VolumeStrength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAnalyse = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.dtpEndDate2 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpStartDate2 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Index2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecurityGroupID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecurityGroupTitle2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AverageCycle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AverageProfit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAnalyse2 = new System.Windows.Forms.Button();
            this.nudMinGrowth2 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dtpDate3 = new System.Windows.Forms.DateTimePicker();
            this.btnAnalyse3 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.SecurityName3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecurityDescription3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarketType3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecurityGroupTitle3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuyerStrength3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VolumeStrength3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EPS3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PE3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drpStrategy3 = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxGrowthDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxAvgGrowthPercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinGrowthDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinGrowth2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1288, 455);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.chbAll);
            this.tabPage1.Controls.Add(this.nudMaxGrowthDays);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.nudMaxAvgGrowthPercent);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.dtpDate);
            this.tabPage1.Controls.Add(this.nudMinGrowthDays);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.progressBar1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.btnAnalyse);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1280, 429);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "نماد های مناسب خرید";
            // 
            // chbAll
            // 
            this.chbAll.AutoSize = true;
            this.chbAll.Location = new System.Drawing.Point(830, 23);
            this.chbAll.Name = "chbAll";
            this.chbAll.Size = new System.Drawing.Size(37, 17);
            this.chbAll.TabIndex = 26;
            this.chbAll.Text = "All";
            this.chbAll.UseVisualStyleBackColor = true;
            // 
            // nudMaxGrowthDays
            // 
            this.nudMaxGrowthDays.Location = new System.Drawing.Point(300, 20);
            this.nudMaxGrowthDays.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudMaxGrowthDays.Name = "nudMaxGrowthDays";
            this.nudMaxGrowthDays.Size = new System.Drawing.Size(47, 20);
            this.nudMaxGrowthDays.TabIndex = 25;
            this.nudMaxGrowthDays.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 22);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Maximum Growth days:";
            // 
            // nudMaxAvgGrowthPercent
            // 
            this.nudMaxAvgGrowthPercent.DecimalPlaces = 1;
            this.nudMaxAvgGrowthPercent.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudMaxAvgGrowthPercent.Location = new System.Drawing.Point(532, 20);
            this.nudMaxAvgGrowthPercent.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudMaxAvgGrowthPercent.Name = "nudMaxAvgGrowthPercent";
            this.nudMaxAvgGrowthPercent.Size = new System.Drawing.Size(47, 20);
            this.nudMaxAvgGrowthPercent.TabIndex = 23;
            this.nudMaxAvgGrowthPercent.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(353, 22);
            this.label14.Name = "label14";
            this.label14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label14.Size = new System.Drawing.Size(173, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "Maximum Average Growth percent:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(585, 22);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Date:";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(624, 20);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 18;
            // 
            // nudMinGrowthDays
            // 
            this.nudMinGrowthDays.Location = new System.Drawing.Point(125, 20);
            this.nudMinGrowthDays.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudMinGrowthDays.Name = "nudMinGrowthDays";
            this.nudMinGrowthDays.Size = new System.Drawing.Size(47, 20);
            this.nudMinGrowthDays.TabIndex = 13;
            this.nudMinGrowthDays.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Minimum Growth days:";
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(3, 403);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1274, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SecurityName,
            this.SecurityDescription,
            this.MarketType,
            this.SecurityGroupTitle,
            this.GrowthDays,
            this.GrowthPercent,
            this.AvgGrowthPercent,
            this.BuyerStrength,
            this.VolumeStrength,
            this.Comment});
            this.dataGridView1.Location = new System.Drawing.Point(6, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.Size = new System.Drawing.Size(1268, 348);
            this.dataGridView1.TabIndex = 10;
            // 
            // SecurityName
            // 
            this.SecurityName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SecurityName.HeaderText = "SecurityName";
            this.SecurityName.Name = "SecurityName";
            this.SecurityName.ReadOnly = true;
            this.SecurityName.Width = 98;
            // 
            // SecurityDescription
            // 
            this.SecurityDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SecurityDescription.HeaderText = "SecurityDescription";
            this.SecurityDescription.Name = "SecurityDescription";
            this.SecurityDescription.ReadOnly = true;
            this.SecurityDescription.Width = 123;
            // 
            // MarketType
            // 
            this.MarketType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MarketType.HeaderText = "MarketType";
            this.MarketType.Name = "MarketType";
            this.MarketType.ReadOnly = true;
            this.MarketType.Width = 89;
            // 
            // SecurityGroupTitle
            // 
            this.SecurityGroupTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SecurityGroupTitle.HeaderText = "SecurityGroupTitle";
            this.SecurityGroupTitle.Name = "SecurityGroupTitle";
            this.SecurityGroupTitle.ReadOnly = true;
            this.SecurityGroupTitle.Width = 119;
            // 
            // GrowthDays
            // 
            this.GrowthDays.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.GrowthDays.HeaderText = "GrowthDays";
            this.GrowthDays.Name = "GrowthDays";
            this.GrowthDays.ReadOnly = true;
            this.GrowthDays.Width = 90;
            // 
            // GrowthPercent
            // 
            this.GrowthPercent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.GrowthPercent.HeaderText = "GrowthPercent";
            this.GrowthPercent.Name = "GrowthPercent";
            this.GrowthPercent.ReadOnly = true;
            this.GrowthPercent.Width = 103;
            // 
            // AvgGrowthPercent
            // 
            this.AvgGrowthPercent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.AvgGrowthPercent.HeaderText = "AvgGrowthPercent";
            this.AvgGrowthPercent.Name = "AvgGrowthPercent";
            this.AvgGrowthPercent.ReadOnly = true;
            this.AvgGrowthPercent.Width = 122;
            // 
            // BuyerStrength
            // 
            this.BuyerStrength.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.BuyerStrength.HeaderText = "BuyerStrength";
            this.BuyerStrength.Name = "BuyerStrength";
            this.BuyerStrength.ReadOnly = true;
            this.BuyerStrength.Width = 99;
            // 
            // VolumeStrength
            // 
            this.VolumeStrength.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.VolumeStrength.HeaderText = "VolumeStrength";
            this.VolumeStrength.Name = "VolumeStrength";
            this.VolumeStrength.ReadOnly = true;
            this.VolumeStrength.Width = 107;
            // 
            // Comment
            // 
            this.Comment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Comment.HeaderText = "Comment";
            this.Comment.Name = "Comment";
            this.Comment.ReadOnly = true;
            // 
            // btnAnalyse
            // 
            this.btnAnalyse.Location = new System.Drawing.Point(969, 17);
            this.btnAnalyse.Name = "btnAnalyse";
            this.btnAnalyse.Size = new System.Drawing.Size(161, 23);
            this.btnAnalyse.TabIndex = 9;
            this.btnAnalyse.Text = "Analyse";
            this.btnAnalyse.UseVisualStyleBackColor = true;
            this.btnAnalyse.Click += new System.EventHandler(this.btnAnalyse_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.progressBar2);
            this.tabPage2.Controls.Add(this.dtpEndDate2);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.dtpStartDate2);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.btnAnalyse2);
            this.tabPage2.Controls.Add(this.nudMinGrowth2);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1280, 429);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "رتبه بندی گروه ها";
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(3, 400);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(1271, 23);
            this.progressBar2.TabIndex = 10;
            // 
            // dtpEndDate2
            // 
            this.dtpEndDate2.Location = new System.Drawing.Point(506, 21);
            this.dtpEndDate2.Name = "dtpEndDate2";
            this.dtpEndDate2.Size = new System.Drawing.Size(200, 20);
            this.dtpEndDate2.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(445, 23);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "End Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(175, 23);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Start Date:";
            // 
            // dtpStartDate2
            // 
            this.dtpStartDate2.Location = new System.Drawing.Point(239, 21);
            this.dtpStartDate2.Name = "dtpStartDate2";
            this.dtpStartDate2.Size = new System.Drawing.Size(200, 20);
            this.dtpStartDate2.TabIndex = 6;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index2,
            this.SecurityGroupID,
            this.SecurityGroupTitle2,
            this.AverageCycle,
            this.AverageProfit});
            this.dataGridView2.Location = new System.Drawing.Point(6, 47);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1268, 347);
            this.dataGridView2.TabIndex = 5;
            // 
            // Index2
            // 
            this.Index2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Index2.HeaderText = "Index";
            this.Index2.Name = "Index2";
            this.Index2.ReadOnly = true;
            this.Index2.Width = 58;
            // 
            // SecurityGroupID
            // 
            this.SecurityGroupID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SecurityGroupID.HeaderText = "SecurityGroupID";
            this.SecurityGroupID.Name = "SecurityGroupID";
            this.SecurityGroupID.ReadOnly = true;
            this.SecurityGroupID.Width = 110;
            // 
            // SecurityGroupTitle2
            // 
            this.SecurityGroupTitle2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SecurityGroupTitle2.HeaderText = "SecurityGroupTitle";
            this.SecurityGroupTitle2.Name = "SecurityGroupTitle2";
            this.SecurityGroupTitle2.ReadOnly = true;
            this.SecurityGroupTitle2.Width = 119;
            // 
            // AverageCycle
            // 
            this.AverageCycle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AverageCycle.HeaderText = "AverageCycle";
            this.AverageCycle.Name = "AverageCycle";
            this.AverageCycle.ReadOnly = true;
            this.AverageCycle.Width = 98;
            // 
            // AverageProfit
            // 
            this.AverageProfit.HeaderText = "AverageProfit";
            this.AverageProfit.Name = "AverageProfit";
            this.AverageProfit.ReadOnly = true;
            // 
            // btnAnalyse2
            // 
            this.btnAnalyse2.Location = new System.Drawing.Point(778, 18);
            this.btnAnalyse2.Name = "btnAnalyse2";
            this.btnAnalyse2.Size = new System.Drawing.Size(140, 23);
            this.btnAnalyse2.TabIndex = 4;
            this.btnAnalyse2.Text = "Analyse";
            this.btnAnalyse2.UseVisualStyleBackColor = true;
            this.btnAnalyse2.Click += new System.EventHandler(this.btnAnalyse2_Click);
            // 
            // nudMinGrowth2
            // 
            this.nudMinGrowth2.Location = new System.Drawing.Point(122, 21);
            this.nudMinGrowth2.Name = "nudMinGrowth2";
            this.nudMinGrowth2.Size = new System.Drawing.Size(47, 20);
            this.nudMinGrowth2.TabIndex = 2;
            this.nudMinGrowth2.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 23);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Minimum Growth time:";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.drpStrategy3);
            this.tabPage3.Controls.Add(this.dtpDate3);
            this.tabPage3.Controls.Add(this.btnAnalyse3);
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Controls.Add(this.progressBar3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1280, 429);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "پول هوشمند";
            // 
            // dtpDate3
            // 
            this.dtpDate3.Location = new System.Drawing.Point(257, 23);
            this.dtpDate3.Name = "dtpDate3";
            this.dtpDate3.Size = new System.Drawing.Size(200, 20);
            this.dtpDate3.TabIndex = 19;
            // 
            // btnAnalyse3
            // 
            this.btnAnalyse3.Location = new System.Drawing.Point(490, 20);
            this.btnAnalyse3.Name = "btnAnalyse3";
            this.btnAnalyse3.Size = new System.Drawing.Size(170, 23);
            this.btnAnalyse3.TabIndex = 13;
            this.btnAnalyse3.Text = "Analyse";
            this.btnAnalyse3.UseVisualStyleBackColor = true;
            this.btnAnalyse3.Click += new System.EventHandler(this.btnAnalyse3_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView3.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SecurityName3,
            this.SecurityDescription3,
            this.MarketType3,
            this.SecurityGroupTitle3,
            this.BuyerStrength3,
            this.VolumeStrength3,
            this.EPS3,
            this.PE3});
            this.dataGridView3.Location = new System.Drawing.Point(3, 49);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView3.Size = new System.Drawing.Size(1274, 348);
            this.dataGridView3.TabIndex = 12;
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(3, 403);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(1274, 23);
            this.progressBar3.TabIndex = 11;
            // 
            // SecurityName3
            // 
            this.SecurityName3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SecurityName3.HeaderText = "SecurityName";
            this.SecurityName3.Name = "SecurityName3";
            this.SecurityName3.ReadOnly = true;
            this.SecurityName3.Width = 98;
            // 
            // SecurityDescription3
            // 
            this.SecurityDescription3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SecurityDescription3.HeaderText = "SecurityDescription";
            this.SecurityDescription3.Name = "SecurityDescription3";
            this.SecurityDescription3.ReadOnly = true;
            this.SecurityDescription3.Width = 123;
            // 
            // MarketType3
            // 
            this.MarketType3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MarketType3.HeaderText = "MarketType";
            this.MarketType3.Name = "MarketType3";
            this.MarketType3.ReadOnly = true;
            this.MarketType3.Width = 89;
            // 
            // SecurityGroupTitle3
            // 
            this.SecurityGroupTitle3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SecurityGroupTitle3.HeaderText = "SecurityGroupTitle";
            this.SecurityGroupTitle3.Name = "SecurityGroupTitle3";
            this.SecurityGroupTitle3.ReadOnly = true;
            this.SecurityGroupTitle3.Width = 119;
            // 
            // BuyerStrength3
            // 
            this.BuyerStrength3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.BuyerStrength3.HeaderText = "BuyerStrength";
            this.BuyerStrength3.Name = "BuyerStrength3";
            this.BuyerStrength3.ReadOnly = true;
            this.BuyerStrength3.Width = 99;
            // 
            // VolumeStrength3
            // 
            this.VolumeStrength3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.VolumeStrength3.HeaderText = "VolumeStrength";
            this.VolumeStrength3.Name = "VolumeStrength3";
            this.VolumeStrength3.ReadOnly = true;
            this.VolumeStrength3.Width = 107;
            // 
            // EPS3
            // 
            this.EPS3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.EPS3.HeaderText = "EPS";
            this.EPS3.Name = "EPS3";
            this.EPS3.ReadOnly = true;
            this.EPS3.Width = 53;
            // 
            // PE3
            // 
            this.PE3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PE3.HeaderText = "P/E";
            this.PE3.Name = "PE3";
            this.PE3.ReadOnly = true;
            this.PE3.Width = 51;
            // 
            // drpStrategy3
            // 
            this.drpStrategy3.FormattingEnabled = true;
            this.drpStrategy3.Location = new System.Drawing.Point(106, 23);
            this.drpStrategy3.Name = "drpStrategy3";
            this.drpStrategy3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.drpStrategy3.Size = new System.Drawing.Size(121, 21);
            this.drpStrategy3.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 479);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxGrowthDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxAvgGrowthPercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinGrowthDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinGrowth2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.NumericUpDown nudMinGrowthDays;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAnalyse;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudMinGrowth2;
        private System.Windows.Forms.Button btnAnalyse2;
        private System.Windows.Forms.DateTimePicker dtpEndDate2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpStartDate2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.NumericUpDown nudMaxAvgGrowthPercent;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown nudMaxGrowthDays;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index2;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecurityGroupID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecurityGroupTitle2;
        private System.Windows.Forms.DataGridViewTextBoxColumn AverageCycle;
        private System.Windows.Forms.DataGridViewTextBoxColumn AverageProfit;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecurityName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecurityDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarketType;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecurityGroupTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn GrowthDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn GrowthPercent;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvgGrowthPercent;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuyerStrength;
        private System.Windows.Forms.DataGridViewTextBoxColumn VolumeStrength;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comment;
        private System.Windows.Forms.CheckBox chbAll;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnAnalyse3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.DateTimePicker dtpDate3;
        private System.Windows.Forms.ComboBox drpStrategy3;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecurityName3;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecurityDescription3;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarketType3;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecurityGroupTitle3;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuyerStrength3;
        private System.Windows.Forms.DataGridViewTextBoxColumn VolumeStrength3;
        private System.Windows.Forms.DataGridViewTextBoxColumn EPS3;
        private System.Windows.Forms.DataGridViewTextBoxColumn PE3;
    }
}

