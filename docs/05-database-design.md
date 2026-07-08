# Database Design

## Purpose

This document describes the MVP database design for **EV Economics Explorer**.

The database is responsible for storing authenticated users and saved running cost comparisons.

The MVP database is intentionally simple. It only includes entities that are required for the first working version of the application.

---

# Database Overview

The application uses **SQL Server** with **Entity Framework Core**.

The MVP database stores:

- User accounts
- Saved running cost comparisons

---

# Entity Relationship Diagram

```text
User
 │
 │ 1
 │
 ▼
Comparison
```

A single user can have many saved comparisons.

---

# Entities

## User

Represents an authenticated user of the application.

### Responsibilities

- Authentication
- Ownership of saved comparisons

### Example Fields

- UserId
- FirstName
- LastName
- Email
- PasswordHash
- CreatedDate

---

## Comparison

Represents a single running cost comparison created by a user.

Each comparison stores both the user inputs and the calculated outputs. This ensures historical comparisons remain reproducible even if fuel prices or assumptions change later.

### Example Fields

- ComparisonId
- UserId
- FuelType
- MilesPerGallon
- AnnualMileage
- EvCategory
- ChargingScenario
- PetrolPricePerLitre
- DieselPricePerLitre
- AnnualFuelCost
- AnnualEvCost
- AnnualSaving
- CreatedDate

---

# Relationships

## User to Comparison

One User can have many Comparisons.

Each Comparison belongs to one User.

```text
User 1 ─── * Comparison
```

---

# Design Decisions

- The MVP uses only two tables: `User` and `Comparison`.
- Vehicle details are stored directly on the `Comparison` table.
- Fuel prices used in the calculation are stored directly on the `Comparison` table.
- EV category and charging scenario are stored as values on the `Comparison` table rather than separate lookup tables.
- Historical comparisons should not change if fuel prices or assumptions change later.
- The database is deliberately not over-normalised at MVP stage.

---

# Excluded From MVP

The following tables are intentionally excluded from the MVP:

- VehicleProfile
- EVCategory
- ChargingScenario
- FuelPriceSnapshot
- ElectricityTariff
- CarbonIntensity

These may be introduced later if the application grows and the requirements justify them.

---

# Future Enhancements

Possible future database entities include:

- VehicleProfile
- EVCategory
- ChargingScenario
- FuelPriceSnapshot
- ElectricityTariff
- ElectricityPriceSnapshot
- CarbonIntensity
- SavedScenario

These are not required for the first version.

---

# Database Principles

The database has been designed to:

- keep the MVP simple
- support user authentication
- save historical comparisons
- preserve the assumptions used in each calculation
- avoid unnecessary tables before they are needed
- integrate cleanly with Entity Framework Core
