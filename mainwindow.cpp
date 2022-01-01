#include "mainwindow.h"
#include "ui_mainwindow.h"
#include <QWidget>
#include <QMessageBox>
#include <QDesktopServices>
#include <QProcess>
#include <QFile>
MainWindow::MainWindow(QWidget *parent)
    : QMainWindow(parent)
    , ui(new Ui::MainWindow)
{
    ui->setupUi(this);
    wsaoriginaldata = new wsaoriginal();

    ui->endbutton->addButton(tr("Ready"), QDialogButtonBox::AcceptRole);
    ui->endbutton->addButton(tr("Exit"),QDialogButtonBox::RejectRole);

  //  ui->actionGo_to_opengapps_page->setVisible(false);
    //ui->actionGo_to_rg_adguard_page_where_wsa_was_downloaded->setVisible(false);
    //ui->actionGo_to_wsa_mirror->setVisible(false);

    ui->powershell1->setChecked(true);
    ui->ubuntu->setChecked(true);
    ui->virtual_machine_platform->setChecked(true);
    ui->download_wsa->setChecked(true);
    ui->download_gapps->setChecked(true);
    ui->wsa_windows_dev->setChecked(true);

    ui->tempwsa_false->setChecked(true);

    ui->tempwsa_none->hide();

    ui->gapps_none->hide();

ui->actionMS_Store_for_powershell->setText(tr("MS Store for %1").arg("powershell (core)"));
ui->actionMS_Store_for_WSL->setText(tr("MS Store for %1").arg("WSL"));
ui->actionMS_Store_for_WSA->setText(tr("MS Store for %1").arg("WSA"));
ui->actionMS_Store_for_Ubuntu->setText(tr("MS Store for %1").arg("Ubuntu"));
ui->actionMS_Store_for_OpenSUSE_Tumbleweed->setText(tr("MS Store for %1").arg("OpenSUSE Tumbleweed"));
ui->actionMS_Store_for_Debian->setText(tr("MS Store for %1").arg("Debian"));
ui->actionMS_Store_For_WSATools->setText(tr("MS Store for %1").arg("WSATools"));
  /*  if (theme == "dark") {
        QFile styleSheetFile(":/theme/themedark1.qss");
    styleSheetFile.open(QFile::ReadOnly);
    QString StyleSheet = QLatin1String(styleSheetFile.readAll());
    this->setStyleSheet(StyleSheet);
    }
    if (theme == "light") {
            this->setStyleSheet(" ");
    }*/
}

MainWindow::~MainWindow()
{
    delete ui;
}
QString version = "1.1.0";
void MainWindow::on_actionMS_Store_for_powershell_triggered()
{
    QMessageBox msgBox;
    msgBox.setWindowIcon(QIcon(":/image/wsa-opengapps.png"));
    msgBox.setIcon(QMessageBox::Warning);
    msgBox.setWindowTitle(tr("Redirects to a Web Page"));
    msgBox.setText(tr("Redirect you to a webpage: %1").arg("https://www.microsoft.com/p/powershell/9mz1snwt0n5d"));
    QAbstractButton* xgo = msgBox.addButton(tr("Go"), QMessageBox::YesRole);
    QAbstractButton* xabort = msgBox.addButton(tr("Abort"), QMessageBox::NoRole);
    msgBox.exec();

    if (msgBox.clickedButton()==xgo) {
QDesktopServices::openUrl(QUrl("https://www.microsoft.com/p/powershell/9mz1snwt0n5d"));
    }
}

void MainWindow::on_actionMS_Store_for_WSL_triggered()
{
    QMessageBox msgBox;
    msgBox.setWindowIcon(QIcon(":/image/wsa-opengapps.png"));
    msgBox.setIcon(QMessageBox::Warning);
    msgBox.setWindowTitle(tr("Redirects to a Web Page"));
    msgBox.setText(tr("Redirect you to a webpage: %1").arg("https://aka.ms/wslstorepage"));
    QAbstractButton* xgo = msgBox.addButton(tr("Go"), QMessageBox::YesRole);
    QAbstractButton* xabort = msgBox.addButton(tr("Abort"), QMessageBox::NoRole);
    msgBox.exec();

    if (msgBox.clickedButton()==xgo) {
QDesktopServices::openUrl(QUrl("https://aka.ms/wslstorepage"));
    }

}
void MainWindow::on_actionMS_Store_for_WSA_triggered()
{
  //  if (checked == true) {
    QMessageBox msgBox;
    msgBox.setWindowIcon(QIcon(":/image/wsa-opengapps.png"));
    msgBox.setIcon(QMessageBox::Warning);
    msgBox.setWindowTitle(tr("Redirects to a Web Page"));
    msgBox.setText(tr("Redirect you to a webpage: %1").arg("https://www.microsoft.com/store/productId/9P3395VX91NR"));
    QAbstractButton* xgo = msgBox.addButton(tr("Go"), QMessageBox::YesRole);
    QAbstractButton* xabort = msgBox.addButton(tr("Abort"), QMessageBox::NoRole);
    msgBox.exec();

    if (msgBox.clickedButton()==xgo) {
QDesktopServices::openUrl(QUrl("https://www.microsoft.com/store/productId/9P3395VX91NR"));
    }
  //  }
}

