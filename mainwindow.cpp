#include "mainwindow.h"
#include "ui_mainwindow.h"
#include <QProcess>
#include <QMessageBox>

MainWindow::MainWindow(QWidget *parent)
    : QMainWindow(parent)
    , ui(new Ui::MainWindow)
{
    ui->setupUi(this);
    ui->virtualmachineplatform->setChecked(true);
    ui->ubuntu->setChecked(true);
    ui->adb->setChecked(false);

    ui->powershellmode->setChecked(true);

    ui->progressBar->setValue(0);
}

MainWindow::~MainWindow()
{
    delete ui;
}



void MainWindow::on_buttonBox_accepted()
{
   if (ui->virtualmachineplatform->isChecked())
   {
       QProcess *process = new QProcess(this);
              QString cmd("powershell.exe");
             QStringList parameters{"Start-Process PowerShell -verb runas -ArgumentList 'dism.exe /online /enable-feature /featurename:VirtualMachinePlatform /all /norestart'"};
              process->start(cmd, parameters);
              ui->statusBar->showMessage("Running Virtual machine platform", 5000);
   }
   ui->progressBar->setValue(30);
   if (ui->adb->isChecked())
   {
       QProcess *process = new QProcess(this);
            /*  QString cmd("powershell.exe");
              QStringList parameters{"Invoke-WebRequest https://raw.githubusercontent.com/herrwinfried/android-platform-powershell/main/r31.0.3-windows.ps1 -OutFile $HOME/Downloads/r31.0.3-windows.ps1;cd $HOME/Downloads; ./r31.0.3-windows.ps1; Remove-Item ./r31.0.3-windows.ps1"};
              process->start(cmd, parameters);
              */
       QString cmd("powershell.exe");
      QStringList parameters{"Start-Process PowerShell -verb runas -ArgumentList 'Invoke-WebRequest https://raw.githubusercontent.com/herrwinfried/android-platform-powershell/main/r31.0.3-windows.ps1 -OutFile $HOME/Downloads/r31.0.3-windows.ps1;cd $HOME/Downloads; ./r31.0.3-windows.ps1; Remove-Item ./r31.0.3-windows.ps1'"};
       process->start(cmd, parameters);
ui->statusBar->showMessage("Running android platform tools script.", 5000);
   }
   ui->progressBar->setValue(50);
   if (ui->powershellmode->isChecked()){
       QProcess *process = new QProcess(this);
       QString cmd("powershell.exe");
       QStringList parameters{"Start-Process PowerShell -verb runas -ArgumentList 'Set-ExecutionPolicy -ExecutionPolicy RemoteSigned -Scope LocalMachine'"};
       process->start(cmd, parameters);
               ui->statusBar->showMessage("ran a command as administrator to change permissions", 5000);
   }
   if (ui->powershellmodeend->isChecked())
   {
       QProcess *process = new QProcess(this);
       QString cmd("powershell.exe");
       QStringList parameters{"Start-Process PowerShell -verb runas -ArgumentList 'Set-ExecutionPolicy -ExecutionPolicy RemoteSigned -Scope LocalMachine'"};
       process->start(cmd, parameters);
               ui->statusBar->showMessage("ran a command as administrator to change permissions.", 5000);

   }
   if (ui->notpowershelllevel->isChecked()){
        ui->statusBar->showMessage("No changes are made to powershell levels.", 5000);
   }
   ui->progressBar->setValue(70);
   if (ui->ubuntu->isChecked()) {
              QProcess *process = new QProcess(this);
              QString cmd("powershell.exe");
             QStringList parameters{"Start-Process PowerShell -verb runas -ArgumentList 'Invoke-WebRequest https://raw.githubusercontent.com/herrwinfried/wsa-script/main/automatic-ubuntu.ps1 -OutFile $HOME/Downloads/automatic-ubuntu.ps1;cd $HOME/Downloads; ./automatic-ubuntu.ps1; Remove-Item ./automatic-ubuntu.ps1; pause'"};
              process->start(cmd, parameters);
              ui->statusBar->showMessage("Running Ubuntu Script (WSA script)", 5000);
   };
   if (ui->opensuse->isChecked()) {
       QProcess *process = new QProcess(this);
       QString cmd("powershell.exe");
      QStringList parameters{"Start-Process PowerShell -verb runas -ArgumentList 'Invoke-WebRequest https://raw.githubusercontent.com/herrwinfried/wsa-script/main/automatic-opensusetw.ps1 -OutFile $HOME/Downloads/automatic-opensusetw.ps1;cd $HOME/Downloads; ./automatic-opensusetw.ps1; Remove-Item ./automatic-opensusetw.ps1; pause'"};
       process->start(cmd, parameters);
       ui->statusBar->showMessage("Running openSUSE Tumbleweed Script (WSA script)", 5000);
   }
   if (ui->notwsa->isChecked()) {
       ui->statusBar->showMessage("I didn't do anything because you chose none as WSA.", 5000);
   }
   ////// PowerShell & PDefault perm
   if (ui->powershellmodeend->isChecked())
   {
       QProcess *process = new QProcess(this);
       QString cmd("powershell.exe");
       QStringList parameters{"Start-Process PowerShell -verb runas -ArgumentList 'Set-ExecutionPolicy -ExecutionPolicy Restricted -Scope LocalMachine'"};
       process->start(cmd, parameters);
               ui->statusBar->showMessage("ran a command as administrator to default permissions.", 5000);

   }
   ///
   ui->progressBar->setValue(100);
   if (ui->progressBar->value() == 100) {
       QMessageBox::information(this, "Successful", "Finish!");
       ui->progressBar->setValue(0);
        ui->statusBar->showMessage("Everything you want is set. If You Have Allowed Everything.", 20000);
   }
}


void MainWindow::on_buttonBox_rejected()
{
    QApplication::quit();
}



void MainWindow::on_ubuntu_clicked(bool checked)
{
    if (checked == true) {
    ui->opensuse->setChecked(false);
    ui->notwsa->setChecked(false);
    };
}


void MainWindow::on_opensuse_clicked(bool checked)
{
    if (checked == true) {
    ui->ubuntu->setChecked(false);
    ui->notwsa->setChecked(false);
    };
}


void MainWindow::on_notwsa_clicked(bool checked)
{
    if (checked == true) {
    ui->ubuntu->setChecked(false);
     ui->opensuse->setChecked(false);
    };
}


void MainWindow::on_powershellmodeend_clicked(bool checked)
{
     if (checked == true) {
    ui->powershellmode->setChecked(false);
    ui->notpowershelllevel->setChecked(false);
     }
}


void MainWindow::on_powershellmode_clicked(bool checked)
{
    if (checked == true) {
        ui->powershellmodeend->setChecked(false);
        ui->notpowershelllevel->setChecked(false);
    }
}

void MainWindow::on_notpowershelllevel_clicked(bool checked)
{
    if (checked == true)
    {
        ui->powershellmode->setChecked(false);
        ui->powershellmodeend->setChecked(false);
    }
}

