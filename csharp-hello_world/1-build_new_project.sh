#!/usr/bin/env bash

# Creates new directory
mkdir -p 1-new_project

# Navigates into directory
cd 1-new_project

# Initializes a new C# console project using dotnet
dotnet new console

# Build C# project
dotnet build
