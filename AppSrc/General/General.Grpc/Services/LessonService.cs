using General.Common;
using General.Grpc.Protos;
using Grpc.Core;
using Lesson = General.Grpc.Protos.Lesson;

namespace General.Grpc.Services
{
    public class LessonsService: Lesson.LessonBase
    {
        private readonly ILessonService _lessonService;
        public LessonsService(ILessonService lessonService) {
            _lessonService = lessonService;
        }

        public override Task<AllLessonInfos> GetLessonTitles(LessonTitleReq request, ServerCallContext context)
        {
            var result = _lessonService.FetchLessonsWithTitles(request.LessonIds.ToHashSet()).Select(p => new LessonInfo()
            {
                Id = p.Key,
                Title = p.Value
            }).ToList();


            return Task.FromResult(new AllLessonInfos()
            {
                Lessons = { result }
            });
        }
    }
}
