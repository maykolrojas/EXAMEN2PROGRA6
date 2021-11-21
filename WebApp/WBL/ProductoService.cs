using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BD;
using Entity;

namespace WBL
{
    public interface IProductoService
    {
        Task<DBEntity> Create(ProductoEntity entity);
        Task<DBEntity> Delete(ProductoEntity entity);
        Task<IEnumerable<ProductoEntity>> Get();
        Task<ProductoEntity> GetById(ProductoEntity entity);
        Task<DBEntity> Update(ProductoEntity entity);

        Task<IEnumerable<ProductoEntity>> GetLista();
    }

    public class ProductoService : IProductoService
    {
        private readonly IDataAccess sql;

        public ProductoService(IDataAccess _sql)
        {
            sql = _sql;
        }

        #region MetodosCrud

        //Metodo Get


        public async Task<IEnumerable<ProductoEntity>> Get()
        {
            try
            {
                var result = sql.QueryAsync<ProductoEntity>("db.ProductoObtener", "IdProducto");

                return await result;
            }
            catch (Exception)
            {

                throw;
            }


        }

        public async Task<IEnumerable<ProductoEntity>> GetLista()
        {

            try
            {
                var result = sql.QueryAsync<ProductoEntity>("ProductoLista");

                return await result;
            }
            catch (Exception )
            {

                throw;
            }
        }

        //Metodo GetById
        public async Task<ProductoEntity> GetById(ProductoEntity entity)
        {
            try
            {
                var result = sql.QueryFirstAsync<ProductoEntity>("db.ProductoObtener", new
                { entity.IdProducto });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Metodo Create

        public async Task<DBEntity> Create(ProductoEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("db.ProductoInsertar", new
                {
                   
                    
                    entity.NombreProducto,
                    entity.PrecioProducto
                    



                });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Metodo Update
        public async Task<DBEntity> Update(ProductoEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("db.ProductoActualizar", new
                {
                    entity.IdProducto,
                    entity.NombreProducto,
                    entity.PrecioProducto

                });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Metodo Delete
        public async Task<DBEntity> Delete(ProductoEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("db.ProductoEliminar", new
                {
                    entity.IdProducto,



                });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }

       // Task<IEnumerable<ProductoEntity>> IProductoService.Get()
       // {
       //     throw new NotImplementedException();
      //  }






        #endregion



    }
}












