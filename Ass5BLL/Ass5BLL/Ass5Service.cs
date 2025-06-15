
using Ass5DAL;
using System;
namespace Ass5BLL
{
    public class Ass5Service
    {
        private readonly Ass5Repository _repository;

        public Ass5Service()
        {
            _repository = new Ass5Repository();
        }

        public List<Estate> GetAllEstates()
        {
            try
            {
                return _repository.GetAllEstates();
            }
            catch (Exception ex)
            {
                return null;
            }
            
        }

        public void AddEstate(Estate estate)
        {
            _repository.AddEstate(estate);
        }

        public void DeleteEstate(int estateId)
        {
            _repository.DeleteEstate(estateId);
        }
    }
}
