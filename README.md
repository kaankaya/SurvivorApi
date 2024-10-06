# SurvivorApi

SurvivorApi is a Web API application developed using ASP.NET Core 8. This application manages a relationship between contestants (competitors) and categories and provides CRUD (Create, Read, Update, Delete) operations on these relationships.

## Table of Contents
- [Features](#features)
- [Technologies Used](#technologies-used)
- [Setup](#setup)
- [API Usage](#api-usage)


## Features
- One-to-many relationship between categories and contestants.
- CRUD operations for categories and competitors.
- Listing competitors by their category.
- API documentation and testing with Swagger/OpenAPI.

## Technologies Used
- **.NET Core 8**
- **ASP.NET Core Web API**
- **Entity Framework Core** - For database operations
- **Swagger** - API documentation and testing
- **Postman** - API testing

## Setup
To get a local copy up and running, follow these steps:

1. **Clone the Repository:**
   ```bash
   git clone https://github.com/kaankaya/SurvivorApi.git
   ```
2. **Navigate to the Project Directory:**
  ```bash
  cd SurvivorApi
 ```
3. **Install Dependencies:**
   Open the project in Visual Studio or use the command line to restore the necessary NuGet packages.
  ```bash
  dotnet restore
 ```
4. **Database Setup:**
   Configure your database settings in SurvivorApiContext and apply migrations:
  ```bash
  dotnet ef database update
 ```
5. **Run:**
  ```bash
  dotnet run
 ```

6. **API Usage:**
   
 Competitors
  ```bash
GET /api/competitors - List all competitors.
GET /api/competitors/{id} - Get a specific competitor.
GET /api/competitors/categories/{categoryId} - Get competitors by category ID.
POST /api/competitors - Create a new competitor.
PUT /api/competitors/{id} - Update a specific competitor.
DELETE /api/competitors/{id} - Delete a specific competitor.
```
Categories
```bash
GET /api/categories - List all categories.
GET /api/categories/{id} - Get a specific category.
POST /api/categories - Create a new category.
PUT /api/categories/{id} - Update a specific category.
DELETE /api/categories/{id} - Delete a specific category.
```

7. **Sample POST Request (Add a Competitor)**
```bash
{
  "firstName": "Acun",
  "lastName": "Ilıcalı",
  "categoryId": 1,
  "createdDate": "2024-01-01T10:00:00",
  "modifiedDate": "2024-01-01T10:00:00",
  "isDeleted": false
}
```

