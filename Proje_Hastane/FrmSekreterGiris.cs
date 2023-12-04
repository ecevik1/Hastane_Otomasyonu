using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Proje_Hastane
{
    public partial class FrmSekreterGiris : Form
    {
        public FrmSekreterGiris()
        {
            InitializeComponent();
        }

        DbManager dbManager = new DbManager();

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            this.Close();

            Anasayfa anaForm = Application.OpenForms["Anasayfa"] as Anasayfa;
            if (anaForm != null)
            {
                anaForm.Show();
            }
        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Tbl_Sekreter WHERE SekreterTC = @tc AND SekreterSifre = @sifre", dbManager.baglanti());

            cmd.Parameters.AddWithValue("@tc", mskbxTC.Text);
            cmd.Parameters.AddWithValue("@sifre", txtSifre.Text);

            dbManager.baglanti();

            // Sorguyu çalıştırıp sonucu almak
            int result = (int)cmd.ExecuteScalar();

            dbManager.baglanti().Close();

            // Eşleşme kontrolü
            if (result > 0)
            {
                // Eşleşme bulundu, doğru TC ve şifre
                FrmSekreterDetay frmSekreterDetay = new FrmSekreterDetay();
                frmSekreterDetay.tcNo = mskbxTC.Text;
                frmSekreterDetay.Show();
                this.Close();



            }
            else
            {
                // Eşleşme bulunamadı, yanlış TC veya şifre
                MessageBox.Show("Hatalı TC veya şifre. Lütfen tekrar deneyin.");
            }
        }

        private void lnkLblSifremiUnuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmSifremiUnuttum frmSifremiUnuttum = new FrmSifremiUnuttum();
            frmSifremiUnuttum.Show();
            this.Hide();
        }
    }
}
