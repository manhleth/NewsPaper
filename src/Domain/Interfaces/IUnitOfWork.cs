﻿using NewsPaper.src.Infrastructure.Repositories;

namespace NewsPaper.src.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        // repository
        NewsRepository News { get; }
        UserRepository User { get; }
        SavedRepository Saved { get; }
        CategoryRepository Category { get; }
        // transaction
        Task<int> SaveChangesAsync();
        Task BeginTransactionAsync();
        Task CommitTransactionAsync();
        Task RollbackTransactionAsync();
    }
}
