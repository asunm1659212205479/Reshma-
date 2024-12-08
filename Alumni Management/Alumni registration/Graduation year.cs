// Get the current year
currentYear = zoho.currentdate.getYear();
// Check if the graduation year is in the future
if(input.Graduation_Year > currentYear)
{
	// Display an error message
	alert "Graduation year cannot be in the future. Please enter a valid year.";
	// Clear the invalid input
	input.Graduation_Year = null;
}
