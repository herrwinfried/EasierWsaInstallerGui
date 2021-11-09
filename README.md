#
This project is a GUI ported and simplified version of [WSA-Script](https://github.com/herrwinfried/wsa-script).

![image](https://user-images.githubusercontent.com/52379312/140661118-b6808f10-b476-426c-8da0-aec57ca40a08.png)

## Important Information
**You need to delete the pre-installed WSA. You cannot get updates from Microsoft Store after installing WSA.**

> The ARM version is still beta, please give feedback when you encounter an error.

## Information
if you want to handle things with terminal. [Click here](https://github.com/herrwinfried/wsa-scriptg)

## An amateur video showing the installation

[![q_yd7DohKQA](https://img.youtube.com/vi/iL2ux-dNL84/0.jpg)](https://www.youtube.com/watch?v=iL2ux-dNL84)

https://youtu.be/iL2ux-dNL84

## Requirements

- Windows 11
- [Powershell 7+](https://www.microsoft.com/en-us/p/powershell/9mz1snwt0n5d)
- [Developer mode must be on](https://github.com/herrwinfried/wsa-gui/blob/main/docs/developermode.md)
- [Active Virtual Machine Platform](https://github.com/herrwinfried/wsa-gui/blob/main/docs/vmp.md)
- [WSL](https://aka.ms/wslstorepage) or [internal wsl](https://github.com/herrwinfried/wsa-gui/blob/main/docs/internalwsl.md)
- [Ubuntu](https://www.microsoft.com/en-us/p/ubuntu/9nblggh4msv6) or [openSUSE Tumbleweed](https://www.microsoft.com/en-us/p/opensuse-tumbleweed/9mssk2zxxn11)

> **NOTE: You can also install Powershell from outside the ms store. But it should run as pwsh.exe. You can install WSL internally outside of MS Store, it might be more robust.**

If you don't remove the WSA and opengapps download option, which is now selected by default in the graphical interface, it will download it for you.

**There is one point I must warn about. It is created in the directory named wsaproject and wsa, if these folders are full, they are emptied. (except for necessary files). If you choose to download WSA and OpenGapps. Keyword files containing WSA and opengapps in the directory named wsaproject are deleted. (If you select only WSA, the file belonging to the wsa will be deleted.)**

If you set your Powershell level to none, it is recommended to make it default in case you run into problems.

I left an optional option for you to install adb in the program, and you may have installed adb by selecting it.

### **Brief introduction for adb**

A tool to help you access shell remotely on your WSA.

### **Why didn't you write about openGapps and WSA download?**

 How to download opengapps and wsa is available in the docs section of [WSA-Script/docs](https://github.com/herrwinfried/wsa-script/docs). You can look there.

## **How Do I Download?**

> NOTE: There may be a newer version when you look, so don't be fooled by the version.

![image](https://user-images.githubusercontent.com/52379312/140661296-816d7db5-c0e8-466e-a179-ebe33abcf23b.png)

Click on "WSAGui 1.0.0 - Portable".

![image](https://user-images.githubusercontent.com/52379312/140661350-5578335a-6150-41b1-8f8c-4ad5f6e88f1a.png)

Download the one that says "wsagui_beta_1.0.0-portable.zip".

To run it, extract the zip, then press the WSAgui(.exe) file inside.