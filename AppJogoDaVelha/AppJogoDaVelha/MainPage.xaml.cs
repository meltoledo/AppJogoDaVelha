using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppJogoDaVelha
{
    public partial class MainPage : ContentPage
    {

        string vez = "X";
        bool ganhou = false;
        int  jogadas = 0;
        public MainPage()
        {
            InitializeComponent();
        }

        private void bnt_Clicked(object sender, EventArgs e)
        {
            Button botao_clicado = (Button)sender;
            jogadas++;
            botao_clicado.IsEnabled = false;

            if(vez == "X")
            {
                botao_clicado.Text = "X";
                vez = "O";
            }
            else
            {
                botao_clicado.Text = "O";
                vez = "X";
            }
            /* verificando quem ganhou na primeira linh */
            if(btn10.Text == "X" &&
                btn11.Text == "X" &&
                btn12.Text == "X"
                )
            {
                ganhou = true;
                DisplayAlert("Ganhou!", "O X ganhou!", "OK");
                zerar();
            }
            /* verificando quem ganhou na 2 linh */
            else if (btn20.Text == "X" &&
               btn21.Text == "X" &&
               btn22.Text == "X"
               )
            {
                ganhou = true;
                DisplayAlert("Ganhou!", "O X ganhou!", "OK");
                zerar();
            }
            /* verificando quem ganhou na 3 linh */
            else if (btn30.Text == "X" &&
              btn31.Text == "X" &&
              btn32.Text == "X"
              )
            {
                ganhou = true;
                DisplayAlert("Ganhou!", "O X ganhou!", "OK");
                zerar();
            }
            /* verificando quem ganhou na vertical */
            else if (btn10.Text == "X" &&
             btn21.Text == "X" &&
             btn32.Text == "X"
             )
            {
                ganhou = true;
                DisplayAlert("Ganhou!", "O X ganhou!", "OK");
                zerar();
            }
            /* verificando quem ganhou na vertical */
            else if (btn30.Text == "X" &&
             btn21.Text == "X" &&
             btn12.Text == "X"
             )
            {
                ganhou = true;
                DisplayAlert("Ganhou!", "O X ganhou!", "OK");
                zerar();
            }
            /* verificando quem ganhou na primeira colun */
            else if (btn10.Text == "X" &&
            btn20.Text == "X" &&
            btn30.Text == "X"
            )
            {
                ganhou = true;
                DisplayAlert("Ganhou!", "O X ganhou!", "OK");
                zerar();
            }
            /* verificando quem ganhou na 2 colun */
            else if (btn11.Text == "X" &&
           btn21.Text == "X" &&
           btn31.Text == "X"
           )
            {
                ganhou = true;
                DisplayAlert("Ganhou!", "O X ganhou!", "OK");
                zerar();
            }
            /* verificando quem ganhou na 3 colun */
            else if (btn12.Text == "X" &&
           btn22.Text == "X" &&
           btn32.Text == "X"
           )
            {
                ganhou = true;
                DisplayAlert("Ganhou!", "O X ganhou!", "OK");
                zerar();
            }

            else if (btn10.Text == "O" &&
             btn11.Text == "O" &&
             btn12.Text == "O"
             )
            {
                ganhou = true;
                DisplayAlert("Ganhou!", "O O ganhou!", "OK");
                zerar();
            }





            else if (btn20.Text == "O" &&
            btn21.Text == "O" &&
            btn22.Text == "O")
            {
                ganhou = true;
                DisplayAlert("Ganhou!", "O O ganhou!", "OK");
                zerar();
            }

            else if (btn30.Text == "O" &&
            btn31.Text == "O" &&
            btn32.Text == "O")
            {
                ganhou = true;
                DisplayAlert("Ganhou!", "O O ganhou!", "OK");
                zerar();
            }



            else if (btn10.Text == "O" &&
            btn21.Text == "O" &&
            btn22.Text == "O")
            {
                ganhou = true;
                DisplayAlert("Ganhou!", "O O ganhou!", "OK");
                zerar();
            }

            else if (btn30.Text == "O" &&
             btn21.Text == "O" &&
             btn12.Text == "O")
            {
                ganhou = true;
                DisplayAlert("Ganhou!", "O O ganhou!", "OK");
                zerar();
            }

            else if (btn10.Text == "O" &&
           btn20.Text == "O" &&
           btn30.Text == "O")
            {
                ganhou = true;
                DisplayAlert("Ganhou!", "O O ganhou!", "OK");
                zerar();
            }
            else if (btn10.Text == "O" &&
           btn21.Text == "O" &&
           btn31.Text == "O"
           )
            {
                ganhou = true;
                DisplayAlert("Ganhou!", "O O ganhou!", "OK");
                zerar();
            }





            else if (btn12.Text == "O" &&
           btn22.Text == "O" &&
           btn32.Text == "O"
           )
            {
                ganhou = true;
                DisplayAlert("Ganhou!", "O O ganhou!", "OK");
                zerar();
            }



            else if (ganhou==false && jogadas ==9)
            {
                DisplayAlert("Ninguem ganhou!", "Deu Velha!", "OK");
                zerar();
            }






        }

        void zerar()
        {
            btn10.IsEnabled = true;
            btn10.Text = "";

            btn11.IsEnabled = true;
            btn11.Text = "";

            btn12.IsEnabled = true;
            btn12.Text = "";


            btn20.IsEnabled = true;
            btn20.Text = "";

            btn21.IsEnabled = true;
            btn21.Text = "";

            btn22.IsEnabled = true;
            btn22.Text = "";


            btn30.IsEnabled = true;
            btn30.Text = "";

            btn31.IsEnabled = true;
            btn31.Text = "";

            btn32.IsEnabled = true;
            btn32.Text = "";

            jogadas = 0;

        }

    }
}
