# brewapp
A web app used to track brewing results for both tea and coffee. Currently in early development.

## How to use 
Requires the [.NET SDK 8.0](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
1. Clone the repository.
1. Move to the `src/api` directory inside the repository and execute `dotnet run`. The app should start and show what port it is using. 
1. Interact with the endpoints via
    * [Swagger UI](https://learn.microsoft.com/en-us/aspnet/core/tutorials/web-api-help-pages-using-swagger?view=aspnetcore-8.0#swagger-ui): visit http://localhost:{port}/swagger in your browser
    * OR [httprepl](https://learn.microsoft.com/en-us/aspnet/core/web-api/http-repl): connect to `http://localhost:{port}` 
