using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coreapi.Service
{
   public interface IMail
    {
		 void Sendmail(string param);
    }
}
