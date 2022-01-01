#include "wsaoriginal.h"
#include "ui_wsaoriginal.h"

#include <QWidget>
#include <QMessageBox>
#include <QDesktopServices>
#include <QProcess>
#include <QFile>
wsaoriginal::wsaoriginal(QWidget *parent) :
    QMainWindow(parent),
    ui(new Ui::wsaoriginal)
{
    ui->setupUi(this);
    ui->endbutton->addButton(tr("Ready"), QDialogButtonBox::AcceptRole);
    ui->endbutton->addButton(tr("Exit"),QDialogButtonBox::RejectRole);

    ui->actionGo_to_opengapps_page->setVisible(false);
    ui->actionGo_to_rg_adguard_page_where_wsa_was_downloaded->setVisible(false);

    ui->ubuntu->setChecked(true);
    ui->powershell1->setChecked(true);
    ui->virtual_machine_platform->setChecked(true);
    ui->download_wsa->setChecked(true);

    ui->actionMS_Store_for_powershell->setText(tr("MS Store for %1").arg("powershell (core)"));
    ui->actionMS_Store_for_WSL->setText(tr("MS Store for %1").arg("WSL"));
    ui->actionMS_Store_for_WSA->setText(tr("MS Store for %1").arg("WSA"));
    ui->pushButton_wsa_msstore->setText(tr("MS Store for %1").arg("WSA"));
    ui->actionMS_Store_for_Ubuntu->setText(tr("MS Store for %1").arg("Ubuntu"));
    ui->actionMS_Store_for_OpenSUSE_Tumbleweed->setText(tr("MS Store for %1").arg("OpenSUSE Tumbleweed"));
    ui->actionMS_Store_for_Debian->setText(tr("MS Store for %1").arg("Debian"));
    ui->actionMS_Store_For_WSATools->setText(tr("MS Store for %1").arg("WSATools"));
}

wsaoriginal::~wsaoriginal()
{
    delete ui;
}