void MainWindow::on_actionMS_Store_for_Ubuntu_triggered()
{
    QMessageBox msgBox;
    msgBox.setWindowIcon(QIcon(":/image/wsa-opengapps.png"));
    msgBox.setIcon(QMessageBox::Warning);
    msgBox.setWindowTitle(tr("Redirects to a Web Page"));
    msgBox.setText(tr("Redirect you to a webpage: %1").arg("https://www.microsoft.com/p/ubuntu/9nblggh4msv6"));
    QAbstractButton* xgo = msgBox.addButton(tr("Go"), QMessageBox::YesRole);
    QAbstractButton* xabort = msgBox.addButton(tr("Abort"), QMessageBox::NoRole);
    msgBox.exec();

    if (msgBox.clickedButton()==xgo) {
QDesktopServices::openUrl(QUrl("https://www.microsoft.com/p/ubuntu/9nblggh4msv6"));
    }
}


void MainWindow::on_actionMS_Store_for_OpenSUSE_Tumbleweed_triggered()
{
    QMessageBox msgBox;
    msgBox.setWindowIcon(QIcon(":/image/wsa-opengapps.png"));
    msgBox.setIcon(QMessageBox::Warning);
    msgBox.setWindowTitle(tr("Redirects to a Web Page"));
    msgBox.setText(tr("Redirect you to a webpage: %1").arg("https://www.microsoft.com/p/opensuse-tumbleweed/9mssk2zxxn11"));
    QAbstractButton* xgo = msgBox.addButton(tr("Go"), QMessageBox::YesRole);
    QAbstractButton* xabort = msgBox.addButton(tr("Abort"), QMessageBox::NoRole);
    msgBox.exec();

    if (msgBox.clickedButton()==xgo) {
QDesktopServices::openUrl(QUrl("https://www.microsoft.com/p/opensuse-tumbleweed/9mssk2zxxn11"));
    }
}


void MainWindow::on_actionMS_Store_for_Debian_triggered()
{
    QMessageBox msgBox;
    msgBox.setWindowIcon(QIcon(":/image/wsa-opengapps.png"));
    msgBox.setIcon(QMessageBox::Warning);
    msgBox.setWindowTitle(tr("Redirects to a Web Page"));
    msgBox.setText(tr("Redirect you to a webpage: %1").arg("https://www.microsoft.com/p/debian/9msvkqc78pk6"));
    QAbstractButton* xgo = msgBox.addButton(tr("Go"), QMessageBox::YesRole);
    QAbstractButton* xabort = msgBox.addButton(tr("Abort"), QMessageBox::NoRole);
    msgBox.exec();

    if (msgBox.clickedButton()==xgo) {
QDesktopServices::openUrl(QUrl("https://www.microsoft.com/p/debian/9msvkqc78pk6"));
    }
}


void MainWindow::on_actionMy_GitHub_triggered()
{
    QMessageBox msgBox;
    msgBox.setWindowIcon(QIcon(":/image/wsa-opengapps.png"));
    msgBox.setIcon(QMessageBox::Warning);
    msgBox.setWindowTitle(tr("Redirects to a Web Page"));
    msgBox.setText(tr("Redirect you to a webpage: %1").arg("https://github.com/herrwinfried"));
    QAbstractButton* xgo = msgBox.addButton(tr("Go"), QMessageBox::YesRole);
    QAbstractButton* xabort = msgBox.addButton(tr("Abort"), QMessageBox::NoRole);
    msgBox.exec();

    if (msgBox.clickedButton()==xgo) {
QDesktopServices::openUrl(QUrl("https://github.com/herrwinfried"));
    }
}


void MainWindow::on_actionProject_Page_triggered()
{
    QMessageBox msgBox;
    msgBox.setWindowIcon(QIcon(":/image/wsa-opengapps.png"));
    msgBox.setIcon(QMessageBox::Warning);
    msgBox.setWindowTitle(tr("Redirects to a Web Page"));
    msgBox.setText(tr("Redirect you to a webpage: %1").arg("https://github.com/herrwinfried/wsa-gui"));
    QAbstractButton* xgo = msgBox.addButton(tr("Go"), QMessageBox::YesRole);
    QAbstractButton* xabort = msgBox.addButton(tr("Abort"), QMessageBox::NoRole);
    msgBox.exec();

    if (msgBox.clickedButton()==xgo) {
QDesktopServices::openUrl(QUrl("https://github.com/herrwinfried/wsa-gui"));
    }
}


