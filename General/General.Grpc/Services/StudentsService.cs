using General.Grpc.Protos;
using Grpc.Core;

namespace General.Grpc.Services
{
    public class StudentsService : Student.StudentBase
    {
        public override Task<AllTeachingAssistants> GetAllTeachingAssistants(GetAllTeachingAssistantsReq request, ServerCallContext context)
        {
            var result = Task.FromResult(new AllTeachingAssistants()
            {
                TeachingAssistants = {new TeachingAssistant(){
                    Id = 1,
                    StudentCode = "9812762383"
                }}
            });

            return result;
        }
    }
}
