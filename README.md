# MoviePortal

MoviePortal Blazor is a web application that allows users to browse and view details about various movies. The application is built using Blazor WebAssembly and leverages the TMDB (The Movie Database) API to fetch movie data.

## Features

- Browse a list of movies
- View detailed information about a selected movie, including its cast and genres
- Offline support using a service worker
- Responsive design using Bootstrap

## Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- [Visual Studio](https://visualstudio.microsoft.com/) (recommended IDE)


### Configuration

1. Create an account on [TMDB](https://www.themoviedb.org/) and get an API key.
2. Add your TMDB API key to the `appsettings.Development.json` file.
    

## Project Structure

- `wwwroot/`: Contains static files such as HTML, CSS, and JavaScript.
- `Components/`: Contains Blazor components used in the application.
- `Services/`: Contains services for interacting with external APIs.
- `Models/`: Contains data models used in the application.
- `Program.cs`: Entry point for the Blazor WebAssembly application.
- `App.razor`: Root component for the Blazor application.

## Contributing

Contributions are welcome! Please open an issue or submit a pull request for any changes.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.
