using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSistemaGaragem
{
    class Validacoes
    {
        /// <summary>
        /// Verifica se a garagem está fechada
        /// </summary>
        /// <returns> retorna true se a garagem estiver fechada e false se estiver aberta </returns>
        public static bool garagemFechada()
        {            
            return DateTime.Now.Hour < 7 || DateTime.Now.Hour > 20;
        }        

        /// <summary>
        /// Verifica se há vaga na garagem
        /// </summary>
        /// <param name="lista">lista de entrada de veiculos</param>
        /// <returns>retorna true se tem vaga e false se não tem </returns>
        public static bool temVaga(List<Veiculo> lista)
        {
            return lista.Count <= 50;
        }

        /// <summary>
        /// Verifica se o veículo está na garagem
        /// </summary>
        /// <param name="lista"> lista de veiculos de entrada</param>
        /// <param name="placa"> placa do veiculo </param>
        /// <returns></returns>
        public static bool estaNaGaragem(List<Veiculo> lista, string placa)
        {
            foreach (Veiculo i in lista)
            {
                if (i.Placa.Equals(placa))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
