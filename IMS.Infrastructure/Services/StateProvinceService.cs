using IMS.Core.Entities;
using IMS.Core.Interfaces;
using System;
using System.Collections.Generic;

namespace IMS.Infrastructure.Services
{
    public class StateProvinceService : IStateProvinceService
    {
        private readonly IRepository<StateProvince> _stateProvince;

        public StateProvinceService(IRepository<StateProvince> stateProvince)
        {
            _stateProvince = stateProvince;
        }

        public void DeleteStateProvince(StateProvince stateProvince)
        {
            if (stateProvince == null)
                throw new ArgumentNullException("StateProvince");
            _stateProvince.Delete(stateProvince);
        }

        public List<StateProvince> GetAllStateProvinces()
        {
           return _stateProvince.List();
        }

        public StateProvince GetStateProvinceById(int Id)
        {
            return _stateProvince.GetById(Id);
        }

        public StateProvince InsertStateProvinces(StateProvince stateProvince)
        {
            if (stateProvince == null)
                throw new ArgumentNullException("StateProvince");
            return _stateProvince.Add(stateProvince);
        }

        public void UpdateStateProvince(StateProvince stateProvince)
        {
            if (stateProvince == null)
                throw new ArgumentNullException("StateProvince");
            _stateProvince.Update(stateProvince);
        }
    }
}
