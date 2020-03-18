---
page_type: sample
products:
- office-outlook
- ms-graph
languages:
- csharp
- windows-uwp
extensions:
  contentType: samples
  technologies:
  - Microsoft Graph 
  services:
  - Outlook
  createdDate: 9/28/2016 4:33:07 PM
---
# 适用于 UWP 的 Microsoft Graph MeetingBot 示例

## 目录

* [简介](#introduction)
* [先决条件](#prerequisites)
* [注册和配置应用](#register)
* [构建和调试](#build)
* [运行示例](#runningsample)
* [问题和意见](#questions)
* [其他资源](#additional-resources)

<a name="introduction"></a>
## 简介

本示例演示如何将 Microsoft Graph 功能集成到使用 Cortana 语音命令的 UWP 应用中。安装本示例应用并登录后，你可以通过让 Cortana 在你的日历上显示下一个会议和/或让 Cortana 告诉与会者你将推迟下一个会议，从而将该应用激活。

该应用使用 [Microsoft Graph .NET 客户端库](https://github.com/microsoftgraph/msgraph-sdk-dotnet)来处理 Microsoft Graph 返回的数据。本示例使用 v2.0 版身份验证终结点，让用户可以通过其个人或工作/学校 Microsoft 帐户进行登录。

<a name="prerequisites"></a>
## 先决条件

此示例要求如下：  

* [Visual Studio](https://www.visualstudio.com/en-us/downloads) 
* Windows 10（[已启用开发模式](https://msdn.microsoft.com/library/windows/apps/xaml/dn706236.aspx)）
* [Microsoft](www.outlook.com) 或 [Office 365 商业版帐户](https://msdn.microsoft.com/en-us/office/office365/howto/setup-development-environment#bk_Office365Account)。

<a name="register"></a>
## 注册应用

1. 导航到 [Azure 门户](https://aka.ms/AppRegistrations)以注册应用。使用**个人帐户**（也称为：“Microsoft 帐户”）或**工作/学校帐户**登录。

2. 选择“**新注册**”。在“**注册应用**”页面上，按如下方式设置值。

    * 将“**名称**”设置为 `MeetingBot-Sample`。
    * 将“**受支持的帐户类型**”设置为“**任何组织目录中的帐户和个人 Microsoft 帐户**”。
    * 保留“**重定向 URI**”为空。
    * 选择“**注册**”。

3. 在“**MeetingBot-Sample**”页面上，复制“**应用程序(客户端) ID**”的值。稍后需要用到此值。

4. 选择“**添加重定向 URI**”链接。在“**重定向 URL**”页面上，找到“**建议用于公共客户端（移动、桌面）的重定向 URI**”部分。选择以 `msal` 开头的 URI **以及** **urn:ietf:wg:oauth:2.0:oob** URI。

5. 选择页面顶部的“**保存**”。

<a name="build"></a>
## 生成和调试

**注意：**如果在步骤 2 安装程序包时出现任何错误，请确保您放置该解决方案的本地路径并未太长/太深。若要解决此问题，可以将解决方案移到更接近驱动器根目录的位置。

1. 在 Visual Studio 中加载解决方案后，请配置本示例以便使用你注册的应用程序 ID（在 App.xaml 文件的 Application.Resources 节点中添加这些键的相应值）。
![Microsoft Graph MeetingBot 示例](/readme-images/appId_and_redirectURI.png "App.xaml 文件中的应用 ID 值")

2. 按 F5 生成和调试。运行此解决方案并使用个人或工作/学校帐户登录。

<a name="runningsample"></a>
## 运行示例

第一次运行本示例时，系统将提示你使用 [Microsoft](www.outlook.com) 或 [Office 365 商业版帐户](https://msdn.microsoft.com/en-us/office/office365/howto/setup-development-environment#bk_Office365Account)登录。经过身份验证并同意所需的权限后，除非想要使用其他帐户运行本示例，否则无需再次登录。 

如果想注销，然后使用其他帐户登录，请选择该应用右上角的“**断开连接**”按钮，然后选择其左侧的“**连接**”按钮。

安装并运行一次应用后，可随时通过向 Cortana 发出以下语音命令来激活该应用：

1. “MeetingBot，显示我的下一个会议。”
2. “MeetingBot，告诉我下一个即将迟到的会议。”

如果已[启用了“你好小娜”功能](https://www.cnet.com/how-to/how-to-enable-hey-cortana-on-windows-10/)，可随时通过向设备发出以下语音命令来激活应用：

1. “你好小娜，请让 MeetingBot 显示我的下一个会议。”
2. “你好小娜，请让 MeetingBot 告诉我下一个即将迟到的会议。”

在这两种情况下，该应用都将启动，并显示下一个会议的标题和时间范围。如果你让 MeetingBot 告诉你下一个即将迟到的会议，该应用将确认其是否已向你下一个会议的与会者发送了“推迟”邮件，或者该应用会告诉你在你帐户的邮箱中无法找到会议邀请。

![Microsoft Graph MeetingBot 示例](/readme-images/MeetingBotLateMessage.png "MeetingBot 在发送推迟邮件后")

<a name="contributing"></a>
## 参与

如果想要参与本示例，请参阅 [CONTRIBUTING.MD](/CONTRIBUTING.md)。

此项目已采用 [Microsoft 开放源代码行为准则](https://opensource.microsoft.com/codeofconduct/)。有关详细信息，请参阅[行为准则常见问题解答](https://opensource.microsoft.com/codeofconduct/faq/)。如有其他任何问题或意见，也可联系 [opencode@microsoft.com](mailto:opencode@microsoft.com)。

<a name="questions"></a>
## 问题和意见

我们乐意倾听你对于适用于 UWP 的 Microsoft Graph MeetingBot 项目的反馈。你可通过该存储库中的[问题](https://github.com/microsoftgraph/uwp-csharp-meetingbot-sample/issues)部分向我们发送问题和建议。

您的反馈对我们意义重大。请在[堆栈溢出](http://stackoverflow.com/questions/tagged/microsoftgraph)上与我们联系。请给你的问题添加 [MicrosoftGraph] 标记。

<a name="additional-resources"></a>
## 其他资源

* [其他 Microsoft Graph UWP 示例](https://github.com/microsoftgraph?utf8=%E2%9C%93&query=uwp)
* [Microsoft Graph 概述](http://graph.microsoft.io)
* [Office 开发人员代码示例](http://dev.office.com/code-samples)
* [Office 开发人员中心](http://dev.office.com/)

## 版权信息
版权所有 (c) 2016 Microsoft。保留所有权利。
