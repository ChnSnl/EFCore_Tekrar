namespace EFCore_Tekrar.Models.Entities
{
    public class AppUserProfile : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //RelationalProperties

        public virtual AppUser AppUser { get; set; }
    }
}
