using System;
using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Globalization;
using System.Diagnostics;
using ReactiveUI;
using Avalonia.Markup.Xaml.MarkupExtensions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;

using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace EasierWsaInstaller.Views;
using EasierWsaInstaller.ViewModels;


public partial class MainWindow : Window
{
    private void Language_Turkish()
    {
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
        autosetup_check.Content = "İndirdikte Sonra Kur";

        Optionals_title.Text = "İsteğe Bağlı";
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
        unsupport.Text = "DESTEKLENMİYOR!!!";


    }

    private void Language_English()
    {
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
        autosetup_check.Content = "Install after download";

        Optionals_title.Text = "Optional";
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
        unsupport.Text = "NOT SUPPORT!!!";
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
    
    private string get_product_name()
    {
        string name = wsa_username.Text;
        string result = Regex.Replace(name, @"[^A-Za-z\\/,]+|( )+", "$1").Trim();
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

    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        if (string.IsNullOrEmpty(wsa_username.Text))
        {
            wsa_username.Text = "redfin";
        }
        
        string OS = Environment.OSVersion.Platform.ToString();
        if (OS == "Win32NT")
        {
        
        }
        else
        {
         
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

    private void Arch_x64_OnClick(object? sender, RoutedEventArgs e)
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
    private void Arm_OnClick(object? sender, RoutedEventArgs e)
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

    private void Reset_button_OnClick(object? sender, RoutedEventArgs e)
    {
        this.Hide();
        MainWindow a = new MainWindow();
        a.Show();
        this.Close();

        
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

    private void Other_OnClick(object? sender, RoutedEventArgs e)
    {
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

    private void Control_OnLoaded(object? sender, RoutedEventArgs e)
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows) == false)
        {
            unsupport.IsVisible = true;
           WindowIcon.IsVisible = false;
           CloseButton.IsVisible = false;
           MinimizeButton.IsVisible = false;
        }
        string Pc_Lang = System.Globalization.CultureInfo.CurrentUICulture.TwoLetterISOLanguageName;
        if (Pc_Lang.ToString() == "tr")
        { 
            Language_Turkish();
        }
        else
        {
          Language_English();
        }
    }

    private void MinimizeButton_OnClick(object? sender, RoutedEventArgs e)
    {
        Window hostWindow = (Window)this.VisualRoot;
        hostWindow.WindowState = WindowState.Minimized;
    }
}

