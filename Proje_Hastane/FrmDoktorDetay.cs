using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Hastane
{
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }
        DbManager dbManager = new DbManager();
        public String tcNo;

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmDoktorBilgiDuzenle frmDoktorBilgiDuzenle = new FrmDoktorBilgiDuzenle();
            frmDoktorBilgiDuzenle.tcno = tcNo;
            frmDoktorBilgiDuzenle.Show();
            this.Hide();
        }


        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktor Where DoktorTC = @tcno", dbManager.baglanti());

            cmd.Parameters.AddWithValue("@tcno", tcNo);

            DbDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                lbl_AdSoyad.Text = reader["DoktorAd"].ToString() + " " + reader["DoktorSoyad"].ToString();

            }
            lbl_TC.Text = tcNo;
            String doktorAdSoyad = lbl_AdSoyad.Text;

            //DatagridView1 Randevular

            SqlCommand cmd1 = new SqlCommand("Select RandevuTC,RandevuTarih,RandevuSaat,RandevuSikayet,RandevuDurum From Tbl_Randevu Where RandevuDoktor=@doktor and RandevuDurum = 0 ", dbManager.baglanti());
            cmd1.Parameters.AddWithValue("@doktor", doktorAdSoyad);
            DataTable dataTable1 = new DataTable();
            SqlDataAdapter dataAdapter1 = new SqlDataAdapter(cmd1);
            dataAdapter1.Fill(dataTable1);
            dataGridView1.DataSource = dataTable1;

            dbManager.baglanti().Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = Application.OpenForms["Anasayfa"] as Anasayfa;

            if (anasayfa != null) { anasayfa.Close(); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmDoktorTahlilSonuc frmDoktorTahlilSonuc = new FrmDoktorTahlilSonuc();
            frmDoktorTahlilSonuc.tcNo = selectedRowTC;
            frmDoktorTahlilSonuc.doktor = lbl_AdSoyad.Text;
            frmDoktorTahlilSonuc.Show();
            this.Hide();
        }

        private void btnReceteYaz_Click(object sender, EventArgs e)
        {
            FrmDoktorReceteYaz frm = new FrmDoktorReceteYaz();
            frm.tcNo=selectedRowTC;
            frm.ShowDialog();
        }

        private void listele(String HastaTcNo)
        {
            SqlCommand cmd2 = new SqlCommand("Select HastaTC,HastaAd,HastaSoyad,HastaCinsiyet From Tbl_Hasta Where HastaTC=@HastaTcNo", dbManager.baglanti());
            cmd2.Parameters.AddWithValue("@HastaTcNo", HastaTcNo);
            DataTable dataTable2 = new DataTable();
            SqlDataAdapter dataAdapter2 = new SqlDataAdapter(cmd2);
            dataAdapter2.Fill(dataTable2);
            dataGridView2.DataSource = dataTable2;
            dbManager.baglanti().Close();

        }


        private String selectedRowTC = "null"; // Başlangıç için seçilen satır olmasın
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // ID sütununun adını ve sırasını bilmelisiniz, bu örnekte "RandevuID" olarak varsayalım.
                string TcColumnName = "RandevuTC";

                // ID değerini seçili satırdan alın
                if (selectedRow.Cells[TcColumnName].Value != null)
                {
                    selectedRowTC = selectedRow.Cells[TcColumnName].Value.ToString();
                    listele(selectedRowTC);
                    
                }
                else
                {
                    selectedRowTC = "null"; // ID değeri null ise veya eksikse
                }
            }


        }

        private void btnTahliliste_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand cmdInsert = new SqlCommand("INSERT INTO Tbl_Tahlil (TahlilDoktor, TahlilHastaTC) VALUES (@doktorAdSoyad, @hastaTc)", dbManager.baglanti());
                SqlCommand cmdUpdate = new SqlCommand("Update Tbl_Tahlil Set TahlilSonuc='Sonuclandırılmadı',TahlilDurum='İşleniyor' Where TahlilHastaTC =(@hastaTc)",dbManager.baglanti());

                        // Parametreleri ekleme
                        cmdInsert.Parameters.AddWithValue("@doktorAdSoyad", lbl_AdSoyad.Text);
                        cmdInsert.Parameters.AddWithValue("@hastaTc", selectedRowTC);
                        cmdUpdate.Parameters.AddWithValue("@hastaTc", selectedRowTC);

                // Sorguyu çalıştırma
                cmdInsert.ExecuteNonQuery();
                cmdUpdate.ExecuteNonQuery();

                // Başarılı ekleme mesajı veya diğer işlemleri ekleyebilirsiniz.
                MessageBox.Show("Tahlil İsteği Alındı!","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }
        }

        private void btnSevkEt_Click(object sender, EventArgs e)
        {

            try
            {
                DbManager dbManager = new DbManager();
                dbManager.baglanti(); // Bağlantıyı aç

                // UPDATE sorgusu
                SqlCommand cmdupdate = new SqlCommand("UPDATE Tbl_Randevu SET RandevuDurum = 1 WHERE RandevuTC = @hastatc;", dbManager.baglanti());

                // Parametreyi ekleyin
                cmdupdate.Parameters.AddWithValue("@hastatc", selectedRowTC);

                cmdupdate.ExecuteNonQuery();

                MessageBox.Show("Hasta Sevk Edildi!", "Sevk", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                dbManager.baglanti().Close(); // Bağlantıyı kapat
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
