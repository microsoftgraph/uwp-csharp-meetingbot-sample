# Microsoft Graph MeetingBot sample for UWP


**Table of contents**

* [Introduction](#introduction)
* [Prerequisites](#prerequisites)
* [Register and configure the app](#register)
* [Build and debug](#build)
* [Running the sample](#runningsample)
* [Questions and comments](#questions)
* [Additional resources](#additional-resources)

<a name="introduction"></a>
## Introduction

This sample demonstrates how to integrate Microsoft Graph capabilities into a UWP app that uses Cortana voice commands. Once you've installed it and signed in, you can activate it by asking Cortana to show the next meeting on your calendar and/or asking Cortana to tell the participants of your next meeting that you're running late.

It uses the [Microsoft Graph .NET Client Library](https://github.com/microsoftgraph/msgraph-sdk-dotnet) to work with data returned by Microsoft Graph. The sample uses the v2.0 authentication endpoint, which enables users to sign in with either their personal or work or school Microsoft accounts.

<a name="prerequisites"></a>
## Prerequisites ##

This sample requires the following:  

  * [Visual Studio 2015](https://www.visualstudio.com/en-us/downloads) 
  * Windows 10 ([development mode enabled](https://msdn.microsoft.com/library/windows/apps/xaml/dn706236.aspx))
  * Either a [Microsoft](www.outlook.com) or [Office 365 for business account](https://msdn.microsoft.com/en-us/office/office365/howto/setup-development-environment#bk_Office365Account).

<a name="register"></a>
## Register and configure the app

1. Sign into the [App Registration Portal](https://apps.dev.microsoft.com/) using either your personal or work or school account.
2. Select **Add an app**.
3. Enter a name for the app, and select **Create application**.
	
	The registration page displays, listing the properties of your app.
 
4. Under **Platforms**, select **Add platform**.
5. Select **Native Application**.
6. Copy the Application Id to the clipboard. You'll need to enter this value into the sample app.

	The app id is a unique identifier for your app. The redirect URI is a unique URI provided by Windows 10 for each application to ensure that messages sent to that URI are only sent to that application. 

7. Select **Save**.

<a name="build"></a>
## Build and debug ##

**Note:** If you see any errors while installing packages during step 2, make sure the local path where you placed the solution is not too long/deep. Moving the solution closer to the root of your drive resolves this issue.

1. After you've loaded the solution in Visual Studio, configure the sample to use the application id that you registered by adding the corresponding values for these keys in the Application.Resources node of the App.xaml file.
![Microsoft Graph MeetingBot sample](/readme-images/appId_and_redirectURI.png "App ID value in App.xaml file")

2. Press F5 to build and debug. Run the solution and sign in with either your personal or work or school account.

<a name="runningsample"></a>
## Running the sample ##

When you first run the sample, you'll be prompted to sign in with your [Microsoft](www.outlook.com) or [Office 365 for business account](https://msdn.microsoft.com/en-us/office/office365/howto/setup-development-environment#bk_Office365Account). After you've authenticated and consented to the required permissions, you won't have to sign in again unless you want to run the sample with another account. 

If you want to sign out and then sign in with a different account, select the **disconnect**  button at the top right of the app and then select the **connect** button to its left.

After you've installed and run the app once, you can activate it at any time by issuing the following voice commands to Cortana:

1. "MeetingBot, show my next meeting."
2. "MeetingBot, tell my next meeting I'm going to be late."

If you've [enabled the "Hey Cortana" feature](https://www.cnet.com/how-to/how-to-enable-hey-cortana-on-windows-10/), you can activate the app at any time by issuing these voice commands to your device:

1. "Hey Cortana, ask MeetingBot to show my next meeting."
2. "Hey Cortana, ask MeetingBot to tell my next meeting I'm going to be late."

In both cases, the app will launch and display the title and time frame of your next meeting. If you ask MeetingBot to tell your next meeting that you're going to be late, the app will either confirm that it has sent a "running late" message to your next meeting's participants, or it will tell you that it couldn't find the meeting invitation in your account's mailbox.

![Microsoft Graph MeetingBot sample](/readme-images/MeetingBotLateMessage.png "MeetingBot after sending the running late message")

<a name="contributing"></a>
## Contributing ##

If you'd like to contribute to this sample, see [CONTRIBUTING.MD](/CONTRIBUTING.md).

This project has adopted the [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/). For more information see the [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) or contact [opencode@microsoft.com](mailto:opencode@microsoft.com) with any additional questions or comments.

<a name="questions"></a>
## Questions and comments

We'd love to get your feedback about the Microsoft Graph MeetingBot for UWP project. You can send your questions and suggestions to us in the [Issues](https://github.com/microsoftgraph/uwp-csharp-meetingbot-sample/issues) section of this repository.

Your feedback is important to us. Connect with us on [Stack Overflow](http://stackoverflow.com/questions/tagged/microsoftgraph). Tag your questions with [MicrosoftGraph].

<a name="additional-resources"></a>
## Additional resources ##

- [Other Microsoft Graph UWP samples](https://github.com/microsoftgraph?utf8=%E2%9C%93&query=uwp)
- [Microsoft Graph overview](http://graph.microsoft.io)
- [Office developer code samples](http://dev.office.com/code-samples)
- [Office dev center](http://dev.office.com/)


## Copyright
Copyright (c) 2016 Microsoft. All rights reserved.

