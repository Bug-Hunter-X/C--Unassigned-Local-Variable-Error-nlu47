# C# Unassigned Local Variable Bug

This repository demonstrates a common error in C# programming: using an unassigned local variable. The code in `bug.cs` attempts to use the variable `z` before it's been assigned a value, leading to a compiler error. The solution, provided in `bugSolution.cs`, shows how to correctly assign values to variables before use, resolving the error.

## How to Reproduce

1. Clone this repository.
2. Open `bug.cs` in a C# IDE (like Visual Studio).
3. Attempt to compile the code. You'll encounter a compiler error indicating that the local variable 'z' is used before it has been assigned a value.

## Solution

The solution is to assign a value to `z` before using it in the expression `x + z`. Refer to `bugSolution.cs` for the corrected code.