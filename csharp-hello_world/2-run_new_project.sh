#!/usr/bin/env bash

# Initializes a new C# console project using dotnet
dotnet new console -o "2-new_project"

# Build C# project
dotnet build "2-new_project"

# Runs dotnet pls
dotnet run --project "2-new_project"
