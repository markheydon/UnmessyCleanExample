# Copilot Instructions: Clean Architecture Enforcement

This repository is a reference implementation of Clean Architecture for .NET 10 Blazor. All code, suggestions, and modifications must strictly adhere to these rules:

## Layered Architecture

- **Domain:** Enterprise business rules and models. No dependencies on any other project.
- **Application:** Use cases, service/repository interfaces, DTOs. Depends only on Domain.
- **Infrastructure:** Implements Application interfaces (e.g., data access, APIs). Depends on Application and Domain. No code in Application or Domain may reference Infrastructure.
- **UI (BlazorWebApp):** Presentation logic. Depends only on Application (and Domain if necessary for models). May reference Infrastructure only in the composition root (e.g., for DI registration in `Program.cs`).

## Dependency Rules

- All dependencies must point inward (UI/Infrastructure → Application → Domain).
- **Never** reference Infrastructure from Application or Domain.
- **Never** reference UI from Application, Domain, or Infrastructure.

**Example (Correct):**
- `BlazorWebApp` uses `IWeatherForecastService` (from Application).
- `Infrastructure` implements `IWeatherForecastRepository` (from Application).

**Example (Incorrect):**
- `Application` references `MockWeatherForecastRepository` (from Infrastructure). ❌

## Comments

- All classes, methods, and significant logic must have clear, concise comments explaining their purpose and behavior.
- Comments must clarify architectural intent, especially at layer boundaries.

## AI Agent Requirements

- All generated code must comply with these architecture and commenting rules.
- Do not suggest or generate code that violates layer boundaries or dependency direction.
- If a user request would violate these rules, explain why and suggest an alternative.

## Documentation

- Update this file and the main README if architectural changes are made.
- Ensure all code samples and explanations remain accurate.

---

By following these instructions, this repository will remain a clear, practical, and educational example of Clean Architecture in .NET and Blazor.