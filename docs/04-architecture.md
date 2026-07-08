# Architecture

## Purpose

This document describes the high-level technical architecture of **EV Economics Explorer**.

The architecture is intentionally simple, focusing on modern .NET development practices while remaining appropriate for a solo portfolio project.

The application is designed to demonstrate:

- Layered architecture
- RESTful API development
- JWT authentication
- Database persistence
- External API integration
- Docker containerisation
- CI/CD using GitHub Actions

---

# Architecture Overview

The application consists of the following components:

- **Blazor Web App** – User interface
- **ASP.NET Core Web API** – Business logic and REST endpoints
- **SQL Server** – Persistent data storage
- **Entity Framework Core** – Database access
- **UK Government Fuel Finder API** – Live fuel price data
- **Docker Compose** – Local development environment
- **GitHub Actions** – Continuous Integration

---

# Solution Structure

```text
ev-economics-explorer/

├── src/
│   ├── EvEconomicsExplorer.Api/
│   ├── EvEconomicsExplorer.Web/
│   └── EvEconomicsExplorer.Shared/
│
├── tests/
│   ├── EvEconomicsExplorer.Api.Tests/
│   └── EvEconomicsExplorer.Application.Tests/
│
├── docs/
│
└── README.md
```

---

# High-Level Architecture

```text
                 User
                   │
                   ▼
         Blazor Web Application
                   │
                   ▼
          ASP.NET Core Web API
                   │
        ┌──────────┴──────────┐
        ▼                     ▼
 SQL Server Database   Fuel Finder API
```

---

# Backend Layers

```text
Controllers
      │
      ▼
Services
      │
      ▼
Entity Framework Core
      │
      ▼
SQL Server
```

### Responsibilities

**Controllers**

- Handle HTTP requests and responses.
- Validate incoming requests.
- Delegate work to services.

**Services**

- Contain business logic.
- Perform calculations.
- Coordinate communication with external services and the database.

**Entity Framework Core**

- Maps entities to the database.
- Handles queries and persistence.
- Manages database migrations.

**SQL Server**

- Stores users, vehicle profiles, comparisons and fuel price data.

---

# Data Flow

```text
User
   │
   ▼
Submit Comparison
   │
   ▼
ASP.NET Core API
   │
   ▼
Calculation Service
   │
   ▼
Fuel Price Service
   │
   ▼
SQL Server
   │
   ▼
Comparison Result
   │
   ▼
Dashboard
```

---

# Key Design Decisions

- Business logic is separated from controllers.
- The frontend contains presentation logic only.
- External APIs are isolated behind service classes.
- Entity Framework Core manages all database interactions.
- SQL Server is used as the primary relational database.
- JWT authentication protects user-specific functionality.
- Docker Compose provides a consistent local development environment.
- GitHub Actions automates building and testing.

---

# Architecture Principles

The architecture follows a small set of guiding principles:

- Keep the solution simple.
- Separate concerns between layers.
- Make business logic easy to test.
- Minimise coupling to external APIs.
- Build for maintainability rather than premature optimisation.
