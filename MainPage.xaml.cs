using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DefuseBombs1
{
    public partial class MainPage : ContentPage
    {

        static string bomb = new Random().Next(1, 6).ToString();
        static int scores = 0;
        public MainPage()
        {
            InitializeComponent();
        }
        async void ButtonClicked(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (button.Text == bomb)
            {
                await DisplayAlert("Bomb Exploded", "Game Over", "Retry");
                bomb = new Random().Next(1, 6).ToString();
                scores = 0;
                button.BackgroundColor = Color.Gray;
                BackgroundColor = Color.Red;
                
            }
            else
            {
                scores += 1;
                await DisplayAlert("Bomb Defused!", "Scores: " + scores, "Continue");
                bomb = new Random().Next(1, 6).ToString();
                button.BackgroundColor = Color.Green;
                BackgroundColor = Color.White;
            }
        }   
    }
}
