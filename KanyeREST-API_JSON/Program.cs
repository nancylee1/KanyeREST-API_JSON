using Newtonsoft.Json.Linq;  // Add the Newtonsoft.Json Nuget package. This will allow us to grab our
                             // JSON response from the https://api.kanye.rest API.

var client = new HttpClient();  //Create a new instance of the HttpClient class which provides a base
                                //class for sending HTTP requests and receiving HTTP responses from a resource identified by a URL

var kanyeURL = "https://api.kanye.rest/"; //Create a variable called "kanyeURL" and assign it a value
                                          //of the API's endpoint URL
var ronswansonURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

//var kanyeResponse = client.GetStringAsync(kanyeURL).Result; //Next, we send a GET request to the specified URL and return the response
//                                                            //body as a string in an asynchronous operation. Basically, we get a string of JSON back
//var ronResponse = client.GetStringAsync(ronswansonURL).Result;

//var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();   //Now we can parse through our JSON response and grab the
//                                                                              //values we are interested in. In this case, we grab the VALUE associated with the “quote” NAME.

//var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();


//Console.WriteLine(kanyeQuote);  // Finally, we can add a Console.WriteLine() to print the kanyeQuote to the console

for (int i = 0; i < 5; i++)
{
    var kanyeResponse = client.GetStringAsync(kanyeURL).Result;
    var ronResponse = client.GetStringAsync(ronswansonURL).Result;
    var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();
    var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();
    Console.WriteLine($"Kanye says: {kanyeQuote}");
    Console.WriteLine();
    Console.WriteLine($"Ron says: {ronQuote}");
    Console.WriteLine();
  
}