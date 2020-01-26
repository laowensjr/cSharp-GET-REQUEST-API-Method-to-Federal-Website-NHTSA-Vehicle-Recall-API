# C# GET Request API Method to Federal Website NHTSA Vehicle-Recall-API
CSharp(C#) GET REQUEST API Connection to Vehicle Recall NHTSA Federal Site
IDE Used: Visual Studio 2019

Tested and working great. 


Their suggested code doesn't work as they claim. Here is their code


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
