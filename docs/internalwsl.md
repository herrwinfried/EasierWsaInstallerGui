# active internal wsl

> Open windows terminal as administrator. You can easily enable it by typing the following command.

```
dism.exe /online /enable-feature /featurename:Microsoft-Windows-Subsystem-Linux /all /norestart
```

```
dism.exe /online /enable-feature /featurename:VirtualMachinePlatform /all /norestart
```

```
DISM /Online /Enable-Feature /All /FeatureName:Microsoft-Hyper-V /norestart
```

Reboot...