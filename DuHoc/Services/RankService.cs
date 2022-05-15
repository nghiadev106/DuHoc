using DuHoc.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DuHoc.Services
{
    public interface IRankService
    {
        Task<List<Rank>> GetAll();
    }
    public class RankService : IRankService
    {
        private readonly DuHocContext _context;

        public RankService(DuHocContext context)
        {
            _context = context;
        }

        public async Task<List<Rank>> GetAll()
        {

            return await _context.Rank.ToListAsync();
        }

    }
}

