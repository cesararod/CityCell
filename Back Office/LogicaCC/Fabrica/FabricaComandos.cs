using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using LogicaCC.Comandos;
using LogicaCC.Comandos.Promocion;
using LogicaCC.Comandos.Usuario;
using LogicaCC.Comandos.Marca;
using LogicaCC.Comandos.Producto;

namespace LogicaCC.Fabrica
{
    public class FabricaComandos
    {
        #region Categoria

        /// <summary>
        /// metodo para crear comando que permite agregar una categoria
        /// </summary>
        /// <param name="categoria">entidad sobre la cual se va a trabajar el comando</param>
        /// <returns></returns>
        public static Comando<bool> CrearAgregarCategoria(Entidad categoria)
        {
            Comando<bool> respuesta = new ComandoAgregarCategoria(categoria);
            return respuesta;
        }

        /// <summary>
        /// metodo para crear comando que permite consultar todas las Categorias
        /// </summary>
        /// <returns></returns>
        public static Comando<List<Entidad>> CrearConsultarTodosCategoria()
        {
            Comando<List<Entidad>> respuesta = new ComandoConsultarCategoria();
            return respuesta;
        }

        #endregion

        #region Marca

        /// <summary>
        /// metodo para crear comando que permite agregar una marca
        /// </summary>
        /// <param name="marca">entidad sobre la cual se va a trabajar el comando</param>
        /// <returns></returns>
        public static Comando<bool> CrearAgregarMarca(Entidad marca)
        {
            Comando<bool> respuesta = new ComandoAgregarMarca(marca);
            return respuesta;
        }

        /// <summary>
        /// metodo para crear comando que permite consultar todas las Categorias
        /// </summary>
        /// <returns></returns>
        public static Comando<List<Entidad>> CrearConsultarTodosMarca()
        {
            Comando<List<Entidad>> respuesta = new ComandoConsultarMarca();
            return respuesta;
        }

        #endregion

        #region Producto

        /// <summary>
        /// metodo para crear comando que permite agregar un Producto
        /// </summary>
        /// <param name="producto">entidad sobre la cual se va a trabajar el comando</param>
        /// <returns></returns>
        public static Comando<bool> CrearAgregarProducto(Entidad producto)
        {
            Comando<bool> respuesta = new ComandoAgregaProducto(producto);
            return respuesta;
        }

        /// <summary>
        /// metodo para crear comando que permite consultar todos los Productos
        /// </summary>
        /// <returns></returns>
        public static Comando<List<Entidad>> CrearConsultarTodosProductos()
        {
            Comando<List<Entidad>> respuesta = new ComandoConsultarProducto();
            return respuesta;
        }

        #endregion

        #region Usuario
        /// <summary>
        /// metodo para crear comando que permite agregar un Usuario
        /// </summary>
        /// <param name="usuario">entidad sobre la cual se va a trabajar el comando</param>
        /// <returns></returns>
        public static Comando<bool> CrearAgregarUsuario(Entidad usuario)
        {
            Comando<bool> respuesta = new ComandoAgregarUsuario(usuario);
            return respuesta;
        }
        #endregion

        #region Promocion
        /// <summary>
        /// metodo para crear comando que permite agregar una promocion
        /// </summary>
        /// <param name="usuario">entidad sobre la cual se va a trabajar el comando</param>
        /// <returns></returns>
        public static Comando<bool> CrearAgregarPromocion(Entidad usuario)
        {
            Comando<bool> respuesta = new ComandoAgregaPromocion(usuario);
            return respuesta;
        }


        #endregion
    }
}
