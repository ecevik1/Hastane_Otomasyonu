namespace Proje_Hastane
{
    partial class FrmPoliklinik
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtPoliklinik = new System.Windows.Forms.TextBox();
            this.hastaneVeriTabaniDataSet1 = new Proje_Hastane.HastaneVeriTabaniDataSet1();
            this.tblBransBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_BransTableAdapter = new Proje_Hastane.HastaneVeriTabaniDataSet1TableAdapters.Tbl_BransTableAdapter();
            this.tblBransBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bransIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bransAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneVeriTabaniDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBransBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBransBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SlateGray;
            this.groupBox2.Controls.Add(this.btnSil);
            this.groupBox2.Controls.Add(this.btnEkle);
            this.groupBox2.Location = new System.Drawing.Point(24, 331);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(340, 70);
            this.groupBox2.TabIndex = 135;
            this.groupBox2.TabStop = false;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.DarkRed;
            this.btnSil.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnSil.Location = new System.Drawing.Point(192, 15);
            this.btnSil.Margin = new System.Windows.Forms.Padding(2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(132, 50);
            this.btnSil.TabIndex = 130;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.LimeGreen;
            this.btnEkle.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEkle.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnEkle.Location = new System.Drawing.Point(18, 15);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(132, 50);
            this.btnEkle.TabIndex = 132;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 245);
            this.groupBox1.TabIndex = 134;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "POLİKLİNİKLER";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SlateGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bransIDDataGridViewTextBoxColumn,
            this.bransAdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblBransBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(337, 215);
            this.dataGridView1.TabIndex = 127;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DarkCyan;
            this.groupBox3.Controls.Add(this.txtPoliklinik);
            this.groupBox3.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(24, 260);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(337, 65);
            this.groupBox3.TabIndex = 136;
            this.groupBox3.TabStop = false;
            // 
            // txtPoliklinik
            // 
            this.txtPoliklinik.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPoliklinik.Location = new System.Drawing.Point(5, 29);
            this.txtPoliklinik.Margin = new System.Windows.Forms.Padding(2);
            this.txtPoliklinik.Name = "txtPoliklinik";
            this.txtPoliklinik.Size = new System.Drawing.Size(319, 27);
            this.txtPoliklinik.TabIndex = 125;
            // 
            // hastaneVeriTabaniDataSet1
            // 
            this.hastaneVeriTabaniDataSet1.DataSetName = "HastaneVeriTabaniDataSet1";
            this.hastaneVeriTabaniDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblBransBindingSource
            // 
            this.tblBransBindingSource.DataMember = "Tbl_Brans";
            this.tblBransBindingSource.DataSource = this.hastaneVeriTabaniDataSet1;
            // 
            // tbl_BransTableAdapter
            // 
            this.tbl_BransTableAdapter.ClearBeforeFill = true;
            // 
            // tblBransBindingSource1
            // 
            this.tblBransBindingSource1.DataMember = "Tbl_Brans";
            this.tblBransBindingSource1.DataSource = this.hastaneVeriTabaniDataSet1;
            // 
            // bransIDDataGridViewTextBoxColumn
            // 
            this.bransIDDataGridViewTextBoxColumn.DataPropertyName = "BransID";
            this.bransIDDataGridViewTextBoxColumn.HeaderText = "BransID";
            this.bransIDDataGridViewTextBoxColumn.Name = "bransIDDataGridViewTextBoxColumn";
            this.bransIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bransAdDataGridViewTextBoxColumn
            // 
            this.bransAdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bransAdDataGridViewTextBoxColumn.DataPropertyName = "BransAd";
            this.bransAdDataGridViewTextBoxColumn.HeaderText = "BransAd";
            this.bransAdDataGridViewTextBoxColumn.Name = "bransAdDataGridViewTextBoxColumn";
            // 
            // FrmPoliklinik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(389, 419);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPoliklinik";
            this.Text = "FrmPoliklinik";
            this.Load += new System.EventHandler(this.FrmPoliklinik_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneVeriTabaniDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBransBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBransBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtPoliklinik;
        private HastaneVeriTabaniDataSet1 hastaneVeriTabaniDataSet1;
        private System.Windows.Forms.BindingSource tblBransBindingSource;
        private HastaneVeriTabaniDataSet1TableAdapters.Tbl_BransTableAdapter tbl_BransTableAdapter;
        private System.Windows.Forms.BindingSource tblBransBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bransIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bransAdDataGridViewTextBoxColumn;
    }
}