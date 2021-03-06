; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "Request System"
#define MyAppVersion "beta"
#define MyAppPublisher "Eduardo Seminotti Amaral"
#define MyAppExeName "Request System.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application. Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{B85979EA-E3B5-42D5-BE91-D9014AD665CD}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
DefaultDirName=c:\{#MyAppName}
DisableProgramGroupPage=yes
; Uncomment the following line to run in non administrative install mode (install for current user only.)
;PrivilegesRequired=lowest
OutputDir=C:\Users\Eduardo\OneDrive\Projetos Visual Studio\git.Eduardo\Sistema de Solicitações C#\Instaladores
OutputBaseFilename=RequestSystemInstaller
SetupIconFile=C:\Users\Eduardo\OneDrive\Projetos Visual Studio\git.Eduardo\Sistema de Solicitações C#\Request System\Imagens\Icone.ico
Compression=lzma
SolidCompression=yes
WizardStyle=modern

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"
Name: "brazilianportuguese"; MessagesFile: "compiler:Languages\BrazilianPortuguese.isl"
Name: "spanish"; MessagesFile: "compiler:Languages\Spanish.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "C:\Users\Eduardo\OneDrive\Projetos Visual Studio\git.Eduardo\Sistema de Solicitações C#\Request System\Request System\bin\Release\Request System.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Eduardo\OneDrive\Projetos Visual Studio\git.Eduardo\Sistema de Solicitações C#\Request System\Request System\bin\Release\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{autoprograms}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

