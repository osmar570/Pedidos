using System;
using System.Collections.Generic;
using System.Text;

namespace PedidosExercicio.Entities.Enums
{
    enum OrderStatus : int
    {
        AguardandoPagamento,
        Processando,
        Enviado,
        Entregue
    }
}
