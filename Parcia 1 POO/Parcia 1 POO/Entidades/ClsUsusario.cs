using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcia_1_POO.Negocio
{
    class Clsusario
    {



       {public string ACCESO(Clsusario clsusuario)
        {
            Clsusario clsusuario = new Clsusario();
           
            clsusuario.Nombre1 = "Alvin";
            clsusuario.Contraseña1 = 123;

            if (clsusuario.Nombre1 == "Alvin" || clsusuario.Contraseña1 == 123)
            {
                return "INICIO DE  SESIÓN CORRECTO PUEDES CONTINUAR CON EL PROCESO DE VENTA";


            }
            else
            {
                return "Nombre de usuario incorrecto";

            }


        }

            Clsusario usuario = new Clsusario();
            Nclusuario nclsusuario = new Nclusuario();
         

        public string Nombre1 { get; private set; }
        public object Contraseña1 { get; private set; }

        private class Nclusuario
        {
        }
    }

}