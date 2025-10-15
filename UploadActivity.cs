namespace Workflow_Engine
{
    public class UploadActivity 
    {
        public string _name { get; private set; }
        public string _description { get; private set; }
        public DateTime _time { get; private set; }

        //Constructor
        public UploadActivity(string Name, string Description, DateTime time)
        {
            _description = Description;
            _name = Name;
            _time = time;
        }

        public void uploadAction() 
        {
            Console.WriteLine("You have uploaded the action");
        }
    }
}