void MainWindow::on_actionGo_to_licence_triggered()
{
    QMessageBox msgBox;
    msgBox.setWindowIcon(QIcon(":/image/wsa-opengapps.png"));
    msgBox.setIcon(QMessageBox::Warning);
    msgBox.setWindowTitle(tr("Redirects to a Web Page"));
    msgBox.setText(tr("Redirect you to a webpage: %1").arg("https://github.com/herrwinfried/wsa-gui/blob/main/LICENSE"));
    QAbstractButton* xgo = msgBox.addButton(tr("Go"), QMessageBox::YesRole);
    QAbstractButton* xabort = msgBox.addButton(tr("Abort"), QMessageBox::NoRole);
    msgBox.exec();

    if (msgBox.clickedButton()==xgo) {
QDesktopServices::openUrl(QUrl("https://github.com/herrwinfried/wsa-gui/blob/main/LICENSE"));
    }



}

void MainWindow::on_actionGo_to_opengapps_page_triggered()
{
    QMessageBox msgBox;
    msgBox.setWindowIcon(QIcon(":/image/wsa-opengapps.png"));
    msgBox.setIcon(QMessageBox::Warning);
    msgBox.setWindowTitle(tr("Redirects to a Web Page"));
    msgBox.setText(tr("Redirect you to a webpage: %1").arg("https://opengapps.org"));
    QAbstractButton* xgo = msgBox.addButton(tr("Go"), QMessageBox::YesRole);
    QAbstractButton* xabort = msgBox.addButton(tr("Abort"), QMessageBox::NoRole);
    msgBox.exec();

    if (msgBox.clickedButton()==xgo) {
QDesktopServices::openUrl(QUrl("https://opengapps.org"));
    }
}

void MainWindow::on_actionGo_to_rg_adguard_page_where_wsa_was_downloaded_triggered()
{
    QMessageBox msgBox;
    msgBox.setWindowIcon(QIcon(":/image/wsa-opengapps.png"));
    msgBox.setIcon(QMessageBox::Warning);
    msgBox.setWindowTitle(tr("Redirects to a Web Page"));
    msgBox.setText(tr("Redirect you to a webpage: %1").arg("https://store.rg-adguard.net"));
    QAbstractButton* xgo = msgBox.addButton(tr("Go"), QMessageBox::YesRole);
    QAbstractButton* xabort = msgBox.addButton(tr("Abort"), QMessageBox::NoRole);
    msgBox.exec();

    if (msgBox.clickedButton()==xgo) {
QDesktopServices::openUrl(QUrl("https://store.rg-adguard.net"));
    }
}

void MainWindow::on_actionMS_Store_For_WSATools_triggered()
{
    QMessageBox msgBox;
    msgBox.setWindowIcon(QIcon(":/image/wsa-opengapps.png"));
    msgBox.setIcon(QMessageBox::Warning);
    msgBox.setWindowTitle(tr("Redirects to a Web Page"));
    msgBox.setText(tr("Redirect you to a webpage: %1").arg("https://www.microsoft.com/p/wsatools/9n4p75dxl6fg"));
    QAbstractButton* xgo = msgBox.addButton(tr("Go"), QMessageBox::YesRole);
    QAbstractButton* xabort = msgBox.addButton(tr("Abort"), QMessageBox::NoRole);
    msgBox.exec();

    if (msgBox.clickedButton()==xgo) {
QDesktopServices::openUrl(QUrl("https://www.microsoft.com/p/wsatools/9n4p75dxl6fg"));
    }
}


void MainWindow::on_actionGo_to_wsa_mirror_triggered()
{
    QMessageBox msgBox;
    msgBox.setWindowIcon(QIcon(":/image/wsa-opengapps.png"));
    msgBox.setIcon(QMessageBox::Warning);
    msgBox.setWindowTitle(tr("Redirects to a Web Page"));
    msgBox.setText(tr("Redirect you to a webpage: %1").arg("https://github.com/herrwinfried/wsa-mirror"));
    QAbstractButton* xgo = msgBox.addButton(tr("Go"), QMessageBox::YesRole);
    QAbstractButton* xabort = msgBox.addButton(tr("Abort"), QMessageBox::NoRole);
    msgBox.exec();

    if (msgBox.clickedButton()==xgo) {
QDesktopServices::openUrl(QUrl("https://github.com/herrwinfried/wsa-mirror"));
    }
}

void MainWindow::on_actionApplication_About_triggered()
{
    QApplication::aboutQt();
}

void MainWindow::on_actionDonate_triggered()
{
    QMessageBox::about(this, tr("Donate"), tr("Since I did this project on a voluntary basis, I did not find it necessary to highlight donate. So if you are using Brave browser, you can donate it to my github account.") + "<a href=\"https://github.com/herrwinfried\">" + tr("GitHub Page") + "</a>");

}

void MainWindow::on_actionAbout_triggered()
{
  QMessageBox::about(this, tr("WSA GUI About"), tr("wsa gui is a graphical interface for experimental wsa script. <br> Licensed under the GNU Affero General Public License v3.0") + "<br> <br>" + tr("Made by %1").arg("<a href=\"https://github.com/herrwinfried\">Winfried</a>") + "<br>" + tr("Application Version <b> %1").arg(version) + "</b>");
}

