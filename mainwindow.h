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

    void on_buttonBox_accepted();

    void on_buttonBox_rejected();

    void on_ubuntu_clicked(bool checked);

    void on_opensuse_clicked(bool checked);

    void on_notwsa_clicked(bool checked);

    void on_powershellmodeend_clicked(bool checked);

    void on_powershellmode_clicked(bool checked);

    void on_notpowershelllevel_clicked(bool checked);



private:
    Ui::MainWindow *ui;
};
#endif // MAINWINDOW_H
