using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSistemaGaragem
{
    class Veiculo
    {
        string placa;
        DateTime dataEntrada;
        DateTime horaEntrada;
        DateTime horaSaida;
        TimeSpan tempoPermanencia;
        double valorCobrado;

        /// <summary>
        /// construtor é utilizado na leitura do arquivo de veículos que estão na garagem
        /// </summary>
        /// <param name="placa"> identificação do veículo </param>
        /// <param name="dataEntrada">Data do sistema para a entrada do veículo</param>
        /// <param name="horaEntrada">Hora do sistema para a entrada do veículo</param>
        public Veiculo(string placa, DateTime dataEntrada, DateTime horaEntrada)
        {
            this.placa = placa;
            this.dataEntrada = dataEntrada;
            this.horaEntrada = horaEntrada;
        }

        /// <summary>
        /// construtor é utilizado na leitura do arquivo de veículos que vão sair da garagem
        /// </summary>
        /// <param name="placa"> identificação do veículo </param>
        /// <param name="dataEntrada"> data de entrada do veículo </param>
        /// <param name="horaEntrada"> horário que o veículo entrou na garagem </param>
        /// <param name="horaSaida"> horário que o veículo saiu da garagem </param>
        /// <param name="tempoPermanencia"> Tempo que o veiculo ficou na garagem</param>
        /// <param name="valorCobrado">valor cobrado pelo estacionamento</param>
        public Veiculo(string placa, DateTime dataEntrada, DateTime horaEntrada, DateTime horaSaida, TimeSpan tempoPermanencia, double valorCobrado)
        {
            this.placa = placa;
            this.dataEntrada = dataEntrada;
            this.horaEntrada = horaEntrada;
            this.horaSaida = horaSaida;
            this.tempoPermanencia = tempoPermanencia;
            this.valorCobrado = valorCobrado;
        }


        public string Placa { get => placa; set => placa = value; }
        public DateTime DataEntrada { get => dataEntrada; set => dataEntrada = value; }
        public DateTime HoraEntrada { get => horaEntrada; set => horaEntrada = value; }
        public DateTime HoraSaida { get => horaSaida; set => horaSaida = value; }
        public TimeSpan TempoPermanencia { get => tempoPermanencia; set => tempoPermanencia = value; }
        public double ValorCobrado { get => valorCobrado; set => valorCobrado = value; }
    }
}
