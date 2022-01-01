#ifndef WSAORIGINAL_H
#define WSAORIGINAL_H

#include <QMainWindow>

namespace Ui {
class wsaoriginal;
}

class wsaoriginal : public QMainWindow
{
    Q_OBJECT

public:
    explicit wsaoriginal(QWidget *parent = nullptr);
    ~wsaoriginal();

private slots:
    void on_actionMS_Store_for_powershell_triggered();

    void on_actionMS_Store_for_WSL_triggered();

    void on_actionMS_Store_for_Ubuntu_triggered();

    void on_actionMS_Store_for_OpenSUSE_Tumbleweed_triggered();

    void on_actionMS_Store_for_Debian_triggered();

    void on_actionMy_GitHub_triggered();

    void on_actionProject_Page_triggered();

    void on_actionGo_to_licence_triggered();

    void on_actionApplication_About_triggered();

    void on_actionOnly_WSA_opengapps_triggered();

    void on_actionAbout_triggered();

    void on_actionDonate_triggered();

    void on_switchbutton_pressed();

    void on_virtual_machine_platform_clicked(bool checked);

    void on_powershell_none_pressed();

    void on_endbutton_accepted();

    void on_endbutton_rejected();

    void on_powershell1_clicked(bool checked);

    void on_powershell2_clicked(bool checked);

    void on_powershell_none_clicked(bool checked);

    void on_ubuntu_clicked(bool checked);

    void on_opensusetw_clicked(bool checked);

    void on_debian_clicked(bool checked);

    void on_wsa_none_clicked(bool checked);

    void on_adb_clicked(bool checked);

    void on_wsatools_clicked(bool checked);

    void on_actionGo_to_opengapps_page_triggered();

    void on_actionGo_to_rg_adguard_page_where_wsa_was_downloaded_triggered();

    void on_actionMS_Store_For_WSATools_triggered();

    void on_actionMS_Store_for_WSA_triggered();


    void on_pushButton_wsa_msstore_clicked();

private:
    Ui::wsaoriginal *ui;
};

#endif // WSAORIGINAL_H
