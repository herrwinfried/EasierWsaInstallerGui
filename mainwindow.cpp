#include "mainwindow.h"
#include "ui_mainwindow.h"
#include <QMessageBox>
#include <QProcess>
#include <QDesktopServices>
MainWindow::MainWindow(QWidget *parent)
    : QMainWindow(parent)
    , ui(new Ui::MainWindow)
{
    ui->setupUi(this);
    ui->vmp->setChecked(true);
    ui->ubuntu->setChecked(true);
    ui->powershelllowanddefault->setChecked(true);
    ui->downloadgapps->setChecked(true);
    ui->downloadwsa->setChecked(true);
    ui->progressBar->setValue(0);
QMessageBox::warning(this, "Powershell 7+ is required", "since this program runs on Powershell 7+. Download Powershell from Microsoft store. If you have downloaded it, you can ignore this warning.");
}

MainWindow::~MainWindow()
{
    delete ui;
}


void MainWindow::on_buttonBox_rejected()
{
    QApplication::quit();
}


void MainWindow::on_ubuntu_clicked(bool checked)
{
    if (checked == true) {

        if (ui->downloadwsa->isChecked() == true && ui->downloadgapps->isChecked() == false) {
            QMessageBox::warning(this, "If you are going to continue with Ubuntu", "This is for ubuntu without version. Also make sure OpenGapps are under 'C:\\wsaproject'. \nand ubuntu must be installed on your computer.");
        }
         if (ui->downloadwsa->isChecked() == false && ui->downloadgapps->isChecked() == true) {
             QMessageBox::warning(this, "If you are going to continue with Ubuntu", "This is for ubuntu without version. Also make sure WSA are under 'C:\\wsaproject'. \nand ubuntu must be installed on your computer.");

        }
         if (ui->downloadwsa->isChecked() == false && ui->downloadgapps->isChecked() == false)
         {
             QMessageBox::warning(this, "If you are going to continue with Ubuntu", "This is for ubuntu without version. Also make sure WSA and OpenGapps are under 'C:\\wsaproject'. \nand ubuntu must be installed on your computer.");

         }

          ui->opensuse->setChecked(false);
          ui->nowsa->setChecked(false);
          ui->statusBar->showMessage("It will be done with Ubuntu. WSA process", 10000);
    }
}


void MainWindow::on_opensuse_clicked(bool checked)
{
    if (checked == true) {
        if (ui->downloadwsa->isChecked() == true && ui->downloadgapps->isChecked() == false) {
            QMessageBox::warning(this, "If you are going to continue with OpenSUSE Tumbleweed", "This is for MS version OpenSUSE Tumbleweed. Also make sure OpenGapps are under 'C:\\wsaproject'. \nand OpenSUSE Tumbleweed must be installed on your computer.");
        }
         if (ui->downloadwsa->isChecked() == false && ui->downloadgapps->isChecked() == true) {
             QMessageBox::warning(this, "If you are going to continue with OpenSUSE Tumbleweed", "This is for MS version OpenSUSE Tumbleweed. Also make sure WSA are under 'C:\\wsaproject'. \nand OpenSUSE Tumbleweed must be installed on your computer.");

        }
         if (ui->downloadwsa->isChecked() == false && ui->downloadgapps->isChecked() == false)
         {
             QMessageBox::warning(this, "If you are going to continue with OpenSUSE Tumbleweed", "This is for MS version OpenSUSE Tumbleweed. Also make sure WSA and OpenGapps are under 'C:\\wsaproject'. \nand OpenSUSE Tumbleweed must be installed on your computer.");

         }
          ui->ubuntu->setChecked(false);
          ui->nowsa->setChecked(false);
            ui->statusBar->showMessage("It will be done with openSUSE TW. WSA process", 10000);
    }
}


void MainWindow::on_nowsa_clicked(bool checked)
{
    if (checked == true){
    ui->ubuntu->setChecked(false);
    ui->opensuse->setChecked(false);
    ui->statusBar->showMessage("WSA transactions will not be performed.", 10000);
    }
}