void wsaoriginal::on_actionAbout_triggered()
{
   QMessageBox::about(this, tr("WSA GUI About"), tr("wsa gui is a graphical interface for experimental wsa script. <br> Licensed under the GNU Affero General Public License v3.0") + "<br> <br>" + tr("Made by %1").arg("<a href=\"https://github.com/herrwinfried\">Winfried</a>") + "<br>" + tr("Application Version <b> %1").arg(version) + "</b>");
}



void MainWindow::on_switchbutton_pressed()
{
    wsaoriginaldata->show();
    this->close();
}

void wsaoriginal::on_switchbutton_pressed()
{

this->close();
MainWindow *mainwindow;
mainwindow = new MainWindow();
mainwindow->show();
}

void MainWindow::on_actionOnly_WSA_Original_triggered()
{
    wsaoriginaldata->show();
    this->close();
}

void wsaoriginal::on_actionOnly_WSA_opengapps_triggered()
{
    this->close();
    MainWindow *mainwindow;
    mainwindow = new MainWindow();
    mainwindow->show();
}

void MainWindow::on_virtual_machine_platform_clicked(bool checked)
{

    if (checked == false) {



if (ui->ubuntu->isChecked() == true || ui->opensusetw->isChecked() == true || ui->debian->isChecked() == true) {

        QMessageBox msgBox;
        msgBox.setWindowIcon(QIcon(":/image/wsa-opengapps.png"));
        msgBox.setIcon(QMessageBox::Warning);
        msgBox.setWindowTitle(tr("Important Information"));
        msgBox.setText(tr("If the Virtual Machine Platform is indeed turned off, the installation cannot be performed. If you don't know what you're doing, give up."));
        QAbstractButton* xcontinue = msgBox.addButton(tr("Continue"), QMessageBox::YesRole);
        QAbstractButton* xcancel = msgBox.addButton(tr("Cancel"), QMessageBox::NoRole);
        msgBox.exec();

        if (msgBox.clickedButton()==xcontinue) {
ui->statusBar->showMessage(tr("Virtual Machine will not be activated."), 10000);
        }
        if (msgBox.clickedButton()==xcancel) {
ui->virtual_machine_platform->setChecked(true);

        }
} else {
       ui->statusBar->showMessage(tr("Virtual Machine will not be activated."), 10000);
}
}
    else {
        ui->statusBar->showMessage(tr("Virtual Machine will be activated."), 10000);
    }
}


void MainWindow::on_download_wsa_clicked(bool checked)
{
    if (checked == false) {
if (ui->ubuntu->isChecked() == true || ui->opensusetw->isChecked() == true || ui->debian->isChecked() == true) {

    ui->tempwsa_false->setChecked(false);
    ui->tempwsa_false->setEnabled(false);

    ui->tempwsa_true->setChecked(false);
    ui->tempwsa_true->setEnabled(false);

    ui->tempwsa_none->setChecked(true);

        QMessageBox msgBox;
        msgBox.setWindowIcon(QIcon(":/image/wsa-opengapps.png"));
        msgBox.setIcon(QMessageBox::Warning);
        msgBox.setWindowTitle(tr("Important Information"));
        msgBox.setText(tr("if WSA is installed. Please put it in the folder in <b> c:\\wsaproject </b>. Make sure the file has the original name. Otherwise, a problem may occur. Cancel if you don't know what you're doing."));
        QAbstractButton* xcontinue = msgBox.addButton(tr("Continue"), QMessageBox::YesRole);
        QAbstractButton* xcancel = msgBox.addButton(tr("Cancel"), QMessageBox::NoRole);
        msgBox.exec();

        if (msgBox.clickedButton()==xcontinue) {
ui->statusBar->showMessage(tr("wsa will not download."), 10000);
        }
        if (msgBox.clickedButton()==xcancel) {
ui->download_wsa->setChecked(true);

ui->tempwsa_false->setChecked(true);
ui->tempwsa_true->setEnabled(true);
ui->tempwsa_false->setEnabled(true);
        }
}
}
    else {
        ui->tempwsa_false->setChecked(true);
        ui->tempwsa_true->setEnabled(true);
        ui->tempwsa_false->setEnabled(true);


        ui->statusBar->showMessage(tr("wsa will download."), 10000);
    }
}


