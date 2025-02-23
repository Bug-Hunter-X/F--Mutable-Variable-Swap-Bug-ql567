# F# Mutable Variable Swap Bug

This repository demonstrates a common error when working with mutable variables in F#. The `swap` function attempts to swap the values of two mutable variables, but it fails to do so correctly.  The issue lies in the scope of the variables within the function. 

## How to Reproduce

1. Clone the repository.
2. Compile and run `bug.fs`. Observe that the values of x and y remain unchanged.
3. Compile and run `bugSolution.fs` to see the corrected implementation.

## Bug Description

The original code incorrectly swaps mutable variables. While the local `temp` variable within the `swap` function correctly holds the value of `x`, the assignments `x <- y` and `y <- temp` only modify the copies of `x` and `y` local to the `swap` function.  The original variables passed into `swap` are unaffected.

## Solution

The solution demonstrates the correct way to handle mutable variables and shows how the function should pass and modify the variables by reference.