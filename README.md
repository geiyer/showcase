# A DotNet Core project to consume a REST Service

This is a sample project with Unit Tests to consume a REST Service

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes. 

### Prerequisites

Visual Studio Code or Visual Studio
```
.Net Core 2.1
```

### Installing

A step by step series of examples that tell you how to get a development env running

1. Clone the Github repo
2. Execute the following build command in the "showcase" directory: 

```

dotnet add package coverlet.msbuild
dotnet tool install -g dotnet-reportgenerator-globaltool
dotnet build
```



## Running the Program

Execute the following command in the showcase directory:

```
dotnet run
```
1. Enter the Album Number e.g. 2 or 12 etc
2. The list of all the photos will be displayed on the console.

## Running the tests

Execute the following command in the "tests" directory:
```
dotnet test
dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=opencover
ReportGenerator "-reports:coverage.opencover.xml" "-targetdir:report"   
```

## Authors

* **Gopi Iyer** - *Initial work*


## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details