void MainWindow::on_download_gapps_clicked(bool checked)
{
    if (checked == false) {
if (ui->ubuntu->isChecked() == true || ui->opensusetw->isChecked() == true || ui->debian->isChecked() == true) {

        QMessageBox msgBox;
        msgBox.setWindowIcon(QIcon(":/image/wsa-opengapps.png"));
        msgBox.setIcon(QMessageBox::Warning);
        msgBox.setWindowTitle(tr("Important Information"));
        msgBox.setText(tr("if opengapps is installed. Please put it in the folder in <b> c:\\wsaproject </b>. Make sure the file has the original name. Otherwise, a problem may occur. Cancel if you don't know what you're doing."));
        QAbstractButton* xcontinue = msgBox.addButton(tr("Continue"), QMessageBox::YesRole);
        QAbstractButton* xcancel = msgBox.addButton(tr("Cancel"), QMessageBox::NoRole);
        msgBox.exec();

        if (msgBox.clickedButton()==xcontinue) {
ui->statusBar->showMessage(tr("OpenGapps will not download."), 10000);
        }
        if (msgBox.clickedButton()==xcancel) {
ui->download_gapps->setChecked(true);

        }
}
}
    else {
        ui->statusBar->showMessage(tr("OpenGapps will download."), 10000);
    }
}


void MainWindow::on_wsa_windows_dev_clicked(bool checked)
{
    if (checked == false) {



if (ui->ubuntu->isChecked() == true || ui->opensusetw->isChecked() == true || ui->debian->isChecked() == true) {

        QMessageBox msgBox;
        msgBox.setWindowIcon(QIcon(":/image/wsa-opengapps.png"));
        msgBox.setIcon(QMessageBox::Warning);
        msgBox.setWindowTitle(tr("Important Information"));
        msgBox.setText(tr("Windows developer Mode must be active as the files will be modified. otherwise it cannot be installed. <br> <br> WSA Developer Mode must be enabled while Installing the APK. otherwise it cannot be installed."));
        QAbstractButton* xcontinue = msgBox.addButton(tr("Continue"), QMessageBox::YesRole);
        QAbstractButton* xcancel = msgBox.addButton(tr("Cancel"), QMessageBox::NoRole);
        msgBox.exec();

        if (msgBox.clickedButton()==xcontinue) {
ui->statusBar->showMessage(tr("Developer Mode will not open."), 10000);
        }
        if (msgBox.clickedButton()==xcancel) {
ui->wsa_windows_dev->setChecked(true);

        }
} else {
           ui->statusBar->showMessage(tr("Developer Mode will not open."), 10000);
}
}
    else {
        ui->statusBar->showMessage(tr("Developer Mode will open."), 10000);
    }
}


void MainWindow::on_powershell_none_pressed()
{
if (ui->ubuntu->isChecked() == true || ui->opensusetw->isChecked() == true || ui->debian->isChecked() == true || ui->adb->isChecked() == true) {

        QMessageBox msgBox;
        msgBox.setWindowIcon(QIcon(":/image/wsa-opengapps.png"));
        msgBox.setIcon(QMessageBox::Warning);
        msgBox.setWindowTitle(tr("Important Information"));
        msgBox.setText(tr("For Script to Run Properly. The security level needs to be lowered. If you continue. The script may not run properly. Please cancel if you don't know what you are doing."));
        QAbstractButton* xcontinue = msgBox.addButton(tr("Continue"), QMessageBox::YesRole);
        QAbstractButton* xcancel = msgBox.addButton(tr("Cancel"), QMessageBox::NoRole);
        msgBox.exec();

        if (msgBox.clickedButton()==xcontinue) {
ui->statusBar->showMessage(tr("Powershell security level is set to none."), 10000);
ui->powershell_none->setChecked(true);
        }
        if (msgBox.clickedButton()==xcancel) {


        }
}

}


