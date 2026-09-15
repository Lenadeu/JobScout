# JobScout User Stories

## Primary User

The primary user is an experienced C#/.NET software developer looking for suitable
software development opportunities in Germany.

## MVP User Stories

### US-001: Add a company

As a C#/.NET developer,
I want to save a company with its name, location, website, and career-page link,
so that I can build a list of potential employers.

Acceptance criteria:

- The user can enter a company name.
- The user can enter a location.
- The user can enter the company website.
- The user can enter the career-page URL.
- The company appears in the company list after saving.

### US-002: Record an open position

As a C#/.NET developer,
I want to save a link to an open C#/.NET position,
so that I can return to the position when preparing an application.

Acceptance criteria:

- The user can enter a position title.
- The user can enter the job URL.
- The user can enter a short description or note.
- The position is connected to a saved company.

### US-003: Record initiative-application possibilities

As a C#/.NET developer,
I want to record whether a company accepts initiative applications,
so that I can identify companies where I can apply even without a specific vacancy.

Acceptance criteria:

- The user can mark initiative applications as possible.
- The user can mark initiative applications as not possible.
- The user can leave the value unknown.
- The information is visible in the company details.

### US-004: Record technologies and language requirements

As a C#/.NET developer,
I want to record the technologies and required language levels,
so that I can compare each opportunity with my skills and language abilities.

Acceptance criteria:

- The user can add technology notes.
- The user can select the required German level:
  - Not specified
  - No German required
  - A1
  - A2
  - B1
  - B2
  - C1
  - C2
- The user can select whether English is accepted.
- The information can be edited later.

### US-005: Track application status

As a C#/.NET developer,
I want to track my application status,
so that I know which companies and positions require follow-up.

Acceptance criteria:

- The user can select a status.
- The available statuses include:
  - Not applied
  - Planned
  - Applied
  - Interview
  - Rejected
  - Offer
- The status is visible in the company or position list.

### US-006: View saved companies

As a C#/.NET developer,
I want to view all saved companies in one list,
so that I can manage my job search from one place.

Acceptance criteria:

- The application displays all saved companies.
- The list shows the company name and location.
- The list shows whether open positions exist.
- The list shows whether initiative applications are possible.
- The user can open a company's details.