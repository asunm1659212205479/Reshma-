// Assuming 'name' is the input field in your form
name_input = input.Student_Name;
// Get the name input
// Trim any leading or trailing whitespace
name_input = name_input.trim();
// Check if the input is empty
if(name_input.length() == 0)
{
	alert "The name field cannot be empty.";
	cancel submit;
	// Prevent form submission
}
// Regular expression to check if the input contains only letters and spaces
is_valid = name_input.matches("^[a-zA-Z ]+$");
if(!is_valid)
{
	// If the name contains anything other than letters or spaces, show an alert and stop submission
	alert "The name field should only contain letters and spaces. Please remove any numbers or special characters.";
	cancel submit;
	// Prevent form submission
}