void MainWindow::on_endbutton_accepted()
{
    QString OS;
    if (ui->ubuntu->isChecked() == true) {
    OS = "Ubuntu";
    }
    else if (ui->opensusetw->isChecked() == true) {
    OS = "openSUSE-Tumbleweed";
        }
    else if (ui->debian->isChecked() == true) {
    OS = "Debian";
    }
    if (ui->ubuntu->isChecked() == true || ui->opensusetw->isChecked() == true || ui->debian->isChecked() == true) {
          OS = " -selectos " + OS;
    }
    //##########################
    QString prep;
    if (ui->download_wsa->isChecked() == true) {
    prep = prep + " -wsa 1";
    }
    if (ui->download_gapps->isChecked() == true) {
    prep = prep + " -gapps 1";
    }
    if (ui->wsatools->isChecked() == true) {
    prep = prep + " -wsatools 1";
    }
    if (ui->tempwsa_true->isChecked() == true) {
        prep = prep + " -tempwsa 1";
    }
    QString Check_dev;
    if ((ui->ubuntu->isChecked() == true || ui->opensusetw->isChecked() == true || ui->debian->isChecked() == true) && ui->wsa_windows_dev->isChecked() == true) {
    prep = prep + " -wsadevwin 1";
    Check_dev = "0";
    } else {
        Check_dev = "1";
    }
    QString Check_vmc;
    if ((ui->ubuntu->isChecked() == true || ui->opensusetw->isChecked() == true || ui->debian->isChecked() == true) && ui->virtual_machine_platform->isChecked() == true) {
    prep = prep + " -vmc 1";
    Check_vmc = "0";
    } else {
        Check_vmc = "1";
    }
    if (ui->gapps_aroma->isChecked()) {
        prep = prep + " -gappsvariant "+ui->gapps_aroma->text();
    }
    if (ui->gapps_full->isChecked()) {
        prep = prep + " -gappsvariant "+ui->gapps_full->text();
    }
    if (ui->gapps_micro->isChecked()) {
        prep = prep + " -gappsvariant "+ui->gapps_micro->text();
    }
    if (ui->gapps_mini->isChecked()) {
        prep = prep + " -gappsvariant "+ui->gapps_mini->text();
    }
    if (ui->gapps_nano->isChecked()) {
        prep = prep + " -gappsvariant "+ui->gapps_nano->text();
    }
    if (ui->gapps_pico->isChecked()) {
        prep = prep + " -gappsvariant "+ui->gapps_pico->text();
    }
    if (ui->gapps_stock->isChecked()) {
        prep = prep + " -gappsvariant "+ui->gapps_stock->text();
    }
    if (ui->gapps_super->isChecked()) {
        prep = prep + " -gappsvariant "+ui->gapps_super->text();
    }

    QString commandq;
    commandq = "Start-Process pwsh.exe -verb runas -ArgumentList '-c ";
    if (ui->powershell1->isChecked() || ui->powershell2->isChecked())
    {
      commandq = commandq + ";powershell.exe Set-ExecutionPolicy -ExecutionPolicy RemoteSigned -Scope LocalMachine";
    }
    if ( Check_vmc == "1" && ui->virtual_machine_platform->isChecked() == true) {
          commandq = commandq + ";dism.exe /online /enable-feature /featurename:VirtualMachinePlatform /all /norestart";
      }
    if (ui->adb->isChecked()){
       commandq = commandq + ";Invoke-WebRequest https://raw.githubusercontent.com/herrwinfried/wsa-script/1.1.0/powershell/r31.0.3-windows.ps1 -OutFile $env:TEMP/r31.0.3-windows.ps1 && cd $env:TEMP && ./r31.0.3-windows.ps1 && cd $env:TEMP && Remove-Item ./r31.0.3-windows.ps1";
     }
    if (ui->ubuntu->isChecked() == true || ui->opensusetw->isChecked() == true || ui->debian->isChecked() == true) {
    commandq = commandq + ";Invoke-WebRequest https://raw.githubusercontent.com/herrwinfried/wsa-script/1.1.0/powershell/automatic.ps1 -OutFile $env:TEMP/automatic.ps1 && cd $env:TEMP && ./automatic.ps1" + OS + prep + " && cd $env:TEMP && Remove-Item ./automatic.ps1";
    }
    if ( Check_dev == "1" && ui->wsa_windows_dev->isChecked() == true) {
        commandq = commandq + ";Invoke-WebRequest https://raw.githubusercontent.com/herrwinfried/wsa-script/1.1.0/powershell/wsadevelopermode.ps1 -OutFile $env:TEMP/wsadevelopermode.ps1 && cd $env:TEMP && ./wsadevelopermode.ps1 && cd $env:TEMP && Remove-Item ./wsadevelopermode.ps1";
    }
    if (ui->powershell1->isChecked()) {
       commandq = commandq + ";powershell.exe Set-ExecutionPolicy -ExecutionPolicy Restricted -Scope LocalMachine";
    }
      commandq = commandq + "'";

      if (ui->actionshow_commands_to_type->isChecked() == true) {
         QMessageBox::information(this, "Commands Line", commandq);
      }
    QMessageBox xmsgBox;
    xmsgBox.setWindowIcon(QIcon(":/image/wsa-opengapps.png"));
    xmsgBox.setIcon(QMessageBox::Warning);
    xmsgBox.setWindowTitle(tr("WARNING"));
    xmsgBox.setText(tr("I do not take responsibility. Although this project may seem convincing, it is experimental. If you have WSA installed, you need to uninstall it. It is assumed that you have installed the unspecified base Requirements that are deemed to be met. (WSL, WSL Deployment, WSL User account creation, Powershell core, virtual machine platform)"));
    QAbstractButton* xokey = xmsgBox.addButton(tr("Okey"), QMessageBox::AcceptRole);
    xmsgBox.exec();


    if (ui->wsa_none->isChecked() != true) {
    if (ui->download_wsa->isChecked() == false && ui->download_gapps->isChecked() == false) {
        QMessageBox msgBox;
        msgBox.setWindowIcon(QIcon(":/image/wsa-opengapps.png"));
        msgBox.setIcon(QMessageBox::Information);
        msgBox.setWindowTitle(tr("Important Information"));
        msgBox.setText(tr("I see you didn't choose OpenGapps and WSA. Please put your OpenGapps and wsa File in <b>C:\\wsaproject</b> folder. Otherwise, it may create a problem."));
        QAbstractButton* xokey = msgBox.addButton(tr("Okey"), QMessageBox::AcceptRole);
        msgBox.exec();

    } else
    if (ui->download_wsa->isChecked() == false){
        QMessageBox msgBox;
        msgBox.setWindowIcon(QIcon(":/image/wsa-opengapps.png"));
        msgBox.setIcon(QMessageBox::Information);
        msgBox.setWindowTitle(tr("Important Information"));
        msgBox.setText(tr("I see you didn't choose WSA. Please put your WSA File in <b>C:\\wsaproject</b> folder. Otherwise, it may create a problem."));
        QAbstractButton* xokey = msgBox.addButton(tr("Okey"), QMessageBox::AcceptRole);
        msgBox.exec();

     /*   if (msgBox.clickedButton()==xokey) {
    ui->statusBar->showMessage(tr("MMESSAGE"), 10000);
        }*/
    } else
        if (ui->download_gapps->isChecked() == false){
            QMessageBox msgBox;
            msgBox.setWindowIcon(QIcon(":/image/wsa-opengapps.png"));
            msgBox.setIcon(QMessageBox::Information);
            msgBox.setWindowTitle(tr("Important Information"));
            msgBox.setText(tr("I see you didn't choose OpenGapps. Please put your OpenGapps File in <b>C:\\wsaproject</b> folder. Otherwise, it may create a problem."));
            QAbstractButton* xokey = msgBox.addButton(tr("Okey"), QMessageBox::AcceptRole);
            msgBox.exec();

         /*   if (msgBox.clickedButton()==xokey) {
        ui->statusBar->showMessage(tr("MMESSAGE"), 10000);
            }*/
        }
}
    //////////////////////////////SXXXX///
    QMessageBox msgBox;
    msgBox.setWindowIcon(QIcon(":/image/wsa-opengapps.png"));
    msgBox.setIcon(QMessageBox::Question);
    msgBox.setWindowTitle(tr("Before proceeding with the installation"));
    if (ui->wsa_none->isChecked() != true) {
    msgBox.setText(tr("Make sure you have Powershell 7+ installed and your chosen distribution (Ubuntu/OpenSUSE TW/Debian) is installed and your distribution has a user account. Also, when you press \"Ready\", the processes will start and you will receive a notification that powershell wants to start as administrator. You must allow it to run as administrator or the process will not run. \nAfter a while, when the script is run, it will ask for your root(user password) password on your distro. \n \nClick \"Ready\" if you are ready."));
     } else {
        msgBox.setText(tr("Make sure Powershell 7+ is installed. Also, when you press \"Ready\" the processes will start and you will get a notification that powershell wants to start as administrator. You must allow it to run as administrator, otherwise the process will not run. \n\nClick \"Ready\" if you are ready."));
    }
    QAbstractButton* xready = msgBox.addButton(tr("Ready!"), QMessageBox::AcceptRole);
    QAbstractButton* xcancel = msgBox.addButton(tr("Cancel"), QMessageBox::NoRole);
    msgBox.exec();

    if (msgBox.clickedButton()==xready) {
        QStringList parameters{commandq};
        QProcess *process = new QProcess(this);
        QString cmd("powershell.exe");
        process->start(cmd, parameters);
ui->statusBar->showMessage(tr("the powershell script is starting."), 10000);

    }
    if (msgBox.clickedButton()==xcancel) {
        ui->statusBar->showMessage(tr("The installation process was canceled by the user."), 10000);
    }
}


