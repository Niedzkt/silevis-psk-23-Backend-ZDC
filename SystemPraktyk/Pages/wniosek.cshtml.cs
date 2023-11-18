using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace SystemPraktyk.Pages
{
    public class wniosekModel : PageModel
    {
        public void OnGet()
        {
        }
        public IActionResult OnPostSubmit(FormData formData)
        {
            string jsonString = JsonConvert.SerializeObject(formData, Formatting.Indented);
            string filePath = "plik.json";
            System.IO.File.WriteAllText(filePath, jsonString);

            return new JsonResult(new { status = "success", data = formData });
        }

        public class FormData
        {
            public string CompanyAddress { get; set; }
            public string KrsNumber { get; set; }
            public string NipNumber { get; set; }
            public string CompanyCeo { get; set; }
            public string InternDateSelect { get; set; }
            public string StartDateOfIntern { get; set; }
            public string EndDateOfIntern { get; set; }
        }
    }
}
