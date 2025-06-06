# Financial Risk Event Tracker API

A clean, testable, enterprise-style RESTful API built with ASP.NET Core for tracking and managing operational, cyber, or market risk events.

## 🔧 Features

- Full CRUD API for managing risk events
- EF Core with SQLite for real persistence
- Swagger UI with XML-based endpoint documentation
- Data validation using Data Annotations
- xUnit unit testing for repository logic
- Follows clean architecture principles (separation of concerns, DI)
- Dockerfile for containerised deployment

## ❇️ Technologies

- C# 10 / .NET 8 (LTS)
- ASP.NET Core Web API
- Entity Framework Core + SQLite
- Swagger / OpenAPI
- xUnit
- Git for version control
- Docker

## 🚀 How to Run

```bash
cd RiskEventTracker.API
dotnet run
```

Then visit:

```
http://localhost:5102/swagger
```

Replace `5102` with your local port if different.

## ✅ API Endpoints

| Method | Endpoint | Description |
|--------|----------|-------------|
| `GET` | `/api/riskevents` | Get all risk events |
| `GET` | `/api/riskevents/{id}` | Get risk event by ID |
| `POST` | `/api/riskevents` | Create a new risk event |
| `PUT` | `/api/riskevents/{id}` | Update a risk event |
| `DELETE` | `/api/riskevents/{id}` | Delete a risk event |

## 🧪 Running Tests

```bash
dotnet test
```

## 🐳 Running with Docker
You can also run the API in a containerised environment:

```bash
docker build -t risk-event-tracker .
docker run -p 8080:80 risk-event-tracker
```

Then open:

```bash
http://localhost:8080/swagger
```

## 📝 Future Enhancements

- Add authentication and authorisation (e.g., JWT)
- Add integration tests with WebApplicationFactory
- Deploy to a cloud platform (Render, Azure, etc.)
- Replace SQLite with a production-grade database (SQL Server, PostgreSQL)

## 👤 Author

Created by Elias as a professional showcase of real-world C# API development, testing, persistence, and containerisation best practices.
