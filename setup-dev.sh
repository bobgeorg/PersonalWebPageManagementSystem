#!/bin/bash

# PersonalWebPageManagementSystem Development Setup Script
# This script sets up the development environment

echo "🚀 Setting up PersonalWebPageManagementSystem for development..."

# Check if .NET 8 is installed
if ! command -v dotnet &> /dev/null; then
    echo "❌ .NET SDK is not installed. Please install .NET 8 SDK first."
    echo "Download from: https://dotnet.microsoft.com/download/dotnet/8.0"
    exit 1
fi

# Check .NET version
DOTNET_VERSION=$(dotnet --version)
echo "✅ Found .NET SDK version: $DOTNET_VERSION"

# Restore packages
echo "📦 Restoring NuGet packages..."
dotnet restore

if [ $? -ne 0 ]; then
    echo "❌ Failed to restore packages"
    exit 1
fi

# Build the project
echo "🔨 Building the project..."
dotnet build

if [ $? -ne 0 ]; then
    echo "❌ Build failed"
    exit 1
fi

echo "✅ Setup completed successfully!"
echo ""
echo "🎉 To start the development server, run:"
echo "   dotnet run"
echo ""
echo "💡 The application will be available at http://localhost:5000"
echo "📝 SQLite database will be created automatically on first run"