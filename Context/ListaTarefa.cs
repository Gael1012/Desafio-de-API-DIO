using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apinew.Models;
using Microsoft.EntityFrameworkCore;

namespace apinew.Context
{
    public class ListaTarefa : DbContext
    {
          public ListaTarefa(DbContextOptions<ListaTarefa> options) : base(options)
    {
    }

    // Defina propriedades DbSet para cada modelo (tabela) que você deseja representar no banco de dados
    public DbSet<Tarefa> Tarefas { get; set; }
    }
}