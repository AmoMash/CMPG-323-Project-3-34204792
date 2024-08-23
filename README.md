# CMPG-323-Project-3-34204792
# TelemetryPortal_MVC

## Overview

TelemetryPortal_MVC is a web application designed to manage client and project information. This application allows users to perform CRUD operations on client and project data through a user-friendly interface.

## Features

- Manage clients and projects
- Create, Read, Update, and Delete operations
- Use of ASP.NET Core MVC and Entity Framework Core

## Prerequisites

- .NET 8.0 SDK or later
- SQL Server 2022 Express or compatible database
- Visual Studio 2022

## Project Files

- In the master branch

## Setup Instructions

1. **Clone the Repository:**

    ```bash
    git clone https://github.com/your-username/TelemetryPortal_MVC.git
    cd TelemetryPortal_MVC
    ```

2. **Configure the Database:**

    - Ensure you have SQL Server 2022 Express installed and running.
    - Update the `appsettings.json` file with your database connection string.

    ```json
    {
      "ConnectionStrings": {
        "DefaultConnection": "Your-Connection-String"
      }
    }
    ```

3. **Apply Migrations:**

    Open the Package Manager Console in Visual Studio and run:

    ```powershell
    Update-Database -Context TechtrendsContext
    ```

    Alternatively, run the following command in your terminal:

    ```bash
    dotnet ef database update --context TechtrendsContext
    ```

4. **Run the Application:**

    - Start the application using Visual Studio or by running:

    ```bash
    dotnet run
    ```

    - A window in your web browser will automatically open.

## Usage

- **Clients**: Manage client information via the Clients section.
- **Projects**: Manage project information via the Projects section.

## Reference List
- Here is the document with recources used to complete project 3 [Project3References.docx]
