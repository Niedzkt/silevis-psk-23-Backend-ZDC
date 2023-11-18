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
            [BindProperty]
            public string CompanyAddress { get; set; }
            [BindProperty]
            public string KrsNumber { get; set; }
            [BindProperty]
            public string NipNumber { get; set; }
            [BindProperty]
            public string CompanyCeo { get; set; }
            [BindProperty]
            public string InternDateSelect { get; set; }
            [BindProperty]
            public string startDateOfIntern { get; set; }
            [BindProperty]
            public string endDateOfIntern { get; set; }
        }
    }
}
