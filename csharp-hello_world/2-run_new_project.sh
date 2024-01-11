#!/usr/bin/env bash

# Initializes a new C# console project using dotnet
dotnet new console -o "1-new_project"

# Build C# project
dotnet build "1-new_project"

# Run dotnet
cd "1-new_project" && dotnet run
