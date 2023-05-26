using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSistemaGaragem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            /// <summary>
            /// Métodos traz do arquivo e popula no textBoxList
            /// </summary> 
            Persistencia.lerDoArquivoEntrada(listaEntrada);
            popularTextBoxListaEntrada(listaEntrada);            
            Persistencia.lerDoArquivoSaida(listaSaida);
            popularTextBoxListaSaida(listaSaida);
            
        }

        /// <summary>
        /// Listas para receber os dados para mandar para os arquivos 
        /// </summary>
        List<Veiculo> listaEntrada = new List<Veiculo>();
        List<Veiculo> listaSaida = new List<Veiculo>();

        /// <summary>
        /// Método para popular os textBox de entrada
        /// </summary>
        /// <param name="lista">lista que armazena veículos de entrada</param>
        private void popularTextBoxListaEntrada(List<Veiculo> lista)
        {
            tbListaEntrada.Text = " ";
            foreach (Veiculo i in lista)
            {
                tbListaEntrada.AppendText(i.Placa + " - " + i.HoraEntrada + " - " + i.DataEntrada + Environment.NewLine);
            }
        }

        /// <summary>
        /// Método para popular os textBox de saída
        /// </summary>
        /// <param name="lista">lista que armazena veículos de saida</param>
        private void popularTextBoxListaSaida(List<Veiculo> lista)
        {
            tbListaSaida.Text = " ";
            foreach (Veiculo i in lista)
            {
                tbListaSaida.AppendText(i.Placa + " - " + i.DataEntrada + " - " + i.HoraEntrada + " - " + i.HoraSaida + " - " + i.TempoPermanencia + " - " + i.ValorCobrado + Environment.NewLine);
            }
        }

        private void btEntrada_Click(object sender, EventArgs e)
        {
            if (Validacoes.garagemFechada()) 
            {
                MessageBox.Show("A garagem está fechada!", "Alerta");
            }
            else if (!Validacoes.temVaga(listaEntrada))
            {
                MessageBox.Show("A garagem está cheia!", "Alerta");
            }            
            else if (Validacoes.estaNaGaragem(listaEntrada, tbPlaca.Text)) 
            {
                MessageBox.Show("O veículo já está na garagem!", "Alerta");
            }
            else if (tbPlaca.Text.Length < 7 || tbPlaca.Text.Length > 7)
            {
                MessageBox.Show("Placa Inválida", "Alerta");
            }
            else
            {
                listaEntrada.Add(new Veiculo(tbPlaca.Text, dtpHora.Value, dtpData.Value));
                Persistencia.gravarNoArquivoEntrada(listaEntrada);

                tbListaEntrada.AppendText(tbPlaca.Text + " - " + dtpHora.Value + " - " + dtpData.Value + Environment.NewLine);

                MessageBox.Show($"{tbPlaca.Text}\n{dtpHora.Value}\n{dtpData.Value}");                
            }
        }

        private void btSaida_Click(object sender, EventArgs e)
        {
            int indice;
            foreach (Veiculo i in listaEntrada)
            {
                if (Validacoes.garagemFechada())
                {
                    MessageBox.Show("A garagem está fechada!", "Alerta");
                    break;
                }
                else if (Validacoes.estaNaGaragem(listaEntrada, tbPlaca.Text))
                {
                    indice = listaEntrada.IndexOf(i);

                    listaSaida.Add(i);
                    i.HoraSaida = DateTime.Now;
                    i.TempoPermanencia = i.HoraSaida.Subtract(i.HoraEntrada);
                    i.ValorCobrado = Math.Ceiling(i.TempoPermanencia.TotalMinutes/60)*5.00;

                    Persistencia.gravarNoArquivoSaida(listaSaida);
                    tbListaSaida.AppendText(tbPlaca.Text + " - " + i.DataEntrada + " - " + i.HoraEntrada + " - " + i.HoraSaida + " - " + (int)i.TempoPermanencia.TotalHours + " - " + i.ValorCobrado + Environment.NewLine);

                    listaEntrada.RemoveAt(indice);
                    Persistencia.gravarNoArquivoEntrada(listaEntrada);
                    popularTextBoxListaEntrada(listaEntrada);

                    MessageBox.Show($"{tbPlaca.Text}\n{(int)i.TempoPermanencia.TotalHours} hora(s)\n{i.ValorCobrado} reais");
                    break;
                }
                else
                {
                    MessageBox.Show("O veículo não está na garagem!","Alerta");
                    break;
                }
            }
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
