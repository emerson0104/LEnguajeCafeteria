﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RegistroProyectoFinal.Entidades;
using System.Data.Entity;

namespace RegistroProyectoFinal.DAL
{
    public class Contexto : DbContext
    {


        public DbSet<Factura> Factura { get; set; }

   

        public DbSet<Producto> Producto { get; set; }

 


        public Contexto() : base("ConStr")
        {

        }
    }
}