using HangmanGame.Models;
using Microsoft.EntityFrameworkCore;

namespace HangmanGame.Context;

public class DbContext : Microsoft.EntityFrameworkCore.DbContext
{
    public DbContext(DbContextOptions<DbContext> options) : base(options)
    {
        
    }

    public DbSet<Library> Libraries { get; set; }
    public DbSet<Player> Players { get; set; }

}