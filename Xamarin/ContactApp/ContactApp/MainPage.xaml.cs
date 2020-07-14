using ContactApp.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ContactApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        void SaveButton_Clicked(object sender, EventArgs e)
        {
            //criar uma instância da classe
            //alimentar o conteúdo dos campos da interface na classe Contact
            Contact contact = new Contact()
            {
                Name = nameEntry.Text,
                LastName = lastNameEntry.Text,
                Email = emailEntry.Text,
                PhoneNumber = phoneEntry.Text,
                Address = adressEntry.Text
            };

            // chamar a conexão com o bd interno
            using (SQLiteConnection conn = new SQLiteConnection(Path.Combine(Environment.GetFolderPath
                  (Environment.SpecialFolder.LocalApplicationData), "contact.db3")))
            {
                //criar a tabela - mesma estrutura definida na classe
                //se a tabela já está criada - é feita a associação
                //se não está criada - cria
                conn.CreateTable<Contact>();
                //Insert - add o item na tabela (classe)
                //rowsAdded - mostrar null caso a operação não foi realizada
                // 1 caso foi inserido
                int rowsAdded =  conn.Insert(contact);


            }

        }

        void MostraButton_Clicked(object sender, EventArgs e)
        {
            // faz a conexão
            using (SQLiteConnection conn = new SQLiteConnection(Path.Combine(Environment.GetFolderPath
                  (Environment.SpecialFolder.LocalApplicationData), "contact.db3")))
            {
                //cria a tabela
                conn.CreateTable<Contact>();
                //método toList para carregar os dados no objeto contacts
                var contacts = conn.Table<Contact>().ToList();
                //carrega os dados no listview
                contactListView.ItemsSource = contacts;

            }

        }
    }
}
