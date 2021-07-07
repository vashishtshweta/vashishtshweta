# Introduction 
TODO: 
The Fignum WebApplication is designed to display the output as a Sorted string after removing any Prime number from the entered text input on click on Prime number filter button.


# Build With
	ASP.NET Core Web Application
	Bootstrap
	JQuery
	Laravel

# Prerequisites

Visual Studio2019.


# Getting Started
These following instructions will get you a copy of the project up and running on your local machine for development and testing purposes.
   1. To download the solution.
		https://www.drupal.org/project/issues/admin_menu
   2. Please unzip the Fignum Application Zip folder.
   3. Please double click on the .sln file to open the Fignum WebApplication in Visual Studio 2019.
   


  
# Build and Test
	Build the solution by clicking on BuildSolution tab on the Menu Build -> BuildSolution   (shortcut Ctrl+ Shift + B)
	Click on IIS Express to launch the application. 
	
	To test the application please enter some text in the Enter text input.
			e.g. Input String  "1 2 sample 3 45 2text 23 for 34Input  "
	
	click on Prime Number Filter with Sort Button. The text in the enter text field will be sorted and any prime number will be removed from the Input text 
		e.g. Output String “2 34 45 for Input sample text”
		A message will be displayed with Original Input and the list of prime numbers removed from the input
		
	If there is no prime number to be removed from the input then sorted output will be displayed in the Input textbox with a message "There is no prime number found in entered string."

# Contribute

The fignum WebApplication is designed in a way that multiple features can be added in future. 
I have added OdeToCode.AddFeatureFolders package to organize controllers and views in a Features folder hierarchy have added Filers functionality in the seperate project called Core.Services so that can be resused in other pages or views.