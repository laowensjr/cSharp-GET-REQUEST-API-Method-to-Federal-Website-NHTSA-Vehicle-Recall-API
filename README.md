# C# GET Request API Method to Federal Website NHTSA Vehicle-Recall-API
Alternative GET API REQUEST...
CSharp(C#) GET REQUEST API Connection to Vehicle Recall NHTSA Federal Site
IDE Used: Visual Studio 2019

Tested and working great. 


NHTSA suggested code located at https://vpic.nhtsa.dot.gov/api/Home/Index/LanguageExamples
 may not work as they claim. Thus the reason I've provided an Alternative. Here is their code for C# GET


string url = "https://vpic.nhtsa.dot.gov/api/vehicles/GetModelsForMakeId/440?format=json";
HttpClient client = new HttpClient();
client.BaseAddress = new Uri(url);
client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
try
{
	var tmp = client.GetAsync(url).Result;
	if (tmp.IsSuccessStatusCode)
		var result = tmp.Content.ReadAsStringAsync();
}
catch (Exception err)
{
	// error handling
}
