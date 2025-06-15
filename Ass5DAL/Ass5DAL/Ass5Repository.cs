using Ass5DAL;
using Microsoft.EntityFrameworkCore;
using System;

namespace Ass5DAL
{
    public class Ass5Repository
    {
        private readonly Ass5Context _context;
        public Ass5Repository()
        {
            _context = new Ass5Context();
            _context.EnsureDatabaseCreated();
        }

        public List<Estate> GetAllEstates()
        {
            try
            {
                return _context.Estates.Include(e => e.Address).ToList();
            }
            catch (Exception ex)
            {
                // Consider logging the exception
                return null;
            }
        }

        public void AddEstate(Estate estate)
        {
            _context.Estates.Add(estate);
            _context.SaveChanges();
        }

        public void DeleteEstate(int estateId)
        {
            try
            {
                // First, find the estate with its address included
                var estate = _context.Estates
                    .Include(e => e.Address)
                    .FirstOrDefault(e => e.EstateId == estateId);

                if (estate != null)
                {
                    // Remove the address first if it exists
                    if (estate.Address != null)
                    {
                        _context.Addresses.Remove(estate.Address);
                    }

                    // Then remove the estate
                    _context.Estates.Remove(estate);
                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw; // Re-throw to handle in upper layers
            }
        }
    }
}

