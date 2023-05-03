using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace passed_rod_project
{
    public class Pagamento
   
    {
      public DateTime Data = DateTime.Now;
      public float Valor;

      public string Cancelar() 
      {
        return "Operação cancelada.";
      }
    }
}