﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execepcion1
{
  public  class ExepcionEspecial:ApplicationException
    {
       

        public ExepcionEspecial()
        {

        }
        public ExepcionEspecial(string message):base(message)
        {

        }

    }
}
