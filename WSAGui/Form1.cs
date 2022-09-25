using System;
using System.Diagnostics;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;

namespace WsaGui
{
    public partial class Form1 : Form
    {
        private string Dontarchx()
        {
            string Lang1 = Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName;
            if (Lang1 == "tr")
            {
                return "Üzgünüm cihazýnýz için destek sunamýyorum. amd64 veya arm64 cihazlar için destek var.";
            }
            else if (Lang1 == "de")
            {
                return "Tut mir leid, dass ich für Ihr Gerät keinen Support anbieten kann. Es gibt Unterstützung für amd64 oder arm64-Geräte.";
            }
            else
            {
                return "Sorry I can't offer support for your device. There is support for amd64 or arm64 devices.";
            }
        }

        public string systemarch = System.Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE").ToString().ToLower();

        public void checkarch()
        {
            if (systemarch == "amd64")
            {
                x64ToolStripMenuItem.Checked = true;
            }
            else if (systemarch == "arm64")
            {
                arm64ToolStripMenuItem.Checked = true;
            }
            else
            {
                string message = Dontarchx();
                string title = WelcomeTitle();
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Stop);
                if (result == DialogResult.OK)
                {
                    Close();
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
            wsa_release_combox.SelectedIndex = 3;
            magisk_version_combobox.SelectedIndex = 0;
            checkarch();
            enable_DevMode.Enabled = false;
            enable_DevMode.Checked = true;

        }
        string userName = Environment.UserName;

        //string Lang = Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName;
        private int get_amazon()
        {
            return amazon_appstore.SelectedIndex;
        }
        private int get_magisk()
        {
            return magisk_version_combobox.SelectedIndex;
        }
        private int get_wsa()
        {
            return wsa_release_combox.SelectedIndex;
        }
        private string get_gapps()
        {
            if (gapps_aroma.Checked)
            {
                return gapps_aroma.Text.ToLower();
            }
            else if (gapps_full.Checked)
            {
                return gapps_full.Text.ToLower();
            }
            else if (gapps_micro.Checked)
            {
                return gapps_micro.Text.ToLower();
            }
            else if (gapps_mini.Checked)
            {
                return gapps_mini.Text.ToLower();
            }
            else if (gapps_nano.Checked)
            {
                return gapps_nano.Text.ToLower();
            }
            else if (gapps_pico.Checked)
            {
                return gapps_pico.Text.ToLower();
            }
            else if (gapps_stock.Checked)
            {
                return gapps_stock.Text.ToLower();
            }
            else if (gapps_super.Checked)
            {
                return gapps_super.Text.ToLower();
            }
            else if (notgapps.Checked)
            {
                return "nogapps";
            }
            else
            {
                return "novalue";
            }
        }

        private string get_product_name()
        {
            string name = WsaProductName.Text;
            //string name1 = name.Trim(new Char[] { ' ', '*', '.', ',', '-', '+' });
            string result = Regex.Replace(name, @"[^A-Za-z\\/,]+|( )+", "$1").Trim();
            return result;
        }
        private void otherOS(int number)
        {
            if (number == 0)
            {
                OtherOSLabel.Visible = false;
                OsOtherText.Enabled = false;
                OsOtherText.ReadOnly = true;
                osgroup.Size = new Size(341, 172);
            }

            if (number == 1)
            {
                OtherOSLabel.Visible = true;
                OsOtherText.Enabled = true;
                OsOtherText.ReadOnly = false;
                osgroup.Size = new Size(341, 257);
            }

        }
        private void opengapps(int number)
        {
            if (number == 0)
            {
                //gapps_aroma.Enabled = false;
                gapps_full.Enabled = false;
                gapps_micro.Enabled = false;
                gapps_mini.Enabled = false;
                gapps_nano.Enabled = false;
                gapps_pico.Enabled = false;
                gapps_stock.Enabled = false;
                gapps_super.Enabled = false;

                notgapps.Enabled = false;
                notgapps.Checked = true;
            }
            if (number == 1)
            {
                if (notgapps.Checked == true)
                {
                    notgapps.Enabled = false;
                    notgapps.Checked = false;
                    gapps_pico.Checked = true;

                    // gapps_aroma.Enabled = false;
                    gapps_full.Enabled = true;
                    gapps_micro.Enabled = true;
                    gapps_mini.Enabled = true;
                    gapps_nano.Enabled = true;
                    gapps_pico.Enabled = true;
                    gapps_stock.Enabled = true;
                    gapps_super.Enabled = true;
                }
            }
        }
        private void customizer(int number)
        {
            if (number == 0)
            {
                WsaUsernameButton.Enabled = false;
                amazon_appstore.Enabled = false;
                WsaProductName.Enabled = false;
            }
            if (number == 1)
            {
                WsaUsernameButton.Enabled = true;
                amazon_appstore.Enabled = true;
                WsaProductName.Enabled = true;
            }
        }
        private void OpenURL(string url)
        {
            var uri = url;
            var psi = new ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName = uri;
            Process.Start(psi);
        }

        private string resultAll()
        {

            // SELECT OS
            string Value_OS;
           
         if (OsUbuntu.Checked)
            {
                Value_OS = "Ubuntu";
            }
            else if (OsOpenSUSETW.Checked)
            {
                Value_OS = "openSUSE-Tumbleweed";
            }
            else if(OsDebian.Checked)
            {
                Value_OS = "Debian";
            } else
            {
                Value_OS = OsOtherText.Text;
            }
            string Value_method;
            //

            string Value_arch;

            if (x64ToolStripMenuItem.Checked)
            {
                Value_arch = "amd64";
            } else
            {
                Value_arch = "arm64";
            }
            if (mention_wsagascript.Checked)
            {
                Value_method = "wsagascript";
            }
            else if (mention_magisk.Checked)
            {
                Value_method = "magiskonwsalocal";
            }
            else if (mention_orginal.Checked)
            {
                Value_method = "onlywsa";
            } else
            {
                Value_method = "onlywsa";
            }

            string Value_VMP;

            if (enable_vmp.Checked)
            {
                Value_VMP = "yes";
            } else
            {
                Value_VMP = "no";
            }
            string Value_devmode;
            if (enable_DevMode.Checked)
            {
                Value_devmode = "yes";
            }
            else
            {
                Value_devmode = "no";
            }
            string Value_adb;
            if (Adb.Checked)
            {
                Value_adb = "yes";
            }
            else
            {
                Value_adb = "no";
            }

            string Value_wsatools;
            if (WsaTools.Checked)
            {
                Value_wsatools = "yes";
            }
            else
            {
                Value_wsatools = "no";
            }
            string Value_productname = WsaProductName.Text;
            string Value_amazonstore;
            if (amazon_appstore.TabIndex == 0)
            {
                Value_amazonstore = "yes";
            }
            else if (amazon_appstore.TabIndex == 1)
            {
                Value_amazonstore = "no";
            }
            else
            {
                Value_amazonstore = "no";
            }
            string Value_wsarelease;
            if (wsa_release_combox.TabIndex == 0)
            {
                Value_wsarelease = "Fast";
            } else if (wsa_release_combox.TabIndex == 1)
            {
                Value_wsarelease = "Slow";
            } else if (wsa_release_combox.TabIndex == 2)
            {
                Value_wsarelease = "RP";
            } else if (wsa_release_combox.TabIndex == 3)
            {
                Value_wsarelease = "Retail";
            } else
            {
                Value_wsarelease = "Retail";
            }
            string Value_magiskversion;
            if (magisk_version_combobox.TabIndex == 0)
            {
                Value_magiskversion = "stable";
            }
            else if (magisk_version_combobox.TabIndex == 1)
            {
                Value_magiskversion = "beta";
            }
            else if (magisk_version_combobox.TabIndex == 2)
            {
                Value_magiskversion = "canary";
            }
            else if (magisk_version_combobox.TabIndex == 3)
            {
                Value_magiskversion = "debug";
            } else
            {
                Value_magiskversion = "stable";
            }
            string Value_gappsvalue;

            if (gapps_aroma.Checked)
            {
                Value_gappsvalue = "aroma";
            }  else if (gapps_full.Checked)
            {
                Value_gappsvalue = "full";
            } else if (gapps_micro.Checked)
            {
                Value_gappsvalue = "micro";
            } else if (gapps_mini.Checked)
            {
                Value_gappsvalue = "mini";
            } else if (gapps_nano.Checked)
            {
                Value_gappsvalue = "nano";
            } else if (gapps_pico.Checked)
            {
                Value_gappsvalue = "pico";
            } else if (gapps_stock.Checked)
            {
                Value_gappsvalue = "stock";
            } else if (gapps_super.Checked)
            {
                Value_gappsvalue = "super";
            }
            else
            {
                Value_gappsvalue = "pico";
            }
            String Value_lang;
            string Lang1 = Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName;
            if (Lang1 == "tr") {
                Value_lang = "tr-tr";
            } else if (Lang1 == "de")
            {
                Value_lang = "de-de";
            } else
            {
                Value_lang = "en-US";
            }

            return "-wsldistro " + Value_OS + " -arch " + Value_arch + " -scriptlang " + Value_lang + " -method " + Value_method + " -wsarelease " + Value_wsarelease
                + " -magiskversion " + Value_magiskversion + " -amazonstore " + Value_amazonstore + " -wsatools " + Value_wsatools
                + " -productname " + Value_productname + " -gappsvariant "+ Value_gappsvalue + " -winvmp " + Value_VMP
                + " -windevmode " + Value_devmode + " -adb " + Value_adb;
        }

        private string WelcomeTitle()
        {
            string Lang1 = Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName;
            if (Lang1 == "tr")
            {
                return "Baþlamadan önce";
            }
            else if (Lang1 == "de")
            {
                return "bevor du anfängst";
            }
            else
            {
                return "before you start";
            }
        }
        private string WelcomeDesc()
        {
            string Lang1 = Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName;
            if (Lang1 == "tr")
            {
                return "Kurulum sýrasýnda gerekli programlarýn kurulu olduðundan emin olunuz. Bunlardan bazýlarý Powershell (core), WSL, WSL Daðýtým, vb. Daha fazla bilgi için proje sayfasýný kontrol edin.";
            }
            else if (Lang1 == "de")
            {
                return "Stellen Sie sicher, dass die erforderlichen Programme während der Installation installiert sind. Einige davon sind Powershell (Core), WSL, WSL Distro usw. Weitere Informationen finden Sie auf der Projektseite.";
            }
            else
            {
                return "Make sure that the necessary programs are installed while installing. Some of them are Powershell (core), WSL, WSL Distro, etc.. For more information, check the project page.";
            }
        }
        private string warnTitle()
        {
            string Lang1 = Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName;
            if (Lang1 == "tr")
            {
                return "Önemli bilgi";
            }
            else if (Lang1 == "de")
            {
                return "Wichtige Informationen";
            }
            else
            {
                return "Important Information";
            }
        }
        private string Lang_OtherOS()
        {
            string Lang1 = Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName;
            {
                if (Lang1 == "tr")
                {
                    return "Lütfen seçtiðiniz daðýtým üzerinde gerekli paketlerin kurulu olduðundan emin olunuz. Ýlk üç seçenek dýþýnda size herhangi bir resmi destek saðlanmamaktadýr. Daha fazla bilgi için wsa-script projesini inceleyiniz.";
                }
                else if (Lang1 == "de")
                {
                    return "Bitte stellen Sie sicher, dass die erforderlichen Pakete auf der von Ihnen ausgewählten Distribution installiert sind. Außer für die ersten drei Optionen erhalten Sie keine offizielle Unterstützung. Weitere Informationen finden Sie im wsa-script Projekt.";
                }
                else
                {
                    return "Please make sure the required packages are installed on the distribution you selected. No official support is provided to you, except for the first three options. Check out the wsa-script project for more information.";
                }
            }
        }
        private string Lang_VMP()
        {
            string Lang1 = Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName;
            {
                if (Lang1 == "tr")
                {
                    return "Sanal Makine Platformu gerçekten kapalý ise kurulum yapýlamaz. Ne yaptýðýnýzý bilmiyorsanýz vazgeçin.";
                }
                else if (Lang1 == "de")
                {
                    return "Wenn die Virtual Machine Platform tatsächlich ausgeschaltet ist, kann die Installation nicht durchgeführt werden.Wenn Sie nicht wissen, was Sie tun, geben Sie auf.";
                }
                else
                {
                    return "If the Virtual Machine Platform is indeed turned off, the installation cannot be performed. If you don't know what you're doing, give up.";
                }
            }
        }
        private string Lang_DevMode()
        {
            string Lang1 = Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName;
            {
                if (Lang1 == "tr")
                {
                    return "Dosyalar deðiþtirileceði için Windows geliþtirici Modu etkin olmalýdýr. Aksi takdirde kurulamaz.\nAPK Yüklenirken WSA Geliþtirici Modu etkinleþtirilmelidir. Aksi takdirde kurulamaz.";
                }
                else if (Lang1 == "de")
                {
                    return "Der Windows-Entwicklermodus muss aktiv sein, da die Dateien geändert werden. Andernfalls kann es nicht installiert werden.\nDer WSA-Entwicklermodus muss während der Installation des APK aktiviert sein. Andernfalls kann es nicht installiert werden.";
                }
                else
                {
                    return "Windows developer Mode must be active as the files will be modified. otherwise it cannot be installed.\nWSA Developer Mode must be enabled while Installing the APK. otherwise it cannot be installed.";
                }
            }
        }
        private string Lang_Menu1(string menu, string url)
        {
            string Lang1 = Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName;
            if (menu == "menu")
            {
                if (Lang1 == "tr")
                {
                    menu = string.Format("Sizi bir web sayfasýna yönlendirir: {0}", url);
                }
                else if (Lang1 == "de")
                {
                    menu = string.Format("Leiten Sie zu einer Webseite weiter: {0}", url);
                }
                else
                {
                    menu = string.Format("Redirect you to a webpage: {0}", url);
                }
            }

            return menu;
        }
        private string Lang_Menu1_Title(string menu)
        {
            string Lang1 = Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName;
            if (menu == "menu")
            {
                if (Lang1 == "tr")
                {
                    menu = "Bir Web Sayfasýna Yönlendirmeler";
                }
                else if (Lang1 == "de")
                {
                    menu = "Weiterleitungen zu einer Webseite";
                }
                else
                {
                    menu = "Redirects to a Web Page";
                }
            }

            return menu;
        }

        private string Lang_ChangedArch_Title()
        {
            string Lang1 = Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName;
            if (Lang1 == "tr")
            {
                return "Emin misin?";
            }
            else if (Lang1 == "de")
            {
                return "Bist du dir sicher?";
            }
            else
            {
                return "Are you sure?";
            }
        }

        private string Lang_ChangedArch_Desc()
        {
            string Lang1 = Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName;
            if (Lang1 == "tr")
            {
                return "Otomatik kurulum gerçekleþeceði için seçeceðiniz arch sistem kurmaya çalýþan baþarýsýz olmanýza sonuç açabilir.";
            }
            else if (Lang1 == "de")
            {
                return "Da eine automatische Installation stattfindet, kann der Versuch, das von Ihnen gewählte Arch-System zu installieren, zu einem Fehlschlag führen.";
            }
            else
            {
                return "Since automatic installation will take place, trying to install the arch system you choose may result in your failure.";
            }
        }
        private string Lang_Reset_Desc()
        {
            string Lang1 = Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName;
            if (Lang1 == "tr")
            {
                return "Her Þeyi varsayýlan döndürme istediðinden emin misin? Tüm deðiþtirdiðin ayarlar sýfýrlancak.";
            }
            else if (Lang1 == "de")
            {
                return "Sind Sie sicher, dass Sie alles auf die Standardeinstellungen zurücksetzen möchten? Alle von Ihnen geänderten Einstellungen werden zurückgesetzt.";
            }
            else
            {
                return "Are you sure you want to return everything to default? All the settings you changed will be reset.";
            }
        }
        //
        private string Lang_Ready_Desc()
        {
            string Lang1 = Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName;
            if (Lang1 == "tr")
            {
                return "Tamam düðmesine bastýðýnýzda. Ýþlem baþlayacak, lütfen tüm sistem gereksinimlerini karþýlamanýz gerektiðini unutmayýn. WSL daðýtýmýný yanlýþ seçerseniz vs. Hata yaparsanýz iþlem baþarýsýz olur.\n\nÝþlem baþladýðýnda sistem sizden kullanýcý hesabýnýzýn þifresini isteyebilir(WSL Daðýtýmýnýz), bu yüzden açýlacak ekraný kontrol ediniz.";
            }
            else if (Lang1 == "de")
            {
                return "Wenn Sie die OK-Taste drücken. Der Prozess wird gestartet, bitte beachten Sie, dass Sie alle Systemanforderungen erfüllen müssen. Wenn Sie die falsche WSL-Verteilung auswählen usw. Wenn Sie einen Fehler machen, schlägt der Vorgang fehl.\n\nWenn der Vorgang beginnt, werden Sie vom System möglicherweise nach Ihrem Benutzerkonto-Passwort(WSL Distro) gefragt. Überprüfen Sie daher den sich öffnenden Bildschirm.";
            }
            else
            {
                return "When you press the OK button. The process will start, please note that you must meet all system requirements. If you choose WSL distribution wrong etc. If you make a mistake, the process will fail.\n\nWhen the process starts, the system may ask you for your user account password(WSL Distro), so check the screen that will open.";
            }
        }
        //

        private void magiskversion(int number)
        {
            if (number == 0)
            {
                magisk_version_text.Visible = false;
                magisk_version_combobox.Visible = false;

            }
            if (number == 1)
            {
                magisk_version_text.Visible = true;
                magisk_version_combobox.Visible = true;
            }
        }
        private void OSOther_CheckedChanged(object sender, EventArgs e)
        {
            otherOS(1);
            if (OSOther.Checked == true)
            {

                string message = Lang_OtherOS();
                string title = warnTitle();
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
            }

        }

        private void OsOpenSUSETW_CheckedChanged(object sender, EventArgs e)
        {
            otherOS(0);
        }

        private void OsDebian_CheckedChanged(object sender, EventArgs e)
        {
            otherOS(0);
        }

        private void OsUbuntu_CheckedChanged(object sender, EventArgs e)
        {
            otherOS(0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkarch();

            string message = WelcomeDesc();
            string title = WelcomeTitle();
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Asterisk);
            if (result == DialogResult.Yes)
            {
                Close();
            }
            else
            {
                // Do something  
            }

            //
            notgapps.Enabled = false;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutBox1 a = new AboutBox1();
            a.Show();
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mention_wsagascript_CheckedChanged(object sender, EventArgs e)
        {
            mSStoreForWSAToolStripMenuItem.Enabled = false;
            goToOpengappsToolStripMenuItem.Enabled = true;
            goToToolAdguardStripMenuItem.Enabled = true;
            enable_DevMode.Enabled = true;
            opengapps(1);
            customizer(1);
            magiskversion(0);
        }

        private void mention_magisk_CheckedChanged(object sender, EventArgs e)
        {
            mSStoreForWSAToolStripMenuItem.Enabled = false;
            goToOpengappsToolStripMenuItem.Enabled = true;
            goToToolAdguardStripMenuItem.Enabled = true;
            enable_DevMode.Enabled = false;
            enable_DevMode.Checked = true;
            opengapps(1);
            customizer(1);
            magiskversion(1);
        }

        private void WsaUsernameButton_Click(object sender, EventArgs e)
        {
            WsaProductName.Text = userName;
            WsaProductName.Text = get_product_name();
        }

        private void mention_orginal_CheckedChanged(object sender, EventArgs e)
        {
            goToOpengappsToolStripMenuItem.Enabled = false;
            goToToolAdguardStripMenuItem.Enabled = false;
            mSStoreForWSAToolStripMenuItem.Enabled = true;
            enable_DevMode.Checked = false;
            enable_DevMode.Enabled = true;
            opengapps(0);
            customizer(0);
            magiskversion(0);
        }

        private void enable_vmp_CheckedChanged(object sender, EventArgs e)
        {
            if (!enable_vmp.Checked)
            {
                string message = Lang_VMP();
                string title = warnTitle();
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);

                if (result == DialogResult.Cancel)
                {
                    enable_vmp.Checked = true;
                }
            }
        }

        private void enable_DevMode_CheckedChanged(object sender, EventArgs e)
        {
            if (!enable_DevMode.Checked && !mention_orginal.Checked)
            {
                string message = Lang_DevMode();
                string title = warnTitle();
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                if (result == DialogResult.Cancel)
                {
                    enable_DevMode.Checked = true;
                }
            }
        }

        private void mSStoreForPowershellCoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string URL = "https://www.microsoft.com/p/powershell/9mz1snwt0n5d";
            string message = Lang_Menu1("menu", URL);
            string title = Lang_Menu1_Title("menu");
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                OpenURL(URL);
            }
        }

