using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ChatEjemplo
{
    [ServiceContract]
    public interface IQuickReturnTraderChat
    {
        [OperationContract(IsOneWay = true)]
        void EnviarMensaje(String ElUsuario, string ElMensaje);
    }
}
