# PlataformaCursos

Aplicação console em **C# / .NET** que modela o domínio de uma plataforma de cursos online: conteúdos (artigos, cursos e carreiras), alunos, planos e assinaturas.

O projeto é focado em praticar **orientação a objetos** (herança, classes abstratas, composição) e o **Notification Pattern** para validação de regras de negócio sem lançar exceções.

## Funcionalidades

- Cadastro de **artigos**, **cursos** (com módulos e aulas) e **carreiras** (com itens ordenados que referenciam cursos).
- Níveis de conteúdo via enum `EContentLevel` (Beginner, Fundamental, Intermediary, Advanced).
- **Alunos** com usuário e assinaturas, com verificação de assinatura premium (`IsPremium`).
- Assinaturas por provedor de pagamento: `PayPalSubscription` e `PagarMeSubscription`.
- **Notification Pattern**: entidades acumulam notificações (`Property` + `Message`) em vez de lançar exceções.
  - Ex.: um `CareerItem` sem curso recebe a notificação `Course - Curso invalido`.
  - Ex.: um aluno que já tem assinatura ativa não consegue criar outra.

## Estrutura do projeto

```
PlataformaCursos/
├── ContentContext/          # Article, Career, CareerItem, Content, Course, Lecture, Module
│   └── Enum/                # EContentLevel
├── NotificationContext/     # Notifiable, Notification
├── ShareContext/            # Base (Id Guid + notificações), herdada pelas entidades
├── SubscriptionContext/     # Student, User, Plan, Subscription, PayPalSubscription, PagarMeSubscription
├── Program.cs               # Exemplo de uso (ponto de entrada)
└── PlataformaCursos.csproj
```

## Modelo de domínio

### Herança

```
Notifiable
└── Base (Id)
    ├── Content (abstract: Title, Url)
    │   ├── Article
    │   ├── Course
    │   └── Career
    ├── CareerItem
    ├── Module
    ├── Lecture
    ├── Plan
    ├── User
    ├── Student
    └── Subscription
        ├── PayPalSubscription
        └── PagarMeSubscription
```

### Composição

```
Career  ── Items ─────────► CareerItem[] ──► Course
Course  ── Modules ───────► Module[]
Module  ── Lectures ──────► Lecture[]
Student ── Subscriptions ─► Subscription[]
Student ── User ──────────► User
Subscription ── Plan ─────► Plan
```

## Como executar

**Pré-requisito:** [.NET SDK](https://dotnet.microsoft.com/download) compatível com a versão definida no `PlataformaCursos.csproj`.

```bash
git clone <url-do-repositorio>
cd PlataformaCursos
dotnet run
```

O `Program.cs` cria alguns artigos, cursos e uma carreira, e imprime no console os itens da carreira com seus cursos, níveis e notificações:

```
Especialista .NET
1 - Comece por Aqui
Curso: Fundamentos C# - Nivel: 0
2 - Aprenda POO
Curso:  - Nivel:
Course - Curso invalido
3 - Aprenda .NET
Curso: Fundamentos ASP.NET - Nivel: 0
```

## Como executar

**Pré-requisito:** [.NET SDK](https://dotnet.microsoft.com/download) compatível com a versão definida no `PlataformaCursos.csproj`.

```bash
git clone <url-do-repositorio>
cd PlataformaCursos
dotnet run
```

O `Program.cs` cria alguns artigos, cursos e uma carreira, e imprime no console os itens da carreira com seus cursos, níveis e notificações:

```
Especialista .NET
1 - Comece por Aqui
Curso: Fundamentos C# - Nivel: 0
2 - Aprenda POO
Curso:  - Nivel:
Course - Curso invalido
3 - Aprenda .NET
Curso: Fundamentos ASP.NET - Nivel: 0
```

## Conceitos praticados

- Herança e classes abstratas (`Base`, `Content`, `Subscription`)
- Composição (`Career` → `CareerItem` → `Course` → `Module` → `Lecture`)
- Organização por contextos (`ContentContext`, `SubscriptionContext`, etc.)
- Notification Pattern
- Propriedades calculadas (`IsPremium`, `IsInactive`, `TotalCourses`)
- LINQ (`OrderBy`, `Any`)

## Autor

**Kaio**: [GitHub](https://github.com/Kaio-Silva)
