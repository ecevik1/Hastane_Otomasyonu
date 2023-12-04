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
    public partial class FrmDoktorTahlilSonuc : Form
    {
        public FrmDoktorTahlilSonuc()
        {
            InitializeComponent();
        }
        public String tcNo,doktor;
        DbManager dbManager = new DbManager();
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();

            FrmDoktorDetay frm = Application.OpenForms["frmDoktorDetay"] as FrmDoktorDetay;
            if (frm != null)
            {
                frm.Show();
            }
        }

        private void FrmDoktorTahlilSonuc_Load(object sender, EventArgs e)
        {
            try
            {
                string sqlSorgu = "SELECT TahlilID,TahlilHastaTC, TahlilSonuc FROM Tbl_Tahlil WHERE TahlilDoktor=@doktor and TahlilHastaTC= @tc";

                SqlCommand command = new SqlCommand(sqlSorgu, dbManager.baglanti());
                
                    command.Parameters.AddWithValue("@tc",tcNo );
                    command.Parameters.AddWithValue("@doktor", doktor );

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                    
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // DataGridView'e doktorları ekleyin
                        tablo.DataSource = dataTable; // "tablo" DataGridView kontrolünüzün adı olmalı

                        tablo.Columns["ID"].Width = 40;
                        tablo.Columns["HastaTC"].Width = 100;
                        tablo.Columns["Sonuc"].Width = 233;
                        
              

                    
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Doktorları listelerken bir hata oluştu: " + ex.Message);
            }
            finally
            {
                dbManager.baglanti().Close();
            }

        }
    }
}
