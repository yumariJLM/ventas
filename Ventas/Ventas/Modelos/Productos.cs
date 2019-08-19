﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas.Modelos
{
    public class Productos
    {

        public int Id { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public  int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }

        public Productos(int id, string descripcion, double precio, Categoria categoria)
        {
            Id = id;
            Descripcion = descripcion;
            Precio = precio;
            Categoria = categoria;
            CategoriaId = categoria.Id;


        }
    }
}
