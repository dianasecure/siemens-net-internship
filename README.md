#.NET Siemens internship application problem

📚 Library Management System
This is a simple library management system with two main modes:

🔐 User Mode:
Users can log in, search for books, borrow, and return them. Each user's activity is stored individually.

🛠️ Admin Mode:
Admins can add, update, remove, and delete books from the library's inventory.

🚀 How to Run the Project
1. Clone the Repository: open the project in your preferred IDE (such as Visual Studio).

2. Set Up the Database: create a PostgreSQL database named librarydb.
run the provided SQL script to initialize the database schema and tables.

3. Configure Database Credentials: navigate to the LibraryContext.cs file 
replace the default Username and Password with your PostgreSQL credentials.

4. Run the Application: build and run the project from your IDE. You can now log in as a user or access admin features.

🔐 New Feature: User Login
Users can now log in using their credentials.

All borrowed/returned book data is saved per user.
