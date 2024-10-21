<<<<<<< HEAD
<!DOCTYPE html>
<html>
<head>
</head>
<body>
    <h1>To-Do List Web Application</h1>
    <p>This project is a simple CRUD application for a To-Do List using the MVC pattern in C# .Net core.</p>
    <h2>Table of Contents</h2>
    <ul>
        <li><a href="#prerequisites">Prerequisites</a></li>
        <li><a href="#getting-started">Getting Started</a></li>
        <li><a href="#features">Features</a></li>
        <li><a href="#usage">Usage</a></li>
        <li><a href="#contributing">Contributing</a></li>
        <li><a href="#license">License</a></li>
    </ul>
    <h2 id="prerequisites">Prerequisites</h2>
    <p>Before you begin, ensure you have met the following requirements:</p>
    <ul>
        <li>Visual Studio or a compatible code editor.</li>
        <li>.NET Core SDK installed on your machine.</li>
        <li>A relational database (SQL Server, SQLite, etc.) for data storage.</li>
    </ul>
    <h2 id="getting-started">Getting Started</h2>
    <p>To get this project up and running, follow these steps:</p>
    <ol>
        <li>Clone the repository: <code>git clone &lt;repository_url&gt;</code></li>
        <li>Open the project in Visual Studio or your preferred code editor.</li>
        <li>Configure your database connection string in the <code>appsettings.json</code> file.</li>
        <li>Create the database using Entity Framework Core migrations. Run the following commands:</li>
    </ol>
    <pre>
        <code>
dotnet ef migrations add InitialCreate
dotnet ef database update
        </code>
    </pre>
    <ol start="5">
        <li>Run the application.</li>
        <li>Start using the ToDo application.</li>
    </ol>
    <h2 id="features">Features</h2>
    <ul>
        <li><strong>View ToDo List:</strong> Users can view a list of existing ToDo items.</li>
        <li><strong>Create ToDo Items:</strong> Users can create new ToDo items.</li>
        <li><strong>View Details:</strong> Users can view details of a specific ToDo item.</li>
        <li><strong>Edit ToDo Items:</strong> Users can edit existing ToDo items.</li>
        <li><strong>Delete ToDo Items:</strong> Users can delete ToDo items after confirmation.</li>
    </ul>
    <h2 id="usage">Usage</h2>
    <p>This section provides a brief overview of the functionality of the ToDo web application:</p>
    <ul>
        <li><strong>View ToDo List (Index):</strong> When you open the application, you'll see a list of existing ToDo items. You can click on an item to view its details, edit, or delete it.</li>
        <li><strong>Create New ToDo Item (Create):</strong> Click on the "Create New" button to open a form for creating a new ToDo item. Fill out the details and click "Save" to create it.</li>
        <li><strong>View Details (Details):</strong> Click on a ToDo item in the list to view its details.</li>
        <li><strong>Edit ToDo Item (Edit):</strong> Click on the "Edit" button when viewing the details of a ToDo item to make changes to it. Save your changes by clicking "Save."</li>
        <li><strong>Delete ToDo Item (Delete):</strong> Click on the "Delete" button when viewing the details of a ToDo item. You'll be asked for confirmation before deleting the item.</li>
    </ul>
    <!-- Continue with the rest of your README content -->
    <h2 id="contributing">Contributing</h2>
    <p>If you would like to contribute to this project, please follow these steps:</p>
    <ol>
        <li>Fork the repository.</li>
        <li>Create a new branch for your feature or bug fix.</li>
        <li>Make your changes and commit them.</li>
        <li>Push your changes to your fork.</li>
        <li>Create a pull request to the original repository.</li>
    </ol>
</body>
</html>
=======
To-Do List Project

    This is a simple To-Do List application built using ASP.NET Core MVC, Entity Framework Core, and SQL Server.
    The project allows users to manage their tasks efficiently by providing features to create, view,update, and delete tasks.

 Project Purpose

      The purpose of this project is to demonstrate how to build a web application using ASP.NET Core MVC and Entity Framework Core. 
      It covers the implementation of CRUD (Create, Read, Update, Delete) operations on a relational database (SQL Server), making it a 
      helpful reference for beginners learning MVC patterns and database integration.

Features

      - Create Tasks: Add new tasks to the list.
      - View Tasks: View all tasks, with the ability to filter by status (complete/incomplete).
      - Update Tasks: Modify existing tasks, including task details and completion status.
      - Delete Tasks: Remove tasks from the list.
      - Mark Tasks as Complete/Incomplete: Easily manage task status.

Prerequisites

Before running the project, ensure the following software is installed on your machine:

      - [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
      - [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (or SQL Server Express)
      - [Visual Studio 2022](https://visualstudio.microsoft.com/) (or a code editor with .NET support, e.g., Visual Studio Code)

Getting Started

 1. Clone the Repository

          First, clone the repository from GitHub to your local machine:
          
          in terminal
          git clone https://github.com/yourusername/todo-list-mvc-ef-core.git
          
          Here are the instructions for running your To-Do list project that you can copy directly:

 2. Set Up the Database

          1. Open the project in Visual Studio or your preferred IDE.
          2. Open the `appsettings.json` file and update the `ConnectionStrings` section with your SQL Server connection string:
          
          "ConnectionStrings": {
            "DefaultConnection": "Server=your_server_name;Database=ToDoDb;Trusted_Connection=True;MultipleActiveResultSets=true"
          }
          
          
          3. Open the Package Manager Console in Visual Studio (or use the .NET CLI) and run the following command
             to apply migrations and create the database:
          
          Update-Database


 4. Run the Application

          Once the database is set up, you can run the application using one of the following methods:
          
          - Visual Studio: Press `F5` or click the "Run" button.
          - Command Line: Navigate to the project folder and run the following command:
          
          dotnet run


          The application will start, and by default, it will be available at `https://localhost:5001` (or a similar port).

 5. Access the Application

          Open a web browser and navigate to the URL provided by the terminal or Visual Studio.
          You will now see the homepage where you can manage your tasks (create, view, update, delete).



 Project Structure

        - Controllers: Contains the ToDoController which handles user interactions and sends data to/from the views.
        - Models: The ToDo model represents a task in the to-do list, including properties like Title, Description, DueDate, and IsCompleted.
        - Views: Razor pages used to render the HTML for displaying and interacting with tasks.
        - Data: This includes the ApplicationDbContext class which manages communication with the MSSQL Server database.
        - Migrations: Contains the database migration files generated by Entity Framework Core.

Database Schema

    The application uses a simple schema to store tasks:
    
    - ToDo Table:
      - Id: Primary Key
      - Title: Task title
      - Description: Task details
      - DueDate: The due date of the task
      - IsCompleted: A boolean indicating whether the task is completed

 Technologies Used

    - ASP.NET Core MVC: For building the web application.
    - Entity Framework Core: As the ORM for database operations.
    - MSSQL Server: The relational database to store tasks.
    - Razor Pages: For the views and rendering the UI.


 Contributing

    If you'd like to contribute to this project, feel free to fork the repository,
     make your changes, and submit a pull request. Contributions are welcome!



>>>>>>> cfc29441e13a6afbf225842cff9bddc68064dc29
