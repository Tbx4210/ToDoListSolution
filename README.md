# ToDoList API

A RESTful To-Do List API built with ASP.NET Core (C#), structured as a multi-project solution separating the API layer, data models, and automated tests.

## Overview

This project implements core CRUD (Create, Read, Update, Delete) functionality for managing to-do items via a RESTful API. It was built to practice clean project structure, separation of concerns, and unit testing in a real .NET solution.

## Project Structure

The solution is split into three projects:

- **`ToDoList.API`** — The Web API layer: controllers, endpoints, and request/response handling.
- **`ToDoList.Models`** — Shared data models representing to-do items and related entities.
- **`ToDoList.Tests`** — Unit tests covering the API and business logic.

Keeping these concerns in separate projects mirrors how larger, production-grade .NET solutions are organized, rather than putting everything in a single project.

## Tech Stack

- **Language:** C#
- **Framework:** ASP.NET Core Web API
- **Testing:** Unit tests via the `ToDoList.Tests` project

## Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) (version matching this solution)

### Running the project

```bash
git clone https://github.com/Tbx4210/ToDoListSolution.git
cd ToDoListSolution
dotnet build
dotnet run --project ToDoList.API
```

### Running tests

```bash
dotnet test
```

## API Endpoints

> Update this section with the actual routes implemented in `ToDoList.API` (e.g. `GET /api/todos`, `POST /api/todos`, `PUT /api/todos/{id}`, `DELETE /api/todos/{id}`).

## What I Learned

Building this project helped reinforce:
- Structuring a .NET solution across multiple projects rather than a single monolithic file
- Writing and running unit tests alongside API development
- RESTful API design principles and CRUD operations

## Status

This is a personal learning project, built to practice backend API development in C#/.NET.
