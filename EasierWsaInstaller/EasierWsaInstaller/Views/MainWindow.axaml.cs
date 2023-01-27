using Avalonia.Controls;
using Avalonia.Interactivity;
using MessageBox.Avalonia.DTO;
using MessageBox.Avalonia.Enums;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using TextCopy;
using MessageBoxAvaloniaEnums = MessageBox.Avalonia.Enums;

namespace EasierWsaInstaller.Views;
public partial class MainWindow : Window
{
    private void Language_Turkish()
    {
        Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("tr");
        // MENUS
        Lang.Header = "Dil";
        lang_tr.Header = "Türkçe";

        Arch_title.Header = "Arch";

        Dal_title.Header = "İndirmeler ve Bağlantılar";
        msstore_pwsh.Header = "Powershell Core için MS Store";
        msstore_wsl.Header = "WSL için MS Store";
        msstore_wsa.Header = "WSA için MS Store";
        msstore_ubuntu.Header = "Ubuntu için MS Store";
        msstore_debian.Header = "Debian için MS Store";
        msstore_opensusetw.Header = "OpenSUSE Tumbleweed için MS Store";
        msstore_gapps.Header = "openGAPPS'e git";
        msstore_rgadguard.Header = "rg-adguard sayfasına git";

        About_menu.Header = "Hakkında";
        MyGithub.Header = "Benim Github'ım";
        ProjectPageM.Header = "Proje Sayfası";
        LicenceM.Header = "Lisans";
        EProjectPageM.Header = "EasierWsaInstaller " + ProjectPageM.Header;
        DonateM.Header = "Bağış";
        Aboutm.Header = About_menu.Header;

        Options_menu.Header = "Seçenekler";
        devmode_menu.Header = "Geliştirici Modu";
        devmode_menu1.Header = devmode_menu.Header;
        devmode_never.Header = "Ana powershell asla kapatmayın";
        devmode_clipboard.Header = "Komutları panoya kopyalayın";
        // MENU FINISH

        Select_OS.Text = "İşletim Sistemini Seçin";
        other.Content = "Diğer";

        Method_name.Text = "Bir Yöntem Seçin";
        onlywsa.Content = "Sadece WSA";

        reqT.Text = "Gereksinimler";
        vmp_check.Content = "Sanal Makine Platformunu Etkinleştir";
        devmods_check.Content = "WSA Geliştirici Modunu ve Windows Geliştirici Modunu Etkinleştirin";
        requireclick.Content = "Önkoşulları yükle";
        
        Optionals_title.Text = "İsteğe Bağlı";
        autosetup_check.Content = "İndirdikte Sonra Kur";
        adb_check.Content = "Android platform araçlarını indirin ve kurun + PATH ekle (adb komutu)";
        wsatools_check.Content = "WSATools'u indirin ve kurun(apk alternatifi)";

        Customers_title.Text = "Özelleştirme";

        proname.Text = "Product İsim";
        wsa_username_func.Content = "Kullanıcı adımı yap";

        amazonname.Text = "Amazon AppStore Kaldır";

        wsatitle.Text = "WSA sürüm türünü seçin";

        magisk.Text = "Magisk sürümünü seçin";

        madeby.Text = "Winfried tarafından yapılmıştır. GNU Affero Genel Kamu Lisansı v3.0 altında lisanslanmıştır";

        reset_button.Content = "Reset";
        Ready_button.Content = "Hazır!";
        Cancel_button.Content = "Çıkış";

    }
    
    private void Language_English()
    {
        Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en");
        // MENUS
        Lang.Header = "Language";
        lang_en.Header = "English";
        lang_tr.Header = "Turkish";

        Arch_title.Header = "Arch";

        Dal_title.Header = "Downloads and Links";
        msstore_pwsh.Header = "MS Store for Powershell core";
        msstore_wsl.Header = "MS Store for WSL";
        msstore_wsa.Header = "MS Store for WSA";
        msstore_ubuntu.Header = "MS Store for Ubuntu";
        msstore_debian.Header = "MS Store for Debian";
        msstore_opensusetw.Header = "MS Store for OpenSUSE Tumbleweed";
        msstore_gapps.Header = "Go to openGAPPS";
        msstore_rgadguard.Header = "Go to rg-adguard page";

        About_menu.Header = "About";
        MyGithub.Header = "My Github";
        ProjectPageM.Header = "Project Page";
        LicenceM.Header = "License";
        EProjectPageM.Header = "EasierWsaInstaller " + ProjectPageM.Header;
        DonateM.Header = "Donate";
        Aboutm.Header = About_menu.Header;

        Options_menu.Header = "Options";
        devmode_menu.Header = "Developer Mode";
        devmode_menu1.Header = devmode_menu.Header;
        devmode_never.Header = "Never close the main powershell";
        devmode_clipboard.Header = "Copy the commands to the clipboard";
        // MENU FINISH

        Select_OS.Text = "Select Operating System";
        other.Content = "Other";

        Method_name.Text = "Choose a Method";
        onlywsa.Content = "Only WSA";

        reqT.Text = "Requirements";
        vmp_check.Content = "Enable Virtual Machine Platform";
        devmods_check.Content = "Enable WSA Developer Mode And Windows Developer Mode";
        requireclick.Content = "Set up prerequisite";

        Optionals_title.Text = "Optional";
        autosetup_check.Content = "Install after download";
        adb_check.Content = "Download and install Android platform tools + adds path (adb command)";
        wsatools_check.Content = "Download and install WSATools(apk alternative)";

        Customers_title.Text = "Customers";

        proname.Text = "Product Name";
        wsa_username_func.Content = "Make my username";

        amazonname.Text = "Remove Amazon AppStore";

        wsatitle.Text = "Select WSA release type";

        magisk.Text = "Select Magisk version";

        madeby.Text = "Made by Winfried. Licensed under the GNU Affero General Public License v3.0";

        reset_button.Content = "Reset";
        Ready_button.Content = "Ready!";
        Cancel_button.Content = "Exit";

    }
    
    
    private void os_limit()
    {
        if (ubuntu.IsChecked.ToString() == "True")
        {
            debian.IsChecked = false;
            opensusetw.IsChecked = false;
            other.IsChecked = false;
            info_otherd.IsVisible = false;
            other_distro.IsVisible = false;
        } 
        else if (debian.IsChecked.ToString() == "True")

        {
            ubuntu.IsChecked = false;
            opensusetw.IsChecked = false;
            other.IsChecked = false;
            info_otherd.IsVisible = false;
            other_distro.IsVisible = false;
        }
        
        else if (opensusetw.IsChecked.ToString() == "True")
        {
            ubuntu.IsChecked = false;
            debian.IsChecked = false;
            other.IsChecked = false;
            info_otherd.IsVisible = false;
            other_distro.IsVisible = false;
        }
        else if (other.IsChecked.ToString() == "True")
        {
            ubuntu.IsChecked = false;
            debian.IsChecked = false;
            opensusetw.IsChecked = false;
            info_otherd.IsVisible = true;
            other_distro.IsVisible = true;
        }
        else
        {
            ubuntu.IsChecked = true;
            debian.IsChecked = false;
            opensusetw.IsChecked = false;
            info_otherd.IsVisible = false;
            other_distro.IsVisible = false;
        }
    }

