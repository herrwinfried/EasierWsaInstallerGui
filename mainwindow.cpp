#include "mainwindow.h"
#include "ui_mainwindow.h"
#include <QMessageBox>
#include <QProcess>
MainWindow::MainWindow(QWidget *parent)
    : QMainWindow(parent)
    , ui(new Ui::MainWindow)
{
    ui->setupUi(this);
    ui->vmp->setChecked(true);
    ui->ubuntu->setChecked(true);
    ui->powershelllowanddefault->setChecked(true);
    ui->progressBar->setValue(0);
QMessageBox::warning(this, "Powershell 7+ is required", "since this program runs on Powershell 7+. Download Powershell from Microsoft store. If you have downloaded it, you can ignore this warning.");
QMessageBox::warning(this, "If you are going to continue with Ubuntu", "This is for ubuntu without version. Also make sure WSA and OpenGapps are under 'C:\\wsaproject'.");

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
          QMessageBox::warning(this, "If you are going to continue with Ubuntu", "This is for ubuntu without version. Also make sure WSA and OpenGapps are under 'C:\\wsaproject'. \nand ubuntu must be installed on your computer.");
          ui->opensuse->setChecked(false);
          ui->nowsa->setChecked(false);
          ui->statusBar->showMessage("It will be done with Ubuntu. WSA process", 10000);
    }
}


void MainWindow::on_opensuse_clicked(bool checked)
{
    if (checked == true) {
          QMessageBox::warning(this, "If you are going to continue with OpenSUSE Tumbleweed", "This is for MS version OpenSUSE Tumbleweed. Also make sure WSA and OpenGapps are under 'C:\\wsaproject'. \nand OpenSUSE Tumbleweed must be installed on your computer.");
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
        QMessageBox::warning(this, "Important Information", "Virtual Machine Platform is required for WSA and WSL to work. You can ignore this warning if it is already on.");
    }
        }
}


void MainWindow::on_nops_clicked(bool checked)
{
    if (checked == true) {
        if(ui->ubuntu->isChecked() || ui->opensuse->isChecked() || ui->adb->isChecked())
        {
            QMessageBox::warning(this, "Important Information", "Security mode needs to be lowered to load scripts. It may fail if it is not dropped.");
        }
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
    commandq = commandq + ";Invoke-WebRequest https://raw.githubusercontent.com/herrwinfried/android-platform-powershell/main/r31.0.3-windows.ps1 -OutFile $HOME/Downloads/r31.0.3-windows.ps1 && cd $HOME/Downloads && ./r31.0.3-windows.ps1 && Remove-Item ./r31.0.3-windows.ps1";
  }
  ui->progressBar->setValue(30);

if (ui->ubuntu->isChecked())
{
    commandq = commandq + ";powershell.exe Invoke-WebRequest https://raw.githubusercontent.com/herrwinfried/wsa-script/main/automatic-ubuntu.ps1 -OutFile $HOME/Downloads/automatic-ubuntu.ps1 && cd $HOME/Downloads && ./automatic-ubuntu.ps1 && Remove-Item ./automatic-ubuntu.ps1";
}
if (ui->opensuse->isChecked())
{
        commandq = commandq + ";powershell.exe Invoke-WebRequest https://raw.githubusercontent.com/herrwinfried/wsa-script/main/automatic-opensusetw.ps1 -OutFile $HOME/Downloads/automatic-ubuntu.ps1 && cd $HOME/Downloads && ./automatic-opensusetw.ps1 && Remove-Item ./automatic-opensusetw.ps1";
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

