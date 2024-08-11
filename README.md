# Dictionary Example in C#

This project demonstrates basic operations with a dictionary in C#. It includes a simple console application for managing a dictionary of names and ages using the `AgeDictionaryManager` class. The program provides a menu-driven interface for users to interact with the dictionary.

## Project Overview

The `AgeDictionaryManager` class manages a dictionary that maps names (keys) to ages (values). The class provides methods to add, retrieve, remove, and display entries in the dictionary. The `Program` class contains a console application that allows users to interact with the `AgeDictionaryManager` through a menu-driven interface.

## Features

- **Add/Update an Entry:** Add a new key-value pair or update an existing one.
- **Search for an Entry:** Retrieve the age associated with a name.
- **Remove an Entry:** Remove a key-value pair from the dictionary.
- **Display All Entries:** Display all current key-value pairs in the dictionary.
- **Exit:** Terminate the application.

## Getting Started

### Prerequisites

To run this project, you need to have the following installed:

- [Visual Studio](https://visualstudio.microsoft.com/) or another C# development environment.
- [.NET SDK](https://dotnet.microsoft.com/download)

### Running the Program

1. **Clone the repository:**

    ```bash
    git clone https://github.com/your-username/dictionary-example-csharp.git
    ```

2. **Open the solution in Visual Studio:**
    - Navigate to the project directory.
    - Open the `.sln` file in Visual Studio.

3. **Build and run the project:**
    - Press `F5` or click on the `Run` button in Visual Studio to start the application.

## Code Structure

### `AgeDictionaryManager.cs`

- **Purpose:** Manages a dictionary of names and ages.
- **Key Methods:**
  - `AddAge(string name, int age)`: Adds or updates an entry in the dictionary.
  - `GetAge(string name)`: Retrieves the age for a given name.
  - `ContainsName(string name)`: Checks if a name exists in the dictionary.
  - `RemoveName(string name)`: Removes an entry from the dictionary.
  - `DisplayAll()`: Displays all entries in the dictionary.

### `Program.cs`

- **Purpose:** Provides a menu-driven interface for interacting with the `AgeDictionaryManager`.
- **Key Functionality:**
  - Displays a menu with options to add, search, remove, and display entries.
  - Handles user input and performs the corresponding dictionary operations.

## Usage

After running the application, you will see a menu with the following options:

1. **Add/Update an Entry:** Enter a name and age to add or update an entry.
2. **Search for an Entry:** Enter a name to find the corresponding age.
3. **Remove an Entry:** Enter a name to remove the entry from the dictionary.
4. **Display All Entries:** Show all current entries in the dictionary.
5. **Exit:** Terminate the application.

### Sample Interaction

