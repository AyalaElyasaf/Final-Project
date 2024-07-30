# Hotel Network Server

Welcome to the Hotel Network Server repository! This project serves as the backend for a global hotel network website, providing APIs and database management functionalities.

## Table of Contents

- [About the Project](#about-the-project)
- [Technologies Used](#technologies-used)
- [Installation](#installation)
- [Database Setup](#database-setup)
- [API Endpoints](#api-endpoints)
- [Usage](#usage)
- [Contributing](#contributing)
- [License](#license)
- [Contact](#contact)

## About the Project

The Hotel Network Server is built with C# and SQL, providing robust and scalable backend services for managing hotel information, reservations, and user authentication.

## Technologies Used

- **C#**: Core language for backend development.
- **.NET Framework**: Framework for building the server-side application.
- **SQL**: Database management and operations.
- **Entity Framework**: Data access technology for interacting with the database.

## Installation

Follow these steps to set up and run the server on your local machine:

1. **Clone the repository**:
    ```sh
    git clone https://github.com/yourusername/hotel-network-server.git
    ```

2. **Navigate to the project directory**:
    ```sh
    cd hotel-network-server
    ```

3. **Open the project in Visual Studio**:
    - Open Visual Studio.
    - Click on "Open a project or solution".
    - Navigate to the project directory and select the solution file (.sln).

4. **Restore NuGet packages**:
    - In Visual Studio, go to `Tools > NuGet Package Manager > Manage NuGet Packages for Solution`.
    - Click on "Restore" to install the required packages.

5. **Build the project**:
    - In Visual Studio, go to `Build > Build Solution`.

6. **Run the project**:
    - Press `F5` or click on the `Start` button to run the server.

## Database Setup

1. **Create the database**:
    - Open SQL Server Management Studio (SSMS).
    - Execute the SQL scripts in the `scripts` folder to create the database and tables.

2. **Configure the connection string**:
    - Update the connection string in `appsettings.json` with your database details.

## API Endpoints

Here are some key API endpoints provided by the server:

- **GET /api/hotel/all**: Retrieve a list of all hotels.
- **GET /api/guest**: Retrieve a list of all guest.
- **POST /api/guest**: Add a new guest.
- **POST /api/reservation**: Add a new reservation.
- **GET /api/rooms/{hotelId}**: get all rooms to specipic hotel by ID.

## Usage

1. **Start the server**:
    ```sh
    dotnet run
    ```

2. **Test the endpoints** using tools like Postman or Swagger.

![API Demo](link-to-api-demo.gif)

## Contributing

Contributions are welcome! If you'd like to contribute to the development of this project, please follow these steps:

1. Fork the repository.
2. Create a new branch.
    ```sh
    git checkout -b feature-branch
    ```
3. Make your changes.
4. Commit your changes.
    ```sh
    git commit -m "Add new feature"
    ```
5. Push to the branch.
    ```sh
    git push origin feature-branch
    ```
6. Open a pull request.

## Contact

Feel free to reach out with any questions or feedback!

- **Email**: ayala76745@gmail.com
- **GitHub**: [AyalaElyasaf](https://github.com/AyalaElyasaf)


---

Explore the power of C# and SQL in building scalable and robust backend systems with the Hotel Network Server!
