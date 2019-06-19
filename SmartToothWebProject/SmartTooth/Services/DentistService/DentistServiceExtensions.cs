using Microsoft.Extensions.DependencyInjection;
using SmartTooth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartTooth.Services.Dentist
{
    public static class DentistServiceExtensions
    {
        public static IServiceCollection AddDentist(this IServiceCollection serviceColection)
        {
            return serviceColection.AddScoped<IDentistService, DentistService>();
        }
    }
}
