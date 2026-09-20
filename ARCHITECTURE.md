# JobScout Architecture

## Purpose

JobScout is an ASP.NET Core MVC application for organizing companies and software
development opportunities in Germany.

The architecture should remain simple, testable, and understandable for a small
portfolio project.

## Architectural Style

The application uses a modular monolith structure.

This means:

- the application is deployed as one web application;
- the code is separated into logical areas;
- the application does not require multiple independently deployed services;
- database access is separated from web-page code.

This is appropriate for the current MVP because the project is small and has one
main user.

## Main Technologies

- C#
- .NET
- ASP.NET Core MVC
- Entity Framework Core
- MySQL
- HTML and Bootstrap
- Git and GitHub

## Main Layers

### Presentation Layer

Responsibilities:

- receive browser requests;
- validate input models;
- call application services;
- select views;
- display results to the user.

Planned folders:

- `Controllers`
- `Views`
- `ViewModels`

Controllers should coordinate requests. They should not contain database queries
or complex business rules.

### Application Layer

Responsibilities:

- implement application use cases;
- coordinate operations;
- apply business decisions;
- communicate through interfaces.

Examples of future services:

- `CompanyService`;
- `JobPositionService`;
- `ApplicationTrackingService`.

Services should not know about HTML or Razor views.

### Domain Layer

Responsibilities:

- represent the main business concepts;
- contain domain entities;
- contain enums and important business rules.

Planned domain concepts include:

- `Company`;
- `JobPosition`;
- `ApplicationStatus`;
- `GermanLanguageLevel`.

The domain layer should not depend on ASP.NET Core or MySQL.

### Infrastructure Layer

Responsibilities:

- connect to MySQL;
- configure Entity Framework Core;
- implement repositories;
- perform database persistence.

Planned infrastructure components include:

- `JobScoutDbContext`;
- company repository;
- job-position repository;
- Entity Framework Core configurations.

Infrastructure code should be replaceable without changing the user interface.

## Request Flow

A typical request should follow this direction:

1. The browser sends a request.
2. A controller receives the request.
3. The controller calls an application service.
4. The application service uses a repository when data is needed.
5. The repository communicates with MySQL through Entity Framework Core.
6. The result returns to the service.
7. The controller passes a view model to the Razor view.
8. The Razor view generates HTML for the browser.

## Database Access Rule

Controllers and Razor views must not contain direct database queries.

Database access belongs in the infrastructure layer.

This keeps responsibilities separated and makes the application easier to test and
maintain.

## Current MVP Decision

The first implementation will remain inside the existing `JobScout.Web` project.

Logical folders will be introduced before considering multiple projects.

This avoids unnecessary project complexity while the application is still small.

## Out of Scope

The first version will not include:

- automatic job-site scraping;
- automatic application submission;
- authentication;
- background processing;
- cloud-only services;
- microservices;
- a separate frontend application.

## Future Quality Goals

The project should gradually add:

- input validation;
- automated tests;
- clear error handling;
- logging;
- accessibility improvements;
- responsive layout;
- database migrations;
- separation of view models from database entities.

## Architecture Principle

Each part of the application should have one clear responsibility.

The user interface should display information, application services should coordinate
use cases, the domain should represent business concepts, and infrastructure should
handle persistence.