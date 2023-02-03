﻿using DocumentFormat.OpenXml.Office2010.Excel;

namespace WiredBrainCoffee.StorageApp.Entities
{
    public class Organization: EntityBase
    {
        public string? Name { get; set; }

        public override string ToString() => $"Id: {Id}, Name: {Name}";
    }
}