This project, FourFiveConsole, is targeting .NET 4.5.2 framework. It has a project reference to NetStandandarLibrary project which produces a .NET Standard 2.0 assembly. When this project is compiled, it gives the following error. 

Error: Project '..\NetStandardLibrary\NetStandardLibrary.csproj' targets 'netstandard2.0'. It cannot be referenced by a project that targets '.NETFramework,Version=v4.5'. [K:\git\gitsparty\DotNet\NetStandard\FourFiveConsole\FourFiveConsole.csproj]

Homework Question
+++++++++++++++++
Can NetStandardLibrary be changed in some way to make it work with this project?