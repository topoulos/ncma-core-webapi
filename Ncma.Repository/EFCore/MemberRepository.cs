﻿namespace Ncma.Repository.EFCore
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;
    using Models;

    public class MemberRepository : BaseRepository<Member>, IMemberRepository
    {
        public async Task<List<Member>> GetActiveMembersAsync()
        {
            return await _context.Members.Where(x => x.IsActive).ToListAsync();
        }

        public async Task<List<Member>> GetInactiveMembersAsync()
        {
            return await _context.Members.Where(x => !x.IsActive).ToListAsync();
        }

        public async Task<List<Member>> GetMemberListAsync()
        {
            return await _context.Members.Include(x => x.Dojo).ToListAsync();
        }

        public async Task<List<Member>> SearchAsync(string searchTerm)
        {
            return await _context.Members
                .Where(x => x.FirstName.Contains(searchTerm) ||
                            x.LastName.Contains(searchTerm) ||
                            x.Dojo.Name.Contains(searchTerm) ||
                            x.State.StateAbbrev.Contains(searchTerm) ||
                            x.Dojo.DojoInstructors.Any(y => y.Instructor.FirstName.Contains(searchTerm)) ||
                            x.Dojo.DojoInstructors.Any(y => y.Instructor.FirstName.Contains(searchTerm)) ||
                            x.RankText.Contains(searchTerm) ||
                            x.Id.ToString().Contains(searchTerm) ||
                            x.Country.Name.Contains(searchTerm) ||
                            x.City.Contains(searchTerm))
                .ToListAsync();
        }

        public MemberRepository(NcmaContext context) : base(context)
        {
        }
    }
}