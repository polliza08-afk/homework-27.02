using System.Text.Json;
using System.IO;
using System.Windows.Forms;

namespace Домашня_робота
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public class Subscriber
        {
            public string PIB { get; set; }
            public string Phone { get; set; }
            public string Address { get; set; }
        }

        public void SaveSubscribers()
        {
            string json = JsonSerializer.Serialize(subscribers, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            File.WriteAllText("subscribers.json", json);
        }

        List<Subscriber> subscribers = new List<Subscriber>();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Subscriber s = new Subscriber
            {
                PIB = txtPIB.Text,
                Phone = txtPhone.Text,
                Address = txtAdress.Text
            };

            subscribers.Add(s);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = subscribers;

            SaveSubscribers();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_Load_1(object sender, EventArgs e)
        {
            string json = JsonSerializer.Serialize(subscribers,
            new JsonSerializerOptions { WriteIndented = true });

            File.WriteAllText("subscribers.json", json);
        }

        private void SaveSubscribers_Click(object sender, EventArgs e)
        {
            string json = JsonSerializer.Serialize(subscribers,
            new JsonSerializerOptions { WriteIndented = true });

            File.WriteAllText("subscribers.json", json);
        }
    }
}
