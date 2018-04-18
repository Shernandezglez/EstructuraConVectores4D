using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasConArreglos
{
    class Producto
    {
        private int _codigo;
        private int _cantidad;
        private int _costo;

        private string _nombre;
        private string _desc;

        public Producto(int cd,int cnt,int cst, string nm, string desc)
        {
            _codigo = cd;
            _cantidad = cnt;
            _costo = cst;
            _nombre = nm;
            _desc = desc;
        }

        public int getCodigo { get { return _codigo; } }
        public int getCantidad { get { return _cantidad; } }
        public int getCosto { get { return _costo; } }
        public string getNombre { get { return _nombre; } }
        public string getDesc { get { return _desc; } }

    }
}
