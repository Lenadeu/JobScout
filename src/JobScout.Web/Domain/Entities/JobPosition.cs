using JobScout.Web.Domain.Enums;

namespace JobScout.Web.Domain.Entities
{
    public class JobPosition
    {
        public int Id { get; set; } // Id of the job position
        public int CompanyId { get; set; } // Connects the vacancy to a company

        public string Title { get; set; } = string.Empty;

        public string JobUrl { get; set; } = string.Empty;

        public string? Description { get; set;  } // optional - might be null

        public bool isOpen { get; set; } = true;

        public GermanLanguageLevel GermanLanguageLevel { get; set; } = GermanLanguageLevel.NotSpecified;

        public bool EnglishAccepted { get; set; } // false without initialization

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime UpdateAt { get; set;  } = DateTime.UtcNow;

    }
}
