using CRMApp1.Models.CRMApp;

namespace CRMApp1.CRMApp
{
    public class MockCRMAppService : ICRMAppService
    {
        public Task<List<MeetingsTasksType>> GetMeetingsTasksList()
        {
            return Task.FromResult<List<MeetingsTasksType>>(new());
        }
    }
}
