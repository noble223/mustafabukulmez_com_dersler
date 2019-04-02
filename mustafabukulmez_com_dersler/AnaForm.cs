﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mustafabukulmez_com_dersler
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }
        private void AnaForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_Kurulu_Antivirus_Bulmak_Click(object sender, EventArgs e)
        {
            _001_Kurulu_Antivirus_Bulmak.AntivirusBulmak fr = new _001_Kurulu_Antivirus_Bulmak.AntivirusBulmak();
            fr.ShowDialog();
        }

        private void btn_FolderBrowserDialog_Kullanimi_Click(object sender, EventArgs e)
        {
            _002_FolderBrowserDialog_Kullanimi.FolderBrowserDialogKullanimi_ fr = new _002_FolderBrowserDialog_Kullanimi.FolderBrowserDialogKullanimi_();
            fr.ShowDialog();
        }

        private void btn_dt_bu_satir_baska_tabloya_ait_Click(object sender, EventArgs e)
        {
            _003_DataTable_Bu_Satir_Baska_Tabloya_Ait_Hatasi.form1 fr = new _003_DataTable_Bu_Satir_Baska_Tabloya_Ait_Hatasi.form1();
            fr.ShowDialog();
        }

        private void btn_thread_Sleep_Click(object sender, EventArgs e)
        {
            _004_Thread_Sleep_ile_Islem_Suresini_Uzatmak.thread_sleep fr = new _004_Thread_Sleep_ile_Islem_Suresini_Uzatmak.thread_sleep();
            fr.ShowDialog();
        }

        private void btn__5_TextBox_sadece_sayi_harf_girisi_Click(object sender, EventArgs e)
        {
            _005_TextBox_sadece_sayi_harf_girisi.Form1 fr = new _005_TextBox_sadece_sayi_harf_girisi.Form1();
            fr.ShowDialog();
        }

        private void btn_6_String_Sayisal_Deger_Kontrolu_Click(object sender, EventArgs e)
        {
            _006_String_Sayisal_Deger_Kontrolu.Form1 fr = new _006_String_Sayisal_Deger_Kontrolu.Form1();
            fr.ShowDialog();
        }

        private void btn_7_Kelime_heceleme_islemi_Click(object sender, EventArgs e)
        {
            _007_Kelime_heceleme_islemi.Form2 fr = new _007_Kelime_heceleme_islemi.Form2();
            fr.ShowDialog();
        }

        private void btn__8_Gridview_den_textbox_a_Veri_cekme_Click(object sender, EventArgs e)
        {
            _008_Gridview_den_textbox_a_Veri_cekme.ListeForm fr = new _008_Gridview_den_textbox_a_Veri_cekme.ListeForm();
            fr.ShowDialog();
        }

        private void btn__9_NotiftyIcon_Kullanimi_Click(object sender, EventArgs e)
        {
            _009_NotiftyIcon_Kullanimi.AnaMenu fr = new _009_NotiftyIcon_Kullanimi.AnaMenu();
            fr.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _010_LINQ_to_XML.LINQ_to_XML fr = new _010_LINQ_to_XML.LINQ_to_XML();
            fr.ShowDialog();
        }

        private void btn__011_Sayilari_Roma_Rakamina_Cevir_Click(object sender, EventArgs e)
        {
            _011_Sayilari_Roma_Rakamina_Cevir.Form1 fr = new _011_Sayilari_Roma_Rakamina_Cevir.Form1();
            fr.ShowDialog();
        }

        private void btn__012_kombinasyon_hesaplama_Click(object sender, EventArgs e)
        {
            _012_kombinasyon_hesaplama.Form1 fr = new _012_kombinasyon_hesaplama.Form1();
            fr.ShowDialog();
        }

        private void btn__013_permutasyon_hesaplama_Click(object sender, EventArgs e)
        {
            _013_permutasyon_hesaplama.Form1 fr = new _013_permutasyon_hesaplama.Form1();
            fr.ShowDialog();
        }

        private void btn__014_Tooltip_Kullanimi_Click(object sender, EventArgs e)
        {
            _014_Tooltip_Kullanimi.Form1 fr = new _014_Tooltip_Kullanimi.Form1();
            fr.ShowDialog();
        }

        private void btn__015_Extension_Methods_Click(object sender, EventArgs e)
        {
            _015_Extension_Methods.Form1 fr = new _015_Extension_Methods.Form1();
            fr.ShowDialog();
        }

        private void btn__016_ComboBox_TXT_Dosyai_ile_Doldurma_Click(object sender, EventArgs e)
        {
            _016_ComboBox_TXT_Dosyai_ile_Doldurma.Form1 fr = new _016_ComboBox_TXT_Dosyai_ile_Doldurma.Form1();
            fr.ShowDialog();
        }

        private void btn__017_Kill_Proccess_Program_Kapatmak_Click(object sender, EventArgs e)
        {
            _17_Kill_Proccess_Program_Kapatmak.Form1 fr = new _17_Kill_Proccess_Program_Kapatmak.Form1();
            fr.ShowDialog();
        }

        private void btn__018_Listeler_Arasındaki_Farkları_Bulmak_Click(object sender, EventArgs e)
        {
            _018_Listeler_Arasındaki_Farkları_Bulmak.Form1 fr = new _018_Listeler_Arasındaki_Farkları_Bulmak.Form1();
            fr.ShowDialog();
        }

        private void btn__019_Milisaniye_Bilgisini_Saniye_ve_Dakikaya_Cevirmek_Click(object sender, EventArgs e)
        {
            _019_Milisaniye_Bilgisini_Saniye_ve_Dakikaya_Cevirmek.Form1 fr = new _019_Milisaniye_Bilgisini_Saniye_ve_Dakikaya_Cevirmek.Form1();
            fr.ShowDialog();
        }

        private void btn_020_Excel_OLEDB_Baglanti_ve_Veri_Okuma_Class_Click(object sender, EventArgs e)
        {
            _020_Excel_OLEDB_Baglanti_ve_Veri_Okuma_Class.Form1 fr = new _020_Excel_OLEDB_Baglanti_ve_Veri_Okuma_Class.Form1();
            fr.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            _021_Rastgele_Sifre_Olusturma.Form1 fr = new _021_Rastgele_Sifre_Olusturma.Form1();
            fr.ShowDialog();
        }

        private void btn__022_Ozel_MessageBox_Yapimi_Click(object sender, EventArgs e)
        {
            _022_Ozel_MessageBox_Yapimi.AnaForm fr = new _022_Ozel_MessageBox_Yapimi.AnaForm();
            fr.ShowDialog();
        }
    }
}