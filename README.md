# MoviePages

A web application for managing and browsing a movie catalog. Built with ASP.NET Core Razor Pages, Entity Framework Core, and SQLite, this app allows users to view, add, edit, and delete movies in a simple, modern interface.

---

## Features

- **View Movies**: See a list of all movies in the catalog.
- **View Movie Details**: Display details for each movie.
- **Create Movies**: Add new movies to the catalog.
- **Edit Movies**: Update existing movie information.
- **Delete Movies**: Remove movies from the catalog.
- **Validation**: Form validation for movie name and year.
- **Bootstrap UI**: Responsive and clean interface using Bootstrap.
- *(Optional)*: The structure supports adding search/filter functionality.

---

## Built With

- **.NET**: ASP.NET Core 9.0 (see `TargetFramework` in `.csproj`)
- **Razor Pages**: For page-based web UI.
- **Entity Framework Core**: ORM for data access.
- **SQLite**: Lightweight relational database.
- **Bootstrap 5**: For responsive UI (managed via LibMan).

---

## Prerequisites

- [.NET 9.0 SDK](https://dotnet.microsoft.com/download)
- A code editor (e.g., [Visual Studio Code](https://code.visualstudio.com/) or [Visual Studio 2022+](https://visualstudio.microsoft.com/))
- (Optional) [EF Core Tools](https://learn.microsoft.com/ef/core/cli/dotnet) (`dotnet tool install --global dotnet-ef`)

---

## Getting Started

### 1. Clone the Repository

```sh
git clone https://github.com/codehaks/MoviePages.git
cd MoviePages/src
```

### 2. Restore Dependencies

```sh
dotnet restore
```

### 3. Create the SQLite Database & Apply Migrations

Ensure you have the EF Core tools installed. Then run:

```sh
dotnet ef database update
```

This will create the `movies.db` SQLite database and apply the initial schema and seed data.

### 4. Run the Application

```sh
dotnet run
```

The app will start and provide a local URL (e.g., `https://localhost:5001`). Open it in your browser.

---

## Project Structure

- **Pages/**: Razor Pages for UI (CRUD operations for movies).
- **Models/**: Data models (e.g., `Movie.cs`).
- **Data/**: Database context (`MovieDbContext.cs`) and EF Core configuration.
- **Migrations/**: Entity Framework Core migration files.
- **wwwroot/**: Static files (Bootstrap, JS, CSS, etc.).
- **appsettings.json**: Application configuration.
- **libman.json**: Library Manager config for client-side libraries.

---

## Usage

1. **Home/Movies Page**: View the list of movies.
2. **Create New**: Click "New Movie" to add a movie.
3. **Edit**: Click "Edit" next to a movie to update its details.
4. **Delete**: Click "Delete" to remove a movie (confirmation required).
5. **Validation**: Forms enforce name length and year range.

---

## Testing

Test the following scenarios:

- **Create**: Add a new movie and verify it appears in the list.
- **Read**: View the list and details of movies.
- **Update**: Edit a movie and confirm changes are saved.
- **Delete**: Remove a movie and ensure it is deleted.
- *(If implemented)*: Test any search or filter features.

---

## Note on SQLite

The SQLite database file (`movies.db`) will be created in the project output directory (e.g., `bin/Debug/net9.0/`) after running the EF Core database update command. You can safely delete this file to reset the database.

---

Feel free to further customize this README for your needs!
