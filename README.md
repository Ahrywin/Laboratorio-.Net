# News API Service

## Description
This is a .NET Web API service that provides functionality to manage and store news articles. Built with .NET 9.0, it implements a clean architecture pattern with Entity Framework Core for data persistence and AutoMapper for object mapping.

## Features
- Create and store news articles
- Automatic tracking of creation dates and soft deletion
- SQL Server database integration
- Swagger documentation

## Tech Stack
- .NET 9.0
- Entity Framework Core 9.0.1
- SQL Server
- AutoMapper 13.0.1
- Swagger/OpenAPI

## Project Structure
```
├── Controllers/
│   └── NewsController.cs      # API endpoints
├── Services/
│   └── NewsService.cs         # Business logic
├── Data/
│   ├── DTOs/                  # Data Transfer Objects
│   ├── AxioModels/           # Database Models
│   └── Profile/              # AutoMapper Configurations
```

## API Endpoints

### POST /api/news
Creates a new news article.

**Request Body:**
```json
{
  "newsAxioMessageContent": "string",
  "newsAxioTitle": "string",
  "newsAxioCreatedBy": "guid"
}
```

## Setup and Installation

1. Clone the repository
```bash
git clone https://github.com/Ahrywin/Laboratorio-.Net.git
```

2. Update the connection string in `appsettings.json` if needed

3. Run the application
```bash
dotnet run
```

The API will be available at:
- HTTP: http://localhost:5039
- HTTPS: https://localhost:7008

## Documentation
API documentation is available through Swagger UI when running in development mode at `/swagger`.