    private void opengapps_select()
    {
        if (onlywsa.IsChecked.ToString() == "True")
        {
            aroma.IsEnabled = false;
            full.IsEnabled = false;
            nano.IsEnabled = false;
            super.IsEnabled = false;
            mini.IsEnabled = false;
            pico.IsEnabled = false;
            stock.IsEnabled = false;
            micro.IsEnabled = false;
            noneg.IsChecked = true;  
        }
        else
        {
            aroma.IsEnabled = false;
            full.IsEnabled = true;
            nano.IsEnabled = true;
            super.IsEnabled = true;
            mini.IsEnabled = true;
            pico.IsEnabled = true;
            stock.IsEnabled = true;
            micro.IsEnabled = true;
            if (noneg.IsChecked.ToString() == "True") {
            noneg.IsChecked = false; 
            pico.IsChecked = true;
            }
        }
     
    }
    
    private void devmod_button_select()
    {
        if (onlywsa.IsChecked.ToString() == "True")
        {
            devmods_check.IsChecked = false;
            devmods_check.IsEnabled = false;
        }
        else if (magiskonwsalocal.IsChecked.ToString() == "True")
        {
            devmods_check.IsChecked = true;
            devmods_check.IsEnabled = false;
        }
        else
        {
            devmods_check.IsEnabled = true;
        }
     
    }

   string username = System.Environment.UserName.ToString();

   private string Pc_Lang = Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName.ToString();
   private string alert_message(int Number)
   {
       Pc_Lang = Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName.ToString();
       if (Number == 0) {
           // Important Information
       if (Pc_Lang == "tr")
       {
           return "Önemli Bilgi";
       }
       else
       {
           return "Important Information";
       }
       }
       else if (Number == 1) {
           // Are you sure?
           if (Pc_Lang == "tr")
           {
               return "Emin misin?";
           }
           else
           {
               return "Are you sure?";
           }
       }
       else if (Number == 2) {
           // Welcome Message
           if (Pc_Lang == "tr")
           {
               return "Kurulum sırasında gerekli programların kurulu olduğundan emin olunuz.\nBunlardan bazıları Powershell (core), WSL, WSL Dağıtım, vb. \nDaha fazla bilgi için proje sayfasını kontrol edin.";
           }
           else
           {
               return "Make sure that the necessary programs are installed while installing.\nSome of them are Powershell (core), \nWSL, WSL Distro, etc.. For more information, check the project page.";
           }
       }
       else if (Number == 3) {
           // Other OS Warn Message
           if (Pc_Lang == "tr")
           {
               return "Lütfen seçtiğiniz dağıtım üzerinde gerekli paketlerin kurulu olduğundan emin olunuz.\nİlk üç seçenek dışında size herhangi bir resmi destek sağlanmamaktadır.\nDaha fazla bilgi için EasierWsaInstaller projesini inceleyiniz.";
           }
           else
           {
               return "Please make sure the required packages are installed on the distribution you selected.\nNo official support is provided to you, except for the first three options.\nCheck out the EasierWsaInstaller project for more information.";
           }
       }
       else if (Number == 4)
       {
           // VMP Warning Message
           if (Pc_Lang == "tr")
           {
               return
                   "Sanal Makine Platformu gerçekten kapalı ise kurulum yapılamaz.\nNe yaptığınızı bilmiyorsanız vazgeçin.";
           }
           else
           {
               return
                   "If the Virtual Machine Platform is indeed turned off, the installation cannot be performed.\nIf you don't know what you're doing, give up.";
           }
}
       else if (Number == 5)
       {
           // Devmods Warning Message
           if (Pc_Lang == "tr")
           {
               return
                   "Dosyalar değiştirileceği için Windows geliştirici Modu etkin olmalıdır. Aksi takdirde kurulamaz.\nAPK Yüklenirken WSA Geliştirici Modu etkinleştirilmelidir.\nAksi takdirde kurulamaz.";
           }
           else
           {
               return
                   "Windows developer Mode must be active as the files will be modified. otherwise it cannot be installed.\nWSA Developer Mode must be enabled while Installing the APK.\notherwise it cannot be installed.";
           }
       }
       else if (Number == 6)
       {
           // reset Warning Message
           if (Pc_Lang == "tr")
           {
               return
                   "Her Şeyi varsayılan döndürme istediğinden emin misin?\nTüm değiştirdiğin ayarlar sıfırlancak.";
           }
           else
           {
               return
                   "Are you sure you want to return everything to default?\nAll the settings you changed will be reset.";
           }
       }
       else if (Number == 7)
           {
               // Redirecting Title
               if (Pc_Lang == "tr")
               {
                   return
                       "Bir Web Sayfasına Yönlendirmeler";
               }
               else
               {
                   return
                       "Redirects to a Web Page";
               }
           }
       else if (Number == 8)
       {
           // Redirecting Desc
           if (Pc_Lang == "tr")
           {
               return
                   "Sizi bir web sayfasına yönlendirir";
           }
           else
           {
               return
                   "Redirect you to a webpage";
           }
       }
       else if (Number == 9)
       {
           // Ready Button desc
           if (Pc_Lang == "tr")
           {
               return
                   "Okey düğmesine bastığınızda. İşlem başlayacak, lütfen tüm sistem gereksinimlerini karşılamanız gerektiğini unutmayın. WSL dağıtımını yanlış seçerseniz vs. Hata yaparsanız işlem başarısız olur.\n\nİşlem başladığında sistem sizden kullanıcı hesabınızın şifresini isteyebilir(WSL Dağıtımınız), bu yüzden açılacak ekranı kontrol ediniz.";
           }
           else
           {
               return
                   "When you press the OK button. The process will start, please note that you must meet all system requirements. If you choose WSL distribution wrong etc. If you make a mistake, the process will fail.\n\nWhen the process starts, the system may ask you for your user account password(WSL Distro), so check the screen that will open.";
           }
       }
       else if (Number == 10)
       {
           // Ready button title
           if (Pc_Lang == "tr")
           {
               return
                   "Başlamadan Önce";
           }
           else
           {
               return
                   "Before you start";
           }
       }
       else if (Number == 11)
       {
           // arch
           if (Pc_Lang == "tr")
           {
               return
                   "Otomatik kurulum gerçekleşeceği için seçeceğiniz arch sistem kurmaya çalışan başarısız olmanıza sonuç açabilir.";
           }
           else
           {
               return
                   "Since automatic installation will take place, trying to install the arch system you choose may result in your failure.";
           }
       }
       
       else if (Number == 12)
       {
           // Redirecting Desc
           if (Pc_Lang == "tr")
           {
               return
                   "Sizin için önkoşulları yüklemesi gereken basit bir betik. Deneysel unutmayın!\nBu komut dosyası, Projenin gerektirdiği tüm bağımlılıkları yüklemeyi amaçlamaktadır.\nSadece kurulacak WSL dağıtımının Kullanıcı hesabını oluşturmanız yeterlidir.";
           }
           else
           {
               return
                   "A simple script that should install the prerequisites for you. Remember experimental!\nThis script aims to install all the dependencies required by the Project.\nYou only need to create the User account of the WSL distribution to be installed.";
           }
       }
       else
       {
           return "";
       }
   }

