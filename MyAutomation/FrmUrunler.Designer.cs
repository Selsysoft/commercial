
namespace MyAutomation
{
    partial class FrmUrunler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUrunler));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.BtnUrunlerGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnUrunlerSil = new DevExpress.XtraEditors.SimpleButton();
            this.BtnUrunlerKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.RichTxtDETAY = new System.Windows.Forms.RichTextBox();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.TxtSATISFIYATI = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.TxtAD = new DevExpress.XtraEditors.TextEdit();
            this.TxtMARKA = new DevExpress.XtraEditors.TextEdit();
            this.TxtMODEL = new DevExpress.XtraEditors.TextEdit();
            this.TxtALISFIYATI = new DevExpress.XtraEditors.TextEdit();
            this.NumUpDownADET = new System.Windows.Forms.NumericUpDown();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.MskTxtYIL = new System.Windows.Forms.MaskedTextBox();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSATISFIYATI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMARKA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMODEL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtALISFIYATI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownADET)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(5, 5);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1420, 1020);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.BtnUrunlerGuncelle);
            this.groupControl1.Controls.Add(this.BtnUrunlerSil);
            this.groupControl1.Controls.Add(this.BtnUrunlerKaydet);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.RichTxtDETAY);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.TxtSATISFIYATI);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.TxtAD);
            this.groupControl1.Controls.Add(this.TxtMARKA);
            this.groupControl1.Controls.Add(this.TxtMODEL);
            this.groupControl1.Controls.Add(this.TxtALISFIYATI);
            this.groupControl1.Controls.Add(this.NumUpDownADET);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.MskTxtYIL);
            this.groupControl1.Controls.Add(this.txtID);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1430, 5);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(610, 1020);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "İŞLEMLER";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // BtnUrunlerGuncelle
            // 
            this.BtnUrunlerGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnUrunlerGuncelle.Appearance.Options.UseFont = true;
            this.BtnUrunlerGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnUrunlerGuncelle.ImageOptions.Image")));
            this.BtnUrunlerGuncelle.Location = new System.Drawing.Point(144, 549);
            this.BtnUrunlerGuncelle.Name = "BtnUrunlerGuncelle";
            this.BtnUrunlerGuncelle.Size = new System.Drawing.Size(196, 29);
            this.BtnUrunlerGuncelle.TabIndex = 24;
            this.BtnUrunlerGuncelle.Text = "GÜNCELLE";
            this.BtnUrunlerGuncelle.Click += new System.EventHandler(this.BtnUrunlerGuncelle_Click);
            // 
            // BtnUrunlerSil
            // 
            this.BtnUrunlerSil.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnUrunlerSil.Appearance.Options.UseFont = true;
            this.BtnUrunlerSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnUrunlerSil.ImageOptions.Image")));
            this.BtnUrunlerSil.Location = new System.Drawing.Point(144, 514);
            this.BtnUrunlerSil.Name = "BtnUrunlerSil";
            this.BtnUrunlerSil.Size = new System.Drawing.Size(196, 29);
            this.BtnUrunlerSil.TabIndex = 23;
            this.BtnUrunlerSil.Text = "SİL";
            this.BtnUrunlerSil.Click += new System.EventHandler(this.BtnUrunlerSil_Click);
            // 
            // BtnUrunlerKaydet
            // 
            this.BtnUrunlerKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnUrunlerKaydet.Appearance.Options.UseFont = true;
            this.BtnUrunlerKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnUrunlerKaydet.ImageOptions.Image")));
            this.BtnUrunlerKaydet.Location = new System.Drawing.Point(144, 479);
            this.BtnUrunlerKaydet.Name = "BtnUrunlerKaydet";
            this.BtnUrunlerKaydet.Size = new System.Drawing.Size(196, 29);
            this.BtnUrunlerKaydet.TabIndex = 22;
            this.BtnUrunlerKaydet.Text = "KAYDET";
            this.BtnUrunlerKaydet.Click += new System.EventHandler(this.BtnUrunlerKaydet_Click);
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(79, 364);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(60, 22);
            this.labelControl9.TabIndex = 21;
            this.labelControl9.Text = "DETAY:";
            // 
            // RichTxtDETAY
            // 
            this.RichTxtDETAY.Location = new System.Drawing.Point(144, 366);
            this.RichTxtDETAY.Name = "RichTxtDETAY";
            this.RichTxtDETAY.Size = new System.Drawing.Size(196, 101);
            this.RichTxtDETAY.TabIndex = 20;
            this.RichTxtDETAY.Text = "";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(23, 335);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(116, 22);
            this.labelControl8.TabIndex = 19;
            this.labelControl8.Text = "SATIŞ FİYATI:";
            // 
            // TxtSATISFIYATI
            // 
            this.TxtSATISFIYATI.Location = new System.Drawing.Point(144, 332);
            this.TxtSATISFIYATI.Name = "TxtSATISFIYATI";
            this.TxtSATISFIYATI.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSATISFIYATI.Properties.Appearance.Options.UseFont = true;
            this.TxtSATISFIYATI.Size = new System.Drawing.Size(196, 28);
            this.TxtSATISFIYATI.TabIndex = 18;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(35, 301);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(104, 22);
            this.labelControl7.TabIndex = 17;
            this.labelControl7.Text = "ALIŞ FİYATI:";
            this.labelControl7.Click += new System.EventHandler(this.labelControl7_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(89, 265);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(50, 22);
            this.labelControl6.TabIndex = 16;
            this.labelControl6.Text = "ADET:";
            // 
            // TxtAD
            // 
            this.TxtAD.Location = new System.Drawing.Point(144, 127);
            this.TxtAD.Name = "TxtAD";
            this.TxtAD.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAD.Properties.Appearance.Options.UseFont = true;
            this.TxtAD.Size = new System.Drawing.Size(196, 28);
            this.TxtAD.TabIndex = 15;
            // 
            // TxtMARKA
            // 
            this.TxtMARKA.Location = new System.Drawing.Point(144, 161);
            this.TxtMARKA.Name = "TxtMARKA";
            this.TxtMARKA.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtMARKA.Properties.Appearance.Options.UseFont = true;
            this.TxtMARKA.Size = new System.Drawing.Size(196, 28);
            this.TxtMARKA.TabIndex = 14;
            // 
            // TxtMODEL
            // 
            this.TxtMODEL.Location = new System.Drawing.Point(144, 195);
            this.TxtMODEL.Name = "TxtMODEL";
            this.TxtMODEL.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtMODEL.Properties.Appearance.Options.UseFont = true;
            this.TxtMODEL.Size = new System.Drawing.Size(196, 28);
            this.TxtMODEL.TabIndex = 13;
            this.TxtMODEL.EditValueChanged += new System.EventHandler(this.textEdit3_EditValueChanged);
            // 
            // TxtALISFIYATI
            // 
            this.TxtALISFIYATI.Location = new System.Drawing.Point(144, 298);
            this.TxtALISFIYATI.Name = "TxtALISFIYATI";
            this.TxtALISFIYATI.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtALISFIYATI.Properties.Appearance.Options.UseFont = true;
            this.TxtALISFIYATI.Size = new System.Drawing.Size(196, 28);
            this.TxtALISFIYATI.TabIndex = 12;
            // 
            // NumUpDownADET
            // 
            this.NumUpDownADET.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NumUpDownADET.Location = new System.Drawing.Point(144, 263);
            this.NumUpDownADET.Name = "NumUpDownADET";
            this.NumUpDownADET.Size = new System.Drawing.Size(196, 29);
            this.NumUpDownADET.TabIndex = 11;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(107, 232);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(32, 22);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "YIL:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(75, 198);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(64, 22);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "MODEL:";
            this.labelControl4.Click += new System.EventHandler(this.labelControl4_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(75, 164);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(64, 22);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "MARKA:";
            this.labelControl3.Click += new System.EventHandler(this.labelControl3_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(110, 130);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(29, 22);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "AD:";
            // 
            // MskTxtYIL
            // 
            this.MskTxtYIL.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskTxtYIL.Location = new System.Drawing.Point(144, 229);
            this.MskTxtYIL.Mask = "0000";
            this.MskTxtYIL.Name = "MskTxtYIL";
            this.MskTxtYIL.Size = new System.Drawing.Size(196, 29);
            this.MskTxtYIL.TabIndex = 2;
            this.MskTxtYIL.ValidatingType = typeof(int);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(144, 93);
            this.txtID.Name = "txtID";
            this.txtID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtID.Properties.Appearance.Options.UseFont = true;
            this.txtID.Size = new System.Drawing.Size(196, 28);
            this.txtID.TabIndex = 1;
            this.txtID.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(114, 96);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(25, 22);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID:";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // FrmUrunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmUrunler";
            this.Text = "ÜRÜNLER";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmUrunler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSATISFIYATI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMARKA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMODEL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtALISFIYATI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownADET)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.MaskedTextBox MskTxtYIL;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit TxtAD;
        private DevExpress.XtraEditors.TextEdit TxtMARKA;
        private DevExpress.XtraEditors.TextEdit TxtMODEL;
        private DevExpress.XtraEditors.TextEdit TxtALISFIYATI;
        private System.Windows.Forms.NumericUpDown NumUpDownADET;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private System.Windows.Forms.RichTextBox RichTxtDETAY;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit TxtSATISFIYATI;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton BtnUrunlerKaydet;
        private DevExpress.XtraEditors.SimpleButton BtnUrunlerGuncelle;
        private DevExpress.XtraEditors.SimpleButton BtnUrunlerSil;
    }
}