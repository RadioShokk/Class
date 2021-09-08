using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructure.Productos
{
    public class ProductoModel
    {
        private producto[] productos;
        #region CRUD
        public void Add(producto p)
        {
            Add(p, ref productos);
        }
        public Update(producto p)
        {
            if(p==null)
            {
                throw new ArgumentException("El producto no puede ser null");
            }
            int index = GetIndexById(p.Id);
            if(index<=0)
            {
                throw new Exception($"El producto con id {p.Id} no se encuentra");
            }
            productos[index] = p;
            return index;
        }
        public bool Delete(producto p)
        {
            if (p == null)
            {
                throw new ArgumentException("El producto no puede ser null");
            }
            int index = GetIndexById(p.Id);
            if (index <= 0)
            {
                throw new Exception($"El producto con id {p.Id} no se encuentra");
            }

            if(index==productos.Length-1)
            {
                productos[index] = productos[productos.Length - 1];

            }
            producto[]tmp=new producto[productos.Length-1]
                Array.Copy(productos, tmp, tmp.Length);
            productos = tmp;
            return productos.Length == tmp.Length;
        }
        public producto[] GetAll()
        {
            return productos;
        }
        #endregion
        public void GetAll()
        {
            return productos;
        }
        #region Private Method
        private void Add(producto p, ref producto[] pds)
        {
            if (pds == null)
            {
                pds = new producto[1];
                pds[pds.Length - 1] = p;
                return;
            }

            producto[] tmp = new producto[pds.Length + 1];
            Array.Copy(pds, tmp,pds.Length);
            tmp[tmp.Length - 1] = p;
            pds = tmp;
        }
        //Metodo para encontrar ID//
        private int GetIndexById(int id)
        {
            if(id<=0)
            {
                throw new ArgumentException("El id no puede ser negativo o cero");
            }
            int index = int.MinValue, i = 0;
            if(productos==null)
            {
                return index;
            }
            foreach(producto p in productos)
            {
                if(p.Id==id)
                {
                    index = i;
                    break;
                }
                i++;
            }
        }
        #endregion
        #region Queries
        public producto GetProductoById(int id)
        {
            if(id<=0)
            {
                throw new ArgumentException($"El Id: {id} no es valido");
            }
            int index = GetIndexById(id);
            return index <= 0 ? null : productos[index];
        }
        #endregion
    }
}
