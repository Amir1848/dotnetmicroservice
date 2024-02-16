using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations.Common
{
    public interface ICalculationService
    {
        List<StudentViewModel> GetTeachingAssistantStudents(long termID);

        List<StudentSalaryInfo> CalculateSalaries(long termId);
    }
}
