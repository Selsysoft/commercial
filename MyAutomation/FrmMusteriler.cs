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

namespace MyAutomation
{
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_MUSTERILER", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
         
        void sehirlistesi()
        {
            SqlCommand komut = new SqlCommand("Select SEHIR From TBL_ILLER", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBoxIL.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }

        private void FrmMusteriler_Load(object sender, EventArgs e)
        {
            listele();
            sehirlistesi();
        }


        private void BtnMusterilerKaydet_Click(object sender, EventArgs e)
        {
            //Verileri Kaydetme
            SqlCommand komut = new SqlCommand("insert into TBL_MUSTERILER(AD,SOYAD,TELEFON,TELEFON2,TC,MAIL,IL,ILCE,ADRES,VERGIDAIRE) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAD.Text);
            komut.Parameters.AddWithValue("@p2", TxtSOYAD.Text);
            komut.Parameters.AddWithValue("@p3", MskTxtTELEFON1.Text);
            komut.Parameters.AddWithValue("@p4", MskTxtTELEFON2.Text);
            komut.Parameters.AddWithValue("@p5", MskTxtTC.Text);
            komut.Parameters.AddWithValue("@p6", TxtMAIL.Text);
            komut.Parameters.AddWithValue("@p7", comboBoxIL.Text);
            komut.Parameters.AddWithValue("@p8", comboBoxILCE.Text);
            komut.Parameters.AddWithValue("@p9", RichTxtADRES.Text);
            komut.Parameters.AddWithValue("@p10", TxtVERGIDAIRE.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Müşteri sisteme eklendi", "Bilgi", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            listele();
        }

        private void BtnMusterilerSil_Click(object sender, EventArgs e)
        {
            //Verileri Silme
            SqlCommand komutsil = new SqlCommand("Delete from TBL_MUSTERILER where ID=@p1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1", txtID.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Müşteri Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //Verileri Text Göster
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtID.Text = dr["ID"].ToString();
                TxtAD.Text = dr["AD"].ToString();
                TxtSOYAD.Text = dr["SOYAD"].ToString();
                MskTxtTELEFON1.Text = dr["TELEFON"].ToString();
                MskTxtTELEFON2.Text = dr["TELEFON2"].ToString();
                MskTxtTC.Text = dr["TC"].ToString();
                TxtMAIL.Text = dr["MAIL"].ToString();
                comboBoxIL.Text = dr["IL"].ToString();
                comboBoxILCE.Text = dr["ILCE"].ToString();
                RichTxtADRES.Text = dr["ADRES"].ToString();
                TxtVERGIDAIRE.Text = dr["VERGIDAIRE"].ToString();
            }
        }

        private void BtnMusterilerGuncelle_Click(object sender, EventArgs e)
        {
            //Verileri Güncelle
            SqlCommand komut = new SqlCommand("update TBL_MUSTERILER set AD=@P1,SOYAD=@P2,TELEFON=@P3,TELEFON2=@P4,TC=@P5,MAIL=@P6,IL=@P7,ILCE=@P8,ADRES=@P9,VERGIDAIRE=@P10 where ID=@P11", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAD.Text);
            komut.Parameters.AddWithValue("@p2", TxtSOYAD.Text);
            komut.Parameters.AddWithValue("@p3", MskTxtTELEFON1.Text);
            komut.Parameters.AddWithValue("@p4", MskTxtTELEFON2.Text);
            komut.Parameters.AddWithValue("@p5", MskTxtTC.Text);
            komut.Parameters.AddWithValue("@p6", TxtMAIL.Text);
            komut.Parameters.AddWithValue("@p7", comboBoxIL.Text);
            komut.Parameters.AddWithValue("@p8", comboBoxILCE.Text);
            komut.Parameters.AddWithValue("@p9", RichTxtADRES.Text);
            komut.Parameters.AddWithValue("@p10", TxtVERGIDAIRE.Text);
            komut.Parameters.AddWithValue("@p11", txtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Müşteri Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }

        private void comboBoxIL_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxILCE.Properties.Items.Clear();
            SqlCommand komut = new SqlCommand("Select ILCE from TBL_ILCELER where SEHIR=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", comboBoxIL.SelectedIndex + 1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBoxILCE.Properties.Items.Add(dr[0]);

            }
            bgl.baglanti().Close();
        }
    }
}
