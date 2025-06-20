# EvolvOS 🚀

Bem-vindo ao EvolvOS, uma plataforma web em desenvolvimento, criada para ajudar na organização e evolução dos seus estudos. O objetivo é centralizar matérias, materiais e anotações, tornando o aprendizado um processo mais estruturado e eficiente.

> 🚧 **Status do Projeto:** Em desenvolvimento... 🚧

---

### 📂 Estrutura do Repositório

Este repositório está organizado de forma a separar a documentação do código-fonte da aplicação:

-   **/ (Raiz):** Contém a documentação principal, como este `README`, a `Solution`, `LICENSE` e o `.gitignore` geral.
-   **/src:** Contém todo o código-fonte da aplicação ASP.NET Core MVC.

---

### 📚 Funcionalidades Planejadas

O roadmap de desenvolvimento do EvolvOS inclui as seguintes funcionalidades:

-   [ ] **Autenticação:** Cadastro e Login de usuários.
-   [ ] **Gestão de Matérias:** CRUD (Criar, Ler, Atualizar, Deletar) completo para as matérias ou disciplinas que o usuário está estudando.
-   [ ] **Gestão de Materiais:** Adicionar materiais de estudo (links, anotações, vídeos) a cada matéria.
-   [ ] **Dashboard Pessoal:** Uma visão geral do progresso e das matérias cadastradas.

---

### 🛠️ Tecnologias Utilizadas

-   **Backend:** C#
-   **Framework:** ASP.NET Core MVC (.NET 8.0 ou superior)
-   **ORM:** Entity Framework Core
-   **Banco de Dados:** SQL Server (via LocalDB para desenvolvimento)
-   **Frontend:** HTML5, CSS3, JavaScript (com a estrutura padrão do MVC)

---

### 🏁 Como Executar o Projeto

Existem duas maneiras principais para rodar o EvolvOS localmente:

#### 1. Via Visual Studio (Recomendado)

1.  Clone este repositório:
    ```bash
    git clone [https://github.com/gusta-ve/EvolvOS.git](https://github.com/gusta-ve/EvolvOS.git)
    ```
2.  Navegue até a pasta `EvolvOS` e abra o arquivo de Solução (`.sln`) com o Visual Studio.
3.  Pressione `F5` para compilar e executar o projeto. O Visual Studio cuidará de restaurar as dependências (pacotes NuGet) automaticamente.

#### 2. Via Linha de Comando (.NET CLI)

1.  Clone este repositório.
2.  Navegue até a pasta do projeto web pelo terminal:
    ```bash
    cd EvolvOS/EvolvOS.Web
    ```
3.  Restaure as dependências do projeto:
    ```bash
    dotnet restore
    ```
4.  Execute a aplicação:
    ```bash
    dotnet run
    ```
5.  Abra seu navegador e acesse `https://localhost:5001` ou o endereço indicado no terminal.

---

### 🎯 Objetivos de Aprendizagem

Este projeto é um campo de treinamento prático para solidificar os seguintes conceitos:

-   Estrutura e fluxo do padrão **Model-View-Controller (MVC)**.
-   Implementação de um sistema de **autenticação e autorização**.
-   Operações **CRUD** e manipulação de dados com Entity Framework Core.
-   Aplicação de **Regras de Negócio** na camada de serviço/modelo.
-   Gerenciamento de **dependências** e pacotes NuGet.
-   Boas práticas com **Git e GitHub**.

---

### 📄 Licença

Este projeto está licenciado sob a **Licença MIT**. Veja o arquivo `LICENSE` para mais detalhes.