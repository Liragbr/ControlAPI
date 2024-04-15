# 📞 Introdução a Controle de Contatos

Sistema CRUD para gerenciar o contatos de usuários feita com C# em uma aplicação ASP.NET Core usando .NET 8.0 e funcionalidades do (views-mode) do visual studio 2022, a interligação com o banco de dados foi feita usando o Migration, explicação de uso e informações abaixo.

## Funcionalidades

- Adicionar novos contatos
- Visualizar lista de contatos
- Editar contatos existentes
- Excluir contatos

## Banco de Dados

o banco de dados foi feito usando sql Server Management Studio 2022, a interligação com o banco de dados foi feita usando comandos no prompt de ferramenta: 
```
Add-Migration CreateTable -Context BancoContext
```
```
Update-Database -Context BancoContext
```

## Pacotes Utilizados

- Microsoft.EntityFrameworkCore
- Microsoft.EntityFrameworkCore.Design
- Microsoft.EntityFrameworkCore.SqlServer
- Microsoft.EntityFrameworkCore.Tools
