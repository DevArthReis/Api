
# 📚 TechLibrary API

API REST em ASP.NET Core para autenticação e cadastro de usuários, com JWT e validações customizadas.

---

## 🚀 Pré-requisitos

- [.NET 9 SDK (9.0.203 ou superior)](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)
- Visual Studio 2022 (recomendado) ou qualquer editor com suporte a C#
- Git (opcional)

---

## 🔧 Instalação e Configuração

1. **Clone o repositório** (ou extraia o `.zip`):
   ```bash
   git clone https://github.com/seu-usuario/TechLibrary.Api.git
   ```

2. **Abra a solução no Visual Studio**
   - Arquivo principal: `TechLibrary.sln`

3. **Restaure os pacotes NuGet:**
   - Via terminal:
     ```bash
     dotnet restore
     ```
   - Ou clique com o botão direito na solução e selecione: `Restaurar pacotes NuGet`.

4. **(Opcional) Defina o ambiente como Development**  
   Isso permite acessar o Swagger em ambientes de desenvolvimento:
   ```bash
   setx ASPNETCORE_ENVIRONMENT "Development"
   ```

---

## ▶️ Como Rodar a API

### 🔁 Opção 1: Visual Studio
- Defina o projeto `TechLibrary.Api` como `Projeto de Inicialização`
- Pressione **F5** ou **Ctrl + F5**

### 💻 Opção 2: Terminal
```bash
cd TechLibrary.Api
dotnet run
```

A API será executada por padrão em:

```
http://localhost:5000
```

---

## 📑 Documentação Swagger

Se habilitado (padrão), o Swagger estará disponível em:

```
http://localhost:5000/swagger
```

Caso não apareça, remova o bloco `if (app.Environment.IsDevelopment())` no `Program.cs` e deixe assim:

```csharp
app.MapOpenApi();
app.UseSwagger();
app.UseSwaggerUI();
```

---

## 🔐 Endpoints principais

### ▶️ POST `/Login`
- Autentica um usuário e retorna token JWT.

### ▶️ POST `/Users`
- Registra um novo usuário.

---

## ❓ Dúvidas ou problemas?

- Verifique se está usando a versão correta do .NET SDK.
- Confira se os pacotes NuGet foram restaurados corretamente.
- Certifique-se de que `TechLibrary.Api` foi definido como projeto de inicialização.
- Use o Swagger para testar os endpoints rapidamente.

---

🧑‍💻 Desenvolvido por: Arthur Albuquerque dos Reis
