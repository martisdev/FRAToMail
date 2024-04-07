[Setup]

UsePreviousLanguage=no

AppName=FraToMail
AppVersion=1.0.0
AppVerName=Factures per E-mail 1.0.0

AppPublisher=MSC Soft
AppPublisherURL=https://www.msc-soft.com
AppUpdatesURL=https://msc-soft.com/download/
AllowNoIcons=yes

SourceDir="C:\MSC Source\Windows_APP\FRAToMail\FRAToMail\bin\Release"

WizardImageFile="logo_vert_164.bmp"
WizardSmallImageFile="logo_55.bmp"
SetupIconFile="logo.ico"

AppCopyright=Copyright 2014, All rights reserved.
PrivilegesRequired=admin
OutputBaseFilename=Setup_FRA_TO_MAIL
DefaultDirName={pf}\fra_to_email
DefaultGroupName=Factures H2O per E-mail

[Tasks]
Name: desktopicon; Description: Crear Icona a l'escriptori; GroupDescription: "Additional icons" 

[Files]
Source: FRAToMail.exe; DestDir: {app};  Flags:  sharedfile
Source: MetroFramework.Design.dll; DestDir: {app};  Flags:  sharedfile
Source: MetroFramework.dll; DestDir: {app};  Flags:  sharedfile
Source: MetroFramework.Fonts.dll; DestDir: {app};  Flags:  sharedfile 
Source: PdfSharp.Charting.dll; DestDir: {app};  Flags:  sharedfile
Source: PdfSharp.dll; DestDir: {app};  Flags:  sharedfile 
Source: BouncyCastle.Cryptography.dll; DestDir: {app};  Flags:  sharedfile
Source: Google.Apis.Auth.dll ; DestDir: {app};  Flags:  sharedfile
Source: Google.Apis.Core.dll ; DestDir: {app};  Flags:  sharedfile
Source: Google.Apis.dll ; DestDir: {app};  Flags:  sharedfile
Source: Google.Apis.Gmail.v1.dll ; DestDir: {app};  Flags:  sharedfile
Source: MetroFramework.Design.dll ; DestDir: {app};  Flags:  sharedfile
Source: MimeKit.dll; DestDir: {app};  Flags:  sharedfile
Source: Newtonsoft.Json.dll ; DestDir: {app};  Flags:  sharedfile
Source: System.Buffers.dll ; DestDir: {app};  Flags:  sharedfile
Source: System.Memory.dll ; DestDir: {app};  Flags:  sharedfile
Source: System.Numerics.Vectors.dll ; DestDir: {app};  Flags:  sharedfile
Source: System.Runtime.CompilerServices.Unsafe.dll; DestDir: {app};  Flags:  sharedfile

[Icons]
Name: "{group}\Factures H2O per E-mail"; Filename: "{app}\FRAToMail.exe"; WorkingDir: "{app}" ;
Name: "{userdesktop}\Factures H2O per E-mail"; Filename: "{app}\FRAToMail.exe"; WorkingDir: "{app}";
