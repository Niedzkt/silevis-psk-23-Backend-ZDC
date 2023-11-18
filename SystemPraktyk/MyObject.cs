using Newtonsoft.Json;

namespace SystemPraktyk
{
    public class MyObject
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int StaffStatus { get; set; }
        public int StudentStatus { get; set; }
        public string Email { get; set; }
        public string StudentNumber { get; set; }
        public List<StudentProgrammes> StudentProgrammes { get; set; }

        public static MyObject FromJson(string jsonData)
        {
            return JsonConvert.DeserializeObject<MyObject>(jsonData);
        }
    }
    public class StudentProgrammes
    {
        public string Id { get; set; }
        public string Programme { get; set; }
    }
}