void MainWindow::on_endbutton_rejected()
{
    this->close();
}





void MainWindow::on_powershell1_clicked(bool checked)
{
    if (checked == true) {
ui->statusBar->showMessage(tr("User selected Recommended Powershell security level."), 10000);
    }

}


void MainWindow::on_powershell2_clicked(bool checked)
{
    if (checked == true) {
ui->statusBar->showMessage(tr("The user has chosen to permanently lower the Powershell security level."), 15000);
    }
}


void MainWindow::on_powershell_none_clicked(bool checked)
{
    if (checked == true) {
ui->statusBar->showMessage(tr("The user chose not to touch the Powershell security level."), 15000);
    }

}

void MainWindow::on_ubuntu_clicked(bool checked)
{
    // | ui->download_gapps->isChecked() == false
    if (checked == true) {
ui->statusBar->showMessage(tr("%1 was selected as the WSL distribution to be processed.").arg("Ubuntu"), 10000);

ui->download_wsa->setChecked(true);
ui->download_wsa->setEnabled(true);
ui->download_gapps->setChecked(true);
ui->download_gapps->setEnabled(true);
ui->wsatools->setEnabled(true);

ui->tempwsa_false->setChecked(true);
ui->tempwsa_true->setEnabled(true);
ui->tempwsa_false->setEnabled(true);

//ui->gapps_aroma->setEnabled(true);
ui->gapps_full->setEnabled(true);
ui->gapps_micro->setEnabled(true);
ui->gapps_mini->setEnabled(true);
ui->gapps_nano->setEnabled(true);
ui->gapps_pico->setEnabled(true);
ui->gapps_stock->setEnabled(true);
ui->gapps_super->setEnabled(true);
ui->gapps_pico->setChecked(true);
    }
}

