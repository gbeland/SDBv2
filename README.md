# SDB (Service Database)

## Overview
A database application that manages digital displays, their maintenance and repair, parts replacement, shipping, and tracking.

## Building the Installer

### Prerequisites
- **Inno Setup 6+** installed.
- **Visual Studio** with .NET Framework 4.8 support.

### Steps to Create the Installer

1.  **Build the Application**:
    - Open `SDB.sln` in Visual Studio.
    - Set the configuration to **Release**.
    - **Rebuild** the `SDB` project. This ensures `SDB\bin\Release` contains the latest files and the correct `SDB.exe` with the embedded manifest.

2.  **Compile the Installer Script**:
    - Open `Setup.iss` (located in the repository root) using **Inno Setup Compiler**.
    - Click **Compile**.

3.  **Locate the Installer**:
    - The generated installer `SetupSDB_Inno.exe` will be created in the repository root (or the directory configured in your Inno Setup settings).

4.  **Verify**:
    - Run the installer to update the application.
    - Launch SDB and confirm that scaling and versioning are correct.
