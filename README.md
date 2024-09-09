# Labb1

This is my first assignment for my .NET studies at IT-Högskolan. Assignment submitted in september 2024 after three weeks of studies.

## Critera for the assignment

Create a consoll application asking the user to enter a string. The given string searches for substrings with the same start- and endnumber. No letters are allowed in the substring.

All substrings should be added and printed out.

## Structure for my program

I have two classes (HandleAndPrintString.cs and InitializeString.cs) and Program.cs. InitializeString.cs asks the user to enter a string and ensures the string is not empty. If the string is empty the user is asked again to enter a string.

InitializeString.cs uses a for-loop and a if statement to call the function FindStringToPrint in class HandleAndPrintString.cs. FindStringToPrint searches threw the string to check if it fulfilles the criteria for this assignment. For each string approved FindStringToPrint returns true and for each true the funcion PrintString is calles. PrintString print the string with colored substring and returnes the number of the substring as a double. The final task for my program is to print the total sum of all substrings.
