namespace Assignment_5._1__Final_Project___Incremental_Deliverables
{
    public partial class Form1 : Form
    {
        private List<string> user = new List<string> { "alice", "bob123", "charlie_d" };


        private string[] prohibitedwords = { "123", "badword", "test" };
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nom = textBox1.Text.Trim();

            if (string.IsNullOrWhiteSpace(nom))
            {
                label1.Text = "please enter a name.";
                return;
            }


            bool isvalid = true;
            foreach (string mot in prohibitedwords)
            {
                if (nom.Contains(mot))
                {
                    isvalid = false;
                    break;
                }
            }

            if (isvalid)
            {

                string nomFormatte = nom.Replace("_", "-").ToUpper();
                label1.Text = "name valid : " + nomFormatte;
            }
            else
            {
                label1.Text = "the name contains a forbidden word.";
            }
        }
    }
}