        private void mSStoreForWSLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string URL = "https://aka.ms/wslstorepage";
            string message = Lang_Menu1("menu", URL);
            string title = Lang_Menu1_Title("menu");
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                OpenURL(URL);
            }
        }

        private void mSStoreForWSAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string URL = "https://www.microsoft.com/store/productId/9P3395VX91NR";
            string message = Lang_Menu1("menu", URL);
            string title = Lang_Menu1_Title("menu");
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                OpenURL(URL);
            }
        }

        private void mSStoreForUbuntuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string URL = "https://www.microsoft.com/p/ubuntu/9nblggh4msv6";
            string message = Lang_Menu1("menu", URL);
            string title = Lang_Menu1_Title("menu");
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                OpenURL(URL);
            }
        }

        private void mSStoreForDebianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string URL = "https://www.microsoft.com/p/debian/9msvkqc78pk6";
            string message = Lang_Menu1("menu", URL);
            string title = Lang_Menu1_Title("menu");
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                OpenURL(URL);
            }
        }

        private void mSStoreForOpenSUSETumbleweedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string URL = "https://www.microsoft.com/p/opensuse-tumbleweed/9mssk2zxxn11";
            string message = Lang_Menu1("menu", URL);
            string title = Lang_Menu1_Title("menu");
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                OpenURL(URL);
            }
        }

        private void goToOpengappsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string URL = "https://opengapps.org";
            string message = Lang_Menu1("menu", URL);
            string title = Lang_Menu1_Title("menu");
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                OpenURL(URL);
            }
        }

        private void goToToolAdguardStripMenuItem_Click(object sender, EventArgs e)
        {
            string URL = "https://store.rg-adguard.net";
            string message = Lang_Menu1("menu", URL);
            string title = Lang_Menu1_Title("menu");
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                OpenURL(URL);
            }
        }

        private void myGithubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string URL = "https://github.com/herrwinfried";
            string message = Lang_Menu1("menu", URL);
            string title = Lang_Menu1_Title("menu");
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                OpenURL(URL);
            }
        }

        private void projectPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string URL = "https://github.com/herrwinfried/wsa-gui";
            string message = Lang_Menu1("menu", URL);
            string title = Lang_Menu1_Title("menu");
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                OpenURL(URL);
            }
        }

        private void goToLicenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LicenceBox1 a = new LicenceBox1();
            a.Show();
        }

        private void wsascriptProjectPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string URL = "https://github.com/herrwinfried/wsa-script";
            string message = Lang_Menu1("menu", URL);
            string title = Lang_Menu1_Title("menu");
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                OpenURL(URL);
            }
        }

        private void donateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DonateBox1 a = new DonateBox1();
            a.Show();

        }

        private void WsaProductName_Leave(object sender, EventArgs e)
        {
            WsaProductName.Text = get_product_name();

        }

        private void arm64ToolStripMenuItem_OwnerChanged(object sender, EventArgs e)
        {

        }

        private void x64ToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (x64ToolStripMenuItem.Checked == true)
            {
                arm64ToolStripMenuItem.Checked = false;
            }
            if (x64ToolStripMenuItem.Checked == false && arm64ToolStripMenuItem.Checked == false){
                checkarch();
            }
            }

        private void arm64ToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (arm64ToolStripMenuItem.Checked == true)
            {
                x64ToolStripMenuItem.Checked = false;
            }
            if (x64ToolStripMenuItem.Checked == false && arm64ToolStripMenuItem.Checked == false)
            {
                checkarch();
            }
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en_US");
            Controls.Clear();
            InitializeComponent();
            checkarch();
        }

        private void turkishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("tr");
            Controls.Clear();
            InitializeComponent();
            checkarch();
        }

        private void germanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("de-DE");
            Controls.Clear();
            InitializeComponent();
            checkarch();
        }

        private void x64ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (x64ToolStripMenuItem.Checked == true)
            {

                string message = Lang_ChangedArch_Desc();
                string title = Lang_ChangedArch_Title();
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Hand);

                if (result == DialogResult.Cancel)
                {
                    x64ToolStripMenuItem.Checked = false;
                    arm64ToolStripMenuItem.Checked = true;
                }
                else
                {
                    arm64ToolStripMenuItem.Checked = false;
                }


            }
        }

        private void arm64ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (arm64ToolStripMenuItem.Checked == true)
            {
                string message = Lang_ChangedArch_Desc();
                string title = Lang_ChangedArch_Title();
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    x64ToolStripMenuItem.Checked = true;
                    arm64ToolStripMenuItem.Checked = false;
                }
                else
                {
                    x64ToolStripMenuItem.Checked = false;
                }
            }
        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            string message = Lang_Reset_Desc();
            string title = Lang_ChangedArch_Title();
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                string defaultLanguage = CultureInfo.InstalledUICulture.TwoLetterISOLanguageName;
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(defaultLanguage);
                Controls.Clear();
                InitializeComponent();
                checkarch();
                enable_DevMode.Enabled = false;
                enable_DevMode.Checked = true;
            }
           
        }

        private void ready_button_Click(object sender, EventArgs e)
        {
            string TextShellNoExit;
            if (powershellNoExitToolStripMenuItem.Checked)
            {
                TextShellNoExit = " -noexit ";
            }
            else
            {
                TextShellNoExit = "";
            }
            string TerminalCommand = "Start-Process pwsh.exe -verb runas -ArgumentList '" + TextShellNoExit + "-c ";
            TerminalCommand = TerminalCommand + "Invoke-WebRequest https://raw.githubusercontent.com/herrwinfried/wsa-script/beta/scripts/powershell/guisetup.ps1 -OutFile $env:TEMP/guisetup.ps1 && cd $env:TEMP && ./guisetup.ps1 " + resultAll().ToString() + " && cd $env:TEMP && Remove-Item ./guisetup.ps1;";
            TerminalCommand = TerminalCommand + "'";
            
            if (DeveloperModeToolStripMenuItem.Checked)
            {
             MessageBox.Show(TerminalCommand, "Dev Mode - Read Command", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (clipboardCopyToolStripMenuItem.Checked)
                {
                    MessageBox.Show("Copy Clipboard successful.", "Clipboard", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clipboard.SetText(TerminalCommand);
                }
                
            }
            string message = Lang_Ready_Desc();
            string title = WelcomeTitle();
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                var uri = "powershell.exe";
                var psi = new System.Diagnostics.ProcessStartInfo();
                psi.UseShellExecute = false;
                psi.FileName = uri;
                psi.Arguments = TerminalCommand;
                Process ps = System.Diagnostics.Process.Start(psi);
                ps.WaitForExit();
        
                
            }
        }
    }

}