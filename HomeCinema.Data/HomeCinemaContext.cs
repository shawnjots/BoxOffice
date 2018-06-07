using HomeCinema.Data;
using HomeCinema.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

public class HomeCinemaContext : DbContext
{
	public HomeCinemaContext(DbContextOptions<HomeCinemaContext> options) 
        : base(options)
	{
       
	}

    #region Entity Sets
    public DbSet<User> UserSet { get; set; }
    public DbSet<Role> RoleSet { get; set; }
    public DbSet<UserRole> UserRoleSet { get; set; }
    public DbSet<Customer> CustomerSet { get; set; }
    public DbSet<Movie> MovieSet { get; set; }
    public DbSet<Genre> GenreSet { get; set; }
    public DbSet<Stock> StockSet { get; set; }
    public DbSet<Rental> RentalSet { get; set; }
    public DbSet<Error> ErrorSet { get; set; }
    #endregion

    public virtual void Commit()
    {
        base.SaveChanges();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {//This is where you left off.
       
    }
}
