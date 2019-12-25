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
            this.SecurityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecurityDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarketType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecurityGroupTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAnalyse
            // 
            this.btnAnalyse.Location = new System.Drawing.Point(525, 12);
            this.btnAnalyse.Name = "btnAnalyse";
            this.btnAnalyse.Size = new System.Drawing.Size(162, 23);
            this.btnAnalyse.TabIndex = 0;
            this.btnAnalyse.Text = "Analyse";
            this.btnAnalyse.UseVisualStyleBackColor = true;
            this.btnAnalyse.Click += new System.EventHandler(this.btnAnalyse_Click);
            // 
            // dataGridView1
            // 
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
            this.dataGridView1.Size = new System.Drawing.Size(1175, 376);
            this.dataGridView1.TabIndex = 1;
            // 
            // SecurityName
            // 
            this.SecurityName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SecurityName.HeaderText = "SecurityName";
            this.SecurityName.Name = "SecurityName";
            this.SecurityName.ReadOnly = true;
            // 
            // SecurityDescription
            // 
            this.SecurityDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SecurityDescription.HeaderText = "SecurityDescription";
            this.SecurityDescription.Name = "SecurityDescription";
            this.SecurityDescription.ReadOnly = true;
            // 
            // MarketType
            // 
            this.MarketType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MarketType.HeaderText = "MarketType";
            this.MarketType.Name = "MarketType";
            this.MarketType.ReadOnly = true;
            // 
            // SecurityGroupTitle
            // 
            this.SecurityGroupTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SecurityGroupTitle.HeaderText = "SecurityGroupTitle";
            this.SecurityGroupTitle.Name = "SecurityGroupTitle";
            this.SecurityGroupTitle.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // StatusDescription
            // 
            this.StatusDescription.HeaderText = "StatusDescription";
            this.StatusDescription.Name = "StatusDescription";
            this.StatusDescription.ReadOnly = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 444);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1175, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 479);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAnalyse);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAnalyse;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecurityName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecurityDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarketType;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecurityGroupTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusDescription;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

