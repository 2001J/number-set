# Number-set
# Integer Set Type Project

This project involves implementing an Integer Set Type with various operations such as inserting, removing, checking elements, and more. The set is represented as a sequence of integers, where each element is unique and stored only once.

## Features

The Integer Set Type supports the following operations:

### Insert an Element
**Method:** `InsertElement(int x)`  
Inserts an integer `x` into the set. If `x` is already present, throws an `ElementAlreadyInSetException`. For even numbers, updates the count of even numbers in the set.

### Remove an Element
**Method:** `RemoveElement(int x)`  
Removes an integer `x` from the set. If `x` is not present, throws an `ElementNotInSetException`. For even numbers, updates the count of even numbers.

### Check if the Set is Empty
**Method:** `IsEmpty()`  
Returns `true` if the set is empty, otherwise returns `false`.

### Check if the Set Contains an Element
**Method:** `IsElementInTheSet(int x)`  
Returns `true` if the integer `x` is in the set, otherwise returns `false`.

### Get a Random Element
**Method:** `GetRandomElement()`  
Returns a random element from the set without removing it. Throws `EmptySetException` if the set is empty.

### Get the Number of Even Numbers
**Method:** `GetEvenCount()`  
Returns the count of even numbers currently in the set.

### Print Elements of the Set
**Method:** `PrintElements()`  
Prints all the elements in the set.

## Class Design

### Set Representation
The set is implemented using a `List<int>` that stores the elements. This allows for dynamic resizing as elements are added or removed.

### Even Count
The class maintains an internal counter `evenCount` to keep track of the number of even integers in the set. This is updated whenever an even number is inserted or removed.

### Structure
- `List<int> elements`: Stores the set of integers.
- `int evenCount`: Tracks the number of even integers in the set.

## Methods Overview

- `InsertElement(int x)`: Inserts an element if it's not already present.
- `RemoveElement(int x)`: Removes an element if it exists.
- `IsEmpty()`: Checks if the set is empty.
- `IsElementInTheSet(int x)`: Checks if an element is in the set.
- `GetRandomElement()`: Returns a random element from the set.
- `GetEvenCount()`: Returns the count of even elements in the set.
- `PrintElements()`: Prints all elements in the set.

## Exception Handling

The following exceptions are handled within the implementation:

- `ElementAlreadyInSetException`: Thrown when attempting to insert a duplicate element.
- `ElementNotInSetException`: Thrown when attempting to remove an element that doesn't exist.
- `EmptySetException`: Thrown when trying to retrieve a random element from an empty set.

## Testing

The project includes both black-box and white-box testing approaches:

### Black-Box Testing
- `TestSetConstructor`: Verifies that a newly created set is not null.
- `TestInsertElement`: Verifies successful insertion of elements.
- `TestInsertElementTwice`: Verifies that attempting to insert an element twice throws the correct exception.
- `TestIsElementInTheSet`: Verifies whether an element is present in the set.

### White-Box Testing
- `TestInsertElement`: Ensures the `InsertElement` method functions correctly.
- `TestInsertElementTwice`: Ensures the method throws an exception when the same element is inserted twice.
- `TestIsElementInTheSet`: Verifies the presence of an element after insertion.

## How to Use

1. Clone the repository from [GitHub](https://github.com/2001J/number-set.git) using the following command:
  ```sh
  git clone https://github.com/2001J/number-set.git
  ```
2. Navigate to the `NumberSet` folder within the root directory:
  ```sh
  cd number-set/NumberSet
  ```
3. Run the project using `dotnet run` to interact with the Integer Set Type and its operations:
  ```sh
  dotnet run
  ```
4. To run the test cases, navigate to the project root directory and execute `dotnet test`. You should see output similar to:
  ```sh
  cd ..
  dotnet test
  ```
  Example output:
  ```
  NumberSet % dotnet test
    Determining projects to restore...
    Restored /path/to/NumberSet/NumberSet.csproj (in 44 ms).
    1 of 2 projects are up-to-date for restore.
    NumberSet -> /path/to/NumberSet/bin/Debug/net8.0/NumberSet.dll
    NumberSetTest -> /path/to/NumberSetTest/bin/Debug/net8.0/NumberSetTest.dll
  Test run for /path/to/NumberSetTest/bin/Debug/net8.0/NumberSetTest.dll (.NETCoreApp,Version=v8.0)
  Microsoft (R) Test Execution Command Line Tool Version 17.10.0 (arm64)
  Copyright (c) Microsoft Corporation.  All rights reserved.

  Starting test execution, please wait...
  A total of 1 test files matched the specified pattern.

  Passed!  - Failed:     0, Passed:    15, Skipped:     0, Total:    15, Duration: 57 ms - NumberSetTest.dll (net8.0)
  ```
