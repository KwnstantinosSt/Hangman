using HangmanGame.Models;
using Microsoft.EntityFrameworkCore;

namespace HangmanGame.Context;

public class MyDbContext : DbContext
{
    public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
    {
        
    }

    public DbSet<Library> Libraries { get; set; }
    public DbSet<Player> Players { get; set; }

}