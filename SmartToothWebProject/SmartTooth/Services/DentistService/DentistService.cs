using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SmartTooth.Data;
using SmartTooth.Models;

namespace SmartTooth.Services.Dentist
{
    public class DentistService : IDentistService
    {
        private ApplicationDbContext _context;

        public DentistService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Models.Dentist> AddAsync(Models.Dentist model)
        {
            var entity = new Models.Dentist
            {
                Id = model.Id,
                Description = model.Description,
                FacebookUrl = model.FacebookUrl,
                LastName = model.LastName,
                Email = model.Email,
                Name = model.Name,
                Number = model.Number,
                Specialization = model.Specialization
            };
            await _context.DentistTable.AddAsync(entity);
            await _context.SaveChangesAsync();
            return model;
        }

        public async Task DeleteAsync(Models.Dentist model)
        {
            var entity = _context.DentistTable.SingleOrDefault(e => e.Id == model.Id);
            _context.DentistTable.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task EditAsync(Models.Dentist model)
        {
            var entity = new Models.Dentist
            {
                Id = model.Id,
                Description = model.Description,
                FacebookUrl = model.FacebookUrl,
                LastName = model.LastName,
                Email = model.Email,
                Name = model.Name,
                Number = model.Number,
                Specialization = model.Specialization
            };
            _context.Update(entity);
            await  _context.SaveChangesAsync();
            
        }

        public async Task<Models.Dentist> GetDentistAsync(Guid Id)
        {
            var entity =await _context.DentistTable.SingleOrDefaultAsync(e => e.Id == Id);
            return entity;
        }

        public IEnumerable<Models.Dentist> AllDentistsAsync()
        {
          var entity =  _context.DentistTable.AsEnumerable();
          return entity;
        }

    }
}
