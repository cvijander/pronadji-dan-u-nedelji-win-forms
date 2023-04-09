namespace Dan_u_nedelji
{
    public partial class Form1 : Form
    {
        private Random r = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime danas = DateTime.Now;
            for (int i = 0; i < 20; i++)
            {
                int razlika = r.Next(0, 1000);
                DateTime noviDatum = danas.AddDays(razlika);
                listBox1.Items.Add(noviDatum.ToShortDateString());
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            DateTime datum = DateTime.Parse(listBox1.Items[index].ToString());
            richTextBox1.Text = "Engl: " + datum.DayOfWeek;
            int redniBroj = 0;
            if ((int)datum.DayOfWeek == 0) redniBroj = 7;
            else redniBroj = (int)datum.DayOfWeek;
            richTextBox1.Text += "\n " + "Redni broj: " + redniBroj;
            richTextBox1.Text += "\n";
            richTextBox1.Text += "Srps: " + Srpski(redniBroj);
        }

        private string Srpski(int dayOfWeek)
        {
            string[] dani = { "Ponedeljak", "Utorak", "Sreda", "Cetvrtak", "Petak", "Subota", "Nedelja" };
            int index = dayOfWeek - 1;
            return dani[index].ToString();
        }
    }
}