void MainWindow::on_vmp_clicked(bool checked)
{
    if(ui->ubuntu->isChecked() || ui->opensuse->isChecked())
    {
        if (checked == false) {
            int ret = QMessageBox::warning(this, "Important Information", "Virtual Machine Platform is required for WSA and WSL to work. You can ignore this warning if it is already on.", QMessageBox::Yes | QMessageBox::No);
            switch (ret) {
              case QMessageBox::No:
                    ui->vmp->setChecked(true);
                  break;
              case QMessageBox::Yes:
                     ui->vmp->setChecked(false);
                  break;
              default:
                  // should never be reached
                  break;
            }
    }
        }
}


void MainWindow::on_nops_clicked(bool checked)
{
    if (checked == true) {

    }
}


void MainWindow::on_buttonBox_accepted()
{
  QString commandq;
  commandq = "Start-Process pwsh.exe -verb runas -ArgumentList '-c ";
  if (ui->powershelllow->isChecked() || ui->powershelllowanddefault->isChecked())
  {
    commandq = commandq + ";powershell.exe Set-ExecutionPolicy -ExecutionPolicy RemoteSigned -Scope LocalMachine";
  }
  ui->progressBar->setValue(15);
  if (ui->vmp->isChecked()) {
      commandq = commandq + ";dism.exe /online /enable-feature /featurename:VirtualMachinePlatform /all /norestart";
  }
  ui->progressBar->setValue(20);

  if (ui->ubuntu->isChecked() || ui->opensuse->isChecked() || ui->adb->isChecked())
  {
  //    commandq = commandq + ";mkdir $HOME/Downloads/wsagui";
  }
  ui->progressBar->setValue(20);

  if (ui->adb->isChecked()){
    commandq = commandq + ";Invoke-WebRequest https://raw.githubusercontent.com/herrwinfried/wsa-script/1.0.1/powershell/r31.0.3-windows.ps1 -OutFile $HOME/Downloads/r31.0.3-windows.ps1 && cd $HOME/Downloads && ./r31.0.3-windows.ps1 && Remove-Item ./r31.0.3-windows.ps1";
  }
  ui->progressBar->setValue(30);

if (ui->ubuntu->isChecked())
{
    if (ui->vmp->isChecked() == true)
    {
    if (ui->downloadwsa->isChecked() == true && ui->downloadgapps->isChecked() == true)
    {
        commandq = commandq + ";Invoke-WebRequest https://raw.githubusercontent.com/herrwinfried/wsa-script/1.0.1/powershell/automatic-ubuntu.ps1 -OutFile $HOME/Downloads/automatic-ubuntu.ps1 && cd $HOME/Downloads && ./automatic-ubuntu.ps1 1 1 0 && Remove-Item ./automatic-ubuntu.ps1";

    }
    else if (ui->downloadwsa->isChecked() == true)
    {
        commandq = commandq + ";Invoke-WebRequest https://raw.githubusercontent.com/herrwinfried/wsa-script/1.0.1/powershell/automatic-ubuntu.ps1 -OutFile $HOME/Downloads/automatic-ubuntu.ps1 && cd $HOME/Downloads && ./automatic-ubuntu.ps1 1 0 0 && Remove-Item ./automatic-ubuntu.ps1";

    }
    else if (ui->downloadgapps->isChecked() == true)
    {
        commandq = commandq + ";Invoke-WebRequest https://raw.githubusercontent.com/herrwinfried/wsa-script/1.0.1/powershell/automatic-ubuntu.ps1 -OutFile $HOME/Downloads/automatic-ubuntu.ps1 && cd $HOME/Downloads && ./automatic-ubuntu.ps1 0 1 0 && Remove-Item ./automatic-ubuntu.ps1";
    }
    else {

        commandq = commandq + ";Invoke-WebRequest https://raw.githubusercontent.com/herrwinfried/wsa-script/1.0.1/powershell/automatic-ubuntu.ps1 -OutFile $HOME/Downloads/automatic-ubuntu.ps1 && cd $HOME/Downloads && ./automatic-ubuntu.ps1 0 0 0 && Remove-Item ./automatic-ubuntu.ps1";
}
    }
    else {
        if (ui->downloadwsa->isChecked() == true && ui->downloadgapps->isChecked() == true)
        {
            commandq = commandq + ";Invoke-WebRequest https://raw.githubusercontent.com/herrwinfried/wsa-script/1.0.1/powershell/automatic-ubuntu.ps1 -OutFile $HOME/Downloads/automatic-ubuntu.ps1 && cd $HOME/Downloads && ./automatic-ubuntu.ps1 1 1 1 && Remove-Item ./automatic-ubuntu.ps1";

        }
        else if (ui->downloadwsa->isChecked() == true)
        {
            commandq = commandq + ";Invoke-WebRequest https://raw.githubusercontent.com/herrwinfried/wsa-script/1.0.1/powershell/automatic-ubuntu.ps1 -OutFile $HOME/Downloads/automatic-ubuntu.ps1 && cd $HOME/Downloads && ./automatic-ubuntu.ps1 1 0 1 && Remove-Item ./automatic-ubuntu.ps1";

        }
        else if (ui->downloadgapps->isChecked() == true)
        {
            commandq = commandq + ";Invoke-WebRequest https://raw.githubusercontent.com/herrwinfried/wsa-script/1.0.1/powershell/automatic-ubuntu.ps1 -OutFile $HOME/Downloads/automatic-ubuntu.ps1 && cd $HOME/Downloads && ./automatic-ubuntu.ps1 0 1 1 && Remove-Item ./automatic-ubuntu.ps1";
        }
        else {

            commandq = commandq + ";Invoke-WebRequest https://raw.githubusercontent.com/herrwinfried/wsa-script/1.0.1/powershell/automatic-ubuntu.ps1 -OutFile $HOME/Downloads/automatic-ubuntu.ps1 && cd $HOME/Downloads && ./automatic-ubuntu.ps1 0 0 1 && Remove-Item ./automatic-ubuntu.ps1";
    }
    }

    }


if (ui->opensuse->isChecked())
{
    if (ui->vmp->isChecked() == true)
    {
    if (ui->downloadwsa->isChecked() == true && ui->downloadgapps->isChecked() == true)
    {
        commandq = commandq + ";Invoke-WebRequest https://raw.githubusercontent.com/herrwinfried/wsa-script/1.0.1/powershell/automatic-opensusetw.ps1 -OutFile $HOME/Downloads/automatic-opensusetw.ps1 && cd $HOME/Downloads && ./automatic-opensusetw.ps1 1 1 0 && Remove-Item ./automatic-opensusetw.ps1";

    }
    else if (ui->downloadwsa->isChecked() == true)
    {
        commandq = commandq + ";Invoke-WebRequest https://raw.githubusercontent.com/herrwinfried/wsa-script/1.0.1/powershell/automatic-opensusetw.ps1 -OutFile $HOME/Downloads/automatic-opensusetw.ps1 && cd $HOME/Downloads && ./automatic-opensusetw.ps1 1 0 0 && Remove-Item ./automatic-opensusetw.ps1";

    }
    else if (ui->downloadgapps->isChecked() == true)
    {
        commandq = commandq + ";Invoke-WebRequest https://raw.githubusercontent.com/herrwinfried/wsa-script/1.0.1/powershell/automatic-opensusetw.ps1 -OutFile $HOME/Downloads/automatic-opensusetw.ps1 && cd $HOME/Downloads && ./automatic-opensusetw.ps1 0 1 0 && Remove-Item ./automatic-opensusetw.ps1";
    }
    else {

        commandq = commandq + ";Invoke-WebRequest https://raw.githubusercontent.com/herrwinfried/wsa-script/1.0.1/powershell/automatic-opensusetw.ps1 -OutFile $HOME/Downloads/automatic-opensusetw.ps1 && cd $HOME/Downloads && ./automatic-opensusetw.ps1 0 0 0 && Remove-Item ./automatic-opensusetw.ps1";
}
    }
    else {
        if (ui->downloadwsa->isChecked() == true && ui->downloadgapps->isChecked() == true)
        {
            commandq = commandq + ";Invoke-WebRequest https://raw.githubusercontent.com/herrwinfried/wsa-script/1.0.1/powershell/automatic-opensusetw.ps1 -OutFile $HOME/Downloads/automatic-opensusetw.ps1 && cd $HOME/Downloads && ./automatic-opensusetw.ps1 1 1 1 && Remove-Item ./automatic-opensusetw.ps1";

        }
        else if (ui->downloadwsa->isChecked() == true)
        {
            commandq = commandq + ";Invoke-WebRequest https://raw.githubusercontent.com/herrwinfried/wsa-script/1.0.1/powershell/automatic-opensusetw.ps1 -OutFile $HOME/Downloads/automatic-opensusetw.ps1 && cd $HOME/Downloads && ./automatic-opensusetw.ps1 1 0 1 && Remove-Item ./automatic-opensusetw.ps1";

        }
        else if (ui->downloadgapps->isChecked() == true)
        {
            commandq = commandq + ";Invoke-WebRequest https://raw.githubusercontent.com/herrwinfried/wsa-script/1.0.1/powershell/automatic-opensusetw.ps1 -OutFile $HOME/Downloads/automatic-opensusetw.ps1 && cd $HOME/Downloads && ./automatic-opensusetw.ps1 0 1 1 && Remove-Item ./automatic-opensusetw.ps1";
        }
        else {

            commandq = commandq + ";Invoke-WebRequest https://raw.githubusercontent.com/herrwinfried/wsa-script/1.0.1/powershell/automatic-opensusetw.ps1 -OutFile $HOME/Downloads/automatic-opensusetw.ps1 && cd $HOME/Downloads && ./automatic-opensusetw.ps1 0 0 1 && Remove-Item ./automatic-opensusetw.ps1";
    }
    }

    }
ui->progressBar->setValue(40);
if (ui->ubuntu->isChecked() || ui->opensuse->isChecked() || ui->adb->isChecked())
{
    //commandq = commandq + ";powershell.exe Remove-Item $HOME/Downloads/wsagui";
}
ui->progressBar->setValue(50);
if (ui->powershelllowanddefault->isChecked()) {
   commandq = commandq + ";powershell.exe Set-ExecutionPolicy -ExecutionPolicy Restricted -Scope LocalMachine";
}
ui->progressBar->setValue(60);

  commandq = commandq + "'";
 QMessageBox::warning(this, "will be written on the command line", commandq);
  QStringList parameters{commandq};
  QProcess *process = new QProcess(this);
  QString cmd("powershell.exe");
  process->start(cmd, parameters);
  ui->progressBar->setValue(100);
  if (ui->progressBar->value() == 100) {
       QMessageBox::information(this, "Successful", "Finish!");
       ui->progressBar->setValue(0);
        ui->statusBar->showMessage("Everything you want is set. If You Have Allowed Everything.", 20000);
   }
}


