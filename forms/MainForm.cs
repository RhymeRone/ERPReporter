using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using NebimV3Reporter.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.DashboardCommon;
using System.Runtime.Remoting.Contexts;

namespace NebimV3Reporter
{
    public partial class MainForm : RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ConnectionTest_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var connection = new SqlHelper.Connection(Program.CurrentDBInfo);
            if(connection.Connect())
            {
                XtraMessageBox.Show("Bağlantı Başarılı");
                connection.Disconnect();
            }
        }

        private void ChangeDatabase_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new DatabaseList().ShowDialog();
        }

        private void listeleMusteriler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string command =
                "select [Hesap Açılış Tarihi],[Müşteri Kodu],[Müşteri Adı],Ofis,[Ofis Adı],[Şirket Kodu]," +
                "[Müşteri Tipi Açıklaması],[TC Kimlik No],[Vergi Numarası],[Vergi Dairesi Kodu]," +
                "[Vergi Dairesi Açıklaması],[Perakende Satış Fiyat Grubu],[Toptan Satış Fiyat Grubu]," +
                "[Kullanım Dışı] from TR.Musteriler";

            ShowReport("Müşteriler Listesi", command);
        }

        private void listeleMagazalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string command = 
                "select [Açılış Tarihi],[Şirket Kodu],[Mağaza Kodu],[Mağaza Adı]," +
                "Ofis,[Ofis Adı],[Perakende Satış Fiyat Grubu],[Toptan Satış Fiyat Grubu]," +
                "[Kullanım Dışı] from TR.Lokasyonlar where [Ülke Adı]='Türkiye'";
            ShowReport("Mağazalar Listesi",command);
        }

        private void listelePersoneller_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /*
            string command = "";
            Program.ShowReport("Personeller Listesi", command);*/
            Program.Maintenence();
        }

        private void listeleUrunler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string command = 
                "SELECT [Ürün Kodu],[Ürün Adı],[Ürün Tipi Açıklması],[Madde Vergi Grubu]," +
                "[Ödeme Planı Grubu],[Muhasebe Hesap Grubu],[Mağazada Satışa Açık],[Kullanım Dışı]," +
                "[ProductAtt01] as 'Ürün Özelliği 1',[ProductAtt02] as 'Ürün Özelliği 2',[ProductAtt03] " +
                "as 'Ürün Özelliği 3' FROM TR.Urunler";
            ShowReport("Ürünler Listesi", command);
        }

        private void listeleTedarikciHareketleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string command = 
                "select [Oluşturulma Tarihi],[Dökuman Saati],Sırası,[Cari Hesap Kodu]," +
                "[Cari Hesap Açıklaması],[Satır Açıklaması],[Belge Ref. Numarası],[Şirket Kodu]," +
                "[Oluşturan Kullanıcı],[Borç (Y)],[Alacak (Y)] " +
                "from TR.TedarikciHareketleri;";
            ShowReport("Tedarikçi Hareketleri", command, "Borç (Y)","Alacak (Y)");
        }

        private void listeleMusteriHareketleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string command = 
                "select [Oluşturulma Tarihi],[Cari Hesap Tipi Açıklaması],[Cari Hesap Açıklaması]," +
                "[Satır Açıklaması],[Belge Ref. Numarası],[Şirket Kodu],[Borç (Y)],[Alacak (Y)] " +
                "from TR.MusteriHareketleri";
            ShowReport("Müşteri Hareketleri", command, "Borç (Y)", "Alacak (Y)"); 
        }

        private void btnKasaBilgisi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string command = 
                "select [Oluşturulma Tarihi],[Oluşturan Kullanıcı],[Kasa Fiş Tipi Açıklaması]," +
                "[Kasa Fişi Ref. Numarası],[Kasa Cari Hesap Kodu],[Kasa Cari Hesap Açıklaması]," +
                "[Cari Hesap Tipi Açıklaması],[Cari Hesap Kodu],[Cari Hesap Açıklaması],[Şirket Kodu]," +
                "[Mağaza Kodu],[Satır Açıklaması],Tutar,[Borç (Y)],[Alacak (Y)] " +
                "from TR.KasaHareketleri";
            ShowReport("Kasa Bilgisi", command, "Tutar","Borç (Y)","Alacak (Y)");
        }

        private void btnCekSenet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string command =
                "select [Oluşturulma Tarihi],[Ç/S İşlem Açıklaması],[Bordro Ref. Numarası]," +
                "[Cari Hesap Tipi Açıklaması],[Cari Hesap Kodu],[Cari Hesap Açıklaması]," +
                "[Şirket Kodu],[Mağaza Kodu],[Oluşturan Kullanıcı],[Çek Numarası],Banka,[Banka Şubesi]," +
                "[Satır Açıklaması],[Tutar (Y)] from TR.CekSenetHareketleri";
            ShowReport("Çek / Senet Bilgisi", command, "Tutar (Y)");
        }

        protected void ShowReport(string formName, string sqlCommand, params string[] valueBases)
        {
            SqlHelper.Data dbContext = new SqlHelper.Data(new SqlHelper.Connection(Program.CurrentDBInfo));
            ReportDraft reportDraft = new ReportDraft(formName, dbContext.GetTable(sqlCommand), valueBases);
            reportDraft.Show();
        }

        private void btnGuncellemeKontrolü_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UpdateCheck updateCheck = new UpdateCheck();
            updateCheck.ShowDialog()
        }
    }


}
