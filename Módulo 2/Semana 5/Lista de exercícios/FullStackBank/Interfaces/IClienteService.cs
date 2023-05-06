using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FullStackBank.Interfaces
{
    public interface IClienteService
    {
        void CriarConta();

        void BuscarClientePorNumeroDeConta(string conta);

        void ExibirClientes();
    }
}