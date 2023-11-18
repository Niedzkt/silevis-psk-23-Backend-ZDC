using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SystemPraktyk.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public async Task OnGet()
        {
            string apiUrl = "http://hackathon23-mockapi-env.eba-qfrnjqkt.eu-central-1.elasticbeanstalk.com/user/s022222@student.tu.kielce.pl"; 
            string filePath = @"file.json"; 

            var apiService = new ApiService();
            var jsonFileService = new JsonFileService();
            var docxModifier = new DocxModifier();

            try
            {
                string jsonData = await apiService.GetJsonAsync(apiUrl);

                MyObject myObject = MyObject.FromJson(jsonData);

                jsonFileService.SaveObjectToFile(myObject, filePath);

                Console.WriteLine("Plik JSON zosta³ zapisany.");

                docxModifier.ModifyDocx("umowa.docx", "test2.docx", myObject);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Wyst¹pi³ b³¹d: " + ex.Message);
            }
        }
    }
}
