using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace passed_rod_project
{
    public class Pagamento
   
    {
      public DateTime data = DateTime.Now;
      public float valor;
      public float valorTotal;

      public string Cancelar() 
      {
        return "Operação cancelada.";
      }
    }
}