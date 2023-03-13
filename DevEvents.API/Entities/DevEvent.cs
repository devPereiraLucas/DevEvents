namespace DevEvents.API.Entities
{
    public class DevEvent
    {
        public DevEvent()
        {
            Speakers = new List<DevEventSpeaker>();
            isDeleted = false;
        }

        public Guid Id { get; set; }
        public String Title { get; set; }
        public String Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<DevEventSpeaker> Speakers { get; set; }
        public bool isDeleted { get; set; }

        public void Update(String title, String description, DateTime startDate, DateTime endDate) 
        {
            Title = title;
            Description = description;
            StartDate = startDate;
            EndDate = endDate;
        }

        public void Delete()
        {
            isDeleted = true;
        }
    }
}
