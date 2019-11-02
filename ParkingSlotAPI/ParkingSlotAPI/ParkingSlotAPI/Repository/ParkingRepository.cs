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
        PagedList<Carpark> GetCarparks(CarparkResourceParameters carparkResourceParameters);
        Carpark GetCarpark(Guid carparkId);
        IEnumerable<Carpark> GetAllCarparks();
        void AddCarpark(Carpark carpark);
        void DeleteCarpark(Carpark carpark);
        void UpdateCarpark(Carpark carpark);
        void UpdateCarparks(List<Carpark> carparks);
        void SaveChanges();
    }

    public class ParkingRepository : IParkingRepository
    {
        private ParkingContext _context;
        public ParkingRepository(ParkingContext context)
        {
            _context = context;
        }

        public IEnumerable<Carpark> GetAllCarparks()
        {
            return _context.Carparks.OrderBy(a => a.CarparkId);
        }

        public PagedList<Carpark> GetCarparks(CarparkResourceParameters carparkResourceParameters)
        {
            var collectionBeforePaging = _context.Carparks
                .OrderBy(a => a.CarparkId).AsQueryable();

            // filter agency type
            if (!string.IsNullOrEmpty(carparkResourceParameters.AgencyType))
            {
                var agencyTypeForWhereClause = carparkResourceParameters.AgencyType.Trim();

                if (agencyTypeForWhereClause == "HDB" || agencyTypeForWhereClause == "LTA" || agencyTypeForWhereClause == "URA")
                {
                    collectionBeforePaging = collectionBeforePaging.Where(a => a.AgencyType == agencyTypeForWhereClause);
                }
                else
                {
                    throw new AppException($"Cannot find the specified agency type {carparkResourceParameters.AgencyType}.");
                }
            }

            return PagedList<Carpark>.Create(collectionBeforePaging, carparkResourceParameters.PageNumber, carparkResourceParameters.PageSize);
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

        public void UpdateCarpark(Carpark carpark)
        {
            _context.Carparks.Update(carpark);
        }

        public void UpdateCarparks(List<Carpark> carparks)
        {
            _context.Carparks.AddRange(carparks);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void DeleteCarpark(Carpark carpark)
        {
            _context.Carparks.Remove(carpark);
        }
    }
}