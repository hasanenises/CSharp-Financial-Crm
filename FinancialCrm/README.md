# Financial CRM

A desktop personal finance and financial tracking application built with **C#**, **Windows Forms**, **Entity Framework**, and **SQL Server**.

## Key Features

- **Dashboard:** Displays an overview of financial data and key summaries.
- **Category:** Full CRUD operations for managing spending categories.
- **Expenses:** Track expenses with amounts, dates, and category relations.
- **Bank Processes:** Record transactions (such as deposits, withdrawals, and transfers) and automatically update bank balances (`BankBalance`).
- **Banks & Bills:** Manage bank accounts and bill records.
- **Settings:** Manage user accounts (`Users`).
- **Centralized Navigation (`FormLink`):** Static navigation helper for switching between forms cleanly and handling logout confirmation.

## Tech Stack

- **C#** & **Windows Forms (.NET Framework)**
- **Entity Framework**
- **Microsoft SQL Server**
- **Visual Studio**

## Project Structure

- `FormLink.cs` – Centralized form navigation and logout handling
- `FrmDashboard.cs` – Summary and overview screen
- `FrmCategory.cs` – Category management
- `FrmExpenses.cs` – Expense tracking
- `FrmBankProcesses.cs` – Bank transactions and balance updates
- `FrmBanks.cs` – Bank account management
- `FrmBills.cs` – Bill management
- `FrmSettings.cs` – User management