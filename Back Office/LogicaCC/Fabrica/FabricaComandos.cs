using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using LogicaCC.Comandos;
using LogicaCC.Comandos.Garantia;
using LogicaCC.Comandos.Venta;
using LogicaCC.Comandos.Categoria;
using LogicaCC.Comandos.Promocion;
using LogicaCC.Comandos.Usuario;
using LogicaCC.Comandos.Marca;
using LogicaCC.Comandos.Producto;
using LogicaCC.Comandos.Reportes;

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
        /// metodo para crear comando que permite modificar una categoria
        /// </summary>
        /// <param name="categoria">entidad sobre la cual se va a trabajar el comando</param>
        /// <returns></returns>
        public static Comando<bool> CrearModificarCategoria(Entidad categoria)
        {
            Comando<bool> respuesta = new ComandoModificarCategoria(categoria);
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
        /// metodo para crear comando que permite modificar una marca
        /// </summary>
        /// <param name="marca">entidad sobre la cual se va a trabajar el comando</param>
        /// <returns></returns>
        public static Comando<bool> CrearModificarMarca(Entidad marca)
        {
            Comando<bool> respuesta = new ComandoModificarMarca(marca);
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
        /// metodo para crear comando que permite modificar un Producto
        /// </summary>
        /// <param name="producto">entidad sobre la cual se va a trabajar el comando</param>
        /// <returns></returns>
        /// 

        public static Comando<bool> CrearModificarProducto(Entidad producto)
        {
            Comando<bool> respuesta = new ComandoModificarProducto(producto);
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

        /// <summary>
        /// metodo para crear comando que permite modificar un Usuario
        /// </summary>
        /// <param name="usuario">entidad sobre la cual se va a trabajar el comando</param>
        /// <returns></returns>
        public static Comando<bool> CrearModificarUsuario(Entidad usuario)
        {
            Comando<bool> respuesta = new ComandoModificarUsuario(usuario);
            return respuesta;
        }

        /// <summary>
        /// metodo para crear comando que permite consultar todos los Usuarios
        /// </summary>
        /// <returns></returns>
        public static Comando<List<Entidad>> CrearConsultarTodosUsuarios()
        {
            Comando<List<Entidad>> respuesta = new ComandoConsultarUsuario();
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

        /// <summary>
        /// metodo para crear comando que permite modificar una Promocion
        /// </summary>
        /// <param name="promocion">entidad sobre la cual se va a trabajar el comando</param>
        /// <returns></returns>
        /// 

        public static Comando<bool> CrearModificarPromocion(Entidad promocion)
        {
            Comando<bool> respuesta = new ComandoModificarPromocion(promocion);
            return respuesta;
        }

        /// <summary>
        /// metodo para crear comando que permite consultar todas las Promociones
        /// </summary>
        /// <returns></returns>
        public static Comando<List<Entidad>> CrearConsultarTodosPromociones()
        {
            Comando<List<Entidad>> respuesta = new ComandoConsultarPromocion();
            return respuesta;
        }

        #endregion

        #region Ventas

        /// <summary>
        /// metodo para crear comando que permite consultar todas las Ventas
        /// </summary>
        /// <returns></returns>
        public static Comando<List<Entidad>> CrearConsultarTodosVentas()
        {
            Comando<List<Entidad>> respuesta = new ComandoConsultarVenta();
            return respuesta;
        }

        /// <summary>
        /// metodo para crear comando que permite modificar una venta
        /// </summary>
        /// <param name="venta">entidad sobre la cual se va a trabajar el comando</param>
        /// <returns></returns>
        /// 

        public static Comando<bool> CrearModificarVenta(Entidad venta)
        {
            Comando<bool> respuesta = new ComandoModificarVenta(venta);
            return respuesta;
        }

        #endregion

        #region Garantia
        /// <summary>
        /// metodo para crear comando que permite agregar una marca
        /// </summary>
        /// <param name="garantia">entidad sobre la cual se va a trabajar el comando</param>
        /// <returns></returns>
        public static Comando<bool> CrearAgregarGarantia(Entidad garantia)
        {
            Comando<bool> respuesta = new ComandoAgregarGarantia(garantia);
            return respuesta;
        }

        /// <summary>
        /// metodo para crear comando que permite modificar una marca
        /// </summary>
        /// <param name="garantia">entidad sobre la cual se va a trabajar el comando</param>
        /// <returns></returns>
        public static Comando<bool> CrearModificarGarantia(Entidad garantia)
        {
            Comando<bool> respuesta = new ComandoModificarGarantia(garantia);
            return respuesta;
        }


        /// <summary>
        /// metodo para crear comando que permite consultar todas las Categorias
        /// </summary>
        /// <returns></returns>
        public static Comando<List<Entidad>> CrearConsultarTodosGarantia()
        {
            Comando<List<Entidad>> respuesta = new ComandoConsultarGarantia();
            return respuesta;
        }
        #endregion

        #region Reportes

        /// <summary>
        /// metodo para crear comando que permite consultar todas las Categorias
        /// </summary>
        /// <returns></returns>
        public static Comando<List<Entidad>> CrearConsultarReporte1(Entidad parametro)
        {
            Comando<List<Entidad>> respuesta = new ComandoReporte1(parametro);
            return respuesta;
        }

        public static Comando<List<Entidad>> CrearConsultarReporte2()
        {
            Comando<List<Entidad>> respuesta = new ComandoReporte2();
            return respuesta;
        }
        #endregion

        #region Correo
        public static Comando<bool> CrearEnviarCorreo(Entidad correo)
        {
            Comando<bool> respuesta = new ComandoCorreos(correo);
            return respuesta;
        }
        #endregion
    }
}
