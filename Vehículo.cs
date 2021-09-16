using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiagramaClasesUML
{
    public class Vehículo
    {
        private string marca;
        private string línea;
        private string color;
        private int modelo;
        private int placa;
        private string cilindraje;
        private string ClaseVehículo;
        private int potencia;
        private int capacidad;
        /// <summary>
        /// Posee o no blindaje
        /// </summary>
        private bool blindado;
        private string carrocería;
        private string combustible;
        private string TipoServicio;

        /// <param name="blindado">Posee o no blindaje</param>
        /// <param name="capacidad">Kg/Psj</param>
        public Vehículo(bool blindado, int capacidad, string carrocería, string cilindraje, string ClaseVehículo, string color, string combustible, string línea, string marca, int modelo, int placa, int potencia, string TipoServicio)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Posee o no blindaje
        /// </summary>
        private int Blindado
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// Kg/Psj
        /// </summary>
        private int Capacidad
        {
            get => default;
            set
            {
            }
        }

        private string Carrocería
        {
            get => default;
            set
            {
            }
        }

        private string Clase
        {
            get => default;
            set
            {
            }
        }

        private string Color
        {
            get => default;
            set
            {
            }
        }

        private string Combustible
        {
            get => default;
            set
            {
            }
        }

        private string Línea
        {
            get => default;
            set
            {
            }
        }

        private int Marca
        {
            get => default;
            set
            {
            }
        }

        private int Modelo
        {
            get => default;
            set
            {
            }
        }

        private int Placa
        {
            get => default;
            set
            {
            }
        }

        private int Potencia
        {
            get => default;
            set
            {
            }
        }

        private String Tipo
        {
            get => default;
            set
            {
            }
        }
    }
}