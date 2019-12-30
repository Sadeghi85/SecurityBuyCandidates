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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.nudMaxCorrection = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudMinCorrection = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudMinGrowth = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SecurityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecurityDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarketType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecurityGroupTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAnalyse = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nudMinGrowth2 = new System.Windows.Forms.NumericUpDown();
            this.nudMinCorrection2 = new System.Windows.Forms.NumericUpDown();
            this.btnAnalyse2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dtpStartDate2 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpEndDate2 = new System.Windows.Forms.DateTimePicker();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.Index2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecurityGroupID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecurityGroupTitle2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AverageCycle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxCorrection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinCorrection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinGrowth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinGrowth2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinCorrection2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
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
            this.tabPage1.Controls.Add(this.nudMaxCorrection);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.nudMinCorrection);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.nudMinGrowth);
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
            this.tabPage2.Controls.Add(this.nudMinCorrection2);
            this.tabPage2.Controls.Add(this.nudMinGrowth2);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1280, 429);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "رتبه بندی گروه ها";
            // 
            // nudMaxCorrection
            // 
            this.nudMaxCorrection.Location = new System.Drawing.Point(491, 20);
            this.nudMaxCorrection.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudMaxCorrection.Name = "nudMaxCorrection";
            this.nudMaxCorrection.Size = new System.Drawing.Size(47, 20);
            this.nudMaxCorrection.TabIndex = 17;
            this.nudMaxCorrection.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(358, 22);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Maximum Correction time:";
            // 
            // nudMinCorrection
            // 
            this.nudMinCorrection.Location = new System.Drawing.Point(305, 20);
            this.nudMinCorrection.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudMinCorrection.Name = "nudMinCorrection";
            this.nudMinCorrection.Size = new System.Drawing.Size(47, 20);
            this.nudMinCorrection.TabIndex = 15;
            this.nudMinCorrection.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 22);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Minimum Correction time:";
            // 
            // nudMinGrowth
            // 
            this.nudMinGrowth.Location = new System.Drawing.Point(122, 20);
            this.nudMinGrowth.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudMinGrowth.Name = "nudMinGrowth";
            this.nudMinGrowth.Size = new System.Drawing.Size(47, 20);
            this.nudMinGrowth.TabIndex = 13;
            this.nudMinGrowth.Value = new decimal(new int[] {
            20,
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
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Minimum Growth time:";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(6, 400);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1268, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SecurityName,
            this.SecurityDescription,
            this.MarketType,
            this.SecurityGroupTitle,
            this.Status,
            this.StatusDescription});
            this.dataGridView1.Location = new System.Drawing.Point(6, 46);
            this.dataGridView1.Name = "dataGridView1";
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
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 62;
            // 
            // StatusDescription
            // 
            this.StatusDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StatusDescription.HeaderText = "StatusDescription";
            this.StatusDescription.Name = "StatusDescription";
            this.StatusDescription.ReadOnly = true;
            // 
            // btnAnalyse
            // 
            this.btnAnalyse.Location = new System.Drawing.Point(599, 17);
            this.btnAnalyse.Name = "btnAnalyse";
            this.btnAnalyse.Size = new System.Drawing.Size(162, 23);
            this.btnAnalyse.TabIndex = 9;
            this.btnAnalyse.Text = "Analyse";
            this.btnAnalyse.UseVisualStyleBackColor = true;
            this.btnAnalyse.Click += new System.EventHandler(this.btnAnalyse_Click);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(183, 23);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(124, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Minimum Correction time:";
            // 
            // nudMinGrowth2
            // 
            this.nudMinGrowth2.Location = new System.Drawing.Point(122, 21);
            this.nudMinGrowth2.Name = "nudMinGrowth2";
            this.nudMinGrowth2.Size = new System.Drawing.Size(55, 20);
            this.nudMinGrowth2.TabIndex = 2;
            this.nudMinGrowth2.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // nudMinCorrection2
            // 
            this.nudMinCorrection2.Location = new System.Drawing.Point(313, 21);
            this.nudMinCorrection2.Name = "nudMinCorrection2";
            this.nudMinCorrection2.Size = new System.Drawing.Size(55, 20);
            this.nudMinCorrection2.TabIndex = 3;
            this.nudMinCorrection2.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // btnAnalyse2
            // 
            this.btnAnalyse2.Location = new System.Drawing.Point(1032, 18);
            this.btnAnalyse2.Name = "btnAnalyse2";
            this.btnAnalyse2.Size = new System.Drawing.Size(140, 23);
            this.btnAnalyse2.TabIndex = 4;
            this.btnAnalyse2.Text = "Analyse";
            this.btnAnalyse2.UseVisualStyleBackColor = true;
            this.btnAnalyse2.Click += new System.EventHandler(this.btnAnalyse2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index2,
            this.SecurityGroupID,
            this.SecurityGroupTitle2,
            this.AverageCycle});
            this.dataGridView2.Location = new System.Drawing.Point(6, 47);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1268, 347);
            this.dataGridView2.TabIndex = 5;
            // 
            // dtpStartDate2
            // 
            this.dtpStartDate2.Location = new System.Drawing.Point(438, 21);
            this.dtpStartDate2.Name = "dtpStartDate2";
            this.dtpStartDate2.Size = new System.Drawing.Size(200, 20);
            this.dtpStartDate2.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(374, 23);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Start Date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(644, 23);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "End Date:";
            // 
            // dtpEndDate2
            // 
            this.dtpEndDate2.Location = new System.Drawing.Point(705, 21);
            this.dtpEndDate2.Name = "dtpEndDate2";
            this.dtpEndDate2.Size = new System.Drawing.Size(200, 20);
            this.dtpEndDate2.TabIndex = 9;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(3, 400);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(1271, 23);
            this.progressBar2.TabIndex = 10;
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
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxCorrection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinCorrection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinGrowth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinGrowth2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinCorrection2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.NumericUpDown nudMaxCorrection;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudMinCorrection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudMinGrowth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecurityName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecurityDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarketType;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecurityGroupTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusDescription;
        private System.Windows.Forms.Button btnAnalyse;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudMinGrowth2;
        private System.Windows.Forms.Button btnAnalyse2;
        private System.Windows.Forms.NumericUpDown nudMinCorrection2;
        private System.Windows.Forms.DateTimePicker dtpEndDate2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpStartDate2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index2;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecurityGroupID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecurityGroupTitle2;
        private System.Windows.Forms.DataGridViewTextBoxColumn AverageCycle;
    }
}

