using CRMApp1.Models.CRMApp;

namespace CRMApp1.CRMApp
{
    public interface ICRMAppService
    {
        Task<List<MeetingsTasksType>> GetMeetingsTasksList();
    }
}
