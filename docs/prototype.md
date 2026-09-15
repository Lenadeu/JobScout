# JobScout Prototype

## Prototype Goal

Create a simple visual representation of the main JobScout page before implementing
the application functionality.

The prototype should help answer these questions:

- Can the user quickly understand the purpose of the application?
- Can the user see saved companies at a glance?
- Can the user identify companies with open positions?
- Can the user identify companies accepting initiative applications?
- Can the user see German language requirements?
- Can the user easily add a new company?

## Target User

The target user is an experienced C#/.NET software developer searching for suitable
software development opportunities in Germany.

The interface should therefore be practical, compact, and focused on job-search
information rather than decorative content.

## Prototype Scope

The first prototype contains one main page:

- company list;
- search field;
- filters;
- summary information;
- add-company button;
- links to company and job details.

The prototype is static. Buttons and links do not need to work yet.

## Main Page Layout

### Header

The header contains:

- application name: JobScout;
- short description: C#/.NET opportunities in Germany;
- button: Add company.

### Summary Area

The page displays summary cards for:

- total companies;
- companies with open positions;
- companies accepting initiative applications;
- applications requiring follow-up.

### Search and Filters

The page contains:

- search field for company names;
- location filter;
- German-language-level filter;
- application-status filter.

### Company List

Each company row displays:

- company name;
- location;
- open-position indicator;
- initiative-application indicator;
- required German level;
- application status;
- details link.

### Example Companies

The prototype may contain example data such as:

- Example Software GmbH;
- Bavaria Digital AG;
- Rhine Systems GmbH.

These are placeholder companies for the prototype only.

## Design Principles

- Use clear labels.
- Keep the most important information visible.
- Use consistent colors for statuses.
- Make links and buttons easy to identify.
- Use readable text and sufficient spacing.
- Avoid storing personal data in the prototype.
- Keep the layout usable on smaller screens.

## Architecture Direction

The application will use ASP.NET Core MVC:

- Model: application data and validation rules;
- View: HTML interface shown to the user;
- Controller: receives requests and selects the response.

A repository layer will later isolate database access from the rest of the application.

The first prototype does not require a database or working business operations.

## Future Iterations

Possible later improvements include:

- a company-details page;
- an add-company form;
- an edit-company form;
- a job-position list;
- sorting and filtering;
- MySQL persistence;
- validation;
- automated tests;
- accessibility improvements based on testing.