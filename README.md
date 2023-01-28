[_Türkçe Oku_](https://github.com/herrwinfried/EasierWsaInstallerGui/blob/alpha/README-TR.md)

# Warning
**This is an experimental project. We are not responsible for an incident that you will encounter. Do it within your own consciousness.**

# What is EasierWsaInstallerGui?

EasierWsaInstallerGui is a project that has been converted to a EasierWsaInstaller graphical interface and is intended for you to write less command lines.

# Are you looking for my command line instead of the graphical interface?
[Try our EasierWsaInstaller project](https://github.com/herrwinfried/EasierWsaInstaller#readme)

# Video Showing Installation

[![image](https://user-images.githubusercontent.com/52379312/215293594-f8099bda-5a1a-4046-8668-96da842f9d20.png)](https://youtu.be/CqYldLypxYs)


# What are the Requirements?

> You need to fully install ubuntu, OpenSUSE Tumbleweed or debian. So you have to create a User account.

- You must have a minimum Windows 11 device. It is adjusted for Windows 11 only.

- [Virtual Machine Platform Must Be Active](#virtual-machine-platform-must-be-active)
- [Developer Mode must be active.](#developer-mode-must-be-turned-on) **(Applicable if you are going to use the MagiskOnWSA and WSAGAScript method.)**
- [WSL](https://aka.ms/wslstorepage)
- [Ubuntu](https://www.microsoft.com/store/productId/9PDXGNCFSCZV), [OpenSUSE Tumbleweed](https://www.microsoft.com/p/opensuse-tumbleweed/9mssk2zxxn11) or [Debian](https://www.microsoft.com/p/debian/9msvkqc78pk6)
- [Powershell Core(7+)](https://www.microsoft.com/en-us/p/powershell/9mz1snwt0n5d)

## **Is it possible to do it with less hassle?**
Yes, there is a Prepare button in the Requirements Pane. You can have it do most of it for you. However, after restarting your computer, you need to open Ubuntu and create a User account.

*No problem if you want to handle it yourself. Lets continue.*

## Developer Mode must be turned on.
> Settings > Privacy & security > For Developers > Developer Mode
> ![image](https://user-images.githubusercontent.com/52379312/138754144-e81779ea-4c61-46c6-8860-6c39b33aab47.png)

## **Virtual Machine Platform must be active.**

> Open windows terminal as administrator. You can easily enable it by typing the following command. You should have enabled Ubuntu, OpenSUSE Tumbleweed or Debian WSL when you installed it.

> ```
> dism.exe /online /enable-feature /featurename:VirtualMachinePlatform /all /norestart
> ```
> You need to Activate [WSL](https://aka.ms/wslstorepage) also to use ubuntu, openSUSE Tumbleweed or Debian

[Go To "How Do I Download?"](#how-do-i-download)

## **How Do I Download?**

> NOTE: There may be a newer version when you look, so don't be fooled by the version.

![image](https://user-images.githubusercontent.com/52379312/193084466-a23bd4d4-8b73-43ba-83a6-5f20b7c1883e.png)


Click on "EasierWsaInstallerGui 2.0.1 - Portable".

![image](https://user-images.githubusercontent.com/52379312/193084631-d4cdfe6e-e6ca-482f-9b1f-e6ac16663ddf.png)


Download the one that says "wsagui_beta_2.0.1-portable.zip".

To run it, extract the zip, then press the EasierWsaInstaller.Desktop(.exe) file inside.


# FAQ

## What do I do if WSA or Magisk is Updated?

Since our MagiskOnWsaLocal and Wsagascript methods are modified from the originality of the file, you should do the same operations again. It will not receive updates from the store.

## What is root?

You can think of root as an administrator account in Windows. It can also be called a superuser in some places. If you're asking this question for WSL, it's your password when creating the user account.

## What about previous versions? Why Version numbers went backwards ?

We decided to go with the [semantic version](https://semver.org/), so we took it from scratch. Our old versions will not be supported.

## What are you using instead of WinForm?

We are using [AvaloniUI](https://avaloniaui.net). However, although it supports Cross-Platform, it will only work compatible with windows due to the project.

# Issues
Don't forget to ask your questions on [Issues](https://github.com/herrwinfried/wsa-gui/issues), and the FAQ will be updated as you ask your questions.


