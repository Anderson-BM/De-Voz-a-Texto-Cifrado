using System;
using System.Speech.Recognition;  //---- AQUI ESTA LA LIBRERIA UTILIZADA
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace ANDERSON_PROJECTO_AI
{
    public partial class txtResultado : Form
    {
        private SpeechRecognitionEngine recognizer;
        private StringBuilder textoReconocido;

        public txtResultado()
        {
            InitializeComponent();

            // Configurare el motor de reconocimiento de voz
            recognizer = new SpeechRecognitionEngine();
            recognizer.LoadGrammar(new DictationGrammar());
            recognizer.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(Recognizer_SpeechRecognized);
            recognizer.RecognizeCompleted += new EventHandler<RecognizeCompletedEventArgs>(Recognizer_RecognizeCompleted);

            textoReconocido = new StringBuilder();
        }

        // ----- ESTE ES EL PUNTO DE RECONOCIEMIENTO DE VOZ
        private void Recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            // aqui Agregue el texto reconocido en lugar de sobrescribir
            textoReconocido.Append(e.Result.Text + " ");
            txtResultado2.Text = textoReconocido.ToString();
        }

        private void Recognizer_RecognizeCompleted(object sender, RecognizeCompletedEventArgs e)
        {
            MessageBox.Show("El reconocimiento de audio ha finalizado.");
        }


        // --- METODO CON EL CUAL SE ENCRITA EL TEXTO
        private string EncriptarTexto(string texto)
        {
            byte[] data = Encoding.UTF8.GetBytes(texto);
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashData = sha256.ComputeHash(data);
                return Convert.ToBase64String(hashData);
            }
        }

        // --- ESTE METODO ES PARA SELECIONAR EL ARCHIVO Y HACER LA TRASCRICION
        private void btnConvertir_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Archivos WAV|*.wav",
                Title = "Selecciona un archivo de audio"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //---- ESTO ES OARA QUE LIMPIE EL TEXTO
                    textoReconocido.Clear();
                    txtResultado2.Clear();

                    recognizer.SetInputToWaveFile(openFileDialog.FileName);
                    recognizer.RecognizeAsync(RecognizeMode.Multiple);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al procesar el archivo de audio: " + ex.Message);
                }
            }

    }

        // --- ESTE METODO ES PARA EL CIFRADO DE EL CODIGO
        private void btnHaxeo_Click(object sender, EventArgs e)
        {


            if (textoReconocido.Length > 0)
            {
                txtResultado2.Text = EncriptarTexto(textoReconocido.ToString());
            }
            else
            {
                MessageBox.Show("Primero convierta el audio a texto.");
            }
        }

        private void txtResultado2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}