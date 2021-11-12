Small .NET Project with
- Library (prefix some string with 'hello ')
- Application (call to library and print 'hello world')
- Test (test the library)

You can do:

dotnet clean
dotnet restore
dotnet build
dotnet test
dotnet run --project Application
dotnet pack      # create NuGet packages)

For linting, do:
dotnet tool install --global dotnet-fsharplint --version 0.20.2
(this does not work with .NET 6.0, .NET 5.0 is required)
