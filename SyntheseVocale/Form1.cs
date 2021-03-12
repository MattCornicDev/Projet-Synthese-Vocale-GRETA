using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;


namespace SyntheseVocale
{
    public partial class Form1 : Form
    {
        private SpeechRecognitionEngine moteurReconnaissance;
        private Choices formeChoisie;
        private GrammarBuilder contraintesReconnaissance;
        private Grammar motsAReconnaitre;

        private Bitmap imageAssociee;
        private int moteurReconnaissance_SpeechRecognized;
        private int moteurReconnaissance_SpeechRecognitionRejected;

        public Form1()
        {
            InitializeComponent();

            // instanciation d'une reconnaissance vocales
            moteurReconnaissance = new SpeechRecognitionEngine();
            // On précise que l'acquisition se fera sur le canal d'entrée audio par défaut (micro)
            moteurReconnaissance.SetInputToDefaultAudioDevice();
            // On constuir le dictionnaire des mots à reconnaissance, ceux qui ne figurent pas dans cette liste ne seront pas reconnus
            formeChoisie = new Choices(new string[] { "carré", "cercle", "triangle" });
            // On implante le dictionnaire dans le moteur de reconnaissance en utilisant un GrammarBuilder
            contraintesReconnaissance = new GrammarBuilder(formeChoisie);
            motsAReconnaitre = new Grammar(contraintesReconnaissance);
            moteurReconnaissance.LoadGrammarAsync(motsAReconnaitre);

            // Abonnement aux évènements liés à la reconnaissance vocale
            // Evènement déclencher lorsqu'un mot est reconnu
            moteurReconnaissance.SpeechRecognized += MoteurReconnaissance_SpeechRecognized2;
            // Evenement déclencheur lorqu'un mot n'est pas reconnu
            moteurReconnaissance.SpeechRecognitionRejected += MoteurReconnaissance_SpeechRecognitionRejected1;

           


        }

        private void MoteurReconnaissance_SpeechRecognitionRejected1(object sender, SpeechRecognitionRejectedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void MoteurReconnaissance_SpeechRecognized2(object sender, SpeechRecognizedEventArgs e)
        {
            throw new NotImplementedException();
        }


        private void MoteurReconnaissance_SpeechRecognitionRejected(object sender, SpeechRecognitionRejectedEventArgs e)
        {
            // Si le mot n'est pas reconnu on informe l'utilisateur 
            MessageBox.Show("Mot non reconnu");
        }

        private void MoteurReconnaissance_SpeechRecognized(object sender, SpeechRecognitionRejectedEventArgs e)
        {
            // Si le mot est reconnu on affiche l'image correspond à la forme reconnue
            // et on ajoute le texte dans le richtext box prévu à cet effet
            richTextBoxReco.AppendText(e.Result.Text);
            richTextBoxReco.AppendText("\n");
            FileStream fluxImage;

            switch (e.Result.Text)
            {
                case "carré":
                    fluxImage = new FileStream(@"..\images\carre.jpg", FileMode.Open);
                    pictureBoxAssociee.Image = Image.FromStream(fluxImage);
                    fluxImage.Close();
                    break;
                case "cercle":
                    fluxImage = new FileStream(@"..\images\cercles.jpg", FileMode.Open);
                    pictureBoxAssociee.Image = Image.FromStream(fluxImage);
                    fluxImage.Close();
                    break;
                case "triangle":
                    fluxImage = new FileStream(@"\..\images\triangles.jpg", FileMode.Open);
                    pictureBoxAssociee.Image = Image.FromStream(fluxImage);
                    fluxImage.Close();
                    break;
                default: break;

            }
        }

        private void buttonParler_Click(object sender, EventArgs e)
        {
            // on ne reconnait qu'un mot à la fois
            moteurReconnaissance.RecognizeAsync(RecognizeMode.Single);
        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

