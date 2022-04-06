using System;
using System.Threading.Tasks;
using UKParliament.CodeTest.Services.Models;

namespace UKParliament.CodeTest.Web.Controllers
{
    public interface IBookingService
    {
        Task<BookingInfo> GetAsync(int bookingId);
    }

    public class BookingService : IBookingService
    {
        public BookingService()
        {

        }

        public async Task<BookingInfo> GetAsync(int bookingId)
        {
            throw new NotImplementedException();
        }
    }
}