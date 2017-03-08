﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using LogicaCC.Comandos;
using LogicaCC.Comandos;
using LogicaCC.Comandos.Marca;
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
        public static Comando<bool> CrearAgregarMarca(Entidad categoria)
        {
            Comando<bool> respuesta = new ComandoAgregarMarca(categoria);
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

        

        #endregion

        #region Promocion

        

        #endregion
    }
}
