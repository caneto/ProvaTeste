# ProvaTeste
Tecnologia Utizada .Net C#
Versão 2013

Projeto aberto e em WebApi.zip para caso de problemas

Adicionado o projeto Versão Publish em WebApi.Publish

Base de dados usada para testes de ser colocar no c:\Temp\ devido a permissões, ou deixar que ele criar uma.


Ao abrir o projeto, ir no NuGet (para baixar as librarys que usei do Free

Usado para Testes o SoupUI (https://www.soapui.org/downloads/soapui.html)

Ao Rodar, os paramentros e metodos são os abaixo.

http://localhost:xxxx/api/cliente/CadastrarCliente (Metodo HTTP POST)

Estrutura esperada (Exemplo) :

{
  "Codigo":1,
  "Nome":"Nome Teste",
  "Sobrenome":"Sobre Nome",
  "Email":"Email",
  "Endereco":"Endereco",
  "Telefone":"Telefone"
}

http://localhost:xxxx/api/cliente/AlterarCliente (Metodo HTTP PUT)

Estrutura esperada (Exemplo) :

{
  "Id":1,
  "Codigo":1,
  "Nome":"Nome Teste",
  "Sobrenome":"Sobre Nome",
  "Email":"Email",
  "Endereco":"Endereco",
  "Telefone":"Telefone"
}

PS:Este "Id', é o campo id padrão do FreeDb, pode user outro mais me aprofundei, pois uso assim, em projetos.

http://localhost:xxxx/api/cliente/ExcluirCliente/{codigo} (Metodo HTTP DELETE)

{codigo} = numero do registro inteiro.

http://localhost:xxxx/api/cliente/ConsultarClientePorCodigo/{codigo} (Metodo HTTP GET)

{codigo} = numero do registro inteiro.

Retorno Lista do Objeto do Modelo Cliente para o codigo passado.

Modelo do Objeto

[{
   "Id": 2,
   "Codigo": 2,
   "Nome": "xxxxx",
   "Sobrenome": "xxxxx",
   "Email": "xxxxx",
   "Endereco": "xxxxx",
   "Telefone": "xxxxxx"
}]

http://localhost:xxxx/api/cliente/ConsultarClientes() (Metodo HTTP GET)

Retorno Lista de Todos os Objetos do Modelo Cliente.

Objeto em Json neste modelo.

[
      {
      "Id": 1,
      "Codigo": 1,
      "Nome": "zzzzz",
      "Sobrenome": "zzzzz",
      "Email": "zzzzz",
      "Endereco": "zzzzz",
      "Telefone": "zzzzz"
   },
      {
      "Id": 2,
      "Codigo": 2,
      "Nome": "yyyyy",
      "Sobrenome": "yyyyy",
      "Email": "yyyyy",
      "Endereco": "yyyyy",
      "Telefone": "yyyyy"
   },
      {
      "Id": 3,
      "Codigo": 3,
      "Nome": "xxxxx",
      "Sobrenome": "xxxxx",
      "Email": "xxxx",
      "Endereco": "xxxxx",
      "Telefone": "xxxxx"
   }
]
