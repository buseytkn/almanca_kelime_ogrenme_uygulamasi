namespace Kelime_Ogren
{
    partial class FrmIstatistik
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.almancaSozlukDataSet = new Kelime_Ogren.AlmancaSozlukDataSet();
            this.tBLOYUNCULARBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBLOYUNCULARTableAdapter = new Kelime_Ogren.AlmancaSozlukDataSetTableAdapters.TBLOYUNCULARTableAdapter();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oyuncuAdSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogruDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yanlisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.almancaSozlukDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLOYUNCULARBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.oyuncuAdSoyadDataGridViewTextBoxColumn,
            this.dogruDataGridViewTextBoxColumn,
            this.yanlisDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBLOYUNCULARBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(727, 391);
            this.dataGridView1.TabIndex = 0;
            // 
            // almancaSozlukDataSet
            // 
            this.almancaSozlukDataSet.DataSetName = "AlmancaSozlukDataSet";
            this.almancaSozlukDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLOYUNCULARBindingSource
            // 
            this.tBLOYUNCULARBindingSource.DataMember = "TBLOYUNCULAR";
            this.tBLOYUNCULARBindingSource.DataSource = this.almancaSozlukDataSet;
            // 
            // tBLOYUNCULARTableAdapter
            // 
            this.tBLOYUNCULARTableAdapter.ClearBeforeFill = true;
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oyuncuAdSoyadDataGridViewTextBoxColumn
            // 
            this.oyuncuAdSoyadDataGridViewTextBoxColumn.DataPropertyName = "OyuncuAdSoyad";
            this.oyuncuAdSoyadDataGridViewTextBoxColumn.HeaderText = "OyuncuAdSoyad";
            this.oyuncuAdSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.oyuncuAdSoyadDataGridViewTextBoxColumn.Name = "oyuncuAdSoyadDataGridViewTextBoxColumn";
            // 
            // dogruDataGridViewTextBoxColumn
            // 
            this.dogruDataGridViewTextBoxColumn.DataPropertyName = "Dogru";
            this.dogruDataGridViewTextBoxColumn.HeaderText = "Dogru";
            this.dogruDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dogruDataGridViewTextBoxColumn.Name = "dogruDataGridViewTextBoxColumn";
            // 
            // yanlisDataGridViewTextBoxColumn
            // 
            this.yanlisDataGridViewTextBoxColumn.DataPropertyName = "Yanlis";
            this.yanlisDataGridViewTextBoxColumn.HeaderText = "Yanlis";
            this.yanlisDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yanlisDataGridViewTextBoxColumn.Name = "yanlisDataGridViewTextBoxColumn";
            // 
            // FrmIstatitsik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 391);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmIstatitsik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İstatistik";
            this.Load += new System.EventHandler(this.FrmIstatitsik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.almancaSozlukDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLOYUNCULARBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private AlmancaSozlukDataSet almancaSozlukDataSet;
        private System.Windows.Forms.BindingSource tBLOYUNCULARBindingSource;
        private AlmancaSozlukDataSetTableAdapters.TBLOYUNCULARTableAdapter tBLOYUNCULARTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oyuncuAdSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogruDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yanlisDataGridViewTextBoxColumn;
    }
}