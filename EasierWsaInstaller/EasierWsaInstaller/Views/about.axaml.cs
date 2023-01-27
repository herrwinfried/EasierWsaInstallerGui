using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Runtime.InteropServices;

namespace EasierWsaInstaller.Views;

public partial class about : Window
{
    public about()
    {
        InitializeComponent();
#if DEBUG
        this.AttachDevTools();
#endif
    }

   /* private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }*/
    private void CloseButton_OnClick(object? sender, RoutedEventArgs e)
    {
        this.Close();
    }

    private void Language_Turkish()
    {
        titledata.Text = "HAKKINDA";
        Bar1.Text = "EasierWsaInstallerGUI, aşağıdakiler için bir grafik arayüzdür";
        Bar2.Text = "deneysel EasierWsaInstaller.";
        Bar3.Text = "GNU Affero Genel Kamu Lisansı v3.0 altında lisanslanmıştır";
        Bar4.Text = "Winfried tarafından yapılmıştır.";
        Cancel_button.Content = "Tamam";
    }
    private void Language_English()
    {
        titledata.Text = "ABOUT";
        Bar1.Text = "EasierWsaInstallerGUI is a graphical interface for";
        Bar2.Text = "experimental EasierWsaInstaller.";
        Bar3.Text = "Licensed under the GNU Affero General Public License v3.0";
        Bar4.Text = "Made by Winfried";
        Cancel_button.Content = "Okey";
    }
    private void Control_OnLoaded(object? sender, RoutedEventArgs e)
    {
        version.Text = "ALPHA";
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