void MainWindow::on_downloadwsa_clicked(bool checked)
{
    if (checked == false) {
        if (ui->ubuntu->isChecked() || ui->opensuse->isChecked()) {
            int ret = QMessageBox::warning(this, "Important Information", "Are you sure you don't want to download? \nYou may encounter an error later", QMessageBox::Yes | QMessageBox::No);
            switch (ret) {
              case QMessageBox::No:
                    ui->downloadwsa->setChecked(true);
                  break;
              case QMessageBox::Yes:
                     ui->downloadwsa->setChecked(false);
                  break;
              default:
                  // should never be reached
                  break;
            }
        }
    }
}


void MainWindow::on_downloadgapps_clicked(bool checked)
{
    if (checked == false) {
        if (ui->ubuntu->isChecked() || ui->opensuse->isChecked()) {
       int ret = QMessageBox::warning(this, "Important Information", "Are you sure you don't want to download? \nYou may encounter an error later", QMessageBox::Yes | QMessageBox::No);
       switch (ret) {
         case QMessageBox::No:
               ui->downloadgapps->setChecked(true);
             break;
         case QMessageBox::Yes:
                ui->downloadgapps->setChecked(false);
             break;
         default:
             // should never be reached
             break;
       }
        }
    }

}


void MainWindow::on_nops_pressed()
{
    if(ui->ubuntu->isChecked() || ui->opensuse->isChecked() || ui->adb->isChecked())
    {
        int ret = QMessageBox::warning(this, "Important Information", "Security mode needs to be lowered to load scripts. It may fail if it is not dropped.", QMessageBox::Yes | QMessageBox::No);
        switch (ret) {
          case QMessageBox::No:

              break;
          case QMessageBox::Yes:
                 ui->nops->setChecked(true);
              break;
          default:
              // should never be reached
              break;
        }
    }
}



