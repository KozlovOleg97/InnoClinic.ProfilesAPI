namespace InnoClinic.ProfilesAPI.Core.Entities.Common
{
    public class BaseEntityProfile
    {
        public Guid Id { get; set; }
        public Guid AccountId { get; set; }
        public Guid PhotoId { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string MiddleName { get; set; }

        //public string GetFullName()
        //{
        //    return $"{FirstName} {LastName} {MiddleName}";
        //}
    }
}
