using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        
        }

        public void Login_Clicked(object sender, EventArgs e)
        {
            var ID = EntryId.Text.ToString();
            var senha = Entrysenha.Text.ToString();


            if (ID == "admin" && senha == "@dmin")
            {
                DisplayAlert("Login", "Login realizado com sucesso", "OK");
            }
            else
            {
                DisplayAlert("Login", "Tente novamente", "OK");
               
            }

       

        }

        public void Limpar_Clicked(object sender, EventArgs e)
        {
            EntryId.Text = "";
            Entrysenha.Text = "";
        }
        
        public void Credito_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Créditos", "Fernanda", "OK");
        }



    }
}
