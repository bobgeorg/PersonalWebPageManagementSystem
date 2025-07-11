# PersonalWebPageManagementSystem

A modern ASP.NET Core 8.0 web application that offers an easy way to create and manage a personal web page and resume.

![Homepage](https://github.com/user-attachments/assets/fcadd3af-c204-46eb-90b0-5229456ba0f1)

## Features

- **Personal Resume Management**: Create and edit your professional resume with personal details, employment history, education, and skills
- **Responsive Design**: Clean, modern UI using Bootstrap that works on all devices
- **Data Persistence**: SQLite database for development, SQL Server support for production
- **Rich Form Validation**: Comprehensive client and server-side validation
- **Dynamic Content**: Add multiple employment entries, education records, and skills

![Edit Resume](https://github.com/user-attachments/assets/06dfb293-4dff-4419-960f-b2419756eb46)

## Technology Stack

- **Backend**: ASP.NET Core 8.0 with Razor Pages
- **Database**: Entity Framework Core with SQLite (dev) / SQL Server (prod)
- **Frontend**: Bootstrap 5, jQuery, DataTables
- **Styling**: CSS3 with responsive design

## Getting Started

### Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/)

### Installation

1. **Clone the repository**
   ```bash
   git clone https://github.com/bobgeorg/PersonalWebPageManagementSystem.git
   cd PersonalWebPageManagementSystem
   ```

2. **Restore dependencies**
   ```bash
   dotnet restore
   ```

3. **Build the project**
   ```bash
   dotnet build
   ```

4. **Run the application**
   ```bash
   dotnet run
   ```

5. **Open your browser**
   - Navigate to `http://localhost:5000` (or the URL shown in the console)

### Development Setup

The application automatically creates a SQLite database (`WPMS.db`) on first run in development mode. No additional database setup is required for development.

## Configuration

### Database Connections

The application supports two database configurations:

- **Development**: SQLite database (`WPMS.db`) - automatically created
- **Production**: SQL Server - configure connection string in `appsettings.json`

### Connection Strings

Update `appsettings.json` for your environment:

```json
{
  "ConnectionStrings": {
    "WPMSContextSQLite": "Data Source=WPMS.db",
    "WPMSContextSQLServer": "Server=(localdb)\\mssqllocaldb;Database=WPMS;Trusted_Connection=True;MultipleActiveResultSets=true"
  }
}
```

## Project Structure

```
PersonalWebPageManagementSystem/
├── Data/                          # Entity Framework DbContext
├── Models/                        # Domain models (Resume, Education, etc.)
├── ViewModels/                    # ViewModels for forms and validation
├── Pages/                         # Razor Pages
│   ├── Index.cshtml              # Main resume display page
│   ├── BuildResume.cshtml        # Resume editing form
│   └── Shared/                   # Shared layouts and partials
├── wwwroot/                      # Static files
│   ├── css/                      # Stylesheets
│   ├── js/                       # JavaScript files
│   ├── lib/                      # Client libraries (Bootstrap, jQuery)
│   └── Images/                   # Image assets
├── appsettings.json              # Configuration
└── Program.cs                    # Application startup
```

## Usage

1. **View Resume**: Visit the homepage to see the current resume
2. **Edit Resume**: Click "Edit Resume" to modify personal details, add employment history, education, and skills
3. **Add Employment**: Use the dynamic form to add multiple work experiences
4. **Upload Photo**: Upload a profile picture through the image upload feature

## Contributing

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/amazing-feature`)
3. Commit your changes (`git commit -m 'Add some amazing feature'`)
4. Push to the branch (`git push origin feature/amazing-feature`)
5. Open a Pull Request

## Recent Improvements

- ✅ Fixed CSS selector syntax error for better form styling
- ✅ Increased job title character limit from 5 to 100 characters
- ✅ Added SQL Server connection string configuration
- ✅ Improved error handling for database initialization
- ✅ Enhanced documentation and setup instructions

## License

This project is open source and available under the [MIT License](LICENSE).
