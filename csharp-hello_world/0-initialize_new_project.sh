#!/usr/bin/env bash

# Creates a new directory
mkdir -p 0-new_project

# Navigates into directory
cd 0-new_project

# Initializes new C# project using dotnet
dotnet new console

# Move back to the parent directory
cd ..
