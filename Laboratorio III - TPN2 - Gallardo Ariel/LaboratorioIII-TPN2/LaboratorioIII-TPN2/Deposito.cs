using System;
using System.Collections.Generic;
using System.Text;

namespace LaboratorioIII_TPN2
{
    class Deposito
    {
        public List<Articulo> articulos { get; set; }
        public String nombre { get; set; }
        public String domicilio { get; set; }
        public List<Articulo> articulosBajoStock()
        {
            List<Articulo> tempArticulos = new List<Articulo>();
            articulos.ForEach(delegate (Articulo articulo) {
                if(articulo.stockTotal <= articulo.stockMinimo)
                {
                    tempArticulos.Add(articulo);
                }
            });
            return tempArticulos;
        }
    }
}
