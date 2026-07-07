# Feasibility Analysis

## Project

EV Economics Explorer

---

# Executive Summary

The project is considered feasible.

The technical architecture is doable, the required technologies align with the developer's capabilitries, and the public data sources exist for the core functionality. 

The primary challenge is lack of experience in managing a personal project of this size. The MVP will therefore focus on comparing running costs between petrol, diesel, and electric vehicles using transparent assumptions. 


---

# Technical Feasibility 
## Assessment

**High**

The project will be built using technologies that are already familiar or are intentionally being learned as part of the project.

Technology stack:

- ASP.NET Core
- Blazor
- SQL Server
- Entity Framework Core
- Docker
- GitHub Actions
- Azure
- REST APIs

New technologies to learn:

- Docker Compose
- CI/CD
- Azure deployment
- Production configuration
- Background API integration

These technologies are commonly used in professional .NET development and directly address gaps identified during previous portfolio projects.

---

# Operational Feasibility

## Assessment

**High**

The application represents a realistic internal business application.

Users complete a straightforward workflow:

1. Create an account.
2. Enter current vehicle information.
3. Configure driving assumptions.
4. Compare annual running costs.
5. Save previous comparisons.

No specialist hardware is required.

The application can be deployed as a standard web application.

---

# Economic Feasibility

## Assessment

**High**

Target project cost:

**£0**

Free tools:

- GitHub
- Visual Studio Community
- SQL Server Developer
- Docker Desktop
- GitHub Actions

Free data sources:

- UK Government Fuel Finder API

The only potential future cost is cloud hosting, which is not required during MVP development.

---

# Legal Feasibility

## Assessment

**Medium-High**

The application will only use publicly available data sources with appropriate licensing.

The application will not:

- scrape commercial websites
- collect unnecessary personal data
- provide financial advice
- recommend specific vehicles

Users will be informed that calculations are estimates based on published assumptions.

API licences will be reviewed before integration.

---

# Schedule Feasibility

## Assessment

**High**

Estimated development timeline:

Discovery & Planning:
1 week

Foundation:
1 week

Core MVP:
2 weeks

Testing & Deployment:
1 week

Estimated MVP completion:

5 weeks

This assumes approximately 15–20 hours of development per week alongside job applications and networking.

---

# Assumptions

The project assumes:

- Government fuel-price data remains available.
- Public APIs remain accessible.
- Users can provide approximate annual mileage.
- Representative EV efficiency assumptions are sufficiently accurate for comparison purposes.
- The project remains focused on running costs rather than total vehicle ownership costs.

---


# Dependencies

External dependencies include:

| Dependency | Purpose |
|------------|---------|
| UK Government Fuel Finder API | Fuel prices |
| GitHub | Source control |
| Docker | Local development |
| SQL Server | Data storage |
| Azure | Deployment |

Failure of any external API should not prevent the application from running.

---
# Risk Assessment

| Priority | Risk | Impact | Likelihood | Mitigation |
|-----------|------|--------|------------|------------|
| High | Scope becomes too large | High | High | Keep MVP small and prioritise core functionality |
| High | External API changes | High | Medium | Abstract API access behind services and cache responses |
| High | Incorrect business assumptions | High | Medium | Research assumptions and document all calculations |
| Medium | Cloud deployment delays | Medium | Medium | Develop locally first and deploy after MVP completion |
| Medium | Limited testing time | Medium | Medium | Prioritise business logic tests |
| Low | UI polish takes too long | Low | Medium | Prioritise functionality over appearance |

---

# Success Factors

The project will be considered successful if it:

- demonstrates full ownership of a .NET application
- integrates at least one real external API
- implements authentication
- uses SQL Server with Entity Framework Core
- is containerised using Docker
- includes automated CI/CD
- is deployed to the cloud
- provides a realistic business solution

