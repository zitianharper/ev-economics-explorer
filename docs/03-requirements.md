# Requirements Specification

## Project

EV Economics Explorer

---

# Purpose

This document defines the functional and non-functional requirements for EV Economics Explorer.

The application is intended to help UK drivers compare the annual running costs of their current petrol or diesel vehicle against equivalent electric vehicle charging scenarios using real UK fuel price data and transparent assumptions.

---

# Product Goal

Develop a web application that allows users to estimate whether switching to an electric vehicle could reduce their annual running costs.

The application should demonstrate modern software engineering practices while remaining simple, transparent and easy to use.

---

# Target Users

Primary users:

- UK drivers considering switching to an electric vehicle.

Secondary users:

- Software engineering recruiters.
- Hiring managers.
- Developers reviewing the project.

---

# Functional Requirements

## FR1 - User Authentication

The application shall allow users to:

- Register an account.
- Log in.
- Log out.
- Maintain a secure authenticated session.

---

## FR2 - Vehicle Information

The application shall allow users to enter:

- Current fuel type.
- Vehicle fuel economy (MPG).
- Annual mileage.

---

## FR3 - EV Comparison

The application shall allow users to select:

- Small EV
- Family EV
- SUV EV

Each category shall use predefined efficiency assumptions.

---

## FR4 - Charging Behaviour

The application shall allow users to select:

- Mostly home charging
- Mixed home/public charging
- Mostly public charging

---

## FR5 - Fuel Price Retrieval

The application shall retrieve current UK fuel prices from the Government Fuel Finder API.

The application shall cache retrieved prices.

If the API is unavailable, the user shall receive an appropriate message.

---

## FR6 - Cost Calculations

The application shall calculate:

- Annual petrol cost.
- Annual diesel cost.
- Annual EV charging cost.
- Cost per mile.
- Estimated annual savings.

---

## FR7 - Dashboard

The application shall display:

- Current vehicle running cost.
- EV running cost.
- Annual savings.
- Cost per mile.
- Key assumptions used in the calculation.

---

## FR8 - Saved Comparisons

Authenticated users shall be able to:

- Save comparisons.
- View previous comparisons.
- Delete previous comparisons.

---

# Non-Functional Requirements

## Performance

The application should return calculation results within two seconds.

---

## Security

Passwords shall be securely hashed.

Protected pages shall require authentication.

Sensitive configuration values shall not be committed to source control.

---

## Reliability

The application shall continue functioning if an external API becomes temporarily unavailable.

Previously cached fuel prices may be used.

---

## Maintainability

Business logic shall be separated from presentation.

The project shall follow a layered architecture.

Database access shall be handled using Entity Framework Core.

---

## Usability

The application shall be usable by someone with little or no knowledge of electric vehicles.

All assumptions shall be clearly explained.

The user interface shall remain simple and uncluttered.

---

## Portability

The application shall run locally using Docker Compose.

The application should be deployable to Azure.

---

# Constraints

The project shall:

- Use ASP.NET Core.
- Use Blazor.
- Use SQL Server.
- Use Entity Framework Core.
- Use Docker.
- Use GitHub Actions.

---

# Out of Scope

The MVP will not include:

- Vehicle purchasing advice.
- Insurance comparisons.
- Finance calculations.
- Depreciation.
- Servicing costs.
- Charging station maps.
- Vehicle recommendation engine.
- Route planning.

---

# User Stories

### Registration

As a new user,

I want to register an account,

so that I can save my vehicle comparisons.

---

### Login

As a returning user,

I want to log in,

so that I can access my saved comparisons.

---

### Fuel Price Retrieval

As a user,

I want the application to use current UK fuel prices,

so that my calculations reflect current market conditions.

---

### Cost Comparison

As a driver,

I want to compare my current running costs with different EV charging scenarios,

so that I can understand the financial impact of switching.

---

### Dashboard

As a user,

I want to see my results in an easy-to-read dashboard,

so that I can quickly understand the outcome.

---

### Saved Comparisons

As a user,

I want to save previous calculations,

so that I can compare different scenarios over time.

---

# Minimum Viable Product

The MVP shall include:

- Authentication
- Vehicle input
- Fuel price API integration
- Running cost calculations
- Dashboard
- Saved comparisons
- Docker
- SQL Server
- Entity Framework Core

---

# Success Criteria

The application will be considered successful if a user can:

1. Register.
2. Log in.
3. Enter vehicle information.
4. Retrieve current fuel prices.
5. Compare running costs.
6. Save their comparison.
7. View previous comparisons.

