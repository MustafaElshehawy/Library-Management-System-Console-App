# Library Management System

Library Management System - Business
Requirements
1. Project Overview
The Library Management System is a console-based application developed using .NET (C#) to
manage library operations efficiently. It provides functionalities for both administrators and regular
users. The system handles user authentication, book management, and borrowing processes.
2. System Users
There are two types of users in the system: Administrator – Has access to manage books,
including adding, editing, and deleting them. Regular User – Can view available books, borrow
books, and check availability details.
3. Login Process
When the application starts, it displays a welcome message and prompts the user to enter a
username and password. If the credentials match the admin account (Username: admin,
Password: 123456), the admin panel is displayed. Otherwise, the user is considered a regular
library user and is directed to the user interface.
4. Admin Features
The Administrator can: Add a new book by providing its title, author, and availability status. Edit
existing book details. Remove books from the system. View a list of all books and their statuses.
5. User Features
The Regular User can: View all books (available and unavailable). Check when an unavailable
book will be available. Select a book to borrow by entering its code. Enter the borrowing duration in
days (maximum 14 days allowed). If the entered duration exceeds 14 days, an error message is
shown, and the user must re-enter a valid duration. The borrowing cost is calculated at $1 per day.
Borrowing terms and conditions are displayed for confirmation. If the user agrees, a success
message “Borrowing completed successfully” is displayed, and the program exits. If the user
disagrees, they are redirected to restart the process.
6. Business Rules
Each borrowing transaction must be confirmed by the user. Borrowing duration cannot exceed 14
days. The borrowing cost is fixed at $1 per day. Only admins can modify the library’s book
collection.
7. Technical Requirements
Language: C# (.NET 8 Console Application) Data Structures: Lists, Dictionaries, and Arrays
Object-Oriented Design principles must be applied (Classes for Book, User, and Library)
Role-based access control for Admin and User
8. Expected Outcome
The system ensures efficient management of books, provides clear borrowing policies, and
enforces proper role-based actions, creating a smooth user experience for both admin and regular
users.
