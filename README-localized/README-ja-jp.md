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
# UWP 用 Microsoft Graph MeetingBot サンプル

## 目次

* [はじめに](#introduction)
* [前提条件](#prerequisites)
* [アプリを登録して構成する](#register)
* [ビルドとデバッグ](#build)
* [サンプルの実行](#runningsample)
* [質問とコメント](#questions)
* [その他のリソース](#additional-resources)

<a name="introduction"></a>
## 概要

このサンプルは、Microsoft Graph 機能を、Contana 音声コマンドを使用する UWP アプリに統合する方法を示しています。インストールしてサインインしたら、Cortana に次の会議を予定表に表示するように依頼するか、Cortana に次の会議の参加者に遅れていることを伝えるように依頼することで、アクティブにすることができます。

Microsoft Graph が返すデータを操作するために、[Microsoft Graph .NET クライアント ライブラリ](https://github.com/microsoftgraph/msgraph-sdk-dotnet)を使用します。このサンプルは v2.0 の認証エンドポイントを使用します。このエンドポイントにより、ユーザーは個人用か、職場または学校の Microsoft アカウントでサインインできます。

<a name="prerequisites"></a>
## 前提条件

このサンプルを実行するには次のものが必要です。  

* [Visual Studio](https://www.visualstudio.com/en-us/downloads) 
* Windows 10 ([開発モードが有効](https://msdn.microsoft.com/library/windows/apps/xaml/dn706236.aspx))
* [Microsoft](www.outlook.com) または [Office 365 for Business アカウント](https://msdn.microsoft.com/en-us/office/office365/howto/setup-development-environment#bk_Office365Account)のいずれか。

<a name="register"></a>
## アプリを登録する

1. [Azure ポータル](https://aka.ms/AppRegistrations)に移動してアプリを登録します。アプリ登録を作成するためのアクセス許可が付与されている**個人用アカウント** (別名:Microsoft アカウント) または**職場または学校のアカウント**を使用してログインします。

2. [**新規登録**] を選択します。[**アプリケーションの登録**] ページで、次のように値を設定します。

    * [**名前**] を [`MeetingBot-Sample`] に設定します。
    * [**サポート対象のアカウントの種類**] を [**任意の組織のディレクトリ内のアカウントと、個人用の Microsoft アカウント**] に設定します。
    * [**リダイレクト URI**] は空のままにします。
    * [**登録**] を選択します。

3. [**MeetingBot-Sample**] ページで、**アプリケーション (クライアント) ID** の値をコピーします。この情報は後で必要になります。

4. [**リダイレクト URI の追加**] リンク を選択します。[**リダイレクト URI**] ページで [**パブリック クライアント (モバイル、デスクトップ) に推奨されるリダイレクト URI**] セクションを見つけます。"`msal`" から始まる URI **および** "**urn:ietf:wg:oauth:2.0:oob**" という URI を選択します。

5. ページの上部にある [**保存**] を選択します。

<a name="build"></a>
## ビルドとデバッグ

**メモ:**手順 2 でパッケージのインストール中にエラーが発生した場合は、ソリューションを保存したローカル パスが長すぎたり深すぎたりしていないかご確認ください。この問題は、ソリューションをドライブのルート近くに移動すると解決します。

1. ソリューションを Visual Studio に読み込んだ後、App.xaml ファイルの Application.Resources ノードにこれらのキーに対応する値を追加して、登録したアプリケーション ID を使用するようにサンプルを構成します。
![Microsoft Graph MeetingBot サンプル](/readme-images/appId_and_redirectURI.png "App.xaml ファイルのアプリ ID の値")

2. F5 キーを押して、ビルドとデバッグを実行します。　ソリューションを実行し、個人用アカウント、あるいは職場または学校のアカウントのいずれかでサインインします。

<a name="runningsample"></a>
## サンプルの実行

サンプルを初めて実行すると、[Microsoft](www.outlook.com) または [Office 365 for business アカウント](https://msdn.microsoft.com/en-us/office/office365/howto/setup-development-environment#bk_Office365Account)でサインインするように求められます。必要な権限を認証して同意したら、別のアカウントでサンプルを実行する場合を除き、再度サインインする必要はありません。 

サインアウトしてから別のアカウントでサインインする場合は、アプリの右上にある [**切断**] ボタンを選択し、左側の [**接続**] ボタンを選択します。

アプリをインストールして実行したら、次の音声コマンドを Cortana に発行して、いつでもアクティブにできます。

1. 「MeetingBot、次の会議を表示してくささい」
2. 「MeetingBot、次の会議の参加者に私が遅れると伝えてください」

[「コルタナさん」機能を有効にしている](https://www.cnet.com/how-to/how-to-enable-hey-cortana-on-windows-10/)場合は、次の音声コマンドをデバイスに発行することで、いつでもアプリをアクティブにできます。

1. 「コルタナさん、MeetingBot に次の会議を表示するようにしてください」
2. 「コルタナさん、MeetingBot に次の会議の参加者に私が遅れると伝えるようにしてください」

どちらの場合も、アプリが起動し、次の会議のタイトルと時間枠が表示されます。MeetingBot に次の会議に遅れることを伝えるようにすると、アプリは次の会議の参加者に「遅れている」メッセージを送信したことを確認するか、アカウントのメールボックスで会議の招待が見つからなかったことが通知します。

![Microsoft Graph MeetingBot サンプル](/readme-images/MeetingBotLateMessage.png "遅れるというメッセージを送信した後の MeetingBot")

<a name="contributing"></a>
## 投稿

このサンプルに投稿する場合は、[CONTRIBUTING.MD](/CONTRIBUTING.md) を参照してください。

このプロジェクトでは、[Microsoft Open Source Code of Conduct (Microsoft オープン ソース倫理規定)](https://opensource.microsoft.com/codeofconduct/) が採用されています。詳細については、「[Code of Conduct の FAQ (倫理規定の FAQ)](https://opensource.microsoft.com/codeofconduct/faq/)」を参照してください。また、その他の質問やコメントがあれば、[opencode@microsoft.com](mailto:opencode@microsoft.com) までお問い合わせください。

<a name="questions"></a>
## 質問とコメント

UWP プロジェクト用 Microsoft Graph MeetingBot に関するフィードバックをお寄せください。質問や提案は、このリポジトリの「[問題](https://github.com/microsoftgraph/uwp-csharp-meetingbot-sample/issues)」セクションで送信できます。

お客様からのフィードバックを重視しています。[スタック オーバーフロー](http://stackoverflow.com/questions/tagged/microsoftgraph)でご連絡ください。ご質問には [MicrosoftGraph] のタグを付けてください。

<a name="additional-resources"></a>
## その他の技術情報

* [Microsoft Graph UWP の他のサンプル](https://github.com/microsoftgraph?utf8=%E2%9C%93&query=uwp)
* [Microsoft Graph の概要](http://graph.microsoft.io)
* [Office 開発者向けコード サンプル](http://dev.office.com/code-samples)
* [Office デベロッパー センター](http://dev.office.com/)

## 著作権
Copyright (c) 2016 Microsoft.All rights reserved.
