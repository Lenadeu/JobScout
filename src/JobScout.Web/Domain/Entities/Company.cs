using JobScout.Web.Domain.Enums;

namespace JobScout.Web.Domain.Entities
{
    public class Company //one company in the app
    {
        public int Id { get; set; } // Database identifier
        public string Name { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public string? WebsiteUrl { get; set; } // optional - allowed to be null
        public string? CareerPageUrl {  get; set; } //optional
        public string? TechnologyNotes { get; set; } //optional
        public InitiativeApplicationPossibility InitiativeApplicationPossibility
        {
            get; set;
        } = InitiativeApplicationPossibility.Unknown;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set;  } = DateTime.UtcNow;

    }
}
