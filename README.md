# Code Generating Tool V1

## Description
The **Code Generator** was created to streamline the process of building Windows Forms applications. It automates the generation of SQL queries and CRUD functions with just a click. Additionally, the tool can generate classes for the DataAccess Layer and Business Layer based on a 3-tier architecture, making it easier to maintain scalable and organized applications. 

This project is built using **Windows Forms**, **.NET Framework**, and **Microsoft SQL Server**.

## Features
- **Automatic SQL Query Generation**: Generate SQL queries (e.g., `INSERT INTO`, `UPDATE`, `DELETE`) with a few clicks.
- **CRUD Function Generation**: Generate full CRUD operations for database tables.
- **DataAccess and Business Layer Classes**: Generate classes based on a 3-tier architecture.
  
## Getting Started

### Prerequisites
- **.NET Framework** (for the Windows Forms application)
- **Microsoft SQL Server** (for the database)
  
### Installation
1. Clone the repository: `git clone https://github.com/Toufik-Sam/Code-Generator-V1.git`
2. Open the project in Visual Studio.
3. Configure the database connection by editing the `ConnectionString` in the **DataAccess Layer** under `clsDataAccessSettings`.

## How to Use
1. Upon launching the tool, your created databases will be loaded into the **Database** comboBox.
2. Select a database from the **Database** comboBox.
3. The tables of the selected database will be loaded into the **Table Name** comboBox.
4. To generate code, click **Generator** in the menu, then select the type of code you wish to generate (e.g., SQL Query → `INSERT INTO`).

## Technologies Used
- **Windows Forms .NET Framework**
- **Microsoft SQL Server** for database management

## Contact
[toufik.sam2022@gmail.com] - [www.linkedin.com/in/toufik-sam-bouafia-455773337]

![image alt](https://github.com/Toufik-Sam/Code-Generator-V1/blob/73ede41a64d816b0797c9b2a8e541e167c08fc67/screenshot.PNG)

