using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontController
{
    public class FrontController
    {

        private Dispatcher dispatcher;

        public FrontController()
        {
            dispatcher = new Dispatcher();
        }

        private bool isAuthenticUser()
        {
            Console.WriteLine("Usuario Autenticado");
            return true;
        }

        private void trackRequest(String request)
        {
            Console.WriteLine("Pagina solicitada: " + request);
        }

        public void dispatchRequest(String request)
        {
            //log each request
            trackRequest(request);

            //authenticate the user
            if (isAuthenticUser())
            {
                dispatcher.dispatch(request);
            }
        }
    }
}
