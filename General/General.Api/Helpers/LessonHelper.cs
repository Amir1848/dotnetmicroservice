using FUM.BaseApi.Helper;
using General.Api.Protos;
using General.Common;
using Google.Protobuf.Collections;
using Grpc.Core;

namespace General.Api
{
    public class LessonHelperService : LessonHelper.LessonHelperBase
    {
        ILessonService service;

        public LessonHelperService(ILessonService service) 
        {
            this.service = service;
        }

        public override Task<GetLessonTitlesRes> GetLessonTitles(GetLessonTitlesReq request, ServerCallContext context)
        {
            var idTitleDic = this.service.FetchLessonsWithTitles(request.Ids);
            var idTitles = new RepeatedField<LessonIdWithTitle>();
            foreach (var item in idTitleDic)
            {
                idTitles.Add(new LessonIdWithTitle()
                {
                    Id = item.Key,
                    Title = item.Value
                });
            }

            return Task.FromResult(new GetLessonTitlesRes()
            {
                Titles = { idTitles },
            });
        }
    }
}
