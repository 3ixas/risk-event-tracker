# Risk Event Tracker API

A simple, testable RESTful Web API built with ASP.NET Core for tracking and managing risk events such as operational, cyber, or market risks.

## 🔧 Features

- Add, view, update, and delete risk events via REST API
- In-memory repository (simulates a real database)
- Swagger UI for easy API testing
- Unit tested with xUnit
- Follows clean architecture principles
- Ready to be extended or connected to a database

## ❇️ Technologies

- C# 10 / .NET 8 (LTS)
- ASP.NET Core Web API
- xUnit for testing
- Swagger/OpenAPI
- Git for version control

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

## 📝 Future Enhancements

- Replace in-memory storage with a real database (e.g., SQL Server, PostgreSQL)
- Add authentication and authorisation
- Add Docker support

## 👤 Author

Created by Elias as a showcase of clean C# API design, testing, and documentation practices.