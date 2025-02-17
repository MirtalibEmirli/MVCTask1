﻿namespace Task1.Entities.Abstracts
{
    public abstract class BaseItem
    {
        public int Price { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Img { get; set; }
    }
}
