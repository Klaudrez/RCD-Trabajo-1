using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RedesWS
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        public string GetRutValidacion(string value)
        {
            if (ValidarFormatoRut(value, '.', '-'))
            {
                if(!ValidarNum(value))
                    return "Formato invalido";
 
                string digito = value.Substring(value.Length - 1);

                if (digito == "k")
                    digito = "K";

                if (digitoVerificador(RutToInt(value)) == digito)
                    return " Rut valido! ";
                else
                    return " Rut invalido! ";
            }
            else
                return "Formato invalido";
        }

        public string GetMensaje(string Ap, string Am, string Ns, char G)
        {
            string mensaje = "";
            if (G == 'M')
                mensaje += "Sr. ";
            else
                mensaje += "Sra. ";
            
            mensaje = mensaje + Mayus(Ns) + " " + Mayus(Ap) + " " + Mayus(Am);
            
            if(ValidarPalabra(Ap) && ValidarPalabra(Am) && ValidarPalabra(Ns))
                return mensaje;
            else
                return "Nombre no valido";
            
           
     
        }
        private bool ValidarNum(string value)
        {
            int validador = 0;
            if (int.TryParse(value.Substring(0, (value.Length) - 2), out validador))
                return true;
            else
                return false; 
        }

        private int RutToInt(string value)
        {
            string aux = value.Substring(0, (value.Length) - 2);
            int num = Int32.Parse(aux);  
            return num;
        }
        private string digitoVerificador(int rut)
        {
            int Digito;
            int Contador;
            int Multiplo;
            int Acumulador;
            string Digito_V;

            Contador = 2;
            Acumulador = 0;

            while (rut != 0)
            {
                Multiplo = (rut % 10) * Contador;
                Acumulador = Acumulador + Multiplo;
                rut = rut / 10;
                Contador = Contador + 1;
                if (Contador == 8)
                {
                    Contador = 2;
                }

            }

            Digito = 11 - (Acumulador % 11);
            Digito_V = Digito.ToString();
            if (Digito == 10)
            {
                Digito_V = "K";
            }
            if (Digito == 11)
            {
                Digito_V = "0";
            }
            return Digito_V;
        }

        private bool ValidarFormatoRut(string palabra, char formato, char formato2)
        {
            int cont = 0;
            foreach (char c in palabra)
            {
                if (c == formato)
                    return false;
                if (c == formato2)
                    cont++;
            }
            if (cont != 1)
                return false;
            else
                return true;
        }

        private string Mayus(string palabras)
        {
            string minus = palabras.ToLower();
            string[] Nombres = minus.Split(' ');
            string frase = "";
            string aux;
            int Cont = 0;
            foreach (string nombre in Nombres)
            {
                char[] vs = nombre.ToCharArray();
                vs[0] = char.ToUpper(vs[0]);
                aux = new string(vs);
                if (Cont > 0)
                    frase = frase + " " + aux;
                else
                    frase += aux;
                Cont++;
            }

            return frase;
        }

        private bool ValidarPalabra(string palabra)
        {
            foreach(char letra in palabra)
            {
                if (!char.IsLetter(letra) && letra != ' ')
                    return false;
            }
            return true;
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
