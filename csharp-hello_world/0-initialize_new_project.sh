#!/usr/bin/env bash

# Creates new directory
mkdir -p 0-new_project

# Navigates into directory
cd 0-new_project

# Initializes a new C# project using dotnet
dotnet new console

# Move to current directory
cd ..
