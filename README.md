# dts-developer-technical-test

This project is a coding task for the Junior Software Developer – Cross Cutting application.

## Table of Contents
- [TechStack](#TechStack)
- [Configuration](#Configuration)
- [Usage](#usage)



## TechStack

**Client** 

- ReactJS
- Bootstrap
- node 22.13.1

**Server** 

- ASP.NET Core Web Api
- .NET Core 8.0
- Entity Framework Core
- Microsoft SQL Server

**Testing**

- xUnit
- FakeItEasy
- FluentAssertions

## Configuration

please modify the connection string inside the path/to/appsettings.json file please modify the connection string based on your local SQL instance

"ConnectionStrings": {
  "DefaultConnection": "Server={(localdb)\\db instance};Database=dts;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;"

## Usage

To run project locally:

```Terminal of choice
cd dts-developer-technical-test/dts-challenge/dts-challenge.Server
dotnet run
```

To run the test:
```Terminal of choice
cd dts-developer-technical-test/dts-challenge/dts-challenge-test
dotnet test
```
##UI

### Task list page
![Image](https://github.com/user-attachments/assets/6a7196bc-4d57-46d6-afeb-bafdbd30bb56)

### Add new task page
![Image](https://github.com/user-attachments/assets/30825759-9fa8-4ef3-8577-b0ffd6a68c43)

### Details view page
![Image](https://github.com/user-attachments/assets/107a1e3f-f4f0-4c21-9562-5b2d26f7fbbf)

### Edit page
![Image](https://github.com/user-attachments/assets/18b56519-25f9-4b5e-a92c-2f449cc70a5c)

### Delete confirmation
![Image](https://github.com/user-attachments/assets/23f26439-0d86-4ac1-897b-c2b6c8ce0394)
