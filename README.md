# Employee Management API

## Overview
This project is an ASP.NET Core 6.0-based backend API for managing employee data. It provides functionalities to list, filter, create, update, and delete employee records, along with associated departments and companies.

## Features
- **Get All Employees**: Retrieve a list of all employees along with their department and company information.
- **Filter Employees**: Filter employees based on criteria such as name, surname, department name, and company name with pagination support.
- **Get Employee Details**: View detailed information for a specific employee.
- **Create Employee**: Add new employee records to the database.
- **Update Employee**: Modify existing employee information.
- **Delete Employee**: Remove employee records from the database.
- **CRUD Operations for Department and Company**: Includes operations for managing department and company data.

 ## Technologies Used
- **ASP.NET Core 6.0**: Backend framework.
- **Entity Framework Core**: ORM for database interactions using Code First approach.
- **Microsoft SQL Server**: Database system.
- **Onion Architecture**: Architectural pattern for organizing code.
- **Repository Design Pattern**: Pattern for data access layer abstraction.
- **Lazy Loading**: For deferred loading of related data.
- **Global Exception Handling**: Centralized error handling mechanism.
- **Fluent Validation**: For model validation.
- **AutoMapper**: For mapping between entities and DTOs.
- **Swagger**: For API documentation.

 ## Getting Started
 ### Prerequisites
- [.NET SDK 6.0](https://dotnet.microsoft.com/download/dotnet/6.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)

  ### Setting Up the Project

1. **Clone the Repository:**
   
   ```bash
   git clone https://github.com/fidanbb/EmployeeManagement.git
   
2. **Set up the database:**
   
   Open the appsettings.Development.json file and configure the connection string:
   ```json
   "ConnectionStrings": {
   "DefaultConnection": "Server=YOUR_SERVER_NAME;initial Catalog=EmployeeManagementDb;integrated Security=true; TrustServerCertificate=true;"
   },
   
3. **Restore Dependencies:**
   
   Ensure all required packages are installed:
   
   ```bash
      dotnet restore
   
4. **Change Directory:**
   
   Navigate to the API Project directory and run the below command:
   ```bash
   cd Presentation/EmployeeManagement.Api
     
5. **Apply Migrations:**
   
   Run the following command to apply migrations and create the database:
   
   ```bash
      dotnet ef database update
   
6. **Build the project:**
   
   ```bash
     dotnet build
   
7. **Run the project:**
   
   ```bash
     dotnet run

## API Documentation
After running the application, you can access the Swagger UI at:

- URL: https://localhost:7150/swagger/index.html





