# BBDN-REST-Demo-CSharp
This project contains sample code for interacting with the Blackboard Learn REST Web Services in C#. This sample was built in Microsoft Visual Studio Community 2019 against .NET Framework 4.7.2. It uses HttpClient and async/await processing.

### Project at a glance:
- Target: Blackboard Learn SaaS 2015.12.0 and above
- Source Release: v2.0
- Release Date  2020-11-02
- Author: shurrey
- Tested on Blackboard Learn SaaS Release 3800.19.0-rel.54+54663c8

### Requirements:
- Visual Studio - This sample was built with Microsoft Visual Studio Community 2019
- Requires the following libraries for .NET Framework 4.7.2:
  - Microsoft.Bcl version 1.1.10
  - Microsoft.Bcl.Build version 1.0.21
  - Microsoft.Net.Http version 2.2.29
  - Newtonsoft.Json version 12.0.3
  - Nito.AsyncEx version 5.1.0
  - Nito.AsyncEx.Context version 5.1.0
  - Nito.AsyncEx.Tasks version 5.1.0
  - Nito.Disposables version 2.2.0
  - System.Collections.Immutable version 1.4.0

### Setting Up Your Project
Open Microsoft Visual Studio. Click File->Open and navigate to the directory you cloned this project in. Select BBDN-REST-Demo-CSharp.sln and open it. Your project workspace is now ready to go.

You may need to add a few references. To accomplish this, you will need to right click on 'References' in the Solution Explorer and then select 'Add Reference...'. From the subsequent screen, use the search tool to discover and install the packages listed above.

### Configuring the Code Sample
All data is located in the BBDN-REST-Demo-CSharp/bbdn/rest/Constants.cs file. You <i>can</i> change these values as you see fit. However, you must change three values:
- HOSTNAME: must be set equal to your test environment's URL with https.
- KEY: replace <insert your key> with your key.
- SECRET: replace <insert your secret> with your secret.

### Building the Code Sample
If all of the steps above have been followed, you should just be able to build the project. In the UI, you can either type CTRL+SHIFT+B or select Build->Build Project from the menu. The exe will be built in placed in either bin/Debug or bin/Release, depending upon your build configuration settings in Visual Studio.

### Using the Code Sample
This is a console app. You can run from an MS-DOS prompt, or set up your project properties to send the appropriate command line arguments. The sample code allows you to perform the full Create, Read, Update, and Delete options on the following five objects:
- Datasource
- Term
- Course
- User
- Membership

You can also run all operations on all objects.

The syntax is BBDN-REST-Demo-Csharp.exe --<object> CRUD or BBDN-REST-Demo-CSharp --all

For CRUD, you can enter a string with the operations you wish to perform on the object. for --all, all operations are assumed. C = Create, R = Read, U = Update, D = Delete. There should be no spaces. Ordering doesn't matter, but only CRUD are accepted. Any other value is ignored.
	
### Conclusion
This code will give you the base knowledge you need to interact with the Blackboard Learn REST services using C#. For a thorough walkthrough of this code, visit the corresponding Community site page <a href="https://docs.blackboard.com/learn/REST/REST%20Demo%20Using%20CSharp.html" target="_blank">here</a>.
