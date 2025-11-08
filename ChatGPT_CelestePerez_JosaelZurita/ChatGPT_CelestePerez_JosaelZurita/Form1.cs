using OpenAI;
using OpenAI.Chat;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatGPT_CelestePerez_JosaelZurita
{
    public partial class Form1 : Form
    {

        private OpenAIClient client;

        public Form1()
        {
            InitializeComponent();
        }

        private async void btnEnviar_Click(object sender, EventArgs e)
        {
            string pregunta = textPrompt.Text;

            var apiKey = Environment.GetEnvironmentVariable("OPENAI_API_KEY");
            var client = new OpenAI.Chat.ChatClient(model: "gpt-4o-mini", apiKey: apiKey);

            var respuesta = await client.CompleteChatAsync(pregunta);

            // Mostrar el texto de la respuesta
            textChat.Text = respuesta.Value.Content[0].Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Obtiene la API key desde las variables de entorno del usuario
            string apiKey = Environment.GetEnvironmentVariable("OPENAI_API_KEY");

            if (string.IsNullOrEmpty(apiKey))
            {
                MessageBox.Show("No se encontró la API key en el entorno. Configúrala antes de continuar.");
                return;
            }

            client = new OpenAIClient(apiKey);
            MessageBox.Show("Conexión lista con OpenAI");
        }

        private void btnCls_Click(object sender, EventArgs e)
        {
            textPrompt.Clear();
            label1.Text = "Listo";
        }
    }
}
