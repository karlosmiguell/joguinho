using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace joguinho
{
    public partial class Form1 : Form
    {
        //uma string para criar uma lista de palavra 
        string[] palavras = new string[6]
        {
            "Abacaxi",
            "Melão",
            "Melancia",
            "Manga",
            "Uva",
            "Abacate"
        };


        string palavra = "";

        //Random para pegar uma letra aleatoria
        private Random rnd = new Random();

        //uma lista para pegar a letra da palavra com char
        private List<char> letra = new List<char>();


        // um int de chances de vida
        int chances = 7;
        public Form1()
        {
            InitializeComponent();
            SortearPalavras();
            lbLetrasUtilizadas.Text = "Letras Utilizadas";
            ChancesDeVida();
        }

        private void ChancesDeVida()
        {
            //aqui vou atualizar toda vez 
            // em que o jogador errar, ele perde uma vida
            // mudando a cor 
            lbChances.Text = "Chances: " + chances; 

            if (chances >= 6)
            {
                lbChances.ForeColor = Color.Green;
            }

            else if (chances >=3)
            {
                lbChances.ForeColor = Color.Orange;
            }

            else
            {
                lbChances.ForeColor = Color.Red;
            }
        }

        private void SortearPalavras()
        {
            //um inteiro para pegar uma palavra entre as outras 6
            int aleatorio = rnd.Next(0, palavras.Length);
            palavra = palavras[aleatorio];

            string aparecer = "";

            foreach (char letras in palavra)
            {
                // se tiver a letra, vai uma letra mais um espaço
                if (letra.Contains(letras))
                {
                    aparecer += letra + " ";
                }


                // se não tiver, aparece o traço
                else
                {
                    aparecer += " _ ";
                }

                lbPalavra.Text = aparecer;
            }
        }

        private void btJogar_Click(object sender, EventArgs e)
        {
            if (tbLetra.Text.Length == 1)
            {
                char letras = Convert.ToChar(tbLetra.Text);
                letra.Add(letras);
                AtualizarPalavra();



                tbLetra.Clear();
                tbLetra.Focus();
                lbStatus.Text = " ";
                lbLetrasUtilizadas.Text += letra + "; ";

                //status, verificando se tem a letra na pálavra
                if (palavra.Contains(letras))
                {
                    lbStatus.Text = "Já contém esta letra na palavra!";
                }

                //se não tem a letra na palavra
                else
	            {
                    chances--;
                    ChancesDeVida();
                    if (chances == 0)
                    {
                        tbLetra.Enabled = false;
                        btJogar.Enabled = false;
                        MessageBox.Show("Estude mais!");
                    }

                    lbStatus.Text = "Não há esta letra na palavra!";
                }
            }

            //se não tem nenhuma letra
            else
            {
                lbStatus.Text = "Digite UMA letra!";      
            }
            
        }

        private void AtualizarPalavra()
        {
            string exibirpalavra = "";


            bool venceu = true;
            foreach (char letrinhas in palavra)
            {
                if (letra.Contains(letrinhas))
                {
                    exibirpalavra += letrinhas + " "; 
                }

                else
                {
                    exibirpalavra += "_ ";
                    venceu = false;
                }

                lbPalavra.Text = exibirpalavra;

                if (venceu)
                {
                    tbLetra.Enabled = false;
                    btJogar.Enabled = false;

                    MessageBox.Show("você Ganhou");
                }
            }
        }

        private void btJogar_KeyDown(object sender, KeyEventArgs e)
        {
            //fui no raio, dois click "KeyDown"

            // se eu apertar a tecla ENTER 
            //ele realiza uma ação no botão jogar
            if (e.KeyCode == Keys.Enter)
            {
                btJogar.PerformClick();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
