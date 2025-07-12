# Personal Web Page Management System - Clean Architecture

## Περιγραφή

Αυτό το project έχει αναδιοργανωθεί ακολουθώντας τις αρχές της **Clean Architecture** για καλύτερη οργάνωση, maintainability και testability.

## Δομή Clean Architecture

### 1. **Core Layer**
Το κεντρικό layer που περιέχει την επιχειρηματική λογική και δεν εξαρτάται από εξωτερικά frameworks.

#### Domain (Core/Domain/)
- **Entities/**: Οι κύριες επιχειρηματικές οντότητες
  - `Resume.cs`
  - `ResumeProfile.cs`
  - `ResumeExperience.cs`
  - `ResumeEducation.cs`
  - `ResumeSkill.cs`

- **Interfaces/**: Contracts για repositories και services
  - `IResumeRepository.cs`
  - `IUnitOfWork.cs`

#### Application (Core/Application/)
- **DTOs/**: Data Transfer Objects για μεταφορά δεδομένων
- **Services/**: Application services με business logic
  - `IResumeService.cs`
  - `ResumeService.cs`
- **UseCases/**: Specific use cases (μελλοντική επέκταση)

### 2. **Infrastructure Layer**
Υλοποιήσεις των interfaces του Domain layer και εξωτερικές εξαρτήσεις.

#### Persistence (Infrastructure/Persistence/)
- `PersonalWebPageContext.cs`: Entity Framework DbContext

#### Repositories (Infrastructure/Repositories/)
- `ResumeRepository.cs`: Υλοποίηση του IResumeRepository
- `UnitOfWork.cs`: Υλοποίηση του Unit of Work pattern

#### Configuration
- `DependencyInjection.cs`: Dependency Injection configuration

### 3. **Presentation Layer**
Το UI layer που περιέχει Razor Pages, ViewModels και Controllers.

#### ViewModels (Presentation/ViewModels/)
- ViewModels με validation attributes για το UI
- Mapping μεταξύ DTOs και ViewModels

#### Mappers (Presentation/Mappers/)
- `ResumeMapper.cs`: Mapping μεταξύ DTOs και ViewModels

#### Pages (Presentation/Pages/)
- Ενημερωμένα Razor Pages που χρησιμοποιούν το Clean Architecture

## Πλεονεκτήματα της νέας δομής

### 1. **Separation of Concerns**
- Κάθε layer έχει συγκεκριμένες ευθύνες
- Καλύτερη οργάνωση κώδικα
- Ευκολότερη maintenance

### 2. **Dependency Inversion**
- Το Core layer δεν εξαρτάται από external frameworks
- Τα Infrastructure και Presentation layers εξαρτώνται από το Core

### 3. **Testability**
- Εύκολο unit testing χάρη στη χρήση interfaces
- Mocking των dependencies

### 4. **Scalability**
- Εύκολη προσθήκη νέων features
- Καλύτερη δομή για μεγαλύτερα projects

## Χρήση

### Εκκίνηση της εφαρμογής
```bash
dotnet run
```

### Database Setup
Η εφαρμογή χρησιμοποιεί:
- **SQLite** για Development environment
- **SQL Server** για Production environment

### Dependency Injection
Όλες οι εξαρτήσεις έχουν ρυθμιστεί στο `Program.cs`:
```csharp
// Add Infrastructure and Application services
builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddApplication();
```

## Μελλοντικές Βελτιώσεις

1. **AutoMapper**: Για πιο εύκολο mapping μεταξύ objects
2. **MediatR**: Για CQRS pattern implementation
3. **FluentValidation**: Για πιο προηγμένο validation
4. **Unit Tests**: Για καλύτερη code coverage
5. **API Controllers**: Για REST API endpoints

## Σημειώσεις

- Τα παλιά αρχεία στους φακέλους `Models/`, `ViewModels/`, `Data/` μπορούν να διαγραφούν μετά την επιβεβαίωση ότι η νέα δομή λειτουργεί σωστά
- Τα namespace έχουν ενημερωθεί για να αντικατοπτρίζουν τη νέα δομή
- Όλα τα αρχεία έχουν proper validation attributes και error handling
