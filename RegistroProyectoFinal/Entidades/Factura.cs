﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace RegistroProyectoFinal.Entidades
{
    public class Factura
    {
        [Key]

        public int FacturaId { get; set; }



        public string NombreCliente { get; set; }

        public DateTime Fecha { get; set; }

        public double SubTotal { get; set; }

        public double Itbis { get; set; }

        public double Total { get; set; }

        public virtual List<FacturaDetalle> Detalle { get; set; }


        public Factura()
        {
            this.Detalle = new List<FacturaDetalle>();
        }

        public void AgregarDetalle(int Id, int FacturaId, int ProductoId, double Cantidad, double Precio, double Importe)
        {
            this.Detalle.Add(new FacturaDetalle(Id, FacturaId, ProductoId, Cantidad, Precio, Importe));
        }

        public override string ToString()
        {
            return FacturaId.ToString();
        }

    }
}
