﻿using ParkingSlotAPI.Database;
using ParkingSlotAPI.Entities;
using ParkingSlotAPI.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkingSlotAPI.Repository
{
    public interface IParkingRepository
    {
        IEnumerable<Carpark> GetCarparks(CarparkResourceParameters carparkResourceParameters);
        Carpark GetCarpark(Guid carparkId);
        void AddCarpark(Carpark carpark);
        void DeleteCarpark(Carpark carpark);
    }

    public class ParkingRepository : IParkingRepository
    {
        private ParkingContext _context;
        public ParkingRepository(ParkingContext context)
        {
            _context = context;
        }

        public IEnumerable<Carpark> GetCarparks(CarparkResourceParameters carparkResourceParameters)
        {
            return _context.Carparks
                .OrderBy(a => a.CarparkId)
                .Skip(carparkResourceParameters.PageSize
                * (carparkResourceParameters.PageNumber - 1))
                .Take(carparkResourceParameters.PageSize)
                .ToList();
        }

        public Carpark GetCarpark(Guid carparkId)
        {
            return _context.Carparks.FirstOrDefault(a => a.Id == carparkId);
        }

        public Carpark GetCarparkById(string carparkId)
        {
            return _context.Carparks.FirstOrDefault(a => a.CarparkId == carparkId);
        }

        public void AddCarpark(Carpark carpark)
        {
            carpark.Id = Guid.NewGuid();
            _context.Carparks.Add(carpark);
        }

        public void DeleteCarpark(Carpark carpark)
        {
            _context.Carparks.Remove(carpark);
        }
    }
}
