# Final Exam Application - Rick and Morty Character Explorer

## Student Information
**Name:** KIM EGOC  
**Project Name:** FinalExamApplication

---

## Assigned API
**API Name:** Rick and Morty API  
**Endpoint:** `https://rickandmortyapi.com/api/character`  
**Documentation:** https://rickandmortyapi.com/documentation

---

## Project Description
This ASP.NET Core Razor Pages application consumes the Rick and Morty API to display character information in a clean, responsive table format. The application fetches character data including their status, species, gender, origin, current location, and number of episodes they appear in.

---

## DTO Structure

The application uses the following Data Transfer Objects to handle the API response:

### 1. **CharacterResponse** (Root DTO)
- `Info`: Contains metadata about the API response (count, pages, next, prev)
- `Results`: A list of Character objects

### 2. **Info** (Nested DTO)
- `Count`: Total number of characters in the database
- `Pages`: Total number of pages available
- `Next`: URL to the next page (if available)
- `Prev`: URL to the previous page (if available)

### 3. **Character** (Main Data DTO)
- `Id`: Unique character identifier
- `Name`: Character's name
- `Status`: Alive, Dead, or Unknown
- `Species`: Character's species (Human, Alien, etc.)
- `Type`: Character type/subspecies
- `Gender`: Character's gender
- `Origin`: Origin object containing name and URL
- `Location`: Location object containing current location name and URL
- `Image`: URL to character's avatar image
- `Episode`: List of episode URLs the character appears in
- `Url`: API URL for this character
- `Created`: DateTime when the character was created in the database

### 4. **Origin** (Nested DTO)
- `Name`: Name of the origin location
- `Url`: API URL for the origin location

### 5. **Location** (Nested DTO)
- `Name`: Name of the current location
- `Url`: API URL for the current location

---

## Features Implemented

✅ ASP.NET Core Razor Pages (.NET 8)  
✅ HttpClient with IHttpClientFactory for API consumption  
✅ JSON deserialization using System.Text.Json  
✅ Proper error handling for API failures  
✅ Bootstrap 5 responsive table layout  
✅ Color-coded status badges (Green=Alive, Red=Dead, Gray=Unknown)  
✅ Character avatars displayed in table  
✅ Episode count badge for each character  
✅ Displays 20 characters from the API  
✅ **Fully mobile responsive** with dual layout (cards on mobile, table on desktop)  
✅ **Adaptive design** that switches automatically based on screen size  
✅ Clean, modern UI with Bootstrap styling  
✅ Proper handling of nested data (origin, location, episodes)

---

## How to Run

1. **Prerequisites:**
   - .NET 8.0 SDK or later
   - Visual Studio 2022 or VS Code

2. **Steps:**
   ```bash
   cd FinalExamApplication
   dotnet restore
   dotnet run
   ```

3. **Access the application:**
   - Navigate to: `https://localhost:5001` or `http://localhost:5000`

---

## Screenshot

**Note:** A screenshot of the application showing the table with character data should be included here. The screenshot should show:
- The banner with the project name and description
- The data table displaying at least 10 characters
- Character avatars, status badges, and episode counts
- Responsive Bootstrap styling

To capture a screenshot:
1. Run the application using `dotnet run`
2. Open a browser and navigate to the application
3. Take a full-page screenshot showing the complete table
4. Save the screenshot as `screenshot.png` in the project root folder

---

## Technical Implementation Notes

### Backend (Index.cshtml.cs)
- Uses `IHttpClientFactory` for efficient HTTP client management
- Implements async/await pattern for API calls
- Fetches character data from Rick and Morty API
- Includes try-catch error handling with logging
- Deserializes JSON with case-insensitive property matching
- Exposes data through public properties for Razor page binding

### Frontend (Index.cshtml)
- Bootstrap 5 components for modern UI
- **Dual layout system:**
  - **Mobile (< 768px):** Card-based layout with stacked information
  - **Desktop (≥ 768px):** Traditional table layout
- **Responsive breakpoints** using Bootstrap's `d-md-none` and `d-none d-md-block`
- **Mobile-optimized:**
  - Smaller text sizes on mobile
  - Card-based interface for better touch interaction
  - Larger avatar images in cards
  - Stacked information for easy reading
- **Desktop-optimized:**
  - Full table with all columns
  - Hover effects on table rows
  - Compact layout for more information density
- Color-coded badges for visual status indication
- Responsive images using Bootstrap's `img-fluid`
- Conditional rendering for error messages and empty states
- Clean separation of concerns with Razor syntax

### API Integration
- REST API consumption via GET request
- Handles nested JSON objects (origin, location)
- Handles JSON arrays (episode list)
- Proper null checking for optional fields
- Displays summary information (episode count) instead of full arrays

---

## Project Structure

```
FinalExamApplication/
├── Models/
│   └── CharacterResponse.cs      # All DTO classes
├── Pages/
│   ├── Index.cshtml               # View with Bootstrap table
│   ├── Index.cshtml.cs            # PageModel with API logic
│   └── Shared/
│       └── _Layout.cshtml         # Main layout template
├── Program.cs                     # App configuration & DI setup
├── appsettings.json               # Configuration settings
└── README.md                      # This file
```

---

## Additional Notes

- The application displays 20 characters by default (API's first page)
- Total character count (826) is displayed at the top of the table
- The table is fully responsive and works on mobile devices
- Avatar images are lazy-loaded from the Rick and Morty CDN
- Episode count shows how many episodes each character appears in
- Status badges use semantic colors for better UX

---

## License
This is a student project created for educational purposes.

---

**Submission Date:** October 23, 2025

