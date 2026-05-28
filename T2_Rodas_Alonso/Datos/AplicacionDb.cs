using System.Collections.Generic;
using T2_Rodas_Alonso.Models;
using Microsoft.EntityFrameworkCore;

namespace T2_Rodas_Alonso.Datos
{
    public class AplicacionDb : DbContext
    {
        
        public AplicacionDb(DbContextOptions<AplicacionDb> options)
            : base(options)
        {
        }

        public DbSet<Distribuidor> Distribuidores { get; set; }
    }

}

