using Calculations.Grpc.Protos;
using Grpc.Net.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations.Business.Helpers
{
    public class LessonHelper : Lesson.LessonClient
    {
        public LessonHelper(GrpcChannel channel) : base(channel) { }
    }
}
