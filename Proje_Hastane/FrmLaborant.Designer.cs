namespace Proje_Hastane
{
    partial class FrmLaborant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLaborant));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tahlilIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tahlilHastaTCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tahlilSonucDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tahlilDoktorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblTahlilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastaneVeriTabaniDataSet1 = new Proje_Hastane.HastaneVeriTabaniDataSet1();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMessage = new System.Windows.Forms.RichTextBox();
            this.btnGonder = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblDoktor = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnGeri = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tbl_TahlilTableAdapter = new Proje_Hastane.HastaneVeriTabaniDataSet1TableAdapters.Tbl_TahlilTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTahlilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneVeriTabaniDataSet1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tahlilIDDataGridViewTextBoxColumn,
            this.tahlilHastaTCDataGridViewTextBoxColumn,
            this.tahlilSonucDataGridViewTextBoxColumn,
            this.tahlilDoktorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblTahlilBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(745, 127);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tahlilIDDataGridViewTextBoxColumn
            // 
            this.tahlilIDDataGridViewTextBoxColumn.DataPropertyName = "TahlilID";
            this.tahlilIDDataGridViewTextBoxColumn.HeaderText = "TahlilID";
            this.tahlilIDDataGridViewTextBoxColumn.Name = "tahlilIDDataGridViewTextBoxColumn";
            this.tahlilIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.tahlilIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // tahlilHastaTCDataGridViewTextBoxColumn
            // 
            this.tahlilHastaTCDataGridViewTextBoxColumn.DataPropertyName = "TahlilHastaTC";
            this.tahlilHastaTCDataGridViewTextBoxColumn.HeaderText = "TahlilHastaTC";
            this.tahlilHastaTCDataGridViewTextBoxColumn.Name = "tahlilHastaTCDataGridViewTextBoxColumn";
            this.tahlilHastaTCDataGridViewTextBoxColumn.ReadOnly = true;
            this.tahlilHastaTCDataGridViewTextBoxColumn.Width = 250;
            // 
            // tahlilSonucDataGridViewTextBoxColumn
            // 
            this.tahlilSonucDataGridViewTextBoxColumn.DataPropertyName = "TahlilSonuc";
            this.tahlilSonucDataGridViewTextBoxColumn.HeaderText = "TahlilSonuc";
            this.tahlilSonucDataGridViewTextBoxColumn.Name = "tahlilSonucDataGridViewTextBoxColumn";
            this.tahlilSonucDataGridViewTextBoxColumn.ReadOnly = true;
            this.tahlilSonucDataGridViewTextBoxColumn.Width = 200;
            // 
            // tahlilDoktorDataGridViewTextBoxColumn
            // 
            this.tahlilDoktorDataGridViewTextBoxColumn.DataPropertyName = "TahlilDoktor";
            this.tahlilDoktorDataGridViewTextBoxColumn.HeaderText = "TahlilDoktor";
            this.tahlilDoktorDataGridViewTextBoxColumn.Name = "tahlilDoktorDataGridViewTextBoxColumn";
            this.tahlilDoktorDataGridViewTextBoxColumn.ReadOnly = true;
            this.tahlilDoktorDataGridViewTextBoxColumn.Width = 200;
            // 
            // tblTahlilBindingSource
            // 
            this.tblTahlilBindingSource.DataMember = "Tbl_Tahlil";
            this.tblTahlilBindingSource.DataSource = this.hastaneVeriTabaniDataSet1;
            // 
            // hastaneVeriTabaniDataSet1
            // 
            this.hastaneVeriTabaniDataSet1.DataSetName = "HastaneVeriTabaniDataSet1";
            this.hastaneVeriTabaniDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.IndianRed;
            this.groupBox2.Controls.Add(this.txtMessage);
            this.groupBox2.Controls.Add(this.btnGonder);
            this.groupBox2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(406, 163);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(424, 219);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MESAJ";
            // 
            // txtMessage
            // 
            this.txtMessage.BackColor = System.Drawing.Color.PeachPuff;
            this.txtMessage.Location = new System.Drawing.Point(11, 27);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(396, 130);
            this.txtMessage.TabIndex = 4;
            this.txtMessage.Text = "";
            // 
            // btnGonder
            // 
            this.btnGonder.BackColor = System.Drawing.Color.PeachPuff;
            this.btnGonder.Location = new System.Drawing.Point(120, 176);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(174, 34);
            this.btnGonder.TabIndex = 3;
            this.btnGonder.Text = "Gönder";
            this.btnGonder.UseVisualStyleBackColor = false;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.IndianRed;
            this.groupBox1.Controls.Add(this.lblSonuc);
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Controls.Add(this.lblDoktor);
            this.groupBox1.Controls.Add(this.lblHasta);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(21, 163);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 219);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ALICI";
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.BackColor = System.Drawing.Color.PeachPuff;
            this.lblSonuc.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuc.Location = new System.Drawing.Point(21, 176);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(126, 26);
            this.lblSonuc.TabIndex = 7;
            this.lblSonuc.Text = "Randevu ID :";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.PeachPuff;
            this.lblID.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblID.Location = new System.Drawing.Point(174, 176);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 26);
            this.lblID.TabIndex = 6;
            // 
            // lblDoktor
            // 
            this.lblDoktor.AutoSize = true;
            this.lblDoktor.BackColor = System.Drawing.Color.PeachPuff;
            this.lblDoktor.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDoktor.Location = new System.Drawing.Point(131, 94);
            this.lblDoktor.Name = "lblDoktor";
            this.lblDoktor.Size = new System.Drawing.Size(0, 26);
            this.lblDoktor.TabIndex = 5;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.BackColor = System.Drawing.Color.PeachPuff;
            this.lblHasta.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHasta.Location = new System.Drawing.Point(131, 42);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(0, 26);
            this.lblHasta.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(26, 94);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(89, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // BtnGeri
            // 
            this.BtnGeri.BackColor = System.Drawing.Color.Crimson;
            this.BtnGeri.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGeri.ForeColor = System.Drawing.Color.White;
            this.BtnGeri.Location = new System.Drawing.Point(763, 12);
            this.BtnGeri.Name = "BtnGeri";
            this.BtnGeri.Size = new System.Drawing.Size(83, 46);
            this.BtnGeri.TabIndex = 24;
            this.BtnGeri.Text = "X";
            this.BtnGeri.UseVisualStyleBackColor = false;
            this.BtnGeri.Click += new System.EventHandler(this.BtnGeri_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(763, 64);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(83, 75);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // tbl_TahlilTableAdapter
            // 
            this.tbl_TahlilTableAdapter.ClearBeforeFill = true;
            // 
            // FrmLaborant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(858, 404);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.BtnGeri);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Corbel", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLaborant";
            this.Text = "FrmLaborant";
            this.Load += new System.EventHandler(this.FrmLaborant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTahlilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneVeriTabaniDataSet1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox txtMessage;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnGeri;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblDoktor;
        private System.Windows.Forms.Label lblHasta;
        private HastaneVeriTabaniDataSet1 hastaneVeriTabaniDataSet1;
        private System.Windows.Forms.BindingSource tblTahlilBindingSource;
        private HastaneVeriTabaniDataSet1TableAdapters.Tbl_TahlilTableAdapter tbl_TahlilTableAdapter;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tahlilIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tahlilHastaTCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tahlilSonucDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tahlilDoktorDataGridViewTextBoxColumn;
    }
}