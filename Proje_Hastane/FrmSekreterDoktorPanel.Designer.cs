namespace Proje_Hastane
{
    partial class FrmSekreterDoktorPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSekreterDoktorPanel));
            this.mskbxTC = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnGeri = new System.Windows.Forms.Button();
            this.CmbBxBrans = new System.Windows.Forms.ComboBox();
            this.TxtSfre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtSyd = new System.Windows.Forms.TextBox();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.doktorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doktorAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doktorSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doktorTCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doktorSifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doktorTelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doktorBransDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblDoktorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastaneVeriTabaniDataSet1 = new Proje_Hastane.HastaneVeriTabaniDataSet1();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbl_DoktorTableAdapter = new Proje_Hastane.HastaneVeriTabaniDataSet1TableAdapters.Tbl_DoktorTableAdapter();
            this.msktxtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDoktorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneVeriTabaniDataSet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mskbxTC
            // 
            this.mskbxTC.BackColor = System.Drawing.Color.Azure;
            this.mskbxTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskbxTC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mskbxTC.HidePromptOnLeave = true;
            this.mskbxTC.Location = new System.Drawing.Point(34, 243);
            this.mskbxTC.Mask = "00000000000";
            this.mskbxTC.Name = "mskbxTC";
            this.mskbxTC.Size = new System.Drawing.Size(284, 26);
            this.mskbxTC.TabIndex = 126;
            this.mskbxTC.ValidatingType = typeof(int);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(128, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 125;
            this.pictureBox1.TabStop = false;
            // 
            // BtnGeri
            // 
            this.BtnGeri.BackColor = System.Drawing.Color.Crimson;
            this.BtnGeri.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGeri.ForeColor = System.Drawing.Color.White;
            this.BtnGeri.Location = new System.Drawing.Point(11, 11);
            this.BtnGeri.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnGeri.Name = "BtnGeri";
            this.BtnGeri.Size = new System.Drawing.Size(40, 37);
            this.BtnGeri.TabIndex = 124;
            this.BtnGeri.Text = "<";
            this.BtnGeri.UseVisualStyleBackColor = false;
            this.BtnGeri.Click += new System.EventHandler(this.BtnGeri_Click);
            // 
            // CmbBxBrans
            // 
            this.CmbBxBrans.BackColor = System.Drawing.Color.Azure;
            this.CmbBxBrans.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBxBrans.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CmbBxBrans.FormattingEnabled = true;
            this.CmbBxBrans.Items.AddRange(new object[] {
            "Kardiyoloji",
            "Üroloji"});
            this.CmbBxBrans.Location = new System.Drawing.Point(33, 314);
            this.CmbBxBrans.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmbBxBrans.Name = "CmbBxBrans";
            this.CmbBxBrans.Size = new System.Drawing.Size(284, 27);
            this.CmbBxBrans.TabIndex = 123;
            // 
            // TxtSfre
            // 
            this.TxtSfre.BackColor = System.Drawing.Color.Azure;
            this.TxtSfre.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSfre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtSfre.Location = new System.Drawing.Point(33, 373);
            this.TxtSfre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtSfre.Name = "TxtSfre";
            this.TxtSfre.Size = new System.Drawing.Size(284, 27);
            this.TxtSfre.TabIndex = 121;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 343);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 19);
            this.label5.TabIndex = 120;
            this.label5.Text = "Şifre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(30, 285);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 19);
            this.label6.TabIndex = 119;
            this.label6.Text = "Poliklinik";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(33, 217);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 19);
            this.label4.TabIndex = 117;
            this.label4.Text = "T.C. Kimlik No";
            // 
            // TxtSyd
            // 
            this.TxtSyd.BackColor = System.Drawing.Color.Azure;
            this.TxtSyd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSyd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtSyd.Location = new System.Drawing.Point(36, 178);
            this.TxtSyd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtSyd.Name = "TxtSyd";
            this.TxtSyd.Size = new System.Drawing.Size(284, 27);
            this.TxtSyd.TabIndex = 115;
            // 
            // TxtAd
            // 
            this.TxtAd.BackColor = System.Drawing.Color.Azure;
            this.TxtAd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtAd.Location = new System.Drawing.Point(36, 120);
            this.TxtAd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(284, 27);
            this.TxtAd.TabIndex = 114;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 156);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 113;
            this.label2.Text = "Soyisim";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(33, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 19);
            this.label1.TabIndex = 112;
            this.label1.Text = "İsim";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SlateGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.doktorIDDataGridViewTextBoxColumn,
            this.doktorAdDataGridViewTextBoxColumn,
            this.doktorSoyadDataGridViewTextBoxColumn,
            this.doktorTCDataGridViewTextBoxColumn,
            this.doktorSifreDataGridViewTextBoxColumn,
            this.doktorTelefonDataGridViewTextBoxColumn,
            this.doktorBransDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblDoktorBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(615, 328);
            this.dataGridView1.TabIndex = 127;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // doktorIDDataGridViewTextBoxColumn
            // 
            this.doktorIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.doktorIDDataGridViewTextBoxColumn.DataPropertyName = "DoktorID";
            this.doktorIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.doktorIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doktorIDDataGridViewTextBoxColumn.Name = "doktorIDDataGridViewTextBoxColumn";
            this.doktorIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // doktorAdDataGridViewTextBoxColumn
            // 
            this.doktorAdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.doktorAdDataGridViewTextBoxColumn.DataPropertyName = "DoktorAd";
            this.doktorAdDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.doktorAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doktorAdDataGridViewTextBoxColumn.Name = "doktorAdDataGridViewTextBoxColumn";
            this.doktorAdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // doktorSoyadDataGridViewTextBoxColumn
            // 
            this.doktorSoyadDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.doktorSoyadDataGridViewTextBoxColumn.DataPropertyName = "DoktorSoyad";
            this.doktorSoyadDataGridViewTextBoxColumn.HeaderText = "Soyad";
            this.doktorSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doktorSoyadDataGridViewTextBoxColumn.Name = "doktorSoyadDataGridViewTextBoxColumn";
            this.doktorSoyadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // doktorTCDataGridViewTextBoxColumn
            // 
            this.doktorTCDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.doktorTCDataGridViewTextBoxColumn.DataPropertyName = "DoktorTC";
            this.doktorTCDataGridViewTextBoxColumn.HeaderText = "TC";
            this.doktorTCDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doktorTCDataGridViewTextBoxColumn.Name = "doktorTCDataGridViewTextBoxColumn";
            this.doktorTCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // doktorSifreDataGridViewTextBoxColumn
            // 
            this.doktorSifreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.doktorSifreDataGridViewTextBoxColumn.DataPropertyName = "DoktorSifre";
            this.doktorSifreDataGridViewTextBoxColumn.HeaderText = "Sifre";
            this.doktorSifreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doktorSifreDataGridViewTextBoxColumn.Name = "doktorSifreDataGridViewTextBoxColumn";
            this.doktorSifreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // doktorTelefonDataGridViewTextBoxColumn
            // 
            this.doktorTelefonDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.doktorTelefonDataGridViewTextBoxColumn.DataPropertyName = "DoktorTelefon";
            this.doktorTelefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.doktorTelefonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doktorTelefonDataGridViewTextBoxColumn.Name = "doktorTelefonDataGridViewTextBoxColumn";
            this.doktorTelefonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // doktorBransDataGridViewTextBoxColumn
            // 
            this.doktorBransDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.doktorBransDataGridViewTextBoxColumn.DataPropertyName = "DoktorBrans";
            this.doktorBransDataGridViewTextBoxColumn.HeaderText = "Brans";
            this.doktorBransDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doktorBransDataGridViewTextBoxColumn.Name = "doktorBransDataGridViewTextBoxColumn";
            this.doktorBransDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblDoktorBindingSource
            // 
            this.tblDoktorBindingSource.DataMember = "Tbl_Doktor";
            this.tblDoktorBindingSource.DataSource = this.hastaneVeriTabaniDataSet1;
            // 
            // hastaneVeriTabaniDataSet1
            // 
            this.hastaneVeriTabaniDataSet1.DataSetName = "HastaneVeriTabaniDataSet1";
            this.hastaneVeriTabaniDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(339, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(621, 358);
            this.groupBox1.TabIndex = 128;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DOKTORLAR";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkRed;
            this.button2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.button2.Location = new System.Drawing.Point(330, 14);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 50);
            this.button2.TabIndex = 130;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.CadetBlue;
            this.button3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.button3.Location = new System.Drawing.Point(184, 14);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 50);
            this.button3.TabIndex = 131;
            this.button3.Text = "Güncelle";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LimeGreen;
            this.button4.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.button4.Location = new System.Drawing.Point(26, 14);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(132, 50);
            this.button4.TabIndex = 132;
            this.button4.Text = "Kaydı Tamamla";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SlateGray;
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Location = new System.Drawing.Point(431, 393);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(470, 70);
            this.groupBox2.TabIndex = 133;
            this.groupBox2.TabStop = false;
            // 
            // tbl_DoktorTableAdapter
            // 
            this.tbl_DoktorTableAdapter.ClearBeforeFill = true;
            // 
            // msktxtTelefon
            // 
            this.msktxtTelefon.BackColor = System.Drawing.Color.Azure;
            this.msktxtTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.msktxtTelefon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.msktxtTelefon.HidePromptOnLeave = true;
            this.msktxtTelefon.Location = new System.Drawing.Point(33, 436);
            this.msktxtTelefon.Mask = "(999) 000-0000";
            this.msktxtTelefon.Name = "msktxtTelefon";
            this.msktxtTelefon.Size = new System.Drawing.Size(284, 26);
            this.msktxtTelefon.TabIndex = 135;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(30, 410);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 19);
            this.label3.TabIndex = 134;
            this.label3.Text = "Telefon NO :";
            // 
            // FrmSekreterDoktorPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(970, 485);
            this.ControlBox = false;
            this.Controls.Add(this.msktxtTelefon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mskbxTC);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnGeri);
            this.Controls.Add(this.CmbBxBrans);
            this.Controls.Add(this.TxtSfre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtSyd);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmSekreterDoktorPanel";
            this.Text = "FrmSekreterDoktorPanel";
            this.Load += new System.EventHandler(this.FrmSekreterDoktorPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDoktorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneVeriTabaniDataSet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskbxTC;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnGeri;
        private System.Windows.Forms.ComboBox CmbBxBrans;
        private System.Windows.Forms.TextBox TxtSfre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtSyd;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox2;
        private HastaneVeriTabaniDataSet1 hastaneVeriTabaniDataSet1;
        private System.Windows.Forms.BindingSource tblDoktorBindingSource;
        private HastaneVeriTabaniDataSet1TableAdapters.Tbl_DoktorTableAdapter tbl_DoktorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn doktorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doktorAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doktorSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doktorTCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doktorSifreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doktorTelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doktorBransDataGridViewTextBoxColumn;
        private System.Windows.Forms.MaskedTextBox msktxtTelefon;
        private System.Windows.Forms.Label label3;
    }
}