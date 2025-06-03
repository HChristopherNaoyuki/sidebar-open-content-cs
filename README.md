# Sidebar Navigation Application

A minimalist WPF application with sidebar navigation functionality, built with C# and XAML.

## Features

- Clean, modern interface with dark sidebar and light content area
- Four navigation sections: Chats, Reminders, Quiz, and Activity
- Exit functionality to close the application
- Smooth transitions between content pages
- Responsive design with hover effects

## Requirements

- .NET Framework 4.7.2 or later
- Visual Studio 2019/2022 (for development)

## How to Use

1. Click on any sidebar button to switch between content sections:
   - **Chats**: Displays the chats interface
   - **Reminders**: Shows the reminders section
   - **Quiz**: Navigates to quiz content
   - **Activity**: Displays activity information
   - **Exit**: Closes the application

2. The application remembers your current section when switching views.

## Development

To modify or extend this application:

1. Clone the repository
2. Open the solution in Visual Studio
3. Edit the XAML for UI changes or the C# code for functionality

### Project Structure

- `MainWindow.xaml`: Contains all UI definitions
- `MainWindow.xaml.cs`: Handles navigation logic and events

## Customization

You can easily customize:
- Colors by editing the resource dictionaries
- Button styles in the Window.Resources section
- Content pages by modifying the Grid elements

## Known Issues

Please open an issue if you find any bugs.

---
