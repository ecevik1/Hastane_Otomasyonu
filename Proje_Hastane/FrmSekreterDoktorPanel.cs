using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Proje_Hastane
{
    public partial class FrmSekreterDoktorPanel : Form
    {
        public FrmSekreterDoktorPanel()
        {
            InitializeComponent();
        }

        DbManager dbManager = new DbManager();

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            FrmSekreterDetay frm = Application.OpenForms["frmSekreterDetay"] as FrmSekreterDetay;
            if (frm != null)
            {
                frm.Show();
                this.Close();
            }
        }

        private String doktorid;

        public void refresh()
        {
            this.tbl_DoktorTableAdapter.Fill(this.hastaneVeriTabaniDataSet1.Tbl_Doktor);
        }
        private void FrmSekreterDoktorPanel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hastaneVeriTabaniDataSet1.Tbl_Doktor' table. You can move, or remove it, as needed.
            this.tbl_DoktorTableAdapter.Fill(this.hastaneVeriTabaniDataSet1.Tbl_Doktor);

            try { 
            SqlCommand selectcmd = new SqlCommand("Select BransAd From Tbl_Brans", dbManager.baglanti());
            
            SqlDataReader reader = selectcmd.ExecuteReader();

            while (reader.Read())
            {
                string bransAd = reader["BransAd"].ToString();
                CmbBxBrans.Items.Add(bransAd); // ComboBox'a eklemek için Add metodu kullanılır
            }
            reader.Close();
            }
            catch(Exception    ex) { MessageBox.Show("(Cmbbx Brans Cekme)"+"\n"+"Bir hata oluştu: " + ex.Message); }
            finally { dbManager.baglanti().Close();  }


        }

        public bool KontrolEt()
        {
            if (string.IsNullOrEmpty(TxtAd.Text) ||
                string.IsNullOrEmpty(TxtSfre.Text) ||
                string.IsNullOrEmpty(TxtSyd.Text) ||
                string.IsNullOrEmpty(msktxtTelefon.Text) ||
                string.IsNullOrEmpty(mskbxTC.Text) ||
                CmbBxBrans.SelectedIndex == -1) // Combobox'ın seçili bir öğe olup olmadığını kontrol etmek için
            {
                return false;
            }
            return true;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // ID sütununun adını ve sırasını bilmeliyiz
               
                // ID değerini seçili satırdan alın
                if (selectedRow.Cells[0].Value != null)
                {
                    int selectedID = (int)selectedRow.Cells[0].Value; // ID'yi int olarak alıyoruz
                    // Doktor bilgilerini çekmek için bu ID'yi kullanacağız                                                         // Doktor bilgilerini çekmek için bu ID'yi kullanabilirsiniz
                    GetDoctorInfo(selectedID);
                }
            }*/



            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];


                if (selectedRow != null)
                {
                    doktorid = (String)selectedRow.Cells[0].Value.ToString();
                    TxtAd.Text = (String)selectedRow.Cells[1].Value.ToString();
                    TxtSyd.Text = (String)selectedRow.Cells[2].Value.ToString();
                    mskbxTC.Text = (String)selectedRow.Cells[3].Value.ToString();
                    TxtSfre.Text = (String)selectedRow.Cells[4].Value.ToString();
                    CmbBxBrans.Text = (String)selectedRow.Cells[6].Value.ToString();
                    msktxtTelefon.Text = (String)selectedRow.Cells[5].Value.ToString();

                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (KontrolEt())
            {
                try
                {
                    SqlCommand cmdInsert = new SqlCommand("Insert Into Tbl_Doktor(DoktorAd,DoktorSoyad,DoktorTC,DoktorTelefon,DoktorSifre,DoktorBrans) values (@ad,@soyad,@TC,@telefon,@sifre,@brans);", dbManager.baglanti());
                    cmdInsert.Parameters.AddWithValue("@ad", TxtAd.Text);
                    cmdInsert.Parameters.AddWithValue("@soyad", TxtSyd.Text);
                    cmdInsert.Parameters.AddWithValue("@TC", mskbxTC.Text);
                    cmdInsert.Parameters.AddWithValue("@telefon", msktxtTelefon.Text);
                    cmdInsert.Parameters.AddWithValue("@brans", CmbBxBrans.Text);
                    cmdInsert.Parameters.AddWithValue("@sifre", TxtSfre.Text);

                    cmdInsert.ExecuteNonQuery();
                    dbManager.baglanti().Close();
                    MessageBox.Show("Doktor Kaydedildi!", "Kayıt Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    

                }
                catch (Exception ex)
                {
                    // Hata işleme kodu burada
                    MessageBox.Show("(Doktor Ekleme)" + "\n" + "Bir hata oluştu: " + ex.Message);
                }
                finally
                {
                    dbManager.baglanti().Close();
                    refresh();
                }
            }
            else { MessageBox.Show("Lütfen bilgileri eksiksiz giriniz!", "EKSİK BİLGİ!", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (KontrolEt())
            {
                try
                {
                    SqlCommand cmdUpdate = new SqlCommand("Update Tbl_Doktor SET DoktorAd=@ad,DoktorSoyad=@soyad , DoktorTC=@TC, DoktorTelefon=@telefon , DoktorSifre=@sifre , DoktorBrans=@brans  where DoktorID=@id;", dbManager.baglanti());
                    cmdUpdate.Parameters.AddWithValue("@ad", TxtAd.Text);
                    cmdUpdate.Parameters.AddWithValue("@soyad", TxtSyd.Text);
                    cmdUpdate.Parameters.AddWithValue("@TC", mskbxTC.Text);
                    cmdUpdate.Parameters.AddWithValue("@telefon", msktxtTelefon.Text);
                    cmdUpdate.Parameters.AddWithValue("@brans", CmbBxBrans.Text);
                    cmdUpdate.Parameters.AddWithValue("@sifre", TxtSfre.Text);
                    cmdUpdate.Parameters.AddWithValue("@id", doktorid);

                    cmdUpdate.ExecuteNonQuery();
                    dbManager.baglanti().Close();
                    MessageBox.Show("Doktor Güncellendi!", "Güncelleme Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    

                }
                catch (Exception ex)
                {
                    // Hata işleme kodu burada
                    MessageBox.Show("Doktro Bilgi Güncelleme"+"\n"+"Bir hata oluştu: " + ex.Message);
                }
                finally
                {
                    dbManager.baglanti().Close();
                    refresh();
                }
            }
            else { MessageBox.Show("Lütfen bilgileri eksiksiz giriniz!", "EKSİK BİLGİ!", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (KontrolEt())
            {
                try
                {
                    SqlCommand cmdDelete = new SqlCommand("Delete From Tbl_Doktor where DoktorID=@id;", dbManager.baglanti());
                    
                    cmdDelete.Parameters.AddWithValue("@id", doktorid);

                    cmdDelete.ExecuteNonQuery();
                    dbManager.baglanti().Close();
                    MessageBox.Show("Doktor Kaydı Kaydılırdı!", "Kaldırma Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    // Hata işleme kodu burada
                    MessageBox.Show("(Doktor kayıt Silme)" + "\n" + "Bir hata oluştu: " + ex.Message);
                }
                finally
                {
                    dbManager.baglanti().Close();
                    refresh();
                }
            }
            else { MessageBox.Show("Kayıt Silinemedi!", "Başarısız!", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }
    }
}
