# EventEase

EventEase is a Blazor Web App coursework project for browsing events, registering attendees, maintaining scoped user-session state, and tracking attendance.

## Rubric coverage

1. **GitHub repository:** This project is ready to be committed to a public GitHub repository.
2. **Foundational Event Card:** `EventCard.razor` is reusable. `EventEditor.razor` contains event fields and two-way binding with `@bind-Value`.
3. **Routing:** Routes include `/`, `/events`, `/events/{Id:int}`, `/register`, `/registration-success`, and `/attendance`, plus a not-found experience.
4. **Validation and reliability:** Registration and event models use data annotations. Forms include validation summaries/messages. Typed route constraints and missing-event handling prevent common routing errors. Lists use `@key` for efficient rendering.
5. **Advanced features:** The app includes a validated registration form, scoped `UserSessionService`, scoped in-memory `EventService`, and an interactive attendance tracker.
6. **Copilot summary:** See the section below.

## How Copilot assisted

- **Foundation:** Copilot helped scaffold the reusable event card, event model, form fields, component parameters, and two-way data-binding syntax.
- **Debugging and routing:** Copilot helped check route templates, add the integer route constraint, handle unknown event IDs, and create a user-friendly not-found route.
- **Optimization:** Copilot suggested data-annotation validation, scoped services, `@key` in rendered lists, null-safe lookups, and concise shared components.
- **Advanced features:** Copilot helped design the registration workflow, session state service, attendee model, and attendance toggle behavior.
- **Documentation:** Copilot organized the rubric checklist and setup instructions in this README.

## Run locally

Prerequisite: .NET 8 SDK.

```bash
dotnet restore
dotnet run
```

Open the local URL printed in the terminal. Test this flow: Events -> event details -> Register -> Registration success -> Attendance.

## Verification checklist

- Submit an empty registration form and confirm validation messages appear.
- Enter an invalid email and confirm validation blocks submission.
- Open `/events/999` and confirm the event-not-found message appears.
- Open an unknown path and confirm the router not-found page appears.
- Complete registration and toggle the attendee's attendance status.
- Refreshing or opening a new server circuit may reset the in-memory coursework data. This is intentional for this demo.

## Publish to GitHub

Create an empty public repository named `EventEase`, then run from this project folder:

```bash
git init -b main
git add .
git commit -m "Initial commit"
git remote add origin https://github.com/YOUR-USERNAME/EventEase.git
git push -u origin main
```

Do not commit passwords, access tokens, API keys, or other secrets. Replace `YOUR-USERNAME` with your GitHub username, then submit the public repository page URL in Coursera.
