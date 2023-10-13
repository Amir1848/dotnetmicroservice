using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Common;
using FUM.BaseBusiness.Services;
using General.Common;

namespace General.Business
{
    public class StudentService : ServiceBase<Student, StudentViewModel, GeneralDbContext>, IStudentService
    {
        public StudentService(GeneralDbContext ctx): base(ctx)
        {
        }

        public override StudentViewModel FetchByID(long id)
        {
            return FetchAll().Where(p => p.ID == id).Select(propa => new StudentViewModel
            {
                ID = propa.ID,
                FirstName = propa.FirstName,
                LastName = propa.LastName,
                StudentCode = propa.StudentCode,
            }).SingleOrDefault();
        }



    }
}
