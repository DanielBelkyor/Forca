using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forca
{
    public partial class FrmGameForca : Form
    {
        private String[] palavras;
        private String[] dicas;
        private String palavra;
        private String tela;
        private int tentativas;
        private int pospalavra;

        public FrmGameForca()
        {
            InitializeComponent();
            this.IniciaVetor();
        }
        private void IniciaVetor()
        {
            palavras = new String[10];
            dicas = new String[10];

            palavras[0] = "Banana";
            dicas[0] = "Fruta";

            palavras[1] = "Abacaxi";
            dicas[1] = "Fruta";

            palavras[2] = "BMW";
            dicas[2] = "carro";

            palavras[3] = "Ferrari";
            dicas[3] = "carro";

            palavras[4] = "Nike";
            dicas[4] = "Marca de tênis";

            palavras[5] = "allStar";
            dicas[5] = "Marca de tênis";

            palavras[6] = "java";
            dicas[6] = "Linguagem de Programação";

            palavras[7] = "python";
            dicas[7] = "Linguagem de Programação";

            palavras[8] = "css";
            dicas[8] = "Linguagem de Programação";

            palavras[9] = "html";
            dicas[9] = "Linguagem de Programação";

        } 
        private void IniciaJogo()
        {
            Random r = new Random();
            pospalavra = r.Next(0, 10);
            palavra = palavras[pospalavra];

            tela = "";
            for (int i = 0; i < palavra.Length; i++)
            {
                tela = tela + "#";
            }
            txtBxPalavra.Text = tela;
            lblDica.Text = dicas[pospalavra];

            tentativas = 5;
            lblTotal.Text = tentativas.ToString();
            lblRestante.Text = tentativas.ToString();
        }
        private void BtnStart_Click(object sender, EventArgs e)
        {
            pnlGame.Visible = true;
            BtnStart.Visible = false;
            this.IniciaJogo();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Boolean encontrou = false;
            char letra = '0';
            int pletra = 0;
            try
            {
                letra = Convert.ToChar(txtBxLetra.Text);
            }
            catch
            {
                MessageBox.Show("É permitido aapenas letras");
                return;
            }
            String txt = "";
            for (int i = 0; i < palavra.Length; i++)
            {
                
                    if (palavra[i] == letra)
                    {
                        encontrou = true;
                        pletra = i;

                        txt = txt + txtBxLetra.Text;
                    }
                    else
                    {
                        txt = txt + tela[i];
                    }
                }
            
                tela = txt;
                txtBxPalavra.Text = tela;
                txtBxPalavra.Clear();
                tentativas--;
            lblRestante.Text = tentativas.ToString();
            if(tentativas <= 0)
            {
                pnlGame.Visible = false;
            }
        }
        
    }
    
}

