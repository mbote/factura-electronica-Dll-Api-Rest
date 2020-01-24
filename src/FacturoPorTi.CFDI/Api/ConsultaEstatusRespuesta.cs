﻿using System.Collections.Generic;
using FacturoPorTi.CFDI.Entidades;

namespace FacturoPorTi.CFDI
{
    public class ConsultaEstatusRespuesta : WCFRespuesta
    {
        private List<FoliosRespuesta> FoliosRespuestaField;
        public List<FoliosRespuesta> FoliosRespuesta
        {
            get
            {
                return this.FoliosRespuestaField;
            }
            set
            {
                this.FoliosRespuestaField = value;
            }
        }
    }
}