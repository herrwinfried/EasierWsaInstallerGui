[_Read English_](https://github.com/herrwinfried/EasierWsaInstallerGui/blob/alpha/README.md)


# Uyarı
**Bu deneysel bir projedir. Karşılaşacağınız bir olaydan biz sorumlu değiliz. Bunu kendi bilincinizin içinde yapın.**

# EasierWsaInstallerGui nedir?

EasierWsaInstallerGui, EasierWsaInstaller grafik arayüzüne dönüştürülmüş ve daha az komut satırı yazmanız için tasarlanmış bir projedir.

# Grafik arayüz yerine benim komut satırımı mı arıyorsunuz?
[EasierWsaInstaller projemizi deneyin](https://github.com/herrwinfried/EasierWsaInstaller#readme)

# Kurulumu Gösteren Video

[![image](https://user-images.githubusercontent.com/52379312/193453617-98d3fdd9-d3a0-4d50-8ec2-36b77d6120ca.png)](https://youtu.be/GbHFhOz-JTk)


# Gereksinimleri nelerdir?

> ubuntu, OpenSUSE Tumbleweed veya debian'ı tamamen kurmanız gerekiyor. Bu nedenle, bir Kullanıcı hesabı oluşturmanız gerekir.

- Minimum Windows 11 cihazınız olmalıdır. Yalnızca Windows 11 için ayarlanmıştır.

- [Sanal Makine Platformu Aktif Olmalı](#virtual-machine-platform-mus-be-active)
- [Geliştirici Modu aktif olmalıdır.](#developer-mode-must-be-turned-on) **(MagiskOnWSA ve WSAGAScript yöntemini kullanacaksanız geçerlidir.)**
- [WSL](https://aka.ms/wslstorepage)
- [Ubuntu](https://www.microsoft.com/store/productId/9PDXGNCFSCZV), [OpenSUSE Tumbleweed](https://www.microsoft.com/p/opensuse-tumbleweed/9mssk2zxxn11) veya [Debian]( https://www.microsoft.com/p/debian/9msvkqc78pk6)
- [Powershell Core(7+)](https://www.microsoft.com/en-us/p/powershell/9mz1snwt0n5d)

## **Bunu daha az güçlükle yapmak mümkün mü?**
Evet, Gereksinimler Bölmesinde Hazırla düğmesi vardır. Sizin için çoğunu yapmasını sağlayabilirsiniz. Ancak, bilgisayarınızı yeniden başlattıktan sonra Ubuntu'yu açmanız ve bir Kullanıcı hesabı oluşturmanız gerekir.

* Kendiniz halletmek isterseniz sorun değil. Devam edelim.*

## Geliştirici Modu açık olmalıdır.
> Ayarlar > Gizlilik ve güvenlik > Geliştiriciler için > Geliştirici Modu
> ![image](https://user-images.githubusercontent.com/52379312/138754144-e81779ea-4c61-46c6-8860-6c39b33aab47.png)

## **Sanal Makine Platformu etkin olmalıdır.**

> Windows terminalini yönetici olarak açın. Aşağıdaki komutu yazarak kolayca etkinleştirebilirsiniz. Kurduğunuzda Ubuntu, OpenSUSE Tumbleweed veya Debian WSL'yi etkinleştirmiş olmalısınız.

> ```
> dism.exe /online /enable-feature /featurename:VirtualMachinePlatform /all /norestart
> ```
> Ubuntu, openSUSE Tumbleweed veya Debian kullanmak için [WSL](https://aka.ms/wslstorepage)'i de Etkinleştirmeniz gerekir.

["Nasıl İndiririm?" Bölümüne Git"](#how-do-i-download)

## **How Do I Download?**

> NOT: Baktığınızda daha yeni bir versiyon olabilir, bu yüzden versiyona aldanmayın.

![image](https://user-images.githubusercontent.com/52379312/193084466-a23bd4d4-8b73-43ba-83a6-5f20b7c1883e.png)


"EasierWsaInstallerGui 2.0.1 - Portable" üzerine tıklayın.

![image](https://user-images.githubusercontent.com/52379312/193084631-d4cdfe6e-e6ca-482f-9b1f-e6ac16663ddf.png)


"wsagui_beta_2.0.1-portable.zip" yazanı indirin.

Çalıştırmak için zip dosyasını çıkarın, ardından içindeki EasierWsaInstaller.Desktop(.exe) dosyasına basın.

# SSS

## WSA veya Magisk Güncellenirse ne yapmalıyım?

MagiskOnWsaLocal ve Wsagascript metodlarımız dosyanın orijinalinden modifiye edildiği için aynı işlemleri tekrar yapmalısınız. Mağazadan güncelleme almaz.

## Root nedir?

Root'u Windows'ta bir yönetici hesabı olarak düşünebilirsiniz. Bazı yerlerde süper kullanıcı olarak da adlandırılabilir. Bu soruyu WSL için soruyorsanız, kullanıcı hesabını oluştururken kullandığınız şifredir.

## Peki ya önceki sürümler? Sürüm numaraları neden geriye gitti?

[anlamsal sürüm](https://semver.org/) ile devam etmeye karar verdik, bu yüzden onu sıfırdan aldık. Eski sürümlerimiz desteklenmeyecektir.

## WinForm yerine ne kullanıyorsunuz?

[AvaloniUI](https://avaloniaui.net) kullanıyoruz. Ancak Cross-Platform'u desteklese de proje gereği sadece windows ile uyumlu çalışacaktır.

# Sorunlar
Sorularınızı [Sorunlar](https://github.com/herrwinfried/wsa-gui/issues) (ingilizce yazınız) üzerinden sormayı unutmayın; SSS, siz sorularınızı sordukça güncellenecektir.


