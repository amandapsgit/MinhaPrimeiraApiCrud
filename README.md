# MinhaPrimeiraApiCrud

API REST desenvolvida em ASP.NET Core com CRUD completo, utilizando Entity Framework Core e SQL Server, incluindo relacionamento entre entidades.

## Funcionalidades

- Criar Pessoa
- Listar Pessoas
- Atualizar Pessoa
- Remover Pessoa
- Criar Endereço vinculado à Pessoa
- Listar Endereços
- Relacionamento 1:N entre Pessoa e Endereço

## Tecnologias utilizadas

- ASP.NET Core
- C#
- Entity Framework Core
- SQL Server (LocalDB)
- Swagger (OpenAPI)
- Git e GitHub

## Estrutura do projeto

Entidades:

Pessoa
- Id
- Nome
- Idade

Endereco
- Id
- Rua
- PessoaId (chave estrangeira)

Relacionamento:

Uma Pessoa pode possuir vários Endereços.

## Banco de dados

O banco é criado utilizando Entity Framework Migrations.

Comando utilizado:
Add-Migration Inicial
Update-Database

## Como executar o projeto

1. Abrir o projeto no Visual Studio
2. Executar com F5
3. Acessar o Swagger no navegador:
4. https://localhost:7056/swagger

   
## Autor

Amanda Pereira da Silva

Projeto desenvolvido para fins de estudo e prática em ASP.NET Core e Entity Framework.