void wsaoriginal::on_actionMS_Store_for_powershell_triggered()
{
    QMessageBox msgBox;
    msgBox.setWindowIcon(QIcon(":/image/wsa.png"));
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

void wsaoriginal::on_actionMS_Store_for_WSL_triggered()
{
    QMessageBox msgBox;
    msgBox.setWindowIcon(QIcon(":/image/wsa.png"));
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
void wsaoriginal::on_actionMS_Store_for_WSA_triggered()
{
  //  if (checked == true) {
    QMessageBox msgBox;
    msgBox.setWindowIcon(QIcon(":/image/wsa.png"));
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

void wsaoriginal::on_pushButton_wsa_msstore_clicked()
{
    //  if (checked == true) {
      QMessageBox msgBox;
      msgBox.setWindowIcon(QIcon(":/image/wsa.png"));
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

void wsaoriginal::on_actionMS_Store_for_Ubuntu_triggered()
{
    QMessageBox msgBox;
    msgBox.setWindowIcon(QIcon(":/image/wsa.png"));
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


void wsaoriginal::on_actionMS_Store_for_OpenSUSE_Tumbleweed_triggered()
{
    QMessageBox msgBox;
    msgBox.setWindowIcon(QIcon(":/image/wsa.png"));
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


void wsaoriginal::on_actionMS_Store_for_Debian_triggered()
{
    QMessageBox msgBox;
    msgBox.setWindowIcon(QIcon(":/image/wsa.png"));
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

void wsaoriginal::on_actionMS_Store_For_WSATools_triggered()
{
    QMessageBox msgBox;
    msgBox.setWindowIcon(QIcon(":/image/wsa.png"));
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

void wsaoriginal::on_actionMy_GitHub_triggered()
{
    QMessageBox msgBox;
    msgBox.setWindowIcon(QIcon(":/image/wsa.png"));
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


void wsaoriginal::on_actionProject_Page_triggered()
{
    QMessageBox msgBox;
    msgBox.setWindowIcon(QIcon(":/image/wsa.png"));
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


void wsaoriginal::on_actionGo_to_licence_triggered()
{
    QMessageBox msgBox;
    msgBox.setWindowIcon(QIcon(":/image/wsa.png"));
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



void wsaoriginal::on_actionApplication_About_triggered()
{
    QApplication::aboutQt();
}

/*
 * void wsaoriginal::on_actionAbout_triggered()
Go to wsaoriginal
 * */


void wsaoriginal::on_actionDonate_triggered()
{
    QMessageBox::about(this, tr("Donate"), tr("Since I did this project on a voluntary basis, I did not find it necessary to highlight donate. So if you are using Brave browser, you can donate it to my github account.") + "<a href=\"https://github.com/herrwinfried\">" + tr("GitHub Page") + "</a>");

}

void wsaoriginal::on_actionGo_to_opengapps_page_triggered()
{
    QMessageBox msgBox;
    msgBox.setWindowIcon(QIcon(":/image/wsa.png"));
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

void wsaoriginal::on_actionGo_to_rg_adguard_page_where_wsa_was_downloaded_triggered()
{
    QMessageBox msgBox;
    msgBox.setWindowIcon(QIcon(":/image/wsa.png"));
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


void wsaoriginal::on_virtual_machine_platform_clicked(bool checked)
    {

        if (checked == false) {
    if (ui->ubuntu->isChecked() == true || ui->opensusetw->isChecked() == true || ui->debian->isChecked() == true) {

            QMessageBox msgBox;
            msgBox.setWindowIcon(QIcon(":/image/wsa.png"));
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
    }
    }
        else {
            ui->statusBar->showMessage(tr("Virtual Machine will be activated."), 10000);
        }
    }

void wsaoriginal::on_powershell_none_pressed()
{
if (ui->ubuntu->isChecked() == true || ui->opensusetw->isChecked() == true || ui->debian->isChecked() == true || ui->adb->isChecked() == true) {

    QMessageBox msgBox;
    msgBox.setWindowIcon(QIcon(":/image/wsa.png"));
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


void wsaoriginal::on_endbutton_accepted()
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
     if (ui->wsatools->isChecked() == true) {
     prep = prep + " -wsatools 1";
     }
     QString Check_vmc;
     if ((ui->ubuntu->isChecked() == true || ui->opensusetw->isChecked() == true || ui->debian->isChecked() == true) && ui->virtual_machine_platform->isChecked() == true) {
     prep = prep + " -vmc 1";
     Check_vmc = "0";
     } else {
         Check_vmc = "1";
     }
     prep = prep + " -onlywsa 1";
     prep = prep + " -gappsvariant default";



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
     if (ui->powershell1->isChecked()) {
        commandq = commandq + ";powershell.exe Set-ExecutionPolicy -ExecutionPolicy Restricted -Scope LocalMachine";
     }
       commandq = commandq + "'";

       if (ui->actionshow_commands_to_type->isChecked() == true) {
          QMessageBox::information(this, "Commands Line", commandq);
       }
      /* QMessageBox xmsgBox;
       xmsgBox.setWindowIcon(QIcon(":/image/wsa.png"));
       xmsgBox.setIcon(QMessageBox::Warning);
       xmsgBox.setWindowTitle(tr("WARNING"));
       xmsgBox.setText(tr("I do not take responsibility. Although this project may seem convincing, it is experimental. If you have WSA installed, you need to uninstall it. It is assumed that you have installed the unspecified base Requirements that are deemed to be met. (WSL, WSL Deployment, WSL User account creation, Powershell core, virtual machine platform)"));
       QAbstractButton* xokey = xmsgBox.addButton(tr("Okey"), QMessageBox::AcceptRole);
       xmsgBox.exec();*/
       //////////////////////////////SXXXX///
       QMessageBox msgBox;
       msgBox.setWindowIcon(QIcon(":/image/wsa.png"));
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


   void wsaoriginal::on_endbutton_rejected()
   {
       this->close();
   }






void wsaoriginal::on_powershell1_clicked(bool checked)
{
    if (checked == true) {
ui->statusBar->showMessage(tr("User selected Recommended Powershell security level."), 10000);
    }

}


void wsaoriginal::on_powershell2_clicked(bool checked)
{
    if (checked == true) {
ui->statusBar->showMessage(tr("The user has chosen to permanently lower the Powershell security level."), 15000);
    }
}


void wsaoriginal::on_powershell_none_clicked(bool checked)
{
    if (checked == true) {
ui->statusBar->showMessage(tr("The user chose not to touch the Powershell security level."), 15000);
    }

}

void wsaoriginal::on_ubuntu_clicked(bool checked)
{
    // | ui->download_gapps->isChecked() == false
    if (checked == true) {
ui->statusBar->showMessage(tr("%1 was selected as the WSL distribution to be processed.").arg("Ubuntu"), 10000);
    }
}

void wsaoriginal::on_opensusetw_clicked(bool checked)
{
    if (checked == true) {
ui->statusBar->showMessage(tr("%1 was selected as the WSL distribution to be processed.").arg("OpenSUSE Tumbleweed"), 10000);

    }
}


void wsaoriginal::on_debian_clicked(bool checked)
{
    if (checked == true) {
ui->statusBar->showMessage(tr("%1 was selected as the WSL distribution to be processed.").arg("Debian"), 10000);
    }
}


void wsaoriginal::on_wsa_none_clicked(bool checked)
{
    if (checked == true) {
ui->statusBar->showMessage(tr("WSL Deployment did not choose."), 10000);
    }
}


void wsaoriginal::on_adb_clicked(bool checked)
{
    if (checked == true) {
ui->statusBar->showMessage(tr("adb will be installed."), 10000);
    } else {
        ui->statusBar->showMessage(tr("adb will be not installed."), 10000);
    }
}


void wsaoriginal::on_wsatools_clicked(bool checked)
{
    if (checked == true) {
ui->statusBar->showMessage(tr("WSATools will be installed."), 10000);
    } else {
        ui->statusBar->showMessage(tr("WSATools will be not installed."), 10000);
    }
}

