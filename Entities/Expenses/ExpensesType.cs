using System.ComponentModel.DataAnnotations;

namespace Expenses.Entities.Expenses
{
    public class ExpensesType
    {
        public int idTypeExpenses { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "The name must have between 3 and 50 characters")]
        public string nameTypeExpenses { get; set; }
        public string descriptionTypeExpenses { get; set; }
        public bool conditionTypeExpenses { get; set; }
    }
}
