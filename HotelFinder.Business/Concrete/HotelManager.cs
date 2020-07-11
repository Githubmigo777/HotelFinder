using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using HotelFinder.Business.Abstract;
using HotelFinder.DataAccess.Abstract;
using HotelFinder.DataAccess.Concrete;
using HotelFinder.Entities;

namespace HotelFinder.Business.Concrete
{
    public class HotelManager : IHotelService
    {
        private readonly IHotelRepository _hotelRepository;

        public HotelManager(IHotelRepository hotelRepository)
        {
            _hotelRepository = hotelRepository;
        }

        public async Task<List<Hotel>> GetAllHotels()
        {
           return await _hotelRepository.GetAllHotels();
        }

        public async Task<Hotel> GetHotelById(int id)
        {
            if (id>0)
            {
                return await _hotelRepository.GetHotelById(id);
            }

            throw new Exception("Id can not be less than 1");
        }

        public async Task<Hotel> GetHotelByName(string name)
        {
            if (name != null)
            {
                return await _hotelRepository.GetHotelByName(name);
            }

            throw new Exception("Name can not be null");
        }

        public async Task<Hotel> CreateHotel(Hotel hotel)
        {
           return await _hotelRepository.CreateHotel(hotel);
        }

        public async Task<Hotel> UpdateHotel(Hotel hotel)
        {
            return await _hotelRepository.UpdateHotel(hotel);
        }

        public async Task DeleteHotel(int id)
        {
           await _hotelRepository.DeleteHotel(id);
        }
    }
}
