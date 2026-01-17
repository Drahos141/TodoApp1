# TodoApp1
Simple but effective Todo Application built with .NET 8 and Blazor Server

## Features
- Add new todos
- Mark todos as completed/incomplete
- Delete todos
- View todo statistics (total, completed, pending)
- Clean and modern UI

## Prerequisites
- .NET 8.0 SDK or later
- A web browser

## Getting Started

1. Restore dependencies:
   ```bash
   dotnet restore
   ```

2. Build the application:
   ```bash
   dotnet build
   ```

3. Run the application:
   ```bash
   dotnet run
   ```

4. Open your browser and navigate to the URL shown in the console (typically `https://localhost:5001` or `http://localhost:5000`)

## Project Structure
- `Models/` - TodoItem model
- `Services/` - TodoService for managing todos
- `Pages/` - Blazor pages (Index.razor, _Host.cshtml)
- `Shared/` - Shared components (MainLayout, NavMenu)
- `wwwroot/` - Static files (CSS)

## Technologies Used
- .NET 8.0
- Blazor Server
- C#
- ASP.NET Core
