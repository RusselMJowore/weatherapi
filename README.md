Weather Forecast API Documentation
Overview
This Weather Forecast API provides access to weather forecast data for various locations. It allows users to retrieve current weather conditions, as well as forecasts for the next five days.

The API integrates Open Wether Map APIs to create an ASP.Net weather API that can be used to search for cities and thier coordinates and retrieve weather data based on those outputs

Authentication
No authentication is required to access the API.

Endpoints
1. Get City
URL: /api/Home/getcity
Method: GET
Description: Retrieves the coordinates of a city.
Parameters:
location: The name of the location (e.g., city name).
2. Get Five-Day Forecast
URL: /api/Home/getfivedayforecast
Method: GET
Description: Retrieves the five-day weather forecast for a specific location.
Parameters:
location: The coordinates of the location (coordinates).

The API can be use to retrieve city coordinates which in turn allow for the retrival of the Five-Day Forecast data
To use:
Clone the repository, load the folder into an IDE eg"Visual studio" and run the app.
