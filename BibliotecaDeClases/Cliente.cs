using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BibliotecaDeClases
{
    public class Cliente
    {
        private string nombreCompleto;
        private double dinero;
        private eMetodoPago metodoDePago;

        public Cliente(string nombreCompleto, double dinero, eMetodoPago metodoDePago)
        {
            this.nombreCompleto = nombreCompleto;
            this.dinero = dinero;
            this.metodoDePago = metodoDePago;
        }

        public string NombreCompleto
        {
            get { return nombreCompleto; }
        }
        public double Dinero
        {
            get { return dinero; }
            set { this.dinero = value; }
        }
        public eMetodoPago MetodoDePago
        {
            get { return metodoDePago; }
        }


        public enum eMetodoPago
        {
            TarjetaDeCredito,
            Efectivo,
            MercadoPago,
            TarjetaDebito
        }


    }
}