void MainWindow::on_opensusetw_clicked(bool checked)
{
    if (checked == true) {
ui->statusBar->showMessage(tr("%1 was selected as the WSL distribution to be processed.").arg("OpenSUSE Tumbleweed"), 10000);

ui->download_wsa->setChecked(true);
ui->download_wsa->setEnabled(true);
ui->download_gapps->setChecked(true);
ui->download_gapps->setEnabled(true);
ui->wsatools->setEnabled(true);

ui->tempwsa_false->setChecked(true);
ui->tempwsa_true->setEnabled(true);
ui->tempwsa_false->setEnabled(true);

//ui->gapps_aroma->setEnabled(true);
ui->gapps_full->setEnabled(true);
ui->gapps_micro->setEnabled(true);
ui->gapps_mini->setEnabled(true);
ui->gapps_nano->setEnabled(true);
ui->gapps_pico->setEnabled(true);
ui->gapps_stock->setEnabled(true);
ui->gapps_super->setEnabled(true);
ui->gapps_pico->setChecked(true);
    }
}


void MainWindow::on_debian_clicked(bool checked)
{
    if (checked == true) {
ui->statusBar->showMessage(tr("%1 was selected as the WSL distribution to be processed.").arg("Debian"), 10000);

ui->download_wsa->setChecked(true);
ui->download_wsa->setEnabled(true);
ui->download_gapps->setChecked(true);
ui->download_gapps->setEnabled(true);
ui->wsatools->setEnabled(true);

ui->tempwsa_false->setChecked(true);
ui->tempwsa_true->setEnabled(true);
ui->tempwsa_false->setEnabled(true);

//ui->gapps_aroma->setEnabled(true);
ui->gapps_full->setEnabled(true);
ui->gapps_micro->setEnabled(true);
ui->gapps_mini->setEnabled(true);
ui->gapps_nano->setEnabled(true);
ui->gapps_pico->setEnabled(true);
ui->gapps_stock->setEnabled(true);
ui->gapps_super->setEnabled(true);
ui->gapps_pico->setChecked(true);
    }
}

void MainWindow::on_wsa_none_clicked(bool checked)
{
    if (checked == true) {
ui->statusBar->showMessage(tr("WSL Deployment did not choose."), 10000);

ui->download_wsa->setChecked(false);
ui->download_wsa->setEnabled(false);
ui->download_gapps->setChecked(false);
ui->download_gapps->setEnabled(false);
ui->wsatools->setChecked(false);
ui->wsatools->setEnabled(false);

ui->tempwsa_false->setChecked(false);
ui->tempwsa_false->setEnabled(false);

ui->tempwsa_true->setChecked(false);
ui->tempwsa_true->setEnabled(false);

ui->tempwsa_none->setChecked(true);

//ui->gapps_aroma->setEnabled(false);
ui->gapps_full->setEnabled(false);
ui->gapps_micro->setEnabled(false);
ui->gapps_mini->setEnabled(false);
ui->gapps_nano->setEnabled(false);
ui->gapps_pico->setEnabled(false);
ui->gapps_stock->setEnabled(false);
ui->gapps_super->setEnabled(false);
ui->gapps_none->setChecked(true);


    }
}


void MainWindow::on_adb_clicked(bool checked)
{
    if (checked == true) {
ui->statusBar->showMessage(tr("adb will be installed."), 10000);
    } else {
        ui->statusBar->showMessage(tr("adb will be not installed."), 10000);
    }
}


void MainWindow::on_wsatools_clicked(bool checked)
{
    if (checked == true) {
ui->statusBar->showMessage(tr("WSATools will be installed."), 10000);
    } else {
        ui->statusBar->showMessage(tr("WSATools will be not installed."), 10000);
    }
}


void MainWindow::on_tempwsa_true_pressed()
{
    QMessageBox msgBox;
    msgBox.setWindowIcon(QIcon(":/image/wsa-opengapps.png"));
    msgBox.setIcon(QMessageBox::Warning);
    msgBox.setWindowTitle(tr("Important Information"));
    msgBox.setText(tr("Prefer if latest version of WSA is not working. Otherwise, you will install an outdated wsa."));
    QAbstractButton* xcontinue = msgBox.addButton(tr("Continue"), QMessageBox::YesRole);
    QAbstractButton* xcancel = msgBox.addButton(tr("Cancel"), QMessageBox::NoRole);
    msgBox.exec();

    if (msgBox.clickedButton()==xcontinue) {
ui->statusBar->showMessage(tr("The temporarily selected wsa will be downloaded instead of the current wsa."), 10000);
ui->tempwsa_true->setChecked(true);
    }
    if (msgBox.clickedButton()==xcancel) {
    }
}


void MainWindow::on_tempwsa_false_clicked(bool checked)
{
    if (checked == true) {
        ui->statusBar->showMessage(tr("Current WSA will be downloaded instead of Temporary WSA."), 10000);
    }
}



