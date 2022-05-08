using System.Reflection;
using System.Runtime.CompilerServices;

//
// Informações gerais sobre um assembly são controladas através do seguinte
// conjunto de atributos. Altere esses valores de atributo para modificar as informações
// associado a um assembly.
//
[assembly: AssemblyTitle("")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("")]
[assembly: AssemblyCopyright("")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]		

//
// As informações de versão de um assembly consistem nos quatro valores a seguir:
//
// Versão principal
// Versão menor
// Número da compilação
//      Revisão
//
// Você pode especificar todos os valores ou pode padronizar os números de revisão e compilação
// usando o '*' como mostrado abaixo:
[assembly: AssemblyVersion("1.0.*")]

//
// Para assinar seu assembly, você deve especificar uma chave a ser usada. Consulte o
// Documentação do Microsoft .NET Framework para obter mais informações sobre assinatura de assembly.
//
// Use os atributos abaixo para controlar qual chave é usada para assinatura.
//
// Notas:
// (*) Se nenhuma chave for especificada, o assembly não será assinado.
// (*) KeyName refere-se a uma chave que foi instalada no Serviço de Criptografia
// Provedor (CSP) em sua máquina. KeyFile refere-se a um arquivo que contém
//       uma chave.
// (*) Se os valores KeyFile e KeyName forem especificados, o
// ocorre o seguinte processamento:
// (1) Se o KeyName puder ser encontrado no CSP, essa chave será usada.
// (2) Se o KeyName não existir e o KeyFile existir, a chave
// no KeyFile é instalado no CSP e usado.
// (*) Para criar um KeyFile, você pode usar o utilitário sn.exe (Strong Name).
// Ao especificar o KeyFile, a localização do KeyFile deve ser
// relativo ao diretório de saída do projeto que é
// %Diretório do projeto%\obj\<configuração>. Por exemplo, se o seu KeyFile for
// localizado no diretório do projeto, você especificaria o AssemblyKeyFile
// atributo as [assembly: AssemblyKeyFile("..\\..\\mykey.snk")]
// (*) A assinatura de atraso é uma opção avançada - consulte o Microsoft .NET Framework
// documentação para mais informações sobre isso.
//
[assembly: AssemblyDelaySign(false)]
[assembly: AssemblyKeyFile("")]
[assembly: AssemblyKeyName("")]
