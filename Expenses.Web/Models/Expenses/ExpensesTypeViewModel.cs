using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Expenses.Web.Models.Expenses
{
    public class ExpensesTypeViewModel
    {
        public int idTypeExpenses { get; set; }
        public string nameTypeExpenses { get; set; }
        public string descriptionTypeExpenses { get; set; }
        public bool conditionTypeExpenses { get; set; }
    }
}
