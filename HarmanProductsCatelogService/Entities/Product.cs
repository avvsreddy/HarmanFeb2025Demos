﻿namespace HarmanProductsCatelogService.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Category { get; set; }
        public string Brand { get; set; }
        public bool IsAvailable { get; set; }
        public string Country { get; set; }
    }
}
