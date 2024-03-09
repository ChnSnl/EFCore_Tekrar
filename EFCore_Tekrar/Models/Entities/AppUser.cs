namespace EFCore_Tekrar.Models.Entities
{
    public class AppUser : BaseEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        //Relational Properteies

        public virtual AppUserProfile Profile { get; set; }
        public virtual List<Order> Orders { get; set; }
    }
}
