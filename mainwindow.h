#ifndef MAINWINDOW_H
#define MAINWINDOW_H

#include <QMainWindow>

QT_BEGIN_NAMESPACE
namespace Ui { class MainWindow; }
QT_END_NAMESPACE

class MainWindow : public QMainWindow
{
    Q_OBJECT

public:
    MainWindow(QWidget *parent = nullptr);
    ~MainWindow();

private slots:
    void on_buttonBox_rejected();

    void on_ubuntu_clicked(bool checked);

    void on_opensuse_clicked(bool checked);

    void on_nowsa_clicked(bool checked);

    void on_vmp_clicked(bool checked);

    void on_nops_clicked(bool checked);

    void on_buttonBox_accepted();

    void on_downloadwsa_clicked(bool checked);

    void on_downloadgapps_clicked(bool checked);

    void on_nops_pressed();

    void on_mygithub_pressed();

    void on_mswsl_pressed();

    void on_msubuntu_pressed();

    void on_msopensusetw_pressed();


    void on_wsadownloadpage_pressed();

    void on_gappsdownloadpage_pressed();

private:
    Ui::MainWindow *ui;
};
#endif // MAINWINDOW_H