   private string alert_link(string url)
   {
       return string.Format(alert_message(8) + ": {0}", url);
   }
   private void OpenURL(string url)
   {
       var uri = url;
       var psi = new ProcessStartInfo();
       psi.UseShellExecute = true;
       psi.FileName = uri;
       Process.Start(psi);
   }
    private string get_product_name()
    {
        string name = wsa_username.Text;
        string result = Regex.Replace(name, @"[^A-Za-z\\/,]+|( )+", "$1").Trim();
        return result;
    }

    private string resultAll()
    {
        string selectos;
        if (ubuntu.IsChecked.ToString() == "True")
        {
            selectos = "Ubuntu";
        }
        else if (debian.IsChecked.ToString() == "True")
        {
            selectos = "Debian";
        }
        else if (opensusetw.IsChecked.ToString() == "True")
        {
            selectos = "openSUSE-Tumbleweed";
        }
        else
        {
            selectos = other_distro.Text.ToString();
        }

        string selectarch;

        if (arch_arm.IsChecked.ToString() == "True")
        {
            selectarch = "arm64";
        }
        else if (arch_x64.IsChecked.ToString() == "True")
        {
            selectarch = "amd64";
        }
        else
        {
            selectarch = "arm64";
        }
        string selectmethod;

        if (magiskonwsalocal.IsChecked.ToString() == "True")
        {
            selectmethod = "magiskonwsalocal";
        }
        else if (wsagascript.IsChecked.ToString() == "True")
        {
            selectmethod = "wsagascript";
        }
        else
        {
            selectmethod = "onlywsa";
        }

        string selectvariant;

        if (aroma.IsChecked.ToString() == "True")
        {
            selectvariant = "aroma";
        }
        else if (full.IsChecked.ToString() == "True")
        {
            selectvariant = "full";
        }
        else if (nano.IsChecked.ToString() == "True")
        {
            selectvariant = "nano";
        }
        else if (super.IsChecked.ToString() == "True")
        {
            selectvariant = "super";
        }
        else if (mini.IsChecked.ToString() == "True")
        {
            selectvariant = "mini";
        }
        else if (pico.IsChecked.ToString() == "True")
        {
            selectvariant = "pico";
        } else if (stock.IsChecked.ToString() == "True")
        {
            selectvariant = "stock";
        } else if (micro.IsChecked.ToString() == "True")
        {
            selectvariant = "micro";
        }
        else
        {
            selectvariant = "pico";
        }

        string selectlang;
        Pc_Lang = Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName.ToString();
        if (Pc_Lang == "tr")
        {
            selectlang = "tr-tr";
        }
        else
        {
            selectlang = "en-us";
        }
        
        
        string valueVMP;

        if (vmp_check.IsChecked.ToString() == "True")
        {
            valueVMP = "yes";
        }
        else
        {
            valueVMP = "no";
        }
        
        string valueDEVMODE;

        if (devmods_check.IsChecked.ToString() == "True")
        {
            valueDEVMODE = "yes";
        }
        else
        {
            valueDEVMODE = "no";
        }
        
        string selectAutoMode;

        if (autosetup_check.IsChecked.ToString() == "True")
        {
            selectAutoMode = "yes";
        }
        else
        {
            selectAutoMode = "no";
        }
         
        string selectadb;

        if (adb_check.IsChecked.ToString() == "True")
        {
            selectadb = "yes";
        }
        else
        {
            selectadb = "no";
        }
         
        string selectwsatools;

        if (wsatools_check.IsChecked.ToString() == "True")
        {
            selectwsatools = "yes";
        }
        else
        {
            selectwsatools = "no";
        }
         
        string selectwsausername = wsa_username.Text.ToString();

        string selectwsaRelease;
        if (wsa_release_status.SelectedIndex == 0)
        {
            selectwsaRelease = "fast";
        } else if (wsa_release_status.SelectedIndex == 1)
        {
            selectwsaRelease = "slow";
        }
        else if (wsa_release_status.SelectedIndex == 2)
        {
            selectwsaRelease = "rp";
        }
        else if (wsa_release_status.SelectedIndex == 3)
        {
            selectwsaRelease = "retail";
        }
        else
        {
            selectwsaRelease = "retail";
        }
        string selectAmazonStore;

        if (amazonstore_status.SelectedIndex == 0)
        {
            selectAmazonStore = "yes";
        }
        else
        {
            selectAmazonStore = "no";
        }

        string selectMagiskVersion;

        if (magisk_status.SelectedIndex == 0)
        {
            selectMagiskVersion = "stable";
        }
        else if (magisk_status.SelectedIndex == 1)
        {
            selectMagiskVersion = "beta";
        }
        else if (magisk_status.SelectedIndex == 2)
        {
            selectMagiskVersion = "canary";
        }
        else if (magisk_status.SelectedIndex == 3)
        {
            selectMagiskVersion = "debug";
        }
        else if (magisk_status.SelectedIndex == 4)
        {
            selectMagiskVersion = "release";
        }
        else
        {
            selectMagiskVersion = "stable";
        }
        string result;

        result = "-scriptLanguage " + selectlang + " ";
        result += "-distro " + selectos + " ";
        result += "-arch " + selectarch + " ";
        result += "-method " + selectmethod + " ";
        result += "-gappsvariant " + selectvariant + " ";
        result += "-winvmp " + valueVMP + " ";
        result += "-windevmode " + valueDEVMODE + " ";
        result += "-autosetup " + selectAutoMode + " ";
        result += "-adb " + selectadb + " ";
        result += "-wsatools " + selectwsatools + " ";
        result += "-productname " + selectwsausername + " ";
        result += "-amazonstore " + selectAmazonStore + " ";
        result += "-wsarelease " + selectwsaRelease + " ";
        result += "-magiskversion " + selectMagiskVersion + " ";
        return result;
    }
    private void arch_control()
    {
        string systemarch = System.Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE").ToString().ToLower();
        if (systemarch == "amd64")
        {
            arch_x64.IsChecked = true;
        }
        else if (systemarch == "arm64")
        {
            arch_arm.IsChecked = true;
        }
        else
        {
            arch_x64.IsChecked = true;
        }
    }

