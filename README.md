# Kensington Realty Real Estate Marketing Web App

## Overview

This project is an engineered web application developed for Kensington Realty to provide an advanced marketing platform for real estate properties. It features RESTful APIs, a SQL database backend, and a dynamic user interface for a seamless user experience. The application is hosted on AWS.

**Features:**

- Advanced property listings via RESTful APIs.
- User contact form with backend support for storing submissions.
- Dynamic UI for showcasing property listings.
- Full stack architecture with efficient data storage and retrieval in SQL.

## Technologies Used

- **Front-end:** Blazor, HTML/CSS, JavaScript
- **Back-end:** C# (.NET Core), RESTful APIs
- **Database:** SQL
- **Hosting:** AWS

## Getting Started

### Prerequisites

- .NET SDK
- SQL Server
- AWS CLI (if deploying to AWS)

### Local Development Setup

1. **Clone the Repository**

    ```bash
    git clone https://github.com/yourusername/kensington-realty-webapp.git
    ```

2. **Navigate to the Project Directory**

    ```bash
    cd kensington-realty-webapp
    ```

3. **Restore .NET Packages**

    ```bash
    dotnet restore
    ```

4. **Run Database Migrations**

    Replace `YourDatabaseConnection` with your actual SQL connection string.

    ```bash
    dotnet ef database update --connection "YourDatabaseConnection"
    ```

5. **Run the Project**

    ```bash
    dotnet run
    ```

### Deploying to AWS

For specific steps on how to deploy a Blazor app on AWS, please refer to the official AWS deployment documentation.

## API Documentation

The application features RESTful APIs to support advanced querying capabilities for property listings and user contact submissions. Further documentation is in progress.

## Contributing

Interested in making a contribution? Please fork the repository and submit a pull request.

## License

This project is under the MIT License - see the [LICENSE.md](LICENSE.md) file for details.
