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
using System.Data.SqlClient;

namespace Proje_Hastane
{
    public partial class FrmDoktorGiris : Form
    {
        public FrmDoktorGiris()
        {
            InitializeComponent();
           
        }

       DbManager dbManager = new DbManager();  


        private void BtnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Tbl_Doktor WHERE DoktorTC = @tc AND DoktorSifre = @sifre", dbManager.baglanti());

            cmd.Parameters.AddWithValue("@tc", mskbxTC.Text);
            cmd.Parameters.AddWithValue("@sifre", TxtSfre.Text);

            dbManager.baglanti();

            // Sorguyu çalıştırıp sonucu almak
            int result = (int)cmd.ExecuteScalar();

            dbManager.baglanti().Close();


            if(mskbxTC.Text=="11122233344"&& TxtSfre.Text == "5454")
            {
                FrmLaborant frm = new FrmLaborant();
                frm.Show();
                this.Close();
            }

            // Eşleşme kontrolü
            if (result > 0)
            {
                // Eşleşme bulundu, doğru TC ve şifre
                FrmDoktorDetay frmDoktorDetay = new FrmDoktorDetay();

                frmDoktorDetay.tcNo=mskbxTC.Text;

                frmDoktorDetay.Show();
                this.Close();

            }
            else
            {
                // Eşleşme bulunamadı, yanlış TC veya şifre
                MessageBox.Show("Hatalı TC veya şifre. Lütfen tekrar deneyin.");
            }
            
        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            this.Close();

            Anasayfa anaForm = Application.OpenForms["Anasayfa"] as Anasayfa;
            if (anaForm != null)
            {
                anaForm.Show();
            }
        }

        private void BtnSifremiUnuttum_Click(object sender, EventArgs e)
        {
            FrmSifremiUnuttum sifremiUnuttum = new FrmSifremiUnuttum();
            sifremiUnuttum.Show();
            this.Hide();
        }

        private void FrmDoktorGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
