using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace NotificadorUniversal.Utilerias
{
    class Clases
    {
    }

    public class ConexionBD
    {
        public ConexionBD()
        {
            Servidor = "";
            Usuario = "";
            Contrasenia = "";
            BaseDeDatos = "";
        }

        public string Servidor { get; set; }
        public string Usuario { get; set; }
        public string Contrasenia { get; set; }
        public string BaseDeDatos { get; set; }
    }

    public class Efectos
    {
        public void MouseLeaveEfecto1(DevExpress.XtraEditors.PictureEdit pb, Bitmap imagen)
        {
            try
            {
                pb.Image = imagen;
            }
            catch (Exception x)
            { throw x; }
        }
    }

    public class Seguridad
    {
        /// Encripta una cadena
        public string Encriptar(string _cadenaAencriptar)
        {
            string result = string.Empty;
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(_cadenaAencriptar);
            result = Convert.ToBase64String(encryted);
            return result;
        }

        /// Esta función desencripta la cadena que le envíamos en el parámentro de entrada.
        public string DesEncriptar(string _cadenaAdesencriptar)
        {
            string result = string.Empty;
            byte[] decryted = Convert.FromBase64String(_cadenaAdesencriptar);
            //result = System.Text.Encoding.Unicode.GetString(decryted, 0, decryted.ToArray().Length);
            result = System.Text.Encoding.Unicode.GetString(decryted);
            return result;
        }

        /// <summary>
        /// Performs the ROT13 character rotation.
        /// </summary>
        public string Transform(string valor)
        {
            char[] array = valor.ToCharArray();
            for (int i = 0; i < array.Length; i++)
            {
                int number = (int)array[i];

                if (number >= 'a' && number <= 'z')
                {
                    if (number > 'm')
                    {
                        number -= 13;
                    }
                    else
                    {
                        number += 13;
                    }
                }
                else if (number >= 'A' && number <= 'Z')
                {
                    if (number > 'M')
                    {
                        number -= 13;
                    }
                    else
                    {
                        number += 13;
                    }
                }
                array[i] = (char)number;
            }
            return new string(array);
        }

        // Codificar cadena a Base64
        public string Base64Encode(string valor)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(valor);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        // Decodificar cadena a Base64
        public string Base64Decode(string valor)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(valor);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }

    }

    public class Sesion
    {
        public Sesion()
        {
            idusuario = 0;
            nombre = "";
            idSucursal = 0;
        }

        public int idusuario { get; set; }
        public string nombre { get; set; }
        public int idSucursal { get; set; }
    }
 
}
