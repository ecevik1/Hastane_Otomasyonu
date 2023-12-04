using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proje_Hastane
{
    public partial class FrmRandevuAl : Form
    {
        public FrmRandevuAl()
        {
            InitializeComponent();
        }

        public String tcNo;
        DbManager dbManager = new DbManager();
        private String bransAd, doktorad;
        private int randevuid;

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            closeThis();
        }

        private void closeThis()
        {
            this.Close();
            FrmHastaDetay2 frmHastaDetay2 = Application.OpenForms["frmHastaDetay2"] as FrmHastaDetay2;
            if (frmHastaDetay2 != null)
            {
                frmHastaDetay2.Show();
            }
        }

        private void FrmRandevuAl_Load(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Select BransAd From Tbl_Brans ", dbManager.baglanti());
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string bransAd = reader["BransAd"].ToString();
                    comboBoxPoliklinik.Items.Add(bransAd);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("(Cmbbx Brans Cekme)" + "\n" + "Bir hata oluştu: " + ex.Message);
            }
            finally
            {
                dbManager.baglanti().Close();
            }
        }

        private void comboBoxPoliklinik_SelectedIndexChanged(object sender, EventArgs e)
        {
            bransAd = comboBoxPoliklinik.SelectedItem.ToString();
            ListeleDoktorlar(bransAd);
        }

        private void ListeleDoktorlar(string bransAd)
        {
            try
            {
                string sqlSorgu = "SELECT RandevuID,RandevuDoktor, RandevuSaat, RandevuTarih FROM Tbl_Randevu WHERE RandevuBrans = @bransAd AND RandevuDurum = 0";

                using (SqlCommand command = new SqlCommand(sqlSorgu, dbManager.baglanti()))
                {
                    command.Parameters.AddWithValue("@bransAd", bransAd);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // DataGridView'e doktorları ekleyin
                        tablo.DataSource = dataTable; // "tablo" DataGridView kontrolünüzün adı olmalı

                        tablo.Columns["RandevuID"].Width = 55;
                        tablo.Columns["RandevuDoktor"].Width = 240;
                        tablo.Columns["RandevuSaat"].Width = 150;
                        tablo.Columns["RandevuTarih"].Width = 150;
                

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Doktorları listelerken bir hata oluştu: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                string updateCommand = "UPDATE Tbl_Randevu SET RandevuTC = @TcNo, RandevuDurum = 1 WHERE RandevuID = @id";

                SqlCommand cmdUpdate = new SqlCommand(updateCommand, dbManager.baglanti());
                
                    cmdUpdate.Parameters.AddWithValue("@TcNo", tcNo);

                    cmdUpdate.Parameters.AddWithValue("@id", randevuid);

                    
                    cmdUpdate.ExecuteNonQuery();
                MessageBox.Show("RANDEVU ALMA BAŞARILI ! " , "İŞLEM BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                closeThis();

            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbManager.baglanti().Close();
            }


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tablo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = tablo.Rows[e.RowIndex];

                // RandevuID hücresinin değerini kontrol et
                object randevuIdValue = row.Cells["RandevuID"].Value;

                if (randevuIdValue != null && randevuIdValue != DBNull.Value)
                {
                    // Değer null veya DBNull değilse işlemleri gerçekleştir
                    randevuid = Convert.ToInt32(randevuIdValue);

                    lblSelectedDoktor.Text = row.Cells["RandevuDoktor"].Value.ToString();
                    lblSelectedSaat.Text = row.Cells["RandevuSaat"].Value.ToString();
                    lblSelectedTarih.Text = row.Cells["RandevuTarih"].Value.ToString();
                    lblSelectedBrans.Text = bransAd;
                }
                else
                {
                    // Değer null veya DBNull ise bir işlem yapma veya kullanıcıya uyarı verme
                    MessageBox.Show("RandevuID değeri boş (null) veya geçerli bir sayı değil.");
                }
            }

        }

    }
}


