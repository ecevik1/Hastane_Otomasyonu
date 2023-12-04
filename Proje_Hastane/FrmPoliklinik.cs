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
    public partial class FrmPoliklinik : Form
    {
        public FrmPoliklinik()
        {
            InitializeComponent();
        }

        DbManager dbManager = new DbManager();
        private String selectedID;

        public void refresh()
        {
            this.tbl_BransTableAdapter.Fill(this.hastaneVeriTabaniDataSet1.Tbl_Brans);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmdInsert = new SqlCommand("Insert Into Tbl_Brans(BransAd) values (@brans)", dbManager.baglanti());
                cmdInsert.Parameters.AddWithValue("@brans", txtPoliklinik.Text);
                cmdInsert.ExecuteNonQuery();
                dbManager.baglanti().Close();
                MessageBox.Show("Brans Kaydedildi!", "Kayıt Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch(Exception ex) {
                MessageBox.Show("(Branş Ekleme)" + "\n" + "Bir hata oluştu: " + ex.Message);
            }
            finally 
            { 
                dbManager.baglanti().Close();
                refresh();
            }
      
        }

        private void FrmPoliklinik_Load(object sender, EventArgs e)
        {

           refresh();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmdDelete = new SqlCommand("DELETE FROM Tbl_Brans WHERE BransID=@bransid", dbManager.baglanti());
                cmdDelete.Parameters.AddWithValue("@bransid", selectedID);
                cmdDelete.ExecuteNonQuery();
                dbManager.baglanti().Close();
                MessageBox.Show("Brans Kaldırıldı!", "Silme Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("(Brnaş Silme)" + "\n" + "Bir hata oluştu: " + ex.Message);
            }
            finally
            {
                dbManager.baglanti().Close();
                refresh();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];


                if (selectedRow != null)
                {
                    selectedID = (String)selectedRow.Cells[0].Value.ToString();
                    txtPoliklinik.Text = (String)selectedRow.Cells[1].Value.ToString(); 
                }

            }
        }
    }
}
