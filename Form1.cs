using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TodoGent_UI_2
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(GetSubmitButton());
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Global functions
            // Create a pipeline file data.txt if it does not exist
            if (!System.IO.File.Exists("data.txt"))
            {
                System.IO.File.Create("data.txt").Close();
            }
            else
            {
                // Truncate it
                using (StreamWriter sw = new StreamWriter("data.txt", false))
                {
                    sw.WriteLine("");
                }
            }
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            DateLabel.Text = DateTime.Now.ToString("hh:mm dd/MM/yyyy");
            richTextBox1.Text = "-";
            // Set the cursor to the end of the text
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.Focus();
        }

        private void DateLabel_Click(object sender, EventArgs e)
        {

        }

        private async Task SubmitButton_Click(object sender, EventArgs e)  // IMP: using 'void' as decorator need void not 'Task'
        {
            // Take the inputText
            string inputText = richTextBox1.Text;
            var timestamp = DateLabel.Text;

            // Provide the text to data.txt pipeline so Python can read it TODO: LATER

            // PROCESS OF SENDING DATA TO MODEL:
            var json = JsonSerializer.Serialize(new { text = inputText, timestamped = timestamp });  // convert to json
            var content = new StringContent(json, Encoding.UTF8, "application/json");  //make header

            progressBar1.Visible = true;
            progressBar1.Value = 50;

            // Send the request to the model
            // Load the setup required to connect to the model
            HttpClient client = new HttpClient();
            var response = await client.PostAsync("https://localhost:3000/input", content);
            progressBar1.Value = 100;
            Console.WriteLine(response.StatusCode);




        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void QueryTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void QueryButton_Click(object sender, EventArgs e)
        {
            string queryInput = QueryTextBox.Text;

        }
    }
}
