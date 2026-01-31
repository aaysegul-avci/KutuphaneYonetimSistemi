# Library Management System (C# WinForms)

A **Library Management System** developed with **C# Windows Forms** and **SQL Server**, designed using **State** and **Strategy Design Patterns**.  
The system supports **students**, **staff**, and **admin** roles with full book, borrowing, and reporting functionality.

---

## Features

### User Roles
- **Student**
  - Browse and search books
  - Request to borrow books
  - Track borrowing status
  - Return delivered books
  - View borrowing history

- **Staff**
  - Approve borrow requests
  - Deliver approved books to students
  - View daily borrow/return reports

- **Admin**
  - Add, update, and delete books
  - View advanced reports
  - Monitor borrowing statistics (daily / weekly / monthly)
  - View most borrowed books

---

## Design Patterns Used

### State Pattern
Used to manage the **borrowing lifecycle**:
- `Pending`
- `Approved`
- `Delivered`
- `Returned`

Ensures controlled and valid state transitions.

### Strategy Pattern
Used for **book searching and filtering**:
- By category
- By author
- By publish year

Allows dynamic search behavior based on user selection.

---

## Technologies

- C# (.NET WinForms)
- SQL Server
- Microsoft.Data.SqlClient
- SHA-256 (password hashing)

---

## Database Structure

The project uses **SQL Server**.  
You must create the database and tables manually before running the project.

### Database Name

LibraryDatabase

### 📄 Users Table

```sql
CREATE TABLE Users (
    Id INT IDENTITY PRIMARY KEY,
    FullName NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100) NOT NULL UNIQUE,
    PasswordHash NVARCHAR(256) NOT NULL,
    SchoolNumber NVARCHAR(50),
    Phone NVARCHAR(20),
    Role NVARCHAR(20) NOT NULL,
    CreatedAt DATETIME DEFAULT GETDATE()
);

CREATE TABLE Books (
    Id INT IDENTITY PRIMARY KEY,
    Title NVARCHAR(150) NOT NULL,
    Author NVARCHAR(100) NOT NULL,
    PublishYear INT NOT NULL,
    Category NVARCHAR(50),
    Summary NVARCHAR(MAX),
    Shelf NVARCHAR(20),
    Stock INT NOT NULL
);

CREATE TABLE Borrows (
    Id INT IDENTITY PRIMARY KEY,
    UserId INT NOT NULL,
    BookId INT NOT NULL,
    State NVARCHAR(20) NOT NULL,
    RequestDate DATETIME DEFAULT GETDATE(),
    ApprovalDate DATETIME NULL,
    ReturnDate DATETIME NULL,

    CONSTRAINT FK_Borrows_Users FOREIGN KEY (UserId) REFERENCES Users(Id),
    CONSTRAINT FK_Borrows_Books FOREIGN KEY (BookId) REFERENCES Books(Id)
);
```

## Security

-Passwords are stored using SHA-256 hashing
-Password input fields are masked
-Role-based authorization prevents unauthorized access

## Reporting
### Staff Reports

-Daily approved borrows
-Daily returns
-Late deliveries

### Admin Reports

-Daily / Weekly / Monthly borrow counts
-Most borrowed books
-Full borrow history

---

## How to Run

1- Clone the repository

2- Create the database using the SQL scripts above

3- Update your connection string in:
        SessionManager.ConnectionString

4- Run the project using Visual Studio

