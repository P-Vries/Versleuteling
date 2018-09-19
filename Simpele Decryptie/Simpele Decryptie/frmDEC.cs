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

namespace Simpele_Decryptie
{
    public partial class frmDEC : Form
    {
        //
        //Versie 5
        //

        //
        //Vars
        //
        private string Out;//Deze wordt later gebruikt voor de Decryptie

        public frmDEC()
        {
            InitializeComponent();
        }

        //
        //Methodes
        //
        private void Decryptie()// Decryptie Methode
        {
            
            byte randomInput = byte.Parse(txbInvoer.Text.Substring(0, 1));// Hier kijken we naar het eerste cijfer wat gebruikt word om te ontcijfewren later
            txbUitvoer.Text = "";//Maakt de TekstBox Leeg
            foreach (char c in txbInvoer.Text)// Loop voor elk teken in de tekstbox
            {
                char decrypted = (char)(c - randomInput);// maakt een nieuw teken door het eerste nummer aftetrekken aan de ascii-code van een teken
                Out += decrypted.ToString();//voegt het aangepaste teken aan de output van de methode
            }
            Out = Out.Substring(1);//Hier verwijderen we het eerste nummer waarmee we de waarde hadden vertaald
            txbUitvoer.Text = Out;//Hier voegen we het toe aan het scherm.
            Out = "";// Hier maken we deze variabel leeg zodat we hem opnieuw kunnen gebruiken zonder problemen
        }

        private void Openen()//Openen Methode
        {
            Stream dezeStream; //We maken een stream variabel aan zodat we van een File kunnen lezen.
            OpenFileDialog openFileDialog1 = new OpenFileDialog();//We maken een Nieuwe FileDialoog aan en noemen het " fileDialog1"
            if (openFileDialog1.ShowDialog() == DialogResult.OK)// We kijken of de gebruiker op de OK knopo klikt in het dialoog met de computer
            {
                if ((dezeStream = openFileDialog1.OpenFile())!= null)//We maken de Stream gelijk aan de openFileDialog en kijken of deze niet leeg is. 
                {
                    string fileName = openFileDialog1.FileName;//De bestands locatie slaan we op in de string fileName
                    string fileTekst = File.ReadAllText(fileName);//Alle Tekst in het bestand word in de fileTekst string opgeslagen
                    txbInvoer.Text = fileTekst; // De Tekstbox wordt gevuld met de string 
                }
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
                        sw.Write(txbUitvoer.Text);// De tekst wordt doorgegeven aan de SteamWriter
                    }
                }// We maken deze try-Catch omdat er mischien al een file bestaat
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }//Laat de error Message zien op het scherrm

            }

        }

        //
        //Events
        //
        private void button1_Click(object sender, EventArgs e)
        {
            Decryptie();//Verwijzeing naar de Decryptie methode
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Openen();//Verwijzing naar de Opnenen methhode
        }

        private void btnUitOpslaan_Click(object sender, EventArgs e)
        {
            Opslaan();//Verwijzing naar de Opslag methode
        }
    }
}
