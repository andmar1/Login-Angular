using FBTarjeta.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FBTarjeta
{
    //crea una instancia a nuestra base de datos para poder hacer Consultas y demas operaciones
    public class AplicationDBContext:DbContext
    {
        //1dbste, 2modelo, 3nombreBaseDatos 
        public DbSet<TarjetaCredito> TarjetaCredito { get; set; } //Mapeando modelos con la tabla de la DB
        public AplicationDBContext(DbContextOptions<AplicationDBContext> options):base (options)
        {

        }

    }
}
