using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Hastane
{
    public partial class FrmHastaKayıtOl : Form
    {
        public FrmHastaKayıtOl()
        {
            InitializeComponent();
        }
        DbManager dbManager = new DbManager();

        public bool KontrolEt()
        {
            if (string.IsNullOrEmpty(TxtAd.Text) ||
                string.IsNullOrEmpty(TxtSfre.Text) ||
                string.IsNullOrEmpty(TxtSyd.Text) ||
                string.IsNullOrEmpty(MskTxtTelefon.Text) ||
                string.IsNullOrEmpty(mskbxTC.Text) ||
                CmbBxCnsyt.SelectedIndex == -1) // Combobox'ın seçili bir öğe olup olmadığını kontrol etmek için
            {
                return false;
            }
            return true;
        }

        private void BtnKaydiTamamla_Click(object sender, EventArgs e)
        {

            if (KontrolEt())
            {
                try
                {
                    dbManager.baglanti();

                    SqlCommand cmd = new SqlCommand("INSERT INTO Tbl_Hasta(HastaAd,HastaSoyad,HastaTC,HastaTelefon,HastaCinsiyet,HastaSifre) values (@p1,@p2,@p3,@p4,@p5,@p6)", dbManager.baglanti());

                    cmd.Parameters.AddWithValue("@p1", TxtAd.Text);
                    cmd.Parameters.AddWithValue("@p2", TxtSyd.Text);
                    cmd.Parameters.AddWithValue("@p3", mskbxTC.Text);
                    cmd.Parameters.AddWithValue("@p4", MskTxtTelefon.Text);
                    cmd.Parameters.AddWithValue("@p5", CmbBxCnsyt.Text);
                    cmd.Parameters.AddWithValue("@p6", TxtSfre.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Kayıt başarılı bir şekilde eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    // Hata işleme kodu burada
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
                finally
                {
                    dbManager.baglanti().Close();
                }

                FrmHastaGiris frmHastaGiris = new FrmHastaGiris();
                frmHastaGiris.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen Bilgilerinizi Eksiksiz Giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            FrmHastaGiris frmHastaGiris = new FrmHastaGiris();
            frmHastaGiris.Show();
            this.Close();
        }
    }
}
