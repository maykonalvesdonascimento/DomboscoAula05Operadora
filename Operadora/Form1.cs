using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operadora
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /**
         * Ao apertar o RadioButton Vivo Irá trocar a cor para Dark Violet , Preencher o Operadora pra Vivo, Limpar o Campo Recarga e Chamar o Método AtivarAlterarPreencher
         * **/
        private void radVivo_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = Color.DarkViolet;
            PicLogoOperadora.Image = Properties.Resources.gif_Vivo;


            txtOperadora.Text = "Vivo";
            txtRecarga.Clear();
            ativarAlterarPreencher("Vivo");

        }
		/**
         * Ao apertar o RadioButton Claro Irá trocar a cor para Red , Preencher o Operadora pra Claro, Limpar o Campo Recarga e Chamar o Método AtivarAlterarPreencher
         * **/
		private void radClaro_CheckedChanged(object sender, EventArgs e)

        {
            
            BackColor = Color.Red;
            PicLogoOperadora.Image = Properties.Resources.gif_claro;
            txtOperadora.Text = "Claro";
			txtRecarga.Clear();
			ativarAlterarPreencher("Claro");

        }
		/**
        * Ao apertar o RadioButton Vivo Irá trocar a cor para Blue , Preencher o Operadora pra Vivo, Limpar o Campo Recarga e Chamar o Método AtivarAlterarPreencher
        * **/
		private void radTim_CheckedChanged(object sender, EventArgs e)
        {
            

            BackColor = Color.Blue;
            PicLogoOperadora.Image = Properties.Resources.gif_tim;
            txtOperadora.Text = "Tim";
			txtRecarga.Clear();
			ativarAlterarPreencher("Tim");




        }
		/**
        * Ao apertar o RadioButton Oi Irá trocar a cor para Dark Violet , Preencher o Operadora pra Oi, Limpar o Campo Recarga e Chamar o Método AtivarAlterarPreencher
        * **/

		private void radOi_CheckedChanged(object sender, EventArgs e)
        {
            

            BackColor = Color.Green;
            PicLogoOperadora.Image = Properties.Resources.gif_OI;
            txtOperadora.Text = "Oi";
            txtRecarga.Clear();
            ativarAlterarPreencher("Oi");



        }

        // Método AtivarAlterarPreencher, irá Ativar todos as Labels e TextBox e Chama o método preencherBotõesValidade
        private void ativarAlterarPreencher(String Operadora) {

			lblRecarga.Enabled = true; //Ativa a Label Recarga
			lblDados.Enabled = true; // Ativa a Label Dados da Recarga
			lblDDD.Enabled = true; //  Ativa a Label DDD
			lblOperadora.Enabled = true; // Ativa a Label Operadora
			lblCelular.Enabled = true; // Ativar a Label Celular
			lblNome.Enabled = true; // Ativar a Label Nome
			lblSelecione.Enabled = true; // Ativar a Label Selecione o Valor da Recarga

			txtNome.Enabled = true;  //Ativar a TextBox Nome
            txtDDD.Enabled = true; // Ativa a TextBox DDD
            txtCelular.Enabled = true; // Ativa a TextBox Celular
            txtRecarga.Enabled = true; // Ativa a TextBox Recarga
            GroupOperadoras.ForeColor = Color.White; // Altera a Cor do GroupBox Operadoras ( para que todos os RadioButton fiquem brancos)
            preencherBotoesValidade(Operadora); //Chama o Método PreencherBotões e passa a operadora pra preencher
            ForeColor = Color.White; //Altera os demais valores pra Branco



        }

        //Método responsável pra preencher todos botões de valores e labels de validade, e alterar suas cores
        private void preencherBotoesValidade(String operadora) {

            /**Criando um arrayVivo , ele irá receber cada um dos valores de cada botão de valores da vivo
             * A posição zero do array será referente ao botão btnValor1 , a posição um do array será referente ao botão btnValor2 , e assim por diante.
             * **/
            String[] valoresVivo =  { "12 reais", "15 reais", "20 reais", "30 reais", "35 reais", "40 reais", "100 reais", "200 reais"};

			/**Criando um arrayVivo , ele irá receber cada um dos valores de cada label de validade da vivo
             * A posição zero do array será referente ao label lblValidade , a posição um do array será referente ao Label lblvalidade2 , e assim por diante.
             * **/
			String[] validadesVivo = { "30 dias", "30 dias", "30 dias", "30 dias", "90 dias", "90 dias", "180 dias", "365 dias" };

			/**Criando um arrayTim , ele irá receber cada um dos valores de cada botão de valores da Tim
             * A posição zero do array será referente ao botão btnValor1 , a posição um do array será referente ao botão btnValor2 , e assim por diante.
             * **/
			String[] valoresTim = { "10 reais", "15 reais", "20 reais", "30 reais", "40 reais", "50 reais", "60 reais", "200 reais" };
			/**Criando um arrayTime, ele irá receber cada um dos valores de cada label de validade da Tim
             * A posição zero do array será referente ao label lblValidade , a posição um do array será referente ao Label lblvalidade2 , e assim por diante.
             * **/
			String[] validadesTim = { "30 dias", "30 dias", "30 dias", "90 dias", "90 dias", "180 dias", "180 dias", "180 dias" };

            //o mesmo acontece para os arrays abaixo

			String[] valoresClaro = { "12 reais", "15 reais", "20 reais", "25 reais", "30 reais", "35 reais", "50 reais", "100 reais" };
			String[] validadesClaro = { "30 dias", "30 dias", "60 dias", "60 dias", "90 dias", "90 dias", "120 dias", "180 dias" };

			String[] valoresOi = { "10 reais", "15 reais", "20 reais", "25 reais", "30 reais", "35 reais", "40 reais", "50 reais" };
			String[] validadesOi = { "30 dias", "30 dias", "40 dias", "45 dias", "90 dias", "90 dias", "90 dias", "90 dias" };


            //Como são 8 botões e 8 labels , eu fiz um Uma estrura de Repetição, que irá repetir o código abaixo 8 vezes , uma vez para cada botão e label
			for (int i = 0; i < 8; i++)
            {
				// Criei uma String , aonde ela irá concatenar o valor btnValor + i ( i é o valor de cada incremento do for )
                // Exemplo na primeira interação do For o i será igual a zero , logo o primeiro será o btnValor + (i+1) = btnValor1 ( que é referente o name do primeiro botão)
				String nomebutton = "btnValor" + (i+1);

                //Criei uma String, aonde irá concater o valor lblValidade + i 
                //Exemplo na primeira interação do For o irá será igual a zero , logo o primeiro será o lblValidade + (i+1) =lblValidade1 ( que é referente o name da primeira label)
                String nomelabel = "lblValidade" + (i + 1);

                //Estou instanciando um botão chamado BTN, ele irá receber um objeto criado no Form1 , que tenha o mesmo nome da String nomebutton
                //Exemplo na primeira interação do For o nomebutton irá receber o valor "btnValor1" , logo ele irá buscar um Objeto com nome btnValor1 , e transformar em Button
                Button btn = this.Controls.Find(nomebutton, true).FirstOrDefault() as Button;
                //
                //Estou fazendo o mesmo que eu fiz com o Botão , mas com a Label
                //Aonde na primeira interação do For o nomeLabel irá receber o Valor de "lblValidade1" , logo ele irá buscar um Objeto no Form1 com valor de lblValidade1, e transforma em Label
                Label lbl = this.Controls.Find(nomelabel, true).FirstOrDefault() as Label;
               

                //ativa btn ( botão que foi criado na linhas anteriores)
                btn.Enabled = true;
                //ativa lbl ( label que foi criada na linhas anteriores)
                lbl.Enabled = true;
                
                //Verifica se a operadora que veio como parametro do método é da vivo
                if (operadora == "Vivo")
                {
                    //se for vivo irá preencher os botões e labels com os array da vivo
					btn.Text = valoresVivo[i];
					lbl.Text = validadesVivo[i];
					btn.ForeColor = Color.Violet;
				

				}
				else if (operadora == "Claro")
                {
					//se for vivo irá preencher os botões e labels com os array da claro
					btn.Text = valoresClaro[i];
					lbl.Text = validadesClaro[i];
					btn.ForeColor = Color.Black;
                }
                else if (operadora == "Tim")
                {
					//se for vivo irá preencher os botões e labels com os array da tim
					btn.Text = valoresTim[i];
					lbl.Text = validadesTim[i];
					btn.ForeColor = Color.RoyalBlue;

                }
                else {
					//se for vivo irá preencher os botões e labels com os array da oi
					btn.Text = valoresOi[i];
					lbl.Text = validadesOi[i];
					btn.ForeColor = Color.Gold;
                }



            }




        }

        private void btnValor1_Click(object sender, EventArgs e)
        {
            txtRecarga.Text = btnValor1.Text;
            txtRecarga.Enabled = false;
        }

        private void btnValor2_Click(object sender, EventArgs e)
        {
			txtRecarga.Text = btnValor2.Text;
			txtRecarga.Enabled = false;
		}

        private void btnValor3_Click(object sender, EventArgs e)
        {
			txtRecarga.Text = btnValor3.Text;
			txtRecarga.Enabled = false;
		}

        private void btnValor4_Click(object sender, EventArgs e)
        {
			txtRecarga.Text = btnValor4.Text;
			txtRecarga.Enabled = false;
		}

        private void btnValor5_Click(object sender, EventArgs e)
        {
			txtRecarga.Text = btnValor5.Text;
			txtRecarga.Enabled = false;
		}

        private void btnValor6_Click(object sender, EventArgs e)
        {
			txtRecarga.Text = btnValor6.Text;
			txtRecarga.Enabled = false;
		}

        private void btnValor7_Click(object sender, EventArgs e)
        {
			txtRecarga.Text = btnValor7.Text;
			txtRecarga.Enabled = false;
		}

        private void btnValor8_Click(object sender, EventArgs e)
        {
			txtRecarga.Text = btnValor8.Text;
			txtRecarga.Enabled = false;
		}
    }
}
