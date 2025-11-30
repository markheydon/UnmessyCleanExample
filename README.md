# A simple example of what a so called 'Clean Architecture' project might look like in .NET

After some considerable time away from development stuff, I needed to try get my skills somewhere near to up to date of current development practices. Despite my best efforts, I couldn't for the life of me find an example of clean architecture _(as described by Uncle Bob Martin)_ that wasn't either totally over the top to understand the concepts described or just plain wrong in its implementation.

So, as I often do in these situations, I decided to totally ignore everybody else and do it my way. This repo is the results of my learnings. I don't doubt some people will totally disagree with it, but I don't care, it helped me wrap my head around it and maybe it will someone else too.

## Project Structure

The solution is made up of four projects:

1. **Domain** - This project contains the core business logic and entities. It is completely independent of any other layers and has no dependencies on external libraries or frameworks.

2. **Application** - This project contains the application logic, including use cases and service interfaces. It depends on the Domain project but has no dependencies on infrastructure or UI layers.

3. **Infrastructure** - This project contains implementations of the service interfaces defined in the Application layer. It handles data access, external services, and other infrastructure concerns. It depends on both the Domain and Application projects.

4. **BlazorWebApp** - This project is the entry point of the application. It contains the Blazor components, API controllers, and handles HTTP requests. It depends on the Application and Infrastructure projects.

### Notes

- The dependencies flow inward, meaning that the outer layers depend on the inner layers, but not vice versa. This ensures that the core business logic remains isolated and testable.

- The solution was created from the default Blazor app template available at the time using .NET 10 / C# 14 shortly after the GA release of Visual Studio 2026.

- Some elements, mainly documentation, were totally written by AI -- again moan about that all you want; AI is here, get used to it, I have and I'm really old in _development_ terms!

## References

- [The Clean Architecture by Robert C. Martin (Uncle Bob)](https://blog.cleancoder.com/uncle-bob/2012/08/13/the-clean-architecture.html)
- [UNCLE-BOB.md — Clean Architecture Comparison and Analysis](./UNCLE-BOB.md)

