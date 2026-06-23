 Pizzaria Godoy

Projeto desenvolvido em Blazor com .NET, com o objetivo de criar um sistema web para gerenciamento de uma pizzaria.  
A aplicação possui estrutura com páginas, repositórios, banco de dados, autenticação e operações CRUD para categorias.

---

 Sobre o projeto

O Pizzaria Godoy é um sistema web em desenvolvimento para praticar conceitos importantes de programação com C#, Blazor e Entity Framework.

Neste projeto, estão sendo aplicados conceitos como:

- Componentização com Blazor
- CRUD de categorias
- Repository Pattern
- Entity Framework Core
- Migrations
- SQL Server
- Bootstrap
- JavaScript interop
- Modais de confirmação
- Notificações com Toastr
- Organização de camadas

---

Tecnologias utilizadas

- C#
- .NET
- Blazor
- Entity Framework Core
- SQL Server
- Bootstrap
- JavaScript
- Toastr.js
- Git e GitHub

---

Estrutura do projeto

O projeto está organizado em camadas para facilitar a manutenção e evolução do sistema.

Pizzaria Godoy
│
├── Components
│   ├── Layout
│   ├── Pages
│   └── Shared
│
├── Data
│   ├── ApplicationDbContext.cs
│   ├── ApplicationUser.cs
│   └── Category.cs
│
├── Repository
│   ├── IRepository
│   └── CategoryRepository.cs
│
├── Services
│   └── Extensions
│
├── wwwroot
│   ├── css
│   ├── js
│   ├── images
│   └── lib
│
├── Program.cs
└── appsettings.json
