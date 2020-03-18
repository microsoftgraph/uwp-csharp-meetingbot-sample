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
# Ejemplo de MeetingBot de Microsoft Graph para UWP

## Tabla de contenido

* [Introducción](#introduction)
* [Requisitos previos](#prerequisites)
* [Registrar y configurar la aplicación](#register)
* [Compilar y depurar](#build)
* [Ejecutar el ejemplo](#runningsample)
* [Preguntas y comentarios](#questions)
* [Recursos adicionales](#additional-resources)

<a name="introduction"></a>
## Introducción

Este ejemplo explica cómo integrar capacidades de Microsoft Graph en una aplicación UWP que usa los comandos de voz de Cortana. Una vez instalado y haya iniciado sesión, podrá activar Cortana para que se muestre la siguiente reunión en el calendario y/o que le pida a Cortana que informe a los participantes de la reunión que está realizando más tarde.

Use la [biblioteca cliente .NET de Microsoft Graph](https://github.com/microsoftgraph/msgraph-sdk-dotnet) para trabajar con los datos devueltos por Microsoft Graph. En el ejemplo, se usa el punto de conexión de autenticación v2.0, que permite a los usuarios iniciar sesión con sus cuentas Microsoft personales, o bien con sus cuentas Microsoft profesionales o educativas.

<a name="prerequisites"></a>
## Requisitos previos

Este ejemplo necesita lo siguiente:  

* [Visual Studio](https://www.visualstudio.com/en-us/downloads) 
* Windows 10 ([modo de desarrollo habilitado](https://msdn.microsoft.com/library/windows/apps/xaml/dn706236.aspx))
* Ya sea una cuenta de [Microsoft](www.outlook.com) o bien de [Office 365 para empresa](https://msdn.microsoft.com/en-us/office/office365/howto/setup-development-environment#bk_Office365Account).

<a name="register"></a>
## Registrar la aplicación

1. Desplácese hasta la [el portal de Azure](https://aka.ms/AppRegistrations) para registrar la aplicación. Inicie sesión con una **cuenta personal** (por ejemplo: una cuenta de Microsoft) o una **cuenta profesional o educativa**.

2. Haga clic en **Nuevo registro**. En la página **Registrar una aplicación**, establezca los valores siguientes.

    * Establezca **Nombre** en `ejemplo de MeetingBot`.
    * Establezca los**Tipos de cuenta admitidos** en **Cuentas en cualquier directorio de organización y cuentas personales de Microsoft**. 
    * Deje vacía la opción de **URI de redirección**.
    * Elija **Registrar**.

3. En la página del ejemplo de MeetingBot, copie el valor del **Id. de la aplicación (cliente)**. Lo necesitará más adelante.

4. Seleccione el vínculo **Agregar un URI de redirección**. En la página **URI de redirección**, localice la sección **URI de redirección sugeridos para clientes públicos (para dispositivos móviles o de escritorio)**. Seleccione el URI que comience por `msal` **y** el URI **urn:ietf:wg:oauth:2.0:oob**.

5. En la parte superior de la página, elija **Guardar**.

<a name="build"></a>
## Compilar y depurar

**Nota:** Si observa algún error durante la instalación de los paquetes en el paso 2, asegúrese de que la ruta de acceso local donde colocó la solución no es demasiado larga o profunda. Para solucionar este problema, mueva la solución más cerca de la raíz de la unidad.

1. Después de cargado la solución en Visual Studio, configure el ejemplo para usar el identificador de la aplicación que registró agregando los valores correspondientes para estas claves en la aplicación. el nodo recursos del archivo app. Xaml.
![Ejemplo de Microsoft Graph MeetingBot un valor de ID. de aplicación](/readme-images/appId_and_redirectURI.png "en el archivo app. Xaml")

2. Presione F5 para compilar y depurar. Ejecute la solución e inicie sesión con su cuenta personal, profesional o educativa.

<a name="runningsample"></a>
## Ejecutar el ejemplo

La primera vez que ejecute el ejemplo, se le pedirá que inicie sesión con su [Microsoft](www.outlook.com) o [cuenta de Office 365 para empresas](https://msdn.microsoft.com/en-us/office/office365/howto/setup-development-environment#bk_Office365Account). Después de que se haya autenticado y enviado a los permisos necesarios, no tendrá que iniciar sesión de nuevo a menos que quiera ejecutar el ejemplo en otra cuenta. 

Si desea cerrar sesión y, a continuación, inicie sesión con una cuenta diferente, seleccione el botón **desconectar** en la parte superior derecha de la aplicación y, después, seleccione el botón **conectar** a la izquierda.

Después de instalar y ejecutar la aplicación una vez, puede activarla en cualquier momento emitiendo los siguientes comandos de voz para Cortana:

1. "MeetingBot, muestra mi próxima reunión".
2. "MeetingBot, dile a mi próxima reunión que voy a llegar tarde".

Si [habilitó la característica "Hola Cortana"](https://www.cnet.com/how-to/how-to-enable-hey-cortana-on-windows-10/), puede activar la aplicación en cualquier momento emitiendo estos comandos de voz al dispositivo:

1. "Hola Cortana, pídele a MeetingBot que muestre mi próxima reunión".
2. "Hola Cortana, pídele a MeetingBot que le diga a mi próxima reunión que voy a llegar tarde."

En ambos casos, la aplicación se iniciará y mostrará el título y el período de tiempo de su próxima reunión. Si pide a MeetingBot que le comunique a su próxima reunión que va a llegar tarde, la aplicación le confirmará que ha enviado un mensaje de "con retraso" a los participantes de su próxima reunión, o bien le dirá que no ha podido encontrar la invitación a la reunión en el buzón de su cuenta.

![Ejemplo de Microsoft Graph MeetingBot](/readme-images/MeetingBotLateMessage.png "MeetingBot después de enviar el mensaje con retraso")

<a name="contributing"></a>
## Colaboradores

Si quiere hacer su aportación a este ejemplo, vea [CONTRIBUTING.MD](/CONTRIBUTING.md).

Este proyecto ha adoptado el [Código de conducta de código abierto de Microsoft](https://opensource.microsoft.com/codeofconduct/). Para obtener más información, vea las [Preguntas frecuentes sobre el código de conducta](https://opensource.microsoft.com/codeofconduct/faq/) o póngase en contacto con [opencode@microsoft.com](mailto:opencode@microsoft.com) si tiene otras preguntas o comentarios.

<a name="questions"></a>
## Preguntas y comentarios

Nos encantaría recibir sus comentarios sobre el proyecto de Microsoft Graph MeetingBot para UWP. Puede enviarnos sus preguntas y sugerencias a través de la sección [Problemas](https://github.com/microsoftgraph/uwp-csharp-meetingbot-sample/issues) de este repositorio.

Su opinión es importante para nosotros. Conecte con nosotros en [Stack Overflow](http://stackoverflow.com/questions/tagged/microsoftgraph). Etiquete sus preguntas con [MicrosoftGraph].

<a name="additional-resources"></a>
## Recursos adicionales

* [Otros ejemplos de Microsoft Graph UWP](https://github.com/microsoftgraph?utf8=%E2%9C%93&query=uwp)
* [Información general de Microsoft Graph](http://graph.microsoft.io)
* [Ejemplos de código de Office Developer](http://dev.office.com/code-samples)
* [Centro para desarrolladores de Office](http://dev.office.com/)

## Derechos de autor
Copyright (c) 2016 Microsoft. Todos los derechos reservados.
