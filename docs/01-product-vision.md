docs/01-product-vision.md
This document describes the vision, goals and scope of the EV Economics Explorer project.

# Business Question

> Would an EV reduce my annual running costs given how I drive and charge?

---

# Minimum Viable Product

The MVP will allow users to:

- enter their current vehicle details
- enter annual mileage
- choose charging behaviour
- retrieve current UK fuel prices
- compare annual petrol/diesel costs against EV charging scenarios
- save comparisons
- view the results in a dashboard

---

# Vision

EV Economics Explorer is a full-stack ASP.NET Core application that helps UK drivers understand how their annual running costs would change if they switched from a petrol or diesel vehicle to an electric vehicle.

The application combines real UK fuel-price data (-- THIS MIGHT BE A FUTURE --) with user driving habits) and charging assumptions to provide transparent, easy-to-understand running cost comparisons.

The project is designed as a portfolio application to demonstrate modern .NET software engineering practices while solving a genuine business problem.

---

# Problem Statement

Many people considering an electric vehicle are unsure whether it will actually reduce their running costs.


Online calculators often:

- hide assumptions (method of charging, model of car, driving patterns)
- use outdated or fixed fuel prices
- focus on a single charging scenario
- provide little explanation of how the result was calculated

Example: https://www.selectcarleasing.co.uk/fuel-cost-calculator 

Users therefore struggle to understand how factors such as mileage, charging behaviour and fuel prices influence the economics of switching to an EV.

---

# Product Goal

Provide a simple decision-support tool that allows users to compare the annual running costs of their current vehicle with different EV charging scenarios using real UK fuel-price data and transparent assumptions.

The objective is to help users understand **why** costs differ, rather than simply presenting a final figure.

---

# Target Users

Primary users:

- UK drivers considering purchasing an electric vehicle.
- Drivers who want to estimate potential fuel savings.

Secondary users:

- Students interested in energy economics.
- Recruiters and software engineering interviewers reviewing the project.
- Developers interested in the application's architecture.

---

# Success Criteria

The project will be considered successful if:

- Users can easily compare annual running costs.
- Calculations are based on transparent assumptions.
- The application demonstrates modern .NET engineering practices.
- The project provides strong evidence of full-stack software engineering ability during job interviews.

---

# Out of Scope

Version 1 will not include:

- vehicle recommendations
- finance calculations
- insurance costs
- depreciation
- servicing costs
- charging station availability
- vehicle purchasing advice

These may be considered in future releases but are intentionally excluded from the MVP to keep the project focused.

---

# Technology

- ASP.NET Core
- Blazor
- SQL Server
- Entity Framework Core
- Docker
- GitHub Actions
- REST APIs
- Azure

