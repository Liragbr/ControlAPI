# Controle de Contatos

Sistema CRUD para gerenciar o contatos de usuários em uma aplicação ASP.NET Core usando .NET 8.0, a interligação com o banco de dados foi feita usadno o Migration, explicação de uso abaixo.

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

## Pacotes Utilizados

- Microsoft.EntityFrameworkCore
- Microsoft.EntityFrameworkCore.Design
- Microsoft.EntityFrameworkCore.SqlServer
- Microsoft.EntityFrameworkCore.Tools
