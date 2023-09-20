using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SannaFer.CAI.EJ._01
{
    internal class DatosFormModel
    {
             
            public string Nombre { get; set; }
            public string Documento { get; set; }
            public string Apellido { get; set; }
            public string FechaNacimiento { get; set; }

        internal string validar()
        {
            if (string.IsNullOrEmpty(Nombre))
            {
                return "El nombre no puede ser vacío";
            }

            if (string.IsNullOrEmpty(Documento))
            {
                return "El Documento no puede ser vacío";
            }

            if (Documento.Length != 8)
            {
                return "El documento debe tener 8 caracteres";
            }

            if (string.IsNullOrEmpty(Apellido))
            {
                return "El Apellido no puede ser vacío";
            }

            DateTime fechaNacimiento;

            if (string.IsNullOrEmpty(FechaNacimiento) || !DateTime.TryParseExact(FechaNacimiento, "dd/MM/yyyy", null, DateTimeStyles.None, out fechaNacimiento))
            {
                return "La Fecha de Nacimiento debe estar en el formato dd/MM/yyyy";
            }

            // Verificar si el día es válido (de 1 a 31)
            if (fechaNacimiento.Day < 1 || fechaNacimiento.Day > 31)
            {
                return "El día en la Fecha de Nacimiento no es válido";
            }

            // Verificar si el mes es válido (de 1 a 12)
            if (fechaNacimiento.Month < 1 || fechaNacimiento.Month > 12)
            {
                return "El mes en la Fecha de Nacimiento no es válido";
            }

            return "ok";
        }

    }
}

