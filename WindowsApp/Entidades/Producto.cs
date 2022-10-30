﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp.Entidades
{
    internal class Producto
    {
        public string Nombre { get; set; }  
        public string Descripcion { get; set; } 
        public decimal PrecioCosto { get; set; }    
        public double Margen { get; set; }
        public double IVA { get; set; }
        public decimal PrecioBruto 
        {
            get
            {
                return PrecioBruto;
            }
        }
        public decimal PrecioVenta 
        {
            get
            {
                return PrecioVenta;
            } 
        }
        public string Proveedor { get; set; }
        public string Categoria { get; set; }
        public string SubCategoria { get; set; }
        
    }
}
