﻿namespace C02.CallingStoredProcedure.Entities
{
    public class Department
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public decimal? CheckCost { get; set; }

        public ICollection<Employee> Employees { get; set; } = [];

    }
}
