using BookStoreConsole;
using ConsoleApp2.Models;
using Newtonsoft.Json;
using static System.Console;
using static Newtonsoft.Json.JsonConvert;
using System.Text;
using System.Net;






//    const bool setBearerToken = false;

//const string loginEndpoint = "https://easedemonew.ocr-inc.com/user/loginDefault.ocr";
//const string postEndpoint = "http://easedemonew.ocr-inc.com/webservices/dpss/entityscreen";
//var httpClient = await new HttpService().GetHttpClientAsync(setBearerToken, loginEndpoint);

//var WLS_GLOBAL_HEADER = new WLSGLOBALHEADER() { EMAIL="", LOAD_DATA="Y", ORDER_NO="1"};

//var WLS_SCREENING_PARAM = new WLSSCREENINGPARAM() { ENTITY_ID = "1", KEY_NAME="PRK_001", FIELD_TYPE = "ABC", COUNTRY_CODE="IN", ADDRESS1="49 N", ADDRESS2 = "Tyagi Mohalla", ADDRESS3= "Chhatarpur", CITY= "Gurgaon" };

//var wlsSceeningParamList = new List<WLSSCREENINGPARAM>
//{
//    WLS_SCREENING_PARAM
//};

//var WLSENTITYSCREENREQUEST = new WLSENTITYSCREENREQUEST() { WLS_GLOBAL_HEADER = WLS_GLOBAL_HEADER, WLS_SCREENING_PARAM = wlsSceeningParamList };


//var testObject = new Root() { WLS_ENTITY_SCREEN_REQUEST = null};

//var testJson = JsonConvert.SerializeObject(testObject);

//var content = new StringContent(testJson, Encoding.UTF8, "application/json");

//var response = await httpClient.Value.PostAsync(postEndpoint, content);
//response.EnsureSuccessStatusCode();

//var json = await response.Content.ReadAsStringAsync();

//var repsonse = JsonConvert.DeserializeObject<JsonRespose>(json);

//try
//{
//    var books = DeserializeObject<ListResultDto<BookDto>>(json);
//    WriteLine("====================================");
//    if (books?.Items != null)
//        foreach (var book in books.Items)
//            WriteLine(book.Name);
//    WriteLine("====================================");

//}
//catch (JsonReaderException)
//{
//    WriteLine("Deserializing went wrong");
//}
