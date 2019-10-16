using System;
using System.Collections.Generic;

namespace StudentMVC.Models
{
    public class GroupRepository : IGroupRepository
    {
        private readonly AppDbContext appDbContext;

        public GroupRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public IEnumerable<Group> GetAll => appDbContext.Groups;
    }
}
