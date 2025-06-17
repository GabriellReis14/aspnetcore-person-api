
# 👥 API REST - Cadastro de Pessoas com ASP.NET Core

Projeto simples de API REST desenvolvida em **ASP.NET Core (.NET 6)** para realizar operações básicas de cadastro de pessoas.

## 🛠️ Tecnologias utilizadas:

- ASP.NET Core (.NET 6)
- C#
- Swagger (para documentação e teste)
- Armazenamento em memória (sem banco, apenas lista estática)

## ✅ Funcionalidades:

- **GET /person** → Listar pessoas
- **GET /person/:id** → Listar única pessoa
- **POST /person** → Adicionar nova pessoa
- **PUT /person/:id** → Alterar pessoa existente
- **DELETE /person/:id** → Deletar pessoa existente

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
3. A API vai rodar nas URLs padrão (http://localhost:5279)

4. Acesse o Swagger no navegador:  
http://localhost:5279/swagger

## ✅ Testando com o Swagger:

- GET → Listar pessoas cadastradas
- POST → Adicionar uma nova pessoa
- PUT → Alterar uma pessoa
- DELETE → Deletar uma pessoa

## ✅ Melhorias futuras:
- Implementar Entity Framework Core
- Adicionar autenticação JWT

## ⭐️ Autor:

Gabriell Reis
