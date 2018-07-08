using IMS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Core.Interfaces
{
   public interface IStateProvinceService
    {
        /// <summary>
        /// Delete a state province
        /// </summary>
        /// <param name="stateProvince">StateProvince</param>
        void DeleteStateProvince(StateProvince stateProvince);

        /// <summary>
        /// Gets state province
        /// </summary>
        /// <param name="Id">StateProvince identifier</param>
        /// <returns>StateProvince</returns>
        StateProvince GetStateProvinceById(int Id);

        /// <summary>
        /// Get all stateProvinces
        /// </summary>
        /// <returns>StateProvinces</returns>
        List<StateProvince> GetAllStateProvinces();

        /// <summary>
        /// Inserts a category
        /// </summary>
        /// <param name="stateProvince">Category</param>
        StateProvince InsertStateProvinces(StateProvince stateProvince);

        /// <summary>
        /// Updates the state province
        /// </summary>
        /// <param name="stateProvince">StateProvince</param>
        void UpdateStateProvince(StateProvince stateProvince);
    }
}
