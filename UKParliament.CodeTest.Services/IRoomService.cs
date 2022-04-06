using System;
using System.Threading.Tasks;
using UKParliament.CodeTest.Services.Models;

namespace UKParliament.CodeTest.Web.Controllers
{
    public interface IRoomService
    {
        Task<RoomInfo> GetAsync(int roomId);
    }

    public class RoomService : IRoomService
    {
        public RoomService()
        {
            
        }

        public async Task<RoomInfo> GetAsync(int roomId)
        {
            throw new NotImplementedException();
        }
        
    }
}