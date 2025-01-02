# Library App

## Description
Library App is a console-based library management system implemented in C# using .NET 8.0. It allows users to manage patrons, books, and loans through a simple console interface. The application uses JSON files for data storage and supports operations such as searching for patrons, viewing patron details, managing loans, and renewing memberships.

## Project Structure
- `AccelerateDevGitHubCopilot.sln`
- `README.md`
- `src`
  - `Library.ApplicationCore/`
    - `Entities/`
      - `src/Library.ApplicationCore/Entities/Author.cs`
      - `src/Library.ApplicationCore/Entities/Book.cs`
      - `src/Library.ApplicationCore/Entities/BookItem.cs`
      - `src/Library.ApplicationCore/Entities/Loan.cs`
      - `src/Library.ApplicationCore/Entities/Patron.cs`
    - `Enums/`
      - `src/Library.ApplicationCore/Enums/EnumHelper.cs`
      - `src/Library.ApplicationCore/Enums/LoanExtensionStatus.cs`
      - `src/Library.ApplicationCore/Enums/LoanReturnStatus.cs`
      - `src/Library.ApplicationCore/Enums/MembershipRenewalStatus.cs`
    - `Interfaces/`
      - `src/Library.ApplicationCore/Interfaces/ILoanRepository.cs`
      - `src/Library.ApplicationCore/Interfaces/ILoanService.cs`
      - `src/Library.ApplicationCore/Interfaces/IPatronRepository.cs`
      - `src/Library.ApplicationCore/Interfaces/IPatronService.cs`
    - `Services/`
      - `src/Library.ApplicationCore/Services/LoanService.cs`
      - `src/Library.ApplicationCore/Services/PatronService.cs`
    - `src/Library.ApplicationCore/Library.ApplicationCore.csproj`
  - `Library.Console/`
    - `src/Library.Console/appSettings.json`
    - `src/Library.Console/CommonActions.cs`
    - `src/Library.Console/ConsoleApp.cs`
    - `src/Library.Console/ConsoleState.cs`
    - `Json/`
      - `src/Library.Console/Json/Authors.json`
      - `src/Library.Console/Json/Books.json`
      - `src/Library.Console/Json/BookItems.json`
      - `src/Library.Console/Json/Loans.json`
      - `src/Library.Console/Json/Patrons.json`
    - `src/Library.Console/Library.Console.csproj`
    - `src/Library.Console/Program.cs`
  - `Library.Infrastructure/`
    - `Data/`
      - `src/Library.Infrastructure/Data/JsonData.cs`
      - `src/Library.Infrastructure/Data/JsonLoanRepository.cs`
      - `src/Library.Infrastructure/Data/JsonPatronRepository.cs`
    - `src/Library.Infrastructure/Library.Infrastructure.csproj`
- `tests`
  - `UnitTests/`
    - `ApplicationCore/`
      - `LoanService/`
        - `tests/UnitTests/ApplicationCore/LoanService/ExtendLoan.cs`
        - `tests/UnitTests/ApplicationCore/LoanService/ReturnLoan.cs`
      - `PatronService/`
        - `tests/UnitTests/ApplicationCore/PatronService/RenewMembership.cs`
    - `tests/UnitTests/LoanFactory.cs`
    - `tests/UnitTests/PatronFactory.cs`
    - `tests/UnitTests/UnitTests.csproj`

## Key Classes and Interfaces
### Library.ApplicationCore
- **Entities**
  - `Author`: Represents an author in the library.
  - `Book`: Represents a book in the library.
  - `BookItem`: Represents a physical copy of a book.
  - `Loan`: Represents a loan of a book item to a patron.
  - `Patron`: Represents a library patron.
- **Enums**
  - `EnumHelper`: Provides helper methods for enums.
  - `LoanExtensionStatus`: Represents the status of a loan extension.
  - `LoanReturnStatus`: Represents the status of a loan return.
  - `MembershipRenewalStatus`: Represents the status of a membership renewal.
- **Interfaces**
  - `ILoanRepository`: Interface for loan repository operations.
  - `ILoanService`: Interface for loan service operations.
  - `IPatronRepository`: Interface for patron repository operations.
  - `IPatronService`: Interface for patron service operations.
- **Services**
  - `LoanService`: Implements loan-related business logic.
  - `PatronService`: Implements patron-related business logic.

### Library.Console
- `CommonActions`: Defines common actions for the console application.
- `ConsoleApp`: Manages the console-based user interface.
- `ConsoleState`: Represents the different states of the console application.
- `Program`: Configures and starts the console application.

### Library.Infrastructure
- **Data**
  - `JsonData`: Manages loading and saving data from/to JSON files.
  - `JsonLoanRepository`: Implements loan repository operations using JSON data.
  - `JsonPatronRepository`: Implements patron repository operations using JSON data.

## Usage
1. Clone the repository:
   ```sh
   git clone https://github.com/yourusername/library-app.git
   cd library-app
2. Build the solution:
   ```sh
   dotnet build
3. Run the console application:
   ```sh
    dotnet run --project src/Library.Console/Library.Console.csproj
4. Follow the on-screen instructions to interact with the library management system.

## License
This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
```