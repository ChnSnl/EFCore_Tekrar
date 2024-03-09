using EFCore_Tekrar.Models.Enums;

namespace EFCore_Tekrar.Models.Entities
{
    public abstract class BaseEntity
    {
        public BaseEntity()
        {
            Status= DataStatus.Inserted;
            CreatedDate = DateTime.Now;
        }
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DataStatus Status { get; set; }
    }
}
