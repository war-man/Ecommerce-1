﻿using Library.DbContext.Entities;
using Library.UnitOfWork;

namespace Library.DbContext.Repositories
{
    public class SendEmailResultRepository : Repository<SendEmailResult>
    {
        public SendEmailResultRepository(ProjectXContext context) : base(context)
        {
        }
    }
}