using Calculation.Grpc.Protos;
using Grpc.Net.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations.Business.Helpers
{
    public class StudentHelper : Student.StudentClient
    {
        public StudentHelper(GrpcChannel channel) : base(channel) {}
    }
}
