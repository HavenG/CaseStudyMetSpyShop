﻿namespace CoreCourse.Spyshop.Domain.Catalog
{
    public class Product
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public string PhotoUrl { get; set; }

        public int? SortNumber { get; set; }

        public Category Category { get; set; }
    }
}
