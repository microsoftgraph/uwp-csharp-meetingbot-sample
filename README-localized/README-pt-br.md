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
# Exemplo do Microsoft Graph MeetingBot para UWP

## Sumário

* [Introdução](#introduction)
* [Pré-requisitos](#prerequisites)
* [Registrar e configurar o aplicativo](#register)
* [Criar e depurar](#build)
* [Execução da amostra](#runningsample)
* [Perguntas e comentários](#questions)
* [Recursos adicionais](#additional-resources)

<a name="introduction"></a>
## Introdução

Este exemplo demonstra como integrar os recursos do Microsoft Graph a um aplicativo UWP com os comandos de voz da Cortana. Depois de instalá-lo e entrar, você pode ativá-lo pedindo à Cortana para exibir a próxima reunião no seu calendário e/ou pedindo à Cortana para informar aos participantes da sua próxima reunião que você está atrasado.

O exemplo usa a [Biblioteca de Clientes .NET do Microsoft Graph](https://github.com/microsoftgraph/msgraph-sdk-dotnet) para trabalhar com dados retornados pelo Microsoft Graph. O exemplo utiliza o terminal de autenticação versão 2.0, que permite que os usuários entrem com a conta pessoal, corporativa ou de estudante da Microsoft.

<a name="prerequisites"></a>
## Pré-requisitos

Este exemplo requer o seguinte:  

* [Visual Studio](https://www.visualstudio.com/en-us/downloads) 
* Windows 10 ([habilitado para o modo de desenvolvimento](https://msdn.microsoft.com/library/windows/apps/xaml/dn706236.aspx))
* Tanto a conta do [Microsoft](www.outlook.com) quanto a do [Office 365 for business](https://msdn.microsoft.com/en-us/office/office365/howto/setup-development-environment#bk_Office365Account).

<a name="register"></a>
## Registrar o aplicativo

1. Navegue até o [portal do Azure](https://aka.ms/AppRegistrations) para registrar seu aplicativo. Faça logon usando uma **conta pessoal** (também conhecida como: Conta Microsoft) **Conta Corporativa ou de Estudante**.

2. Selecione **Novo registro**. Na página **Registrar um aplicativo**, defina os valores da seguinte forma.

    * Configure o **Nome** ao `MeetingBot-Sample`.
    * Configure **Tipos de contas com suporte** para **Contas em qualquer diretório organizacional e contas pessoais da Microsoft**.
    * Deixe o **URI de Redirecionamento** vazio.
    * Escolha **Registrar**.

3. Na página **MeetingBot-Sample**, copie o valor da **ID (cliente) do cliente**. Você precisará dela mais tarde.

4. Selecione um link **Adicionar uma URI de redirecionamento**. Na página **Redirecionamento de URIs**, localize a seção**URIs de redirecionamento sugeridas para clientes públicos (móvel, área de trabalho)**. Selecione a URI que começa com `msal` **e**a URI **urn:ietf:wg:oauth:2.0:oob**.

5. Escolha **Salvar na parte superior da página.

<a name="build"></a>
## Criar e depurar

**Observação:** caso receba mensagens de erro durante a instalação de pacotes na etapa 2, verifique se o caminho para o local onde você colocou a solução não é muito longo ou extenso. Mover a solução para mais perto da fonte da sua unidade resolve esse problema.

1. Depois de carregar a solução no Visual Studio, configure o exemplo para usar o ID do aplicativo que você registrou adicionando os valores correspondentes a essas chaves no nó Application.Resources do arquivo App.xaml.
![Exemplo do MeetingBot do Microsoft Graph](/readme-images/appId_and_redirectURI.png "Valor da ID de aplicativo no arquivo App.xaml")

2. Pressione F5 para criar e depurar. Execute a solução e entre com sua conta pessoal, comercial ou escolar.

<a name="runningsample"></a>
## Execução da amostra

Ao executar o exemplo pela primeira vez, você será instruído a entrar com sua conta [Microsoft](www.outlook.com) ou [Office 365 for Business](https://msdn.microsoft.com/en-us/office/office365/howto/setup-development-environment#bk_Office365Account). Depois de ter autenticado e contornado as permissões obrigatórias, não será necessário entrar novamente, a menos que você queira executar o exemplo com outra conta. 

Se você deseja sair e entrar com uma conta diferente, selecione o botão **desconectar** no canto superior direito do aplicativo e selecione o botão **conectar** à sua esquerda.

Depois de instalar e executar o aplicativo uma vez, você pode ativá-lo a qualquer momento emitindo os seguintes comandos de voz para a Cortana:

1. "MeetingBot, mostrar minha próxima reunião".
2. "MeetingBot, avise minha próxima reunião que vou me atrasar".

Se você [tiver habilitado o recurso "Oi, Cortana"](https://www.cnet.com/how-to/how-to-enable-hey-cortana-on-windows-10/), é possível ativar o aplicativo a qualquer momento executando estes comandos de voz no seu dispositivo:

1. "Oi, Cortana, peça ao MeetingBot para mostrar minha próxima reunião."
2. "Oi, Cortana, peça ao MeetingBot avisar à minha próxima reunião que vou me atrasar."

Em ambos os casos, o aplicativo será iniciado e exibirá o título e o período de tempo da próxima reunião. Se você pedir que o MeetingBot avise à próxima reunião que você vai se atrasar, o aplicativo confirmará que ele enviou uma mensagem "atrasado" aos participantes da próxima reunião ou indicará que não conseguiu encontrar o convite da reunião na caixa de correio.

![Exemplo do Microsoft Graph MeetingBot](/readme-images/MeetingBotLateMessage.png "MeetingBot após enviar a mensagem de atraso")

<a name="contributing"></a>
## Colaboração

Se quiser contribuir para esse exemplo, confira [CONTRIBUTING.MD](/CONTRIBUTING.md).

Este projeto adotou o [Código de Conduta de Código Aberto da Microsoft](https://opensource.microsoft.com/codeofconduct/).  Para saber mais, confira as [Perguntas frequentes sobre o Código de Conduta](https://opensource.microsoft.com/codeofconduct/faq/) ou entre em contato pelo [opencode@microsoft.com](mailto:opencode@microsoft.com) se tiver outras dúvidas ou comentários.

<a name="questions"></a>
## Perguntas e comentários

Adoraríamos receber seus comentários sobre o projeto do Microsoft Graph MeetingBot para UWP. Você pode enviar perguntas e sugestões na seção [Problemas](https://github.com/microsoftgraph/uwp-csharp-meetingbot-sample/issues) deste repositório.

Os seus comentários são importantes para nós. Junte-se a nós na página do [Stack Overflow](http://stackoverflow.com/questions/tagged/microsoftgraph). Marque suas perguntas com [MicrosoftGraph].

<a name="additional-resources"></a>
## Recursos adicionais

* [Outros exemplos do Microsoft Graph UWP](https://github.com/microsoftgraph?utf8=%E2%9C%93&query=uwp)
* [Visão geral do Microsoft Graph](http://graph.microsoft.io)
* [Exemplos de código para desenvolvedores do Office](http://dev.office.com/code-samples)
* [Centro de Desenvolvimento do Office](http://dev.office.com/)

## Direitos autorais
Copyright © 2016 Microsoft. Todos os direitos reservados.
