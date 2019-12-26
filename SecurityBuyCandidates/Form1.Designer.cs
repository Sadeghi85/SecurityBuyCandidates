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
            this.btnAnalyse = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.nudGrowth = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudMinCorrection = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudMaxCorrection = new System.Windows.Forms.NumericUpDown();
            this.SecurityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecurityDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarketType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecurityGroupTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGrowth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinCorrection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxCorrection)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAnalyse
            // 
            this.btnAnalyse.Location = new System.Drawing.Point(581, 12);
            this.btnAnalyse.Name = "btnAnalyse";
            this.btnAnalyse.Size = new System.Drawing.Size(162, 23);
            this.btnAnalyse.TabIndex = 0;
            this.btnAnalyse.Text = "Analyse";
            this.btnAnalyse.UseVisualStyleBackColor = true;
            this.btnAnalyse.Click += new System.EventHandler(this.btnAnalyse_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1288, 397);
            this.dataGridView1.TabIndex = 1;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(12, 444);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1288, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Growth time:";
            // 
            // nudGrowth
            // 
            this.nudGrowth.Location = new System.Drawing.Point(84, 15);
            this.nudGrowth.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudGrowth.Name = "nudGrowth";
            this.nudGrowth.Size = new System.Drawing.Size(47, 20);
            this.nudGrowth.TabIndex = 4;
            this.nudGrowth.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Minimum Correction time:";
            // 
            // nudMinCorrection
            // 
            this.nudMinCorrection.Location = new System.Drawing.Point(267, 15);
            this.nudMinCorrection.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudMinCorrection.Name = "nudMinCorrection";
            this.nudMinCorrection.Size = new System.Drawing.Size(47, 20);
            this.nudMinCorrection.TabIndex = 6;
            this.nudMinCorrection.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Maximum Correction time:";
            // 
            // nudMaxCorrection
            // 
            this.nudMaxCorrection.Location = new System.Drawing.Point(453, 15);
            this.nudMaxCorrection.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudMaxCorrection.Name = "nudMaxCorrection";
            this.nudMaxCorrection.Size = new System.Drawing.Size(47, 20);
            this.nudMaxCorrection.TabIndex = 8;
            this.nudMaxCorrection.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 479);
            this.Controls.Add(this.nudMaxCorrection);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudMinCorrection);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudGrowth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAnalyse);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGrowth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinCorrection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxCorrection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnalyse;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudGrowth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudMinCorrection;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudMaxCorrection;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecurityName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecurityDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarketType;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecurityGroupTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusDescription;
    }
}