void MainWindow::on_mygithub_pressed()
{
    int ret = QMessageBox::question(this, "Redirects to a Web Page", "Redirect you to a webpage: http://github.com/HerrWinfried", QMessageBox::Ok | QMessageBox::Abort);
        switch (ret) {
          case QMessageBox::Abort:

              break;
          case QMessageBox::Ok:
                QDesktopServices::openUrl(QUrl("http://github.com/HerrWinfried"));
              break;
          default:
              // should never be reached
              break;
        }
}


void MainWindow::on_mswsl_pressed()
{
    int ret = QMessageBox::question(this, "Redirects to a Web Page", "Redirect you to a webpage: https://aka.ms/wslstorepage", QMessageBox::Ok | QMessageBox::Abort);
        switch (ret) {
          case QMessageBox::Abort:

              break;
          case QMessageBox::Ok:
                QDesktopServices::openUrl(QUrl("https://aka.ms/wslstorepage"));
              break;
          default:
              // should never be reached
              break;
        }
}


void MainWindow::on_msubuntu_pressed()
{
    int ret = QMessageBox::question(this, "Redirects to a Web Page", "Redirect you to a webpage: https://www.microsoft.com/en-us/p/ubuntu/9nblggh4msv6", QMessageBox::Ok | QMessageBox::Abort);
        switch (ret) {
          case QMessageBox::Abort:

              break;
          case QMessageBox::Ok:
                QDesktopServices::openUrl(QUrl("https://www.microsoft.com/en-us/p/ubuntu/9nblggh4msv6"));
              break;
          default:
              // should never be reached
              break;
        }
}


