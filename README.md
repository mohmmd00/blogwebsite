# blogwebsite
This project is a minimalistic blogging platform where users can read blog posts. The project is built using HTML, CSS, and JavaScript for the frontend, and .NET Core with Entity Framework Core (EF Core) for the backend. The blog data is stored in a SQL Server database.

## Features

- User Authentication: Sign up, log in, and log out functionality.
- Create Posts: Authenticated admins can create new blog posts.
- Read Posts: Anyone can read blog posts.
- Edit Posts: Authenticated admins can edit their own blog posts.
- Delete Posts: Authenticated admins can delete their own blog posts.

## Architecture

This project is developed using the Onion Architecture, which promotes a clean separation of concerns and a more maintainable codebase. The main layers of the architecture are:

- Domain: Contains the business logic and domain models.
- Application: Contains application-specific logic and interfaces.
- Infrastructure: Contains data access logic and implementations using EF Core.
- Presentation: Contains the web application (ASP.NET Core MVC) and UI logic.