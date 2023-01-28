using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace EasierWsaInstaller.Views;

public partial class donate : Window
{
    public donate()
    {
        InitializeComponent();
#if DEBUG
        this.AttachDevTools();
#endif
    }
    private void OpenURL(string url)
    {
        var uri = url;
        var psi = new ProcessStartInfo();
        psi.UseShellExecute = true;
        psi.FileName = uri;
        Process.Start(psi);
    }
    
   /* private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }*/
    private void Language_Turkish()
    {
        titledata.Text = "BAĞIŞ";
        Bar1.Text = "Projeyi yaparken hiçbir zaman parayı düşünmedim.";
        Bar2.Text = "Bu yüzden bağış yapma seçeneği bırakmıyorum.";
        Bar3.Text = "Eğer gerçekten bağış yapmak istiyorsanız, Brave tarayıcısı ";
        Bar4.Text = "üzerinden github sayfasına bağışta bulunabilirsiniz";
        Cancelbutton.Content = "Tamam";
    }
    private void Language_English()
    {
        titledata.Text = "DONATE";
        Bar1.Text = "Me never thought in terms of money while building the project.";
        Bar2.Text = "That's why we don't leave an option to donate.";
        Bar3.Text = "If you really want to donate, you can donate to the";
        Bar4.Text = "github page through the Brave browser.";
        Cancelbutton.Content = "Okey";
    }  
    private void CloseButton_OnClick(object? sender, RoutedEventArgs e)
    {
         this.Close();
    }

    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        OpenURL("https://github.com/herrwinfried");
    }

    private void Control_OnLoaded(object? sender, RoutedEventArgs e)
    {
       if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows) == false)
        {
            Menu1.IsVisible = false;
            titledata.IsVisible = false;
        }
        if (System.Globalization.CultureInfo.CurrentUICulture.TwoLetterISOLanguageName.ToString() == "tr")
        {
            Language_Turkish();
        }
        else
        {
            Language_English();
        }
    }
}