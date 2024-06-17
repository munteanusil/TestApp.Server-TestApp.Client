using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TestApp.DataAccess.Repositories;

namespace TestApp.DataAccess;

public class UnitOfWork : IUnitOfWork
{
    private readonly INoteRepository noteRepository;
    private readonly IProductRepository productRepository;

    public UnitOfWork(INoteRepository noteRepository, IProductRepository productRepository)
    {
        this.noteRepository = noteRepository;
        this.productRepository = productRepository;
    }

    public TRepository GetRepository<TRepository>()
    {
        if (typeof(INoteRepository).IsAssignableFrom(typeof(TRepository)))
            return (TRepository)noteRepository;
        else if (typeof(IProductRepository).IsAssignableFrom(typeof(TRepository)))
            return (TRepository)productRepository;
        else
            throw new Exception("repository not found!");
    }
}
