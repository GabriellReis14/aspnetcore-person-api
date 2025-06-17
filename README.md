
# 👥 API REST - Cadastro de Pessoas com ASP.NET Core

Projeto simples de API REST desenvolvida em **ASP.NET Core (.NET 6)** para realizar operações básicas de cadastro de pessoas.

## 🛠️ Tecnologias utilizadas:

- ASP.NET Core (.NET 6)
- C#
- Swagger (para documentação e teste)
- Armazenamento em memória (sem banco, apenas lista estática)

## ✅ Funcionalidades:

- **GET /pessoa** → Listar pessoas
- **POST /pessoa** → Adicionar nova pessoa (enviar string com nome no body)

## ⚙️ Como rodar localmente:

### Pré-requisitos:
- Ter o **.NET 6 SDK ou superior** instalado  
Baixe aqui: https://dotnet.microsoft.com/download

### Passos:

1. Abra o terminal na pasta raiz do projeto
2. Execute:
```bash
dotnet run
```
3. A API vai rodar nas URLs padrão (https://localhost:5001 ou http://localhost:5000)

4. Acesse o Swagger no navegador:  
https://localhost:5001/swagger

## ✅ Testando com o Swagger:

- GET → Listar pessoas cadastradas
- POST → Adicionar uma nova pessoa (exemplo: "João")

## ✅ Melhorias futuras:

- Persistência de dados com banco de dados (SQLite, SQL Server etc)
- Implementar Entity Framework Core
- Adicionar autenticação JWT

## ⭐️ Autor:

Gabriell Reis
