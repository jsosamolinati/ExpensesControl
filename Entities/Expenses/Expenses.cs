using System;
using System.ComponentModel.DataAnnotations;

namespace Expenses.Entities.Expenses
{
    public class Expenses
    {
        public int idExpenses { get; set; }
        [Required]
        public int idTypeExpenses { get; set; }
        [Required]
        public int idUser { get; set; }
        public string code { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public decimal expensesMount { get; set; }
        public string description { get; set; }
        public DateTime dateExpenses { get; set; }
    }
}
