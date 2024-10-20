To-Do List Project

    This is a simple To-Do List application built using ASP.NET Core MVC, Entity Framework Core, and SQL Server. The project allows users to manage their tasks efficiently by providing features to create, view,       update, and delete tasks.

 Project Purpose

      The purpose of this project is to demonstrate how to build a web application using ASP.NET Core MVC and Entity Framework Core. It covers the implementation of CRUD (Create, Read, Update, Delete) operations       on a relational database (SQL Server), making it a helpful reference for beginners learning MVC patterns and database integration.

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
          
          
          3. Open the Package Manager Console in Visual Studio (or use the .NET CLI) and run the following command to apply migrations and create the database:
          
          Update-Database


 3. Run the Application

          Once the database is set up, you can run the application using one of the following methods:
          
          - Visual Studio: Press `F5` or click the "Run" button.
          - Command Line: Navigate to the project folder and run the following command:
          
          dotnet run


          The application will start, and by default, it will be available at `https://localhost:5001` (or a similar port).

 4. Access the Application

          Open a web browser and navigate to the URL provided by the terminal or Visual Studio. You will now see the homepage where you can manage your tasks (create, view, update, delete).


