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
# Exemple MeetingBot Microsoft Graph pour UWP

## Table des matières

* [Introduction](#introduction)
* [Conditions préalables](#prerequisites)
* [Enregistrement et configuration de l’application](#register)
* [Création et débogage](#build)
* [Exécution de l’exemple](#runningsample)
* [Questions et commentaires](#questions)
* [Ressources supplémentaires](#additional-resources)

<a name="introduction"></a>
## Introduction

Cet exemple montre comment intégrer des fonctionnalités de Microsoft Graph dans une application UWP qui utilise des commandes vocales Cortana. Une fois que vous l’avez installé et que vous vous êtes connecté, vous pouvez l’activer en demandant à Cortana d’afficher la prochaine réunion dans votre calendrier et/ou d’informer les participants de votre prochaine réunion que vous êtes en retard.

Il utilise la [bibliothèque client Microsoft Graph .NET](https://github.com/microsoftgraph/msgraph-sdk-dotnet) pour exploiter les données renvoyées par Microsoft Graph. L’exemple utilise le point de terminaison d’authentification v2.0, qui permet aux utilisateurs de se connecter avec leur compte Microsoft personnel, professionnel ou scolaire.

<a name="prerequisites"></a>
## Conditions préalables

Cet exemple nécessite les éléments suivants :  

* [Visual Studio](https://www.visualstudio.com/en-us/downloads) 
* Windows 10 ([avec mode de développement](https://msdn.microsoft.com/library/windows/apps/xaml/dn706236.aspx))
* Un compte [Microsoft](www.outlook.com), ou un [compte Office 365 pour entreprise](https://msdn.microsoft.com/en-us/office/office365/howto/setup-development-environment#bk_Office365Account).

<a name="register"></a>
## Inscription de l’application

1. Accédez au [Portail Azure](https://aka.ms/AppRegistrations) pour enregistrer votre application. Connectez-vous à l’aide d’un **compte personnel** (alias : compte Microsoft) ou d’un **compte professionnel ou scolaire**.

2. Sélectionnez **Nouvelle inscription**. Sur la page **Inscrire une application**, définissez les valeurs comme suit.

    * Définissez le **Nom** sur `MeetingBot-Sample`.
    * Définissez les **Types de comptes pris en charge** sur les **Comptes figurant dans un annuaire organisationnel et les comptes Microsoft personnels**.
    * Laissez **Redirect URI** vide.
    * Sélectionnez **Inscrire**.

3. Sur la page **MeetingBot-Sample**, copiez la valeur de l’**ID d’application (client)**. Vous en aurez besoin ultérieurement.

4. Sélectionnez le lien **Ajouter un URI de redirection**. Dans la page **URI de redirection** Recherchez la section des **URI de redirection suggérés pour les clients publics (mobile, bureau)**. Sélectionnez l’URI commençant par `msal` **et** l’URI **urn:ietf:wg:oauth:2.0:oob**.

5. Sélectionnez **Sauvegarder** en haut de la page.

<a name="build"></a>
## Création et débogage

**Remarque :** si vous constatez des erreurs pendant l’installation des packages à l’étape 2, vérifiez que le chemin d’accès local où vous avez sauvegardé la solution n’est pas trop long/profond. Pour résoudre ce problème, il vous suffit de déplacer la solution dans un dossier plus près du répertoire racine de votre lecteur.

1. Une fois la solution chargée dans Visual Studio, configurez l’exemple pour utiliser l’ID d’application que vous avez enregistrée, en ajoutant les valeurs correspondantes de ces clés dans le nœud Application.Resources du fichier App.xaml.
![Exemple Microsoft Graph MeetingBot](/readme-images/appId_and_redirectURI.png "Valeur d'ID d'application dans le fichier App.xaml")

2. Appuyez sur F5 pour créer et déboguer l’application. Exécutez la solution et connectez-vous avec votre compte personnel, professionnel ou scolaire.

<a name="runningsample"></a>
## Exécution de l’exemple

Lorsque vous exécutez l’exemple pour la première fois, vous êtes invité à vous connecter avec votre compte [Microsoft](www.outlook.com) ou votre [compte Office 365 pour les entreprises](https://msdn.microsoft.com/en-us/office/office365/howto/setup-development-environment#bk_Office365Account). Une fois que vous avez authentifié et envoyé les autorisations requises, vous n’avez plus besoin de vous reconnecter, sauf si vous voulez exécuter l’exemple avec un autre compte. 

Si vous voulez vous déconnecter, puis vous connecter avec un autre compte, sélectionnez le bouton **se déconnecter** en haut à droite de l’application, puis sélectionnez le bouton **se connecter** à gauche.

Après avoir installé et exécuté l’application une première fois, vous pouvez l’activer à tout moment en utilisant les commandes vocales suivantes à Cortana :

1. « MeetingBot, affiche ma prochaine réunion ».
2. « MeetingBot, dis à mon prochain rendez-vous que je vais être en retard ».

Si vous avez [activé la fonctionnalité « Hey Cortana »](https://www.cnet.com/how-to/how-to-enable-hey-cortana-on-windows-10/), vous pouvez activer l’application à tout moment en utilisant les commandes vocales suivantes sur votre appareil :

1. « Hey Cortana, demande à MeetingBot de me montrer ma prochaine réunion ».
2. « Hey Cortana, demande à MeetingBot de dire à mon prochain rendez-vous que je vais être en retard ».

Dans les deux cas, l’application démarre et affiche le titre et l’heure de votre prochaine réunion. Si vous demandez à MeetingBot de dire à votre prochain rendez-vous que vous allez être en retard, l'application confirmera qu'elle a envoyé un message « en retard » aux participants de votre prochaine réunion, ou elle vous dira qu'elle n'a pas pu trouver l'invitation à la réunion dans la boîte aux lettres de votre compte.

![Exemple Microsoft Graph MeetingBot](/readme-images/MeetingBotLateMessage.png "MeetingBot après l’envoi du message de retard")

<a name="contributing"></a>
## Contribution

Si vous souhaitez contribuer à cet exemple, voir [CONTRIBUTING.MD](/CONTRIBUTING.md).

Ce projet a adopté le [code de conduite Open Source de Microsoft](https://opensource.microsoft.com/codeofconduct/). Pour en savoir plus, reportez-vous à la [FAQ relative au Code de conduite](https://opensource.microsoft.com/codeofconduct/faq/) ou contactez [opencode@microsoft.com](mailto:opencode@microsoft.com) pour toute question ou tout commentaire.

<a name="questions"></a>
## Questions et commentaires

Nous serions ravis de connaître votre opinion sur le projet Microsoft Graph MeetingBot pour UWP. Vous pouvez nous faire part de vos questions et suggestions dans la rubrique [Problèmes](https://github.com/microsoftgraph/uwp-csharp-meetingbot-sample/issues) de ce référentiel.

Votre avis compte beaucoup pour nous. Communiquez avec nous sur [Stack Overflow](http://stackoverflow.com/questions/tagged/microsoftgraph). Posez vos questions avec la balise [MicrosoftGraph].

<a name="additional-resources"></a>
## Ressources supplémentaires

* [Autres exemples Microsoft Graph UWP](https://github.com/microsoftgraph?utf8=%E2%9C%93&query=uwp)
* [Présentation de Microsoft Graph](http://graph.microsoft.io)
* [Exemples de code du développeur Office](http://dev.office.com/code-samples)
* [Centre de développement Office](http://dev.office.com/)

## Copyright
Copyright (c) 2016 Microsoft. Tous droits réservés.
