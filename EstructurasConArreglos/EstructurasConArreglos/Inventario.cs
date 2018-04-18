using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasConArreglos
{
    class Inventario
    {
        private Producto[] _pro;
      




        public void agregarProducto(Producto pro)
        {

            for (int i = _pro.Length - 1; i >= 0 + 1; i--)
            {
                _pro[i] = _pro[i - 1];
            }
            _pro[0] = pro;
        }

        public Producto buscar(int cod)
        {
            for (int i = 0; i < _pro.Length-1; i++)
            {
                if (_pro[i].codigo == cod)
                {
                    return _pro[i];
                }
               
            }

            return null;
        }

        public void eliminarProducto(int cod)
        {
            for(int i = 0; i < _pro.Length -1; i++)
            {
                if (_pro[i].codigo == cod)
                {
                    _pro[i] = null;
                }
                   
            }
        }

     



     

    }
}
