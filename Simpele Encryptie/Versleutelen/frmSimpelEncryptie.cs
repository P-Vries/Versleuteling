using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Versleutelen
{
    public partial class frmSimpelEncryptie : Form
    {

        //
        // Versie 5
        //

        public frmSimpelEncryptie()
        {
            InitializeComponent();
        }
        //
        //Methodes
        //
        private void Encryptie()// Encryptie Methode
        {
            Random rnd = new Random();//Maak een nieuwe random generator
            byte random = (byte)rnd.Next(1, 10);//genereer een nummer van 1 tot 10
            txbEncTekst.Text = random.ToString();//Maakt de TekstBox Leeg
            foreach (char c in txbSimpelTekst.Text)// Loop voor elk teken in de tekstbox
            {
                char encrypted = (char)(c + random);// maakt een nieuw teken door een Willekeurig nummer van 1 tot 10 toetevoegen aan de ascii-code van een teken
                txbEncTekst.Text += encrypted.ToString();//voegt het aangepaste teken aan de output van de toepassing
            }
        }
        private void Opslaan() //Opslaan Methode
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();// Laat een save file dialoog zien
            saveFileDialog1.Filter = "Text File | *.txt";//We laten ze kiezen uit meerdere bestanden of in dit geval alleen een txt File
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)// als er Ja of Ok wordt geklikt wordt dit uitgevoerd
            {
                try
                {
                    using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.CreateNew))//We gebruiken een stream om een nieuwe File te maken
                    using (StreamWriter sw = new StreamWriter(s))// We gebruiken dit om naar de net gemaakte File te schrijven.
                    {
                        sw.Write(txbEncTekst.Text);// De tekst wordt doorgegeven aan de SteamWriter
                    }
                }// We maken deze try-Catch omdat er mischien al een file bestaat
                catch(Exception e)
                {
                    MessageBox.Show(e.ToString());
                }//Laat de error Message zien op het scherrm
                
            }
            
        }
        private void Openen()//Openen Methode
        {
            Stream dezeStream; //We maken een stream variabel aan zodat we van een File kunnen lezen.
            OpenFileDialog openFileDialog1 = new OpenFileDialog();//We maken een Nieuwe FileDialoog aan en noemen het " fileDialog1"
            if (openFileDialog1.ShowDialog() == DialogResult.OK)// We kijken of de gebruiker op de OK knopo klikt in het dialoog met de computer
            {
                if ((dezeStream = openFileDialog1.OpenFile()) != null)//We maken de Stream gelijk aan de openFileDialog en kijken of deze niet leeg is. 
                {
                    string fileName = openFileDialog1.FileName;//De bestands locatie slaan we op in de string fileName
                    string fileTekst = File.ReadAllText(fileName);//Alle Tekst in het bestand word in de fileTekst string opgeslagen
                    txbSimpelTekst.Text = fileTekst; // De Tekstbox wordt gevuld met de string 
                }
            }
        }

        //
        //Events
        //
        private void btnEncryptie_Click(object sender, EventArgs e)// Encryptie
        {
            Encryptie();//Verwijzing naar de Encryptie Methode
        }

        private void btnSaveOutput_Click(object sender, EventArgs e)//Opslaan
        {
            Opslaan();//Verwijzing naar de Opslaan Methode
        }

        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            Openen();//Verwijzing naar de Openen Methode
        }
    }
}
