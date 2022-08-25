using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Services
{
    public static class VerificaInputVazio
    {
        public static bool VerificarNull(string objetoVerificar)
        {
            if (objetoVerificar != null)
            {
                var objetoVerificarSemEspaco = objetoVerificar.Trim();
               
                if (objetoVerificarSemEspaco == string.Empty )
                {
                    return false;
                }
                return true;
            }
            return false;
        }
        
    }
}
