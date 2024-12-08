if(input.Application_Deadline < zoho.currentdate)
{
	alert "The deadline cannot be a past date.";
	cancel submit;
}
