# API Design

## Purpose

This document describes the proposed REST API for **EV Economics Explorer**.

The API provides authentication, comparison management and access to current UK fuel prices.

The API follows REST principles and exchanges data using JSON.

---

# API Overview

The backend exposes the following resources:

- Authentication
- Users
- Comparisons
- Fuel Prices

The Blazor frontend communicates exclusively through these API endpoints.

---

# Authentication

## Register

```http
POST /api/auth/register
```

Creates a new user account.

### Request

```json
{
  "firstName": "John",
  "lastName": "Smith",
  "email": "john@example.com",
  "password": "Password123!"
}
```

### Response

```http
201 Created
```

---

## Login

```http
POST /api/auth/login
```

Authenticates a user and returns a JWT.

### Request

```json
{
  "email": "john@example.com",
  "password": "Password123!"
}
```

### Response

```json
{
  "token": "<jwt-token>"
}
```

---

# Comparisons

## Create Comparison

```http
POST /api/comparisons
```

Creates a new running cost comparison.

### Request

```json
{
  "fuelType": "Petrol",
  "milesPerGallon": 42,
  "annualMileage": 12000,
  "evCategory": "Family",
  "chargingScenario": "MostlyHome"
}
```

### Response

```json
{
  "annualFuelCost": 1825,
  "annualEvCost": 640,
  "annualSaving": 1185
}
```

---

## Get Saved Comparisons

```http
GET /api/comparisons
```

Returns all comparisons for the authenticated user.

---

## Get Comparison

```http
GET /api/comparisons/{id}
```

Returns a single saved comparison.

---

## Delete Comparison

```http
DELETE /api/comparisons/{id}
```

Deletes a saved comparison.

---

# Fuel Prices

## Current Fuel Prices

```http
GET /api/fuelprices
```

Returns the latest cached UK fuel prices.

Example response:

```json
{
  "petrolPricePerLitre": 1.37,
  "dieselPricePerLitre": 1.45,
  "retrieved": "2026-07-08T10:30:00Z"
}
```

---

# Authentication

Protected endpoints require a valid JWT.

Authentication header:

```http
Authorization: Bearer <jwt-token>
```

Protected endpoints include:

- Create Comparison
- View Comparisons
- Delete Comparison

Public endpoints include:

- Register
- Login

---

# Response Codes

| Code | Meaning |
|-------|---------|
| 200 | Success |
| 201 | Resource created |
| 400 | Invalid request |
| 401 | Unauthenticated |
| 403 | Forbidden |
| 404 | Resource not found |
| 500 | Internal server error |

---

# Design Principles

The API has been designed to:

- follow REST conventions
- use predictable endpoint names
- exchange data using JSON
- keep controllers lightweight
- place business logic inside services
- isolate external API integrations
- make future expansion straightforward
