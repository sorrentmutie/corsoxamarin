using DemoCorsoMattina.Models;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace DemoCorsoMattina
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            LoadData();
        }

        //private void Cliccami(object sender, EventArgs e)
        //{
        //    Saluto.Text = "Testo Aggiornato";
        //}

        private void LoadData()
        {
            var person = new Person { Id = 1, Name = "Mario", Surname = "Rossi", 
                ImageUrl= "https://www.servizi-web-marketing.it/images/stories/news/immaginedascaricare.jpg"
            };

            var people = new List<Person>
            {
                new Person { Id = 2, Name = "Luigi", Surname = "Bianchi",
                ImageUrl= "https://www.servizi-web-marketing.it/images/stories/news/immaginedascaricare.jpg"},
                new Person { Id = 3, Name = "Giuseppe", Surname = "Verdi",
                ImageUrl= "https://1ty.vn/datafiles/3/2018-06-08/Satya-Nadella-15284509978888.jpg"},
                new Person { Id = 4, Name = "Salvatore", Surname = "Sorrentino",
                ImageUrl= "https://1ty.vn/datafiles/3/2018-06-08/Satya-Nadella-15284509978888.jpg"},
            };

            BindingContext = person;
            listOfPeople.ItemsSource = people;
        }

    }
}
