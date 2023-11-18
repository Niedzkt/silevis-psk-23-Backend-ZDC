using Xceed.Words.NET;

namespace SystemPraktyk
{
    public class DocxModifier
    {
        public void ModifyDocx(string sourceDocxPath, string destinationDocxPath, MyObject data)
        {
            using (DocX document = DocX.Load(sourceDocxPath))
            {
                document.ReplaceText("{firstName}", data.FirstName);
                document.ReplaceText("{lastName}", data.LastName);
              //  document.ReplaceText("{Id}", data.Id);
                document.ReplaceText("{email}", data.Email);
                document.ReplaceText("{studentNumber}", data.StudentNumber);
                //document.ReplaceText("{StudentProgrammes:Id}");
                //document.ReplaceText("{StudentProgrammes:Id}");


                document.SaveAs(destinationDocxPath);
            }
        }
    }
}
