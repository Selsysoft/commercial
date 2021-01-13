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
    public partial class FrmUrunler : Form
    {
        public FrmUrunler()
        {
            InitializeComponent();
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void textEdit3_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void labelControl7_Click(object sender, EventArgs e)
        {

        }

        private void FrmUrunler_Load(object sender, EventArgs e)
        {
            listele();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_URUNLER",
                bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }

        private void BtnUrunlerKaydet_Click(object sender, EventArgs e)
        {
            //Verileri Kaydetme
            SqlCommand komut = new SqlCommand("insert into TBL_URUNLER(URUNAD,MARKA,MODEL,YIL,ADET,ALISFIYAT,SATISFIYAT,DETAY) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAD.Text);
            komut.Parameters.AddWithValue("@p2", TxtMARKA.Text); 
            komut.Parameters.AddWithValue("@p3", TxtMODEL.Text);
            komut.Parameters.AddWithValue("@p4", MskTxtYIL.Text);
            komut.Parameters.AddWithValue("@p5", int.Parse((NumUpDownADET.Value).ToString()));
            komut.Parameters.AddWithValue("@p6", decimal.Parse(TxtALISFIYATI.Text));
            komut.Parameters.AddWithValue("@p7", decimal.Parse(TxtSATISFIYATI.Text));
            komut.Parameters.AddWithValue("@p8", RichTxtDETAY.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün sisteme eklendi", "Bilgi", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            listele();
        }

        private void BtnUrunlerSil_Click(object sender, EventArgs e)
        {
            //Verileri Silme
            SqlCommand komutsil = new SqlCommand("Delete from TBL_URUNLER where ID=@p1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1", txtID.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            listele();

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //Verileri Text Göster
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtID.Text = dr["ID"].ToString();
                TxtAD.Text = dr["URUNAD"].ToString();
                TxtMARKA.Text = dr["MARKA"].ToString();
                TxtMODEL.Text = dr["MODEL"].ToString();
                MskTxtYIL.Text = dr["YIL"].ToString();
                NumUpDownADET.Value = decimal.Parse(dr["ADET"].ToString());
                TxtALISFIYATI.Text = dr["ALISFIYAT"].ToString();
                TxtSATISFIYATI.Text = dr["SATISFIYAT"].ToString();
                RichTxtDETAY.Text = dr["DETAY"].ToString();
            }
        }

        private void BtnUrunlerGuncelle_Click(object sender, EventArgs e)
        {
            //Verileri Güncelle
            SqlCommand komut = new SqlCommand("update TBL_URUNLER set URUNAD=@P1,MARKA=@P2,MODEL=@P3,YIL=@P4,ADET=@P5,ALISFIYAT=@P6,SATISFIYAT=@P7,DETAY=@P8 where ID=@P9", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAD.Text);
            komut.Parameters.AddWithValue("@p2", TxtMARKA.Text);
            komut.Parameters.AddWithValue("@p3", TxtMODEL.Text);
            komut.Parameters.AddWithValue("@p4", MskTxtYIL.Text);
            komut.Parameters.AddWithValue("@p5", int.Parse((NumUpDownADET.Value).ToString()));
            komut.Parameters.AddWithValue("@p6", decimal.Parse(TxtALISFIYATI.Text));
            komut.Parameters.AddWithValue("@p7", decimal.Parse(TxtSATISFIYATI.Text));
            komut.Parameters.AddWithValue("@p8", RichTxtDETAY.Text);
            komut.Parameters.AddWithValue("@p9", txtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }

}
