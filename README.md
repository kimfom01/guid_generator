# Guid Generator

This is a CLI tool for generating abitrary GUID for testing purposes.

## Usage

### Requirements

To build this project you need the following requirements

- [.NET 8 SDK](https://dot.net)
- Terminal

### Running

Open the `guid_generator` directory in terminal and run the following command to run the app

```sh
dotnet run
```

### Build

To build the CLI, run the following command from the `guid_generator` directory in terminal

```sh
dotnet publish -o ./build -p:PublishSingleFile=true
```

> `-p:PublishSingleFile=true` allows you to build into one file otherwise you will have an executable, a dll and other config files
