#include "mainwindow.h"

#include <QApplication>
#include <QLocale>
#include <QTranslator>
#include <QFile>
#include <QInputDialog>
int main(int argc, char *argv[])
{

    QApplication a(argc, argv);

    QTranslator translator;
    const QStringList uiLanguages = QLocale::system().uiLanguages();
    for (const QString &locale : uiLanguages) {
        const QString baseName = "wsa-gui_" + QLocale(locale).name();
        if (translator.load(":/i18n/" + baseName)) {
            a.installTranslator(&translator);
            break;
        }
    }
   /* QStringList themes;
    themes << QInputDialog::tr("Light") << QInputDialog::tr("Dark[BETA]");

    bool ok;
    QString theme = QInputDialog::getItem(NULL, QInputDialog::tr("Select Theme"),
                                         QInputDialog::tr("Select Theme:"), themes, 0, false, &ok);

    if (theme == QInputDialog::tr("Dark[BETA]")) {
        QFile styleSheetFile(":/theme/themedark1.qss");
    styleSheetFile.open(QFile::ReadOnly);
    QString StyleSheet = QLatin1String(styleSheetFile.readAll());
    a.setStyleSheet(StyleSheet);
    }
*/
    MainWindow w;
    w.show();
    return a.exec();
}
