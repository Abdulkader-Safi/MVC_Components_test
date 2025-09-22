# MVC Components Demo

A demonstration project showcasing how to create reusable UI components in ASP.NET Core MVC using Partial Views. This project illustrates a component-based architecture pattern for building modular and maintainable web applications.

## Overview

This project demonstrates the implementation of a card component system using ASP.NET Core MVC Partial Views. It shows how to create reusable UI components that can be easily customized and integrated throughout your application.

## Features

- **Reusable Card Component**: A flexible card component with customizable properties
- **Component-Based Architecture**: Organized structure for scalable UI components
- **Bootstrap Integration**: Responsive design with Bootstrap styling
- **Model-Driven Components**: Strongly-typed components using view models

## Project Structure

```
MVC_Components/
├── Controllers/
│   └── HomeController.cs          # Main controller with component demo
├── Models/
│   ├── CardViewModel.cs           # View model for card component
│   └── ErrorViewModel.cs          # Error handling view model
├── Views/
│   ├── Home/
│   │   ├── Index.cshtml           # Demo page showing multiple cards
│   │   └── Privacy.cshtml         # Privacy page
│   └── Shared/
│       ├── Components/
│       │   └── _Card.cshtml       # Reusable card partial view
│       ├── _Layout.cshtml         # Main layout template
│       └── _ValidationScriptsPartial.cshtml
├── wwwroot/
│   └── css/
│       └── site.css               # Custom styles including card components
└── Program.cs                     # Application configuration
```

## Card Component System

### CardViewModel

The `CardViewModel` class defines the structure and properties of the card component:

```csharp
public class CardViewModel
{
    public string Title { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public string? Footer { get; set; }
    public string? ImageUrl { get; set; }
    public string? ActionUrl { get; set; }
    public string? ActionText { get; set; }
    public string CssClass { get; set; } = "card-default";
    public bool ShowBorder { get; set; } = true;
    public bool ShowShadow { get; set; } = true;
}
```

### Card Partial View

The card component (`Views/Shared/Components/_Card.cshtml`) is a reusable partial view that renders:

- Optional image header
- Title and content sections
- Optional action button
- Optional footer
- Customizable styling and borders

### Usage Example

To use the card component in your views:

```html
<partial name="Components/_Card" model="cardViewModel" />
```

In the controller:

```csharp
var card = new CardViewModel
{
    Title = "Welcome Card",
    Content = "This is a sample card component demonstrating reusable UI in MVC.",
    Footer = "Last updated: " + DateTime.Now.ToString("MMM dd, yyyy"),
    CssClass = "card-success",
    ActionUrl = "/Home/Privacy",
    ActionText = "Learn More"
};
```

## Component Features

### Styling Options

The card component supports various CSS classes for different styles:

- `card-primary` - Blue accent border
- `card-success` - Green accent border  
- `card-warning` - Yellow accent border
- `card-danger` - Red accent border
- `card-border` - Adds border styling
- `card-shadow` - Adds drop shadow with hover effects

### Conditional Rendering

The component intelligently renders elements based on provided data:

- Images are only displayed if `ImageUrl` is provided
- Action buttons appear only when both `ActionUrl` and `ActionText` are set
- Footer section renders only if `Footer` content exists
- Border and shadow effects can be toggled via boolean properties

## Getting Started

### Prerequisites

- .NET 9.0 or later
- Visual Studio 2022 or Visual Studio Code

### Running the Project

1. Clone the repository
2. Navigate to the project directory
3. Run the following commands:

```bash
dotnet restore
dotnet build
dotnet run
```

4. Open your browser and navigate to `https://localhost:5001` or `http://localhost:5000`

### Development

The demo page displays multiple card instances to showcase the component's flexibility. You can modify the card data in `HomeController.cs` (lines 12-95) to experiment with different configurations.

## Key Benefits

- **Reusability**: Components can be used across multiple views and controllers
- **Maintainability**: Changes to component structure only need to be made in one place
- **Consistency**: Ensures uniform appearance and behavior across the application
- **Flexibility**: Easy to customize through view model properties
- **Type Safety**: Strongly-typed models prevent runtime errors

## Learning Objectives

This project demonstrates:

1. How to create partial views for reusable components
2. Model-driven component architecture
3. Conditional rendering in Razor views
4. CSS organization for component styling
5. Bootstrap integration with custom components
6. MVC pattern implementation for component-based UI

## Next Steps

To extend this project, consider:

- Adding more component types (buttons, modals, forms)
- Implementing component composition patterns
- Adding JavaScript functionality to components
- Creating a component library structure
- Implementing ViewComponents for more complex scenarios

## Technology Stack

- **Framework**: ASP.NET Core MVC (.NET 9.0)
- **Frontend**: Bootstrap 5, HTML5, CSS3
- **Templating**: Razor Views
- **Architecture**: Model-View-Controller (MVC)