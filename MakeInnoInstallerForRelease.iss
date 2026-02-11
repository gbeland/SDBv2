[Setup]
AppName=SDB
AppVersion=26.2.11.2
AppPublisher=Prismview
AppPublisherURL=http://www.prismview.com/
AppSupportURL=http://www.prismview.com/
AppUpdatesURL=http://www.prismview.com/
DefaultDirName={autopf}\Prismview\SDB
DefaultGroupName=Prismview
AllowNoIcons=yes
OutputBaseFilename=SetupSDB_V26-2-11-2
Compression=lzma
SolidCompression=yes
PrivilegesRequired=admin
ArchitecturesInstallIn64BitMode=x64

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked
Name: "quicklaunchicon"; Description: "{cm:CreateQuickLaunchIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked; OnlyBelowVersion: 0,6.1

[Files]
; IMPORTANT: Build the SDB project in Release mode before compiling this script!
Source: "SDB\bin\Release\SDB.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "SDB\bin\Release\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{group}\SDB"; Filename: "{app}\SDB.exe"
Name: "{group}\{cm:UninstallProgram,SDB}"; Filename: "{uninstallexe}"
Name: "{commondesktop}\SDB"; Filename: "{app}\SDB.exe"; Tasks: desktopicon
Name: "{userappdata}\Microsoft\Internet Explorer\Quick Launch\SDB"; Filename: "{app}\SDB.exe"; Tasks: quicklaunchicon

[Run]
Filename: "{app}\SDB.exe"; Description: "{cm:LaunchProgram,SDB}"; Flags: nowait postinstall skipifsilent
