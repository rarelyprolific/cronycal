# cronycal

A perpetually unfinished web application to track which books I'm reading.

> [!WARNING]
> **This is not a real application!** It doesn't really work. It will likely
> never be in a finished state. It's a dummy project I'm hacking on
> and using to learn stuff.

## Development

- It should be an **ASP.NET Core 10** website.
- Use **ASP.NET Core Identity** to implement self-contained authn and authz.
- Use **EF Core** with **SQL Server** for data persistence.
- Use **Razor Pages** for UI or possibly **Vue.js** if I want SPA behaviours.
- Consider **Axios** as a possible alternative to plain "fetch" for AJAX requests.

## Hosting in Local Development

- Use **SQL Server** container via **Docker Compose**.

## Code Quality

- Using **csharpier** to auto-format the C# code.
- Using **markdownlint** to validate markdown documentation.

## Testing

- Use **xUnit** for unit testing.
- Use **test containers** for integration testing.
- Use **PlayWright** for automation/E2E/UI testing.
