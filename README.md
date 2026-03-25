# Employee Management System (Advanced)

This project is a desktop application built using **.NET WinForms**.  
It manages employees using a layered architecture and stores data in a **SQLite database**.

The purpose of this project is to practice building a structured .NET application using concepts that are commonly used in real-world software development such as separation of concerns, repository pattern, and service layer architecture.

## Features

- Add employee
- Update employee
- Delete employee
- View employee list
- Department selection
- Salary validation
- SQLite database persistence
- Layered architecture (UI, Services, Data)

## Technologies Used

- .NET 10
- Windows Forms
- SQLite
- Microsoft.Data.Sqlite
- C#

## Project Architecture

The project follows a simple layered architecture.


EmployeeManagementSystem_Advanced
│
├── Models
│ └── Employee.cs
│
├── Data
│ └── EmployeeRepository.cs
│
├── Services
│ └── EmployeeService.cs
│
├── UI
│ ├── Form1.cs
│ └── Form1.Designer.cs
│
└── Program.cs


### Models

Contains the data models used by the application.

Example:


Employee.cs


Represents the employee entity with properties like:

- Id
- Name
- Salary
- Department

### Data Layer

Handles all database operations.


EmployeeRepository.cs


Responsibilities:

- Create database table
- Insert employee
- Update employee
- Delete employee
- Retrieve employees

### Service Layer

Contains business logic between UI and database.


EmployeeService.cs


The service layer communicates with the repository and is used by the UI.

### UI Layer

The Windows Forms interface.


Form1.cs


Handles:

- User input
- Button click events
- DataGridView display
- Interaction with the service layer

## Database

The application uses a local SQLite database file.


employees.db


The database is created automatically when the application runs for the first time.

Table structure:

Employees

Id
Name
Salary
Department


## How to Run

1. Clone the repository

2. Open the project in **Visual Studio**

3. Restore NuGet packages

4. Run the project

The application will automatically create the SQLite database.

## Learning Goals

This project was built to practice:

- Windows Forms development
- CRUD operations
- Repository pattern
- Layered architecture
- SQLite database integration
- Basic validation in desktop applications

## Future Improvements

Possible improvements for this project:

- Search functionality
- Employee filtering by department
- Better UI layout
- Async database operations
- Logging
- Unit tests

- ## Author
Aryan Raj
