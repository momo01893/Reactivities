namespace Domain
{
    public class Activity
    {
        // public Activity(Guid id, string title, DateTime date, string description, string category, string city, string venue)
        // {
        //     this.Id = id;
        //     this.Title = title;
        //     this.Date = date;
        //     this.Description = description;
        //     this.Category = category;
        //     this.City = city;
        //     this.Venue = venue;

        // }
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string City { get; set; }
        public string Venue { get; set; }

    }
}