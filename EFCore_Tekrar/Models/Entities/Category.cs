﻿namespace EFCore_Tekrar.Models.Entities
{
    public class Category : BaseEntity
    {

        public string CategoryName { get; set; }
        public string Description { get; set; }

        //Relational Properties

        public virtual List<Product> Products { get; set; }
    }
}
