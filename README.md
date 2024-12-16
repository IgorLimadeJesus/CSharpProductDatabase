# Sistema de Cadastro de Produtos em C#

Este projeto é uma aplicação simples em C# que permite o cadastro de produtos em um banco de dados SQL Server. O código realiza a inserção de um produto, coletando informações do usuário, como nome e preço, e salvando esses dados em uma tabela de **Produtos** no banco de dados.

## Funcionalidades:
- Conecta-se a um banco de dados SQL Server.
- Coleta o nome e o preço do produto do usuário via console.
- Insere os dados na tabela `Produtos` do banco de dados.

## Estrutura do Código:
1. **Classe Produtos:** Armazena os dados do produto (nome e preço).
2. **Banco de Dados:** Utiliza o SQL Server para armazenar os dados dos produtos em uma tabela.
3. **Tratamento de Erros:** O código inclui um tratamento básico de exceções para capturar falhas durante a inserção dos dados.

## Tecnologias Usadas:
- **C#**: Linguagem de programação utilizada para desenvolver o sistema.
- **SQL Server**: Banco de dados utilizado para armazenar as informações dos produtos.
