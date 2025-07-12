# Personal Web Page Management System - Setup Instructions

## Clean Architecture Structure

This project has been organized using Clean Architecture principles with the following projects:

### Projects Structure
- **PersonalWebPageManagementSystem.Domain** - Core entities and interfaces
- **PersonalWebPageManagementSystem.Application** - Business logic, DTOs, and application services
- **PersonalWebPageManagementSystem.Infrastructure** - Data access, Entity Framework, and external integrations
- **PersonalWebPageManagementSystem.Web.Razor** - User interface using Razor Pages (Startup Project)

### Prerequisites
- .NET 9.0 SDK
- Visual Studio Code with C# extension
- SQL Server or SQLite for database

## Running the Application

### Option 1: Using VS Code (Recommended)
1. Open the workspace in VS Code
2. Press `F5` to start debugging, or
3. Press `Ctrl+Shift+P` and run "Tasks: Run Task" → "run-web-razor"

### Option 2: Using Command Line
```powershell
# Navigate to the workspace directory
cd "c:\Users\bobge\source\repos\PersonalWebPageManagementSystem\PersonalWebPageManagementSystem"

# Run the Web.Razor project
dotnet run --project PersonalWebPageManagementSystem.Web.Razor
```

### Option 3: Using Watch Mode (Development)
```powershell
# For automatic reloading during development
dotnet watch run --project PersonalWebPageManagementSystem.Web.Razor
```

## Available VS Code Tasks
- **build** - Build the entire solution
- **publish** - Publish the Web.Razor project
- **watch** - Run in watch mode with hot reload
- **clean** - Clean all build artifacts
- **restore** - Restore NuGet packages
- **run-web-razor** - Run the Web.Razor project (default task)

## Configuration

### Default Startup Project
The Web.Razor project is configured as the default startup project in VS Code. When you press F5, it will automatically:
1. Build the solution
2. Start the Web.Razor project
3. Open the browser at http://localhost:5113

### Project References
- Application → Domain
- Infrastructure → Domain + Application  
- Web.Razor → Application + Infrastructure

This ensures proper dependency flow following Clean Architecture principles.

## Development Notes
- The original monolithic project has been split into separate layers
- All database migrations and configurations are in the Infrastructure project
- ViewModels and Mappers are in the Web.Razor project
- Business logic is centralized in the Application project
- Domain entities are isolated in the Domain project

## Migration Status

✅ **COMPLETED:**
- ✅ All projects created and configured with Clean Architecture structure
- ✅ All namespace references updated to new project structure
- ✅ All Razor Pages migrated to Web.Razor project
- ✅ ViewModels and Mappers successfully migrated
- ✅ Connection strings configured in appsettings.json
- ✅ Project builds and runs successfully
- ✅ Web.Razor configured as default startup project in VS Code

## Application Status

**🟢 READY TO USE**: The application is fully migrated to Clean Architecture and ready for development/production use.

## Next Steps (Optional Enhancements)
1. ✨ Add comprehensive unit tests
2. 🎨 Enhance UI/UX design
3. 🔒 Add authentication and authorization
4. 📊 Add logging and monitoring
5. 🚀 Set up CI/CD pipeline
