# Project

### By Jessica Munoz

#### _A web API to record dogs and cats for an animal shelter. - August 23th, 2019_

---

## Description

The animal shelter has many dogs and cats they need to have on record and have the ability to regularly reference those records. This API sets up two tables for dogs and cats respectively so their name, gender, and age can be created(POST), read(GET), updated(PUT) and deleted(DELETE).

## Technologies Used

- C#
- .NET
- EntityFrameworkCore
- MySQL
- MySQLWorkBench
- MySqlConnector
- Razor
- Swagger with Swashbuckle

## Installation

- Install .NET locally if it isn't already installed
- Open the terminal, clone down this repository.
- Via the terminal, navigate to the project folder AnimalShelter
  - Enter the command: dotnet restore
  - Enter the command: dotnet ef database update
  - Enter the command: dotnet run
- To review the API documentation:
  - Browse to http://localhost:5000/swagger/v1/swagger.json
- To utilize the CRUD functionality:
  - Browse to http://localhost:5000/swagger

## Specs

| Behaviors                              |                                                                  Input                                                                   |                       Output                       |
| -------------------------------------- | :--------------------------------------------------------------------------------------------------------------------------------------: | :------------------------------------------------: |
| User can add a new dog or cat.         |                                 User clicks "POST" and "Try it out", edits fields and clicks "Execute".                                  |             New dog or cat is created.             |
| User can read all dogs or cats.        |                                             User clicks "GET", "Try it out", and "Execute".                                              |            All dogs or cats are listed.            |
| User can read a specific dog or cat.   |            User clicks "GET/ ... /{id}", "Try it out", enters the id of a previously created cat or dog and clicks "Execute".            | The dog or cat associated with that id is listed.  |
| User can update a specific dog or cat. | User clicks "PUT/ ... /{id}", "Try it out", enters the id of a previously created cat or dog, edits the properties and clicks "Execute". | The dog or cat associated with that id is updated. |
| User can delete a specific dog or cat. |          User clicks "DELETE/ ... /{id}", "Try it out", enters the id of a previously created cat or dog and clicks "Execute".           | The dog or cat associated with that id is deleted. |

## Known Bugs

- No known bugs at this time.

## Support and contact details

_Please contact Jessica Munoz with questions and comments._

### License

_GNU GPLv3_

Copyright (c) 2019 **_Jessica Munoz_**
