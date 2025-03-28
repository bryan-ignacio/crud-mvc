using System;
using dashboard.Models;
using Microsoft.EntityFrameworkCore;

namespace dashboard.Data;

public class ClientesContext : DbContext
{
    public ClientesContext(DbContextOptions<ClientesContext> options) : base(options) { }

    public DbSet<Cliente> Cliente { get; set; }
}