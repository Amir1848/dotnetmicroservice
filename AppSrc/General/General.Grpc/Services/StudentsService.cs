using General.Common;
using General.Grpc.Protos;
using Grpc.Core;
using Student = General.Grpc.Protos.Student;

namespace General.Grpc.Services
{
    public class StudentsService : Student.StudentBase
    {
        private IStudentService _studentService;

        public StudentsService(
            IStudentService studentService) 
        {
            _studentService = studentService;
        }

        public override Task<AllTeachingAssistants> GetAllTeachingAssistants(GetAllTeachingAssistantsReq request, ServerCallContext context)
        {
            var tas = _studentService.GetTeachingAssistants(request.TermId);
            var result = tas.Select(p => new TeachingAssistant
            {
                Id = p.Id,
                CourseTitle = p.CourseName,
                StudentCode = p.StudentCode,
                StudentLastName = p.LastName,
                StudentName = p.FirstName,
                TermTitle = p.TermTitle,
                LessonRef = p.LessonRef
            });

            return Task.FromResult(new AllTeachingAssistants
            {
                TeachingAssistants = { result }
            });
        }
    }
}
