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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proje_Hastane
{
    public partial class FrmHastaTahlillerim : Form
    {
        public FrmHastaTahlillerim()
        {
            InitializeComponent();
        }
        
        public String tcNo;
        DbManager dbManager = new DbManager();

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();

        FrmHastaDetay2 frmHastaDetay2 = Application.OpenForms["frmHastaDetay2"] as FrmHastaDetay2;
            if (frmHastaDetay2 != null)
            {
                frmHastaDetay2.Show();
            }
        }

        private void FrmHastaTahlillerim_Load(object sender, EventArgs e)
        {
            try
            {
                0 string sqlSorgu = "SELECT TahlilID, TahlilSonuc , TahlilDurum FROM Tbl_Tahlil WHERE  TahlilHastaTC= @tc";

                 SqlCommand command = new SqlCommand(sqlSorgu, dbManager.baglanti());

                 command.Parameters.AddWithValue("@tc", tcNo);


                 SqlDataAdapter adapter = new SqlDataAdapter(command);



                 DataTable dataTable = new DataTable();
                 adapter.Fill(dataTable);

                 // DataGridView'e doktorları ekleyin
                 tablo.DataSource = dataTable; // "tablo" DataGridView kontrolünüzün adı olmalı

                 tablo.Columns["ID"].Width = 40;
                 tablo.Columns["TahlilSonuc"].Width = 233;
                 tablo.Columns["TahlilDurum"].Width = 100;
               

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sonuclar listelenirken bir hata oluştu: " + ex.Message);
            }
            finally
            {
                dbManager.baglanti().Close();
            }
        }
    }
}
