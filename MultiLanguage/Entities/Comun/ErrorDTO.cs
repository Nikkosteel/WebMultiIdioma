﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMultiLanguage.Entities.Comun
{
    public class ErrorDTO
    {
        /// <summary>
        /// Variable que puede contener el id del elemento que contiene el error
        /// </summary>
        public string IdElemento { get; set; }
        /// <summary>
        /// Mensaje de error.
        /// </summary>
        public string Mensaje { get; set; }

        /// <summary>
        /// Codigo de error.
        /// </summary>
        public string Codigo { get; set; }

        public string CodigoTecnico { get; set; }
        /// <summary>
        /// Representa la posición del error
        /// </summary>
        public int Posicion { get; set; }
    }
}