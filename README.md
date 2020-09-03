# Introduction 
This is a Windows Forms Application written using the .NET Core 3.1 framework.

This app is designed to convert files to Base64 strings (both decompressed and deflated/compressed) and to convert Base64 strings (both decompressed and deflated/compressed) into files.

# Getting Started
Select a run mode when the application starts up.

# Build and Test
Developers will need the .NET Core 3.1 SDK to be able to develop with this tool. https://dotnet.microsoft.com/download

If you need to make changes to this app and these changes need to be usable by other people who may not have .NET Core installed, the easiest way to publish your changes so that other people can run the .exe is to simply double-click the publishFullySelfContainedExe.bat file in the root solution directory. Doing so will put all the files you need to deploy into Base64FileConverter\bin\Release\netcoreapp3.1\win10-x64\publish.

**Important note:** don't be fooled into thinking you can simply build the solution and have that work on other peoples' machines. If you ONLY build the soltion and use the handful of files that action produces, it will work for people who have the .NET Core 3.1 runtime installed but no one else. Running the publishFullySelfContainedExe.bat file will produce a fully self-contained output that can run on any machine.