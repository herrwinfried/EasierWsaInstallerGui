if (!([Security.Principal.WindowsPrincipal][Security.Principal.WindowsIdentity]::GetCurrent()).IsInRole([Security.Principal.WindowsBuiltInRole] "Administrator")) { Start-Process powershell.exe "-NoProfile -ExecutionPolicy Bypass -File `"$PSCommandPath`"" -Verb RunAs; exit }

$apiUrl = "https://store.rg-adguard.net/api/GetFiles"

$productUrl = "https://www.microsoft.com/store/productId/9P3395VX91NR" # To Do

$downloadFolder = Join-Path $env:TEMP "StoreDownloads"
if(!(Test-Path $downloadFolder -PathType Container)) {
    New-Item $downloadFolder -ItemType Directory -Force
}

mkdir 'C:\wsaproject'

$body = @{
    type = 'url'
    url  = $productUrl
    ring = 'Slow'
    lang = 'en-US'
}

$raw = Invoke-RestMethod -Method Post -Uri $apiUrl -ContentType 'application/x-www-form-urlencoded' -Body $body

$raw | Select-String '<tr style.*<a href=\"(?<url>.*)"\s.*>(?<text>.*)<\/a>' -AllMatches
| % { $_.Matches }
| % { 
    $url = $_.Groups[1].Value
    $text = $_.Groups[2].Value

    if($text -match "_(neutral).*msixbundle$") {
        Write-Host $text $url
       $downloadFile = Join-Path $downloadFolder $text
        Invoke-WebRequest -Uri $url -OutFile "C:\wsaproject\$text"
        pause
    }
}
