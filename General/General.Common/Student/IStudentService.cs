﻿using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.Common
{
    public interface IStudentService: IServiceBase<Student, StudentViewModel>
    {
        void AddStudentToCourse(List<StudentCourse> studentCourses);
    }
}
