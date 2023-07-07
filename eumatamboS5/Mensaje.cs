using System;
using System.Collections.Generic;
using System.Text;

namespace eumatamboS5
{
    public interface Mensaje
    {

        //metodo a implementar  notificacion toast
        void shortAlert(string mensaje);
        void longAlert(string mensaje); 
    }
}
