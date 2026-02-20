# Stock Management System

A comprehensive Windows Forms application for managing stocks, products, customers, and employees. This system allows salesmen to purchase products from a marketplace into the inventory and consultants to manage customer orders.

## Features

- **Role-Based Access**: Specialized interfaces for Salesmen, Consultants, and Customers.
- **Inventory Management**: Track product availability and real-time stock levels.
- **Marketplace Integration**: Salesmen can purchase products from the marketplace to replenish warehouse stock with instant UI updates.
- **Customer Portal**: Customers can browse available stock and place purchase requests with automatic registration and stock validation.
- **Order Processing**: Consultants can review pending "Buy" requests from customers and confirm them, finalizing the sale.
- **Transaction History**: Detailed logs of all stock movements (Buy/Sell/Confirmed) with descriptive transaction labels.
- **Robust UI**: Enhanced feedback with Success/Error messages and automatic list refreshing.

## Technologies Used

- **Framework**: .NET 9.0 (Windows Forms)
- **Language**: C# 13.0
- **ORM**: Entity Framework Core
- **Database**: Microsoft SQL Server (LocalDB)
- **Design Patterns**: Repository Pattern and Unit of Work

## Database Schema

The system uses the following entities:

- **Staff**: System users (Salesmen or Consultants) with specific IDs and passwords.
- **Product**: Master list of products available in the marketplace.
- **Stock**: Current inventory levels for each product in the warehouse.
- **Category**: Classification for products.
- **Customer**: Customer profiles and contact information.
- **StockMovement**: Records of all inbound (Buy) and outbound (Sell) transactions.

## Getting Started

### Prerequisites

- [Visual Studio 2022](https://visualstudio.microsoft.com/) or [JetBrains Rider](https://www.jetbrains.com/rider/)
- [.NET 9.0 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- [SQL Server Express LocalDB](https://learn.microsoft.com/en-us/sql/database-engine/configure-windows/sql-server-express-localdb)

### Installation

1. **Clone the repository**:
   ```bash
   git clone https://github.com/yourusername/StockManagementSystem.git
   cd StockManagementSystem
   ```

2. **Configure the Database**:
   The application is configured to use LocalDB. The connection string is located in `Stocks\Classes\DatabaseHolder\StockDatabase.cs`:
   ```csharp
   optionsBuilder.UseSqlServer(@"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=StockDB;Integrated Security=SSPI;");
   ```
   Ensure your LocalDB instance is running. Entity Framework will create the database automatically on the first run if configured properly, or you can run migrations:
   ```bash
   dotnet ef database update
   ```

3. **Build and Run**:
   Open `Stocks.sln` in your IDE and run the project.

## Usage Guide

### Roles

1. **Salesman**:
   - Access via the login screen.
   - Responsible for purchasing products from the **Marketplace** to increase the company's **Stock**.

2. **Customer**:
   - Access via the "Customer Buying Zone".
   - Can browse the current **Stock** and place orders (this creates a "Buy" movement request).

3. **Consultant**:
   - Access via the login screen.
   - Navigates to the **Consultant Confirm Zone** to approve customer orders.
   - Confirming an order creates a "Sell" movement record.

## Project Structure

- `Stocks/Classes/TableSets`: Entity models (POCOs).
- `Stocks/Classes/DatabaseHolder`: DBContext and service configurations.
- `Stocks/Classes`: Implementation of Repository and Unit of Work patterns.
- `Stocks/Forms`: UI components (Windows Forms).
- `Stocks/Program.cs`: Application entry point.

## License

This project is licensed under the MIT License - see the LICENSE file for details.
