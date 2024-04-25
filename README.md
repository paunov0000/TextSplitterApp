## Text Splitter

This is a simple ASP.NET Core MVC application that splits a user-provided text input into individual words and displays each word on a separate line. The application utilizes Tailwind CSS for a user-friendly interface.

### Technologies Used

* ASP.NET Core MVC: [https://dotnet.microsoft.com/en-us/download](https://dotnet.microsoft.com/en-us/download)
* Tailwind CSS: [https://tailwindcss.com/docs/installation](https://tailwindcss.com/docs/installation)

### Functionality

The application offers a single page with a text input field. Users can enter text, and upon submitting the form, the application processes the input using the following steps:

1. Splits the entered text by spaces.
2. Filters out any empty strings (resulting from multiple spaces).
3. Displays each remaining word on a new line.

The application utilizes a single model (`TextViewModel`) to handle both the input text and the resulting split words.

### Running the application

1. Clone this repository.
2. Ensure you have the .NET Core SDK installed ([https://dotnet.microsoft.com/en-us/download](https://dotnet.microsoft.com/en-us/download)).
3. Open the project in your preferred IDE (e.g., Visual Studio).
4. Run the application (usually by pressing F5 in Visual Studio).

### Code Structure

The project follows the standard ASP.NET Core MVC structure with dedicated folders for:

* **Controllers:** Handles user interactions and calls methods to process the input text.
* **Models:** Contains the `TextViewModel` class with properties for the input text and the split words.
* **Views:** Contains the Razor view files responsible for rendering the user interface.

### Tailwind CSS Integration

Tailwind CSS provides the styling for the application's user interface. The base Tailwind configuration files reside within the project. Feel free to customize the styles as desired.

### Project Simplicity

This is a basic application showcasing the use of ASP.NET Core MVC with a single controller (`HomeController`) handling all functionalities. The `HomeController` implements both GET and POST methods for the `Index` endpoint:

* **GET:** Loads the initial page with an empty `TextViewModel`.
* **POST:** Receives the submitted text from the form, processes it to split words, and updates the `TextViewModel` with the results. The updated view is then displayed.

### Contributing

Feel free to fork this repository and contribute improvements or new features. Here are some potential enhancements:

* Implement handling for punctuation marks.
* Display additional information like word count or character count.