    private void magisk_select()
    {
        if (onlywsa.IsChecked.ToString() == "True" || wsagascript.IsChecked.ToString() == "True")
        {
            magisk.IsVisible = false;
            magisk_status.IsVisible = false;
        }
        else
        {
            magisk.IsVisible = true;
            magisk_status.IsVisible = true;
        }
    }

    private void wsausername_amazon_select()
    {
        if (onlywsa.IsChecked.ToString() == "True")
        {
            proname.IsVisible = false;
            wsa_username.IsVisible = false;
            wsa_username_func.IsVisible = false;

            amazonname.IsVisible = false;
            amazonstore_status.IsVisible = false;

        }
        else
        {
            proname.IsVisible = true;
            wsa_username.IsVisible = true;
            wsa_username_func.IsVisible = true;

            amazonname.IsVisible = true;
            amazonstore_status.IsVisible = true;
        }
    }
    public MainWindow()
    {
        InitializeComponent();
     
    }

    private async void Ready_Button_OnClick(object? sender, RoutedEventArgs e)
    {
        string TextShellNoExit;
        if (string.IsNullOrEmpty(wsa_username.Text))
                 {
                     wsa_username.Text = "redfin";
                 }
        if (noexit_pwsh.IsChecked.ToString() == "True")
        {
            TextShellNoExit = " -noexit ";
        }
        else
        {
            TextShellNoExit = "";
        }
        string execCommand = "Start-Process pwsh.exe -verb runas -ArgumentList '" + TextShellNoExit + "-c ";
        execCommand += "Invoke-WebRequest https://raw.githubusercontent.com/herrwinfried/EasierWsaInstaller/alpha/src/EasierWsaInstaller/guiSupport/setup.ps1 -OutFile $env:TEMP/setup.ps1 && cd $env:TEMP && ./setup.ps1 " + resultAll().ToString() + " && cd $env:TEMP && Remove-Item ./setup.ps1;";
        execCommand += "'";
        
        if (devmode_mod.IsChecked.ToString() == "True")
        {
            await MessageBox.Avalonia.MessageBoxManager.GetMessageBoxStandardWindow(
                new MessageBoxStandardParams
                {
                    ButtonDefinitions = MessageBoxAvaloniaEnums.ButtonEnum.Ok,
                    ContentTitle = "Dev Mode - Read Command",
                    ContentHeader = "Dev Mode - Read Command",
                    ContentMessage = execCommand.ToString(),
                    CanResize = false,
                    Topmost = true,
                    MaxHeight = 300,
                    MaxWidth = 700,
                    WindowStartupLocation = WindowStartupLocation.CenterOwner,
                    Icon = MessageBoxAvaloniaEnums.Icon.Success,
                }).ShowDialog(this);
        }
        if (dev_copy.IsChecked.ToString() == "True")
        {
            await MessageBox.Avalonia.MessageBoxManager.GetMessageBoxStandardWindow(
                new MessageBoxStandardParams
                {
                    ButtonDefinitions = MessageBoxAvaloniaEnums.ButtonEnum.Ok,
                    ContentTitle = "Clipboard",
                    ContentHeader = "Clipboard",
                    ContentMessage = "Copy Clipboard successful.",
                    CanResize = false,
                    Topmost = true,
                    SizeToContent = SizeToContent.WidthAndHeight,
                    WindowStartupLocation = WindowStartupLocation.CenterOwner,
                    Icon = MessageBoxAvaloniaEnums.Icon.Success,
                }).ShowDialog(this);
            ClipboardService.SetText(execCommand.ToString());
        }
        
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows) == true)
        {
            
            var messageBoxStandardWindow = MessageBox.Avalonia.MessageBoxManager.GetMessageBoxStandardWindow(
                new MessageBoxStandardParams
                {
                    ButtonDefinitions = MessageBoxAvaloniaEnums.ButtonEnum.OkCancel,
                    ContentTitle = alert_message(10),
                    ContentHeader = alert_message(10),
                    ContentMessage = alert_message(9),
                    CanResize = false,
                    Topmost = true,
                    MaxHeight = 300,
                    MaxWidth = 700,
                    WindowStartupLocation = WindowStartupLocation.CenterOwner,
                    Icon = MessageBoxAvaloniaEnums.Icon.Warning,
                });
            var resux = await messageBoxStandardWindow.ShowDialog(this);
            if (resux == ButtonResult.Ok)
            {
                var uri = "powershell.exe";
                var psi = new System.Diagnostics.ProcessStartInfo();
                psi.UseShellExecute = false;
                psi.FileName = uri;
                psi.Arguments = execCommand.ToString();
                Process ps = System.Diagnostics.Process.Start(psi);
                ps.WaitForExit();
            }
        }
    

    }

    /*private void Menu_OnClick(object? sender, RoutedEventArgs e)
    {
        if (Lang_en_b.IsChecked.ToString().ToLower() == "true")
        {
            Lang_en_b.IsChecked = false;
        }
        else
        {
            Lang_en_b.IsChecked = true; 
        }
        
        
    }*/

    private void Exit_button_OnClick(object? sender, RoutedEventArgs e)
    {
        this.Close();
    }


    private void Lang_tr_OnClick(object? sender, RoutedEventArgs e)
    {
        
        Language_Turkish();
    }

    private void Lang_en_OnClick(object? sender, RoutedEventArgs e)
    {
        Language_English();
    }

    
    private async void Arch_x64_OnClick(object? sender, RoutedEventArgs e)
    {
        string systemarch = System.Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE").ToString().ToLower();
        
        if (autosetup_check.IsChecked.ToString() == "True")
        {
            var messageBoxStandardWindow = MessageBox.Avalonia.MessageBoxManager.GetMessageBoxStandardWindow(
                new MessageBoxStandardParams
                {
                    ButtonDefinitions = MessageBoxAvaloniaEnums.ButtonEnum.YesNo,
                    ContentTitle = alert_message(0),
                    ContentHeader = alert_message(0),
                    ContentMessage = alert_message(11),
                    CanResize = false,
                    Topmost = true,
                    SizeToContent = SizeToContent.WidthAndHeight,
                    WindowStartupLocation = WindowStartupLocation.CenterOwner,
                    Icon = MessageBoxAvaloniaEnums.Icon.Warning,
                });
            var resux = await messageBoxStandardWindow.ShowDialog(this);
            if (resux == ButtonResult.Yes)
            {
                if (arch_x64.IsChecked.ToString() == "True")
                {
                    arch_x64.IsChecked = false;
                    arch_arm.IsChecked = true;
                }
                else
                {
                    arch_x64.IsChecked = true;
                    arch_arm.IsChecked = false;
                }
            }
        } else if (arch_x64.IsChecked.ToString() == "True")
        {
            arch_x64.IsChecked = false;
            arch_arm.IsChecked = true;
        }
        else
        {
            arch_x64.IsChecked = true;
            arch_arm.IsChecked = false;
        }

    }
    private async void Arm_OnClick(object? sender, RoutedEventArgs e)
    {
        string systemarch = System.Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE").ToString().ToLower();

        if (autosetup_check.IsChecked.ToString() == "True" )
        {
            var messageBoxStandardWindow = MessageBox.Avalonia.MessageBoxManager.GetMessageBoxStandardWindow(
                new MessageBoxStandardParams
                {
                    ButtonDefinitions = MessageBoxAvaloniaEnums.ButtonEnum.YesNo,
                    ContentTitle = alert_message(0),
                    ContentHeader = alert_message(0),
                    ContentMessage = alert_message(11),
                    CanResize = false,
                    Topmost = true,
                    SizeToContent = SizeToContent.WidthAndHeight,
                    WindowStartupLocation = WindowStartupLocation.CenterOwner,
                    Icon = MessageBoxAvaloniaEnums.Icon.Warning,
                });
            var resux = await messageBoxStandardWindow.ShowDialog(this);
            if (resux == ButtonResult.Yes)
            {
                if (arch_arm.IsChecked.ToString() == "True")
                {
                    arch_arm.IsChecked = false;
                    arch_x64.IsChecked = true;
                }
                else
                {
                    arch_arm.IsChecked = true;
                    arch_x64.IsChecked = false;
                }
            }
        } else if (arch_arm.IsChecked.ToString() == "True")
        {
            arch_arm.IsChecked = false;
            arch_x64.IsChecked = true;
        }
        else
        {
            arch_arm.IsChecked = true;
            arch_x64.IsChecked = false;
        }
    }

    private void Devmode_mod_OnClick(object? sender, RoutedEventArgs e)
    {
        if (devmode_mod.IsChecked.ToString() == "True")
        {
            devmode_mod.IsChecked = false;
        }
        else
        {
            devmode_mod.IsChecked = true;
        }
    }

    private void Noexit_pwsh_OnClick(object? sender, RoutedEventArgs e)
    {
        if (noexit_pwsh.IsChecked.ToString() == "True")
        {
            noexit_pwsh.IsChecked = false;
        }
        else
        {
            noexit_pwsh.IsChecked = true;
        }
    }
    

    private void Dev_copy_OnClick(object? sender, RoutedEventArgs e)
    {
        if (dev_copy.IsChecked.ToString() == "True")
        {
            dev_copy.IsChecked = false;
        }
        else
        {
            dev_copy.IsChecked = true;
        }
    }

    private async void Reset_button_OnClick(object? sender, RoutedEventArgs e)
    {

        var messageBoxStandardWindow = MessageBox.Avalonia.MessageBoxManager.GetMessageBoxStandardWindow(
            new MessageBoxStandardParams
            {
                
               ButtonDefinitions = MessageBoxAvaloniaEnums.ButtonEnum.YesNo,
                ContentTitle = alert_message(1),
                ContentHeader = alert_message(1),
                ContentMessage = alert_message(6),
                CanResize = false,
                Topmost = true,
                SizeToContent = SizeToContent.WidthAndHeight,
                WindowStartupLocation = WindowStartupLocation.CenterOwner,
                Icon = MessageBoxAvaloniaEnums.Icon.Warning,
            });
        var resux = await messageBoxStandardWindow.ShowDialog(this);

        if (resux == ButtonResult.Yes)
        {
            this.Hide();
            MainWindow a = new MainWindow();
            a.Show();
            this.Close();
        }
    }


    private void Ubuntu_OnClick(object? sender, RoutedEventArgs e)
    {
      os_limit();
    }

    private void Debian_OnClick(object? sender, RoutedEventArgs e)
    {
        os_limit();
    }

    private void Opensusetw_OnClick(object? sender, RoutedEventArgs e)
    {
        os_limit();
    }

    private async void Other_OnClick(object? sender, RoutedEventArgs e)
    {
        var messageBoxStandardWindow = MessageBox.Avalonia.MessageBoxManager.GetMessageBoxStandardWindow(
            new MessageBoxStandardParams
            {
                ButtonDefinitions = MessageBoxAvaloniaEnums.ButtonEnum.Ok,
                ContentTitle = alert_message(0),
                ContentHeader = alert_message(0),
                ContentMessage = alert_message(3),
                CanResize = false,
                Topmost = true,
                SizeToContent = SizeToContent.WidthAndHeight,
                WindowStartupLocation = WindowStartupLocation.CenterOwner,
                Icon = MessageBoxAvaloniaEnums.Icon.Warning,
            });
        var resux = await messageBoxStandardWindow.ShowDialog(this);
        os_limit();  
       
        

    }

    private void Magiskonwsalocal_OnClick(object? sender, RoutedEventArgs e)
    {
        opengapps_select();
        devmod_button_select();
        magisk_select();
        wsausername_amazon_select();
    }

    private void Wsagascript_OnClick(object? sender, RoutedEventArgs e)
    {
        opengapps_select();
        devmod_button_select();
        magisk_select();
        wsausername_amazon_select();
    }

    private void Onlywsa_OnClick(object? sender, RoutedEventArgs e)
    {
        opengapps_select();
        devmod_button_select();
        magisk_select();
        wsausername_amazon_select();
    }
    private void Wsa_username_func_OnClick(object? sender, RoutedEventArgs e)
    {
        wsa_username.Text = username;
        wsa_username.Text = get_product_name();
    }

    private void Wsa_username_OnTextChanged(object? sender, TextChangedEventArgs e)
    {
        wsa_username.Text = get_product_name();
    }

    private async void Control_OnLoaded(object? sender, RoutedEventArgs e)
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows) == false)
        {
            WindowIcon.IsVisible = false;
            CloseButton.IsVisible = false;
            MinimizeButton.IsVisible = false;
            unsupport.IsVisible = true;
            devmode_clipboard.IsEnabled = false;
            requireclick.IsEnabled = false;
        }
        if (Pc_Lang == "tr")
        {
            Language_Turkish();
        }
        else
        {
           Language_English();
        }

        var messageBoxStandardWindow = MessageBox.Avalonia.MessageBoxManager.GetMessageBoxStandardWindow(
            new MessageBoxStandardParams
            {
                ButtonDefinitions = MessageBoxAvaloniaEnums.ButtonEnum.Ok,
                ContentTitle = alert_message(0),
                ContentHeader = alert_message(0),
                ContentMessage = alert_message(2),
                CanResize = false,
                Topmost = true,
                SizeToContent = SizeToContent.WidthAndHeight,
                WindowStartupLocation = WindowStartupLocation.CenterOwner,
                Icon = MessageBoxAvaloniaEnums.Icon.Warning,
            });
        var resux = await messageBoxStandardWindow.ShowDialog(this);

    }

    private async void Vmp_check_OnClick(object? sender, RoutedEventArgs e)
    {
        if (vmp_check.IsChecked.ToString() == "False") {
        var messageBoxStandardWindow = MessageBox.Avalonia.MessageBoxManager.GetMessageBoxStandardWindow(
            new MessageBoxStandardParams
            {
                ButtonDefinitions = MessageBoxAvaloniaEnums.ButtonEnum.YesNo,
                ContentTitle = alert_message(1),
                ContentHeader = alert_message(1),
                ContentMessage = alert_message(4),
                CanResize = false,
                Topmost = true,
                SizeToContent = SizeToContent.WidthAndHeight,
                WindowStartupLocation = WindowStartupLocation.CenterOwner,
                Icon = MessageBoxAvaloniaEnums.Icon.Warning,
            });
        var resux = await messageBoxStandardWindow.ShowDialog(this);

        if (resux == ButtonResult.Yes)
        {
            vmp_check.IsChecked = false;
        }
        else
        {
            vmp_check.IsChecked = true;
        }
    }
}

    private async void Devmods_check_OnClick(object? sender, RoutedEventArgs e)
    {
        if ((magiskonwsalocal.IsChecked.ToString() == "True" || wsagascript.IsChecked.ToString() == "True") 
            && (devmods_check.IsChecked.ToString() == "False")) {
            var messageBoxStandardWindow = MessageBox.Avalonia.MessageBoxManager.GetMessageBoxStandardWindow(
                new MessageBoxStandardParams
                {
                    ButtonDefinitions = MessageBoxAvaloniaEnums.ButtonEnum.YesNo,
                    ContentTitle = alert_message(1),
                    ContentHeader = alert_message(1),
                    ContentMessage = alert_message(5),
                    CanResize = false,
                    Topmost = true,
                    SizeToContent = SizeToContent.WidthAndHeight,
                    WindowStartupLocation = WindowStartupLocation.CenterOwner,
                    Icon = MessageBoxAvaloniaEnums.Icon.Warning,
                });
            var resux = await messageBoxStandardWindow.ShowDialog(this);

            if (resux == ButtonResult.Yes)
            {
                devmods_check.IsChecked = false;
            }
            else
            {
                devmods_check.IsChecked = true;
            }
        }
    }

    private async void Msstore_pwsh_OnClick(object? sender, RoutedEventArgs e)
    {
        string url = "https://www.microsoft.com/p/powershell/9mz1snwt0n5d";
        var messageBoxStandardWindow = MessageBox.Avalonia.MessageBoxManager.GetMessageBoxStandardWindow(
            new MessageBoxStandardParams
            {
                ButtonDefinitions = MessageBoxAvaloniaEnums.ButtonEnum.YesNo,
                ContentTitle = alert_message(7),
                ContentHeader = alert_message(7),
                ContentMessage = alert_link(url),
                CanResize = false,
                Topmost = true,
                SizeToContent = SizeToContent.WidthAndHeight,
                WindowStartupLocation = WindowStartupLocation.CenterOwner,
                Icon = MessageBoxAvaloniaEnums.Icon.Warning,
            });
        var resux = await messageBoxStandardWindow.ShowDialog(this);

        if (resux == ButtonResult.Yes)
        {
            OpenURL(url);
        }
    }

    private async void Msstore_wsl_OnClick(object? sender, RoutedEventArgs e)
    {
        string url = "https://aka.ms/wslstorepage";
        var messageBoxStandardWindow = MessageBox.Avalonia.MessageBoxManager.GetMessageBoxStandardWindow(
            new MessageBoxStandardParams
            {
                ButtonDefinitions = MessageBoxAvaloniaEnums.ButtonEnum.YesNo,
                ContentTitle = alert_message(7),
                ContentHeader = alert_message(7),
                ContentMessage = alert_link(url),
                CanResize = false,
                Topmost = true,
                SizeToContent = SizeToContent.WidthAndHeight,
                WindowStartupLocation = WindowStartupLocation.CenterOwner,
                Icon = MessageBoxAvaloniaEnums.Icon.Warning,
            });
        var resux = await messageBoxStandardWindow.ShowDialog(this);

        if (resux == ButtonResult.Yes)
        {
            OpenURL(url);
        }
    }

    private async void Msstore_wsa_OnClick(object? sender, RoutedEventArgs e)
    {
        string url = "https://www.microsoft.com/store/productId/9P3395VX91NR";
        var messageBoxStandardWindow = MessageBox.Avalonia.MessageBoxManager.GetMessageBoxStandardWindow(
            new MessageBoxStandardParams
            {
                ButtonDefinitions = MessageBoxAvaloniaEnums.ButtonEnum.YesNo,
                ContentTitle = alert_message(7),
                ContentHeader = alert_message(7),
                ContentMessage = alert_link(url),
                CanResize = false,
                Topmost = true,
                SizeToContent = SizeToContent.WidthAndHeight,
                WindowStartupLocation = WindowStartupLocation.CenterOwner,
                Icon = MessageBoxAvaloniaEnums.Icon.Warning,
            });
        var resux = await messageBoxStandardWindow.ShowDialog(this);

        if (resux == ButtonResult.Yes)
        {
            OpenURL(url);
        }
    }

    private async void Msstore_ubuntu_OnClick(object? sender, RoutedEventArgs e)
    {
        string url = "https://www.microsoft.com/p/ubuntu/9nblggh4msv6";
        var messageBoxStandardWindow = MessageBox.Avalonia.MessageBoxManager.GetMessageBoxStandardWindow(
            new MessageBoxStandardParams
            {
                ButtonDefinitions = MessageBoxAvaloniaEnums.ButtonEnum.YesNo,
                ContentTitle = alert_message(7),
                ContentHeader = alert_message(7),
                ContentMessage = alert_link(url),
                CanResize = false,
                Topmost = true,
                SizeToContent = SizeToContent.WidthAndHeight,
                WindowStartupLocation = WindowStartupLocation.CenterOwner,
                Icon = MessageBoxAvaloniaEnums.Icon.Warning,
            });
        var resux = await messageBoxStandardWindow.ShowDialog(this);

        if (resux == ButtonResult.Yes)
        {
            OpenURL(url);
        }
    }

    private async void Msstore_debian_OnClick(object? sender, RoutedEventArgs e)
    {
        string url = "https://www.microsoft.com/p/debian/9msvkqc78pk6";
        var messageBoxStandardWindow = MessageBox.Avalonia.MessageBoxManager.GetMessageBoxStandardWindow(
            new MessageBoxStandardParams
            {
                ButtonDefinitions = MessageBoxAvaloniaEnums.ButtonEnum.YesNo,
                ContentTitle = alert_message(7),
                ContentHeader = alert_message(7),
                ContentMessage = alert_link(url),
                CanResize = false,
                Topmost = true,
                SizeToContent = SizeToContent.WidthAndHeight,
                WindowStartupLocation = WindowStartupLocation.CenterOwner,
                Icon = MessageBoxAvaloniaEnums.Icon.Warning,
            });
        var resux = await messageBoxStandardWindow.ShowDialog(this);

        if (resux == ButtonResult.Yes)
        {
            OpenURL(url);
        }
    }

    private async void Msstore_opensusetw_OnClick(object? sender, RoutedEventArgs e)
    {
        string url = "https://www.microsoft.com/p/opensuse-tumbleweed/9mssk2zxxn11";
        var messageBoxStandardWindow = MessageBox.Avalonia.MessageBoxManager.GetMessageBoxStandardWindow(
            new MessageBoxStandardParams
            {
                ButtonDefinitions = MessageBoxAvaloniaEnums.ButtonEnum.YesNo,
                ContentTitle = alert_message(7),
                ContentHeader = alert_message(7),
                ContentMessage = alert_link(url),
                CanResize = false,
                Topmost = true,
                SizeToContent = SizeToContent.WidthAndHeight,
                WindowStartupLocation = WindowStartupLocation.CenterOwner,
                Icon = MessageBoxAvaloniaEnums.Icon.Warning,
            });
        var resux = await messageBoxStandardWindow.ShowDialog(this);

        if (resux == ButtonResult.Yes)
        {
            OpenURL(url);
        }
    }

    private async void Msstore_gapps_OnClick(object? sender, RoutedEventArgs e)
    {
        string url = "https://opengapps.org";
        var messageBoxStandardWindow = MessageBox.Avalonia.MessageBoxManager.GetMessageBoxStandardWindow(
            new MessageBoxStandardParams
            {
                ButtonDefinitions = MessageBoxAvaloniaEnums.ButtonEnum.YesNo,
                ContentTitle = alert_message(7),
                ContentHeader = alert_message(7),
                ContentMessage = alert_link(url),
                CanResize = false,
                Topmost = true,
                SizeToContent = SizeToContent.WidthAndHeight,
                WindowStartupLocation = WindowStartupLocation.CenterOwner,
                Icon = MessageBoxAvaloniaEnums.Icon.Warning,
            });
        var resux = await messageBoxStandardWindow.ShowDialog(this);

        if (resux == ButtonResult.Yes)
        {
            OpenURL(url);
        }
    }

    private async void Msstore_rgadguard_OnClick(object? sender, RoutedEventArgs e)
    {
        string url = "https://store.rg-adguard.net";
        var messageBoxStandardWindow = MessageBox.Avalonia.MessageBoxManager.GetMessageBoxStandardWindow(
            new MessageBoxStandardParams
            {
                ButtonDefinitions = MessageBoxAvaloniaEnums.ButtonEnum.YesNo,
                ContentTitle = alert_message(7),
                ContentHeader = alert_message(7),
                ContentMessage = alert_link(url),
                CanResize = false,
                Topmost = true,
                SizeToContent = SizeToContent.WidthAndHeight,
                WindowStartupLocation = WindowStartupLocation.CenterOwner,
                Icon = MessageBoxAvaloniaEnums.Icon.Warning,
            });
        var resux = await messageBoxStandardWindow.ShowDialog(this);

        if (resux == ButtonResult.Yes)
        {
            OpenURL(url);
        }
    }

    private async void MyGithub_OnClick(object? sender, RoutedEventArgs e)
    {
        string url = "https://github.com/herrwinfried";
        var messageBoxStandardWindow = MessageBox.Avalonia.MessageBoxManager.GetMessageBoxStandardWindow(
            new MessageBoxStandardParams
            {
                ButtonDefinitions = MessageBoxAvaloniaEnums.ButtonEnum.YesNo,
                ContentTitle = alert_message(7),
                ContentHeader = alert_message(7),
                ContentMessage = alert_link(url),
                CanResize = false,
                Topmost = true,
                SizeToContent = SizeToContent.WidthAndHeight,
                WindowStartupLocation = WindowStartupLocation.CenterOwner,
                Icon = MessageBoxAvaloniaEnums.Icon.Warning,
            });
        var resux = await messageBoxStandardWindow.ShowDialog(this);

        if (resux == ButtonResult.Yes)
        {
            OpenURL(url);
        }
    }

    private async void ProjectPageM_OnClick(object? sender, RoutedEventArgs e)
    {
        string url = "https://github.com/herrwinfried/EasierWsaInstallerGui";
        var messageBoxStandardWindow = MessageBox.Avalonia.MessageBoxManager.GetMessageBoxStandardWindow(
            new MessageBoxStandardParams
            {
                ButtonDefinitions = MessageBoxAvaloniaEnums.ButtonEnum.YesNo,
                ContentTitle = alert_message(7),
                ContentHeader = alert_message(7),
                ContentMessage = alert_link(url),
                CanResize = false,
                Topmost = true,
                SizeToContent = SizeToContent.WidthAndHeight,
                WindowStartupLocation = WindowStartupLocation.CenterOwner,
                Icon = MessageBoxAvaloniaEnums.Icon.Warning,
            });
        var resux = await messageBoxStandardWindow.ShowDialog(this);

        if (resux == ButtonResult.Yes)
        {
            OpenURL(url);
        }
    }

    private void LicenceM_OnClick(object? sender, RoutedEventArgs e)
    {
    
    }

    private async void EProjectPageM_OnClick(object? sender, RoutedEventArgs e)
    {
        string url = "https://github.com/herrwinfried/EasierWsaInstaller";
        var messageBoxStandardWindow = MessageBox.Avalonia.MessageBoxManager.GetMessageBoxStandardWindow(
            new MessageBoxStandardParams
            {
                ButtonDefinitions = MessageBoxAvaloniaEnums.ButtonEnum.YesNo,
                ContentTitle = alert_message(7),
                ContentHeader = alert_message(7),
                ContentMessage = alert_link(url),
                CanResize = false,
                Topmost = true,
                SizeToContent = SizeToContent.WidthAndHeight,
                WindowStartupLocation = WindowStartupLocation.CenterOwner,
                Icon = MessageBoxAvaloniaEnums.Icon.Warning,
            });
        var resux = await messageBoxStandardWindow.ShowDialog(this);

        if (resux == ButtonResult.Yes)
        {
            OpenURL(url);
        }
    }

    private void DonateM_OnClick(object? sender, RoutedEventArgs e)
    {
        donate a = new donate();
        a.ShowDialog(this);
    }

    private void Aboutm_OnClick(object? sender, RoutedEventArgs e)
    {
        about a = new about();
        a.ShowDialog(this);
    }

    private void MinimizeButton_OnClick(object? sender, RoutedEventArgs e)
    {
        Window hostWindow = (Window)this.VisualRoot;
        hostWindow.WindowState = WindowState.Minimized;
    }

    private async void Requireclick_OnClick(object? sender, RoutedEventArgs e)
    {
        var messageBoxStandardWindow = MessageBox.Avalonia.MessageBoxManager.GetMessageBoxStandardWindow(
            new MessageBoxStandardParams
            {
                ButtonDefinitions = MessageBoxAvaloniaEnums.ButtonEnum.OkCancel,
                ContentTitle = alert_message(10),
                ContentHeader = alert_message(10),
                ContentMessage = alert_message(12),
                CanResize = false,
                Topmost = true,
                SizeToContent = SizeToContent.WidthAndHeight,
                WindowStartupLocation = WindowStartupLocation.CenterOwner,
                Icon = MessageBoxAvaloniaEnums.Icon.Warning,
            });
        var resux = await messageBoxStandardWindow.ShowDialog(this);
        if (resux == ButtonResult.Ok)
        {
            string execCommand = "Start-Process pwsh.exe -verb runas -ArgumentList '" + " -noexit " + "-c ";
            execCommand += "Invoke-WebRequest https://raw.githubusercontent.com/herrwinfried/EasierWsaInstaller/alpha/src/EasierWsaInstaller/guiSupport/requirements.ps1 -OutFile $env:TEMP/requirements.ps1 && cd $env:TEMP && ./requirements.ps1 && cd $env:TEMP && Remove-Item ./requirements.ps1;";
            execCommand += "'";
            var uri = "powershell.exe";
            var psi = new System.Diagnostics.ProcessStartInfo();
            psi.UseShellExecute = false;
            psi.FileName = uri;
            psi.Arguments = execCommand.ToString();
            Process ps = System.Diagnostics.Process.Start(psi);
            ps.WaitForExit();
        }
    }
}

