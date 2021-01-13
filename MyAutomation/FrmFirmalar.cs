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
    public partial class FrmFirmalar : Form
    {
        public FrmFirmalar()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_FIRMALAR",bgl.baglanti());
            DataTable dt = new DataTable();
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
        void temizle()
        {
            TxtID.Text = "";
            TxtAD.Text = "";
            TxtKOD1.Text = "";
            TxtKOD2.Text = "";
            TxtKOD3.Text = "";
            TxtMAIL.Text = "";
            TxtSEKTOR.Text = "";
            TxtVERGIDAIRE.Text = "";
            TxtYETKILI.Text = "";
            TxtYGOREV.Text = "";
            MskTxtFAX.Text = "";
            MskTxtTC.Text = "";
            MskTxtTELEFON1.Text = "";
            MskTxtTELEFON2.Text = "";
            MskTxtTELEFON3.Text = "";
            RchTxtADRES.Text = "";
            //RchTxtOZELKOD1.Text = "";
            //RchTxtOZELKOD2.Text = "";
            //RchTxtOZELKOD3.Text = "";
            //TxtAD.Focus();
        }

        void carikodaciklamalar()
        {
            SqlCommand komut = new SqlCommand("Select FIRMAKOD1 from TBL_KODLAR",bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                RchTxtOZELKOD1.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();
        }

        private void FrmFirmalar_Load(object sender, EventArgs e)
        {
            listele();
            sehirlistesi();
            carikodaciklamalar();
            temizle();
        } 
        
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //Verileri Text Göster
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                TxtID.Text = dr["ID"].ToString();
                TxtAD.Text = dr["AD"].ToString();
                TxtYGOREV.Text = dr["YETKILISTATU"].ToString();
                TxtYETKILI.Text = dr["YETKILIADSOYAD"].ToString();
                MskTxtTELEFON1.Text = dr["TELEFON1"].ToString();
                MskTxtTELEFON2.Text = dr["TELEFON2"].ToString();
                MskTxtTELEFON3.Text = dr["TELEFON3"].ToString();
                TxtSEKTOR.Text = dr["SEKTOR"].ToString();
                MskTxtTC.Text = dr["YETKILITC"].ToString();
                MskTxtFAX.Text = dr["FAX"].ToString();
                TxtMAIL.Text = dr["MAIL"].ToString();
                comboBoxIL.Text = dr["IL"].ToString();
                comboBoxILCE.Text = dr["ILCE"].ToString();
                RchTxtADRES.Text = dr["ADRES"].ToString();
                TxtVERGIDAIRE.Text = dr["VERGIDAIRE"].ToString();
                RchTxtOZELKOD1.Text = dr["OZELKOD1"].ToString();
                RchTxtOZELKOD2.Text = dr["OZELKOD2"].ToString();
                RchTxtOZELKOD3.Text = dr["OZELKOD3"].ToString();
            
            }


            
            
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

        

        private void BtnFirmalarKaydet_Click(object sender, EventArgs e)
        {
            //Verileri Kaydetme
            SqlCommand komut = new SqlCommand("insert into TBL_FIRMALAR(AD,YETKILISTATU,YETKILIADSOYAD,YETKILITC,SEKTOR,TELEFON1,TELEFON2,TELEFON3,MAIL,FAX,IL,ILCE,VERGIDAIRE,ADRES,OZELKOD1,OZELKOD2,OZELKOD3) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15,@p16,@p17)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAD.Text);
            komut.Parameters.AddWithValue("@p2", TxtYGOREV.Text);
            komut.Parameters.AddWithValue("@p3", TxtYETKILI.Text);
            komut.Parameters.AddWithValue("@p4", MskTxtTC.Text);
            komut.Parameters.AddWithValue("@p5", TxtSEKTOR.Text);
            komut.Parameters.AddWithValue("@p6", MskTxtTELEFON1.Text);
            komut.Parameters.AddWithValue("@p7", MskTxtTELEFON2.Text);
            komut.Parameters.AddWithValue("@p8", MskTxtTELEFON3.Text);
            komut.Parameters.AddWithValue("@p9", TxtMAIL.Text);
            komut.Parameters.AddWithValue("@p10", MskTxtFAX.Text);
            komut.Parameters.AddWithValue("@p11", comboBoxIL.Text);
            komut.Parameters.AddWithValue("@p12", comboBoxILCE.Text);
            komut.Parameters.AddWithValue("@p13", TxtVERGIDAIRE.Text);
            komut.Parameters.AddWithValue("@p14", RchTxtADRES.Text);
            komut.Parameters.AddWithValue("@p15", RchTxtOZELKOD1.Text);
            komut.Parameters.AddWithValue("@p16", RchTxtOZELKOD2.Text);
            komut.Parameters.AddWithValue("@p17", RchTxtOZELKOD3.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Firma sisteme eklendi", "Bilgi", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            listele();
        }

        private void BtnFirmalarSil_Click(object sender, EventArgs e)
        {
            //Verileri Silme
            SqlCommand komutsil = new SqlCommand("Delete from TBL_FIRMALAR where ID=@p1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1", TxtID.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Firma Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            listele();
        }

        private void BtnFirmalarGuncelle_Click(object sender, EventArgs e)
        {
            //Verileri Güncelle
            SqlCommand komut = new SqlCommand("update TBL_FIRMALAR set AD=@P1,YETKILISTATU=@P2,YETKILIADSOYAD=@P3,YETKILITC=@P4,SEKTOR=@P5,TELEFON1=@P6,TELEFON2=@P7,TELEFON3=@P8,MAIL=@P9,FAX=@P10,IL=@P11,ILCE=@P12,VERGIDAIRE=@P13,ADRES=@P14,OZELKOD1=@P15,OZELKOD2=@P16,OZELKOD3=@P17 where ID=@P18", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAD.Text);
            komut.Parameters.AddWithValue("@p2", TxtYGOREV.Text);
            komut.Parameters.AddWithValue("@p3", TxtYETKILI.Text);
            komut.Parameters.AddWithValue("@p4", MskTxtTC.Text);
            komut.Parameters.AddWithValue("@p5", TxtSEKTOR.Text);
            komut.Parameters.AddWithValue("@p6", MskTxtTELEFON1.Text);
            komut.Parameters.AddWithValue("@p7", MskTxtTELEFON2.Text);
            komut.Parameters.AddWithValue("@p8", MskTxtTELEFON3.Text);
            komut.Parameters.AddWithValue("@p9", TxtMAIL.Text);
            komut.Parameters.AddWithValue("@p10", MskTxtFAX.Text);
            komut.Parameters.AddWithValue("@p11", comboBoxIL.Text);
            komut.Parameters.AddWithValue("@p12", comboBoxILCE.Text);
            komut.Parameters.AddWithValue("@p13", TxtVERGIDAIRE.Text);
            komut.Parameters.AddWithValue("@p14", RchTxtADRES.Text);
            komut.Parameters.AddWithValue("@p15", RchTxtOZELKOD1.Text);
            komut.Parameters.AddWithValue("@p16", RchTxtOZELKOD2.Text);
            komut.Parameters.AddWithValue("@p17", RchTxtOZELKOD3.Text);
            komut.Parameters.AddWithValue("@p18", TxtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Müşteri Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }
        
        private void BtnFirmalarTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
