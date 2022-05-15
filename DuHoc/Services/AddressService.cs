using DuHoc.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DuHoc.Services
{
    public interface IAddressService
    {
        Task<List<Address>> GetAll();
    }
    public class AddressService : IAddressService
    {
        private readonly DuHocContext _context;

        public AddressService(DuHocContext context)
        {
            _context = context;
        }

        public async Task<List<Address>> GetAll()
        {

            return await _context.Address.ToListAsync();
        }

    }
}

