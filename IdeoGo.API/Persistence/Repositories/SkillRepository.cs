﻿using IdeoGo.API.Domain.Models;
using IdeoGo.API.Domain.Repositories;
using IdeoGo.API.Domain.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdeoGo.API.Persistence.Repositories
{
    public class SkillRepository : BaseRepository, ISkillRepository
    {
        public SkillRepository(AppDbContext context) : base(context) { }

        public async Task AddAsync(Skill skill)
        {
            await _context.Skills.AddAsync(skill);
        }

        public async Task<Skill> FindByIdAsync(int id)
        {
            return await _context.Skills.FindAsync(id);
        }

        public async Task<IEnumerable<Skill>> ListAsync()
        {
            return await _context.Skills.ToListAsync();
        }

        public void Remove(Skill skill)
        {
            _context.Skills.Remove(skill);
        }

        public void Update(Skill skill)
        {
            _context.Skills.Update(skill);
        }
    }
}
