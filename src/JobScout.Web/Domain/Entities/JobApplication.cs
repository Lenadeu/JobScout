using JobScout.Web.Domain.Enums;

namespace JobScout.Web.Domain.Entities
{
    public class JobApplication
    {
        public int Id { get; set; } // job applicaytion id
        public int CompanyId { get; set; } // company id for which the application is

        public int? JobPositionId { get; set; } // ? means the value can be null.
                                                // the value is null if this is an
                                                // initiative application, othervise - this
                                                // is the id of the position

        public ApplicationStatus Status { get; set; } = ApplicationStatus.NotApplied; // New application
                                                                                      // starts as NotApplied

        public string? Notes { get; set; } // optional notes

        public DateTime? AppliedOn { get; set; } //

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    }
}
