if(input.Date_of_Event >= zoho.currentdate)
{
	alert "Future dates are not allowed.";
	cancel submit;
}
