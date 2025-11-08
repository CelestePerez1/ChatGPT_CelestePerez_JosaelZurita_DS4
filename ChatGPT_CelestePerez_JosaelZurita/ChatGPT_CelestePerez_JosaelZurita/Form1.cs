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
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private async void btnEnviar_Click(object sender, EventArgs e)
        {
            string pregunta = textPrompt.Text;

            // ? Validación de entrada vacía o solo espacios
            if (string.IsNullOrWhiteSpace(pregunta))
            {
                MessageBox.Show("Por favor, escribe un mensaje antes de enviar.");
                return;
            }

            // ? Validación de longitud máxima
            if (pregunta.Length > 1000)
            {
                MessageBox.Show("El mensaje supera el límite de 1000 caracteres. Por favor, acórtalo antes de enviarlo.");
                return;
            }

            // Deshabilitar botón y mostrar estado
            btnEnviar.Enabled = false;
            label1.Text = "Enviando...";

            try
            {
                // Mostrar el mensaje del usuario en el chat
                textChat.AppendText($"Tú: {pregunta}\r\n\r\n");

                // Crear cliente (puedes reutilizar el de Form_Load)
                var apiKey = Environment.GetEnvironmentVariable("OPENAI_API_KEY");
                var chatClient = new OpenAI.Chat.ChatClient(model: "gpt-4o-mini", apiKey: apiKey);

                // Obtener respuesta del modelo
                var respuesta = await chatClient.CompleteChatAsync(pregunta);

                // Mostrar respuesta del asistente con salto doble
                string textoRespuesta = respuesta.Value.Content[0].Text.Trim();
                textChat.AppendText($"Asistente: {textoRespuesta}\r\n\r\n");

                // ?? Scroll automático hacia el final
                textChat.SelectionStart = textChat.Text.Length;
                textChat.ScrollToCaret();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al comunicarse con OpenAI:\n{ex.Message}");
            }
            finally
            {
                // Rehabilitar botón y restablecer estado
                btnEnviar.Enabled = true;
                label1.Text = "Listo";
                textPrompt.Clear();
                textPrompt.Focus();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Obtiene la API key desde las variables de entorno del usuario
            string apiKey = Environment.GetEnvironmentVariable("OPENAI_API_KEY");
            //validaciones
            if (string.IsNullOrEmpty(apiKey))
            {
                MessageBox.Show("No se encontró la API key en el entorno. Configúrala antes de continuar.");
                return;
            }

            client = new OpenAIClient(apiKey);
            MessageBox.Show("Conexión exitosa con OpenAI");
        }

        //Limpiar campos de entrada y respuesta
        private void btnCls_Click(object sender, EventArgs e)
        {
            textPrompt.Clear();
            textChat.Clear();
            label1.Text = "Listo";
        }
    }
}
