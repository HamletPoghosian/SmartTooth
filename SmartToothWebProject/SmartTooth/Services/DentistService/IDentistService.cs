using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartTooth.Services.Dentist
{
   public interface IDentistService
    {
        Task<Models.Dentist> AddAsync(Models.Dentist model);

        Task EditAsync(Models.Dentist model);

        Task DeleteAsync(Models.Dentist model);

        Task<Models.Dentist> GetDentistAsync(Guid Id);

        IEnumerable<Models.Dentist> AllDentistsAsync();
    }
}