void MainWindow::on_msopensusetw_pressed()
{
    int ret = QMessageBox::question(this, "Redirects to a Web Page", "Redirect you to a webpage: https://www.microsoft.com/en-us/p/opensuse-tumbleweed/9mssk2zxxn11", QMessageBox::Ok | QMessageBox::Abort);
        switch (ret) {
          case QMessageBox::Abort:

              break;
          case QMessageBox::Ok:
                QDesktopServices::openUrl(QUrl("https://www.microsoft.com/en-us/p/opensuse-tumbleweed/9mssk2zxxn11"));
              break;
          default:
              // should never be reached
              break;
        }
}


void MainWindow::on_wsadownloadpage_pressed()
{
    int ret = QMessageBox::question(this, "Redirects to a Web Page", "Redirect you to a webpage: https://store.rg-adguard.net", QMessageBox::Ok | QMessageBox::Abort);
        switch (ret) {
          case QMessageBox::Abort:

              break;
          case QMessageBox::Ok:
                QDesktopServices::openUrl(QUrl("https://store.rg-adguard.net"));
              break;
          default:
              // should never be reached
              break;
        }
}


void MainWindow::on_gappsdownloadpage_pressed()
{
    int ret = QMessageBox::question(this, "Redirects to a Web Page", "Redirect you to a webpage: https://opengapps.org", QMessageBox::Ok | QMessageBox::Abort);
        switch (ret) {
          case QMessageBox::Abort:

              break;
          case QMessageBox::Ok:
                QDesktopServices::openUrl(QUrl("https://opengapps.org"));
              break;
          default:
              // should never be reached
              break;
        }

}

