using System.Data;

namespace โปรเจค2
{
    public partial class Form1 : Form
    {

        private string[] data;
        private object dtItems;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Menu.SelectedItem.ToString() == "Latte")
            {
                if (typecombo.SelectedItem.ToString() == "Frapp")
                {
                    paytext.Text = (float.Parse(quanitycombo.Text) * 40).ToString();
                }
                if (typecombo.SelectedItem.ToString() == "Ice")
                {
                    paytext.Text = (float.Parse(quanitycombo.Text) * 45).ToString();
                }
                if (typecombo.SelectedItem.ToString() == "Hot")
                {
                    paytext.Text = (float.Parse(quanitycombo.Text) * 35).ToString();
                }
                dataGridView1.Rows.Add(idtext.Text, Menu.Text, typecombo.Text, quanitycombo.Text, paytext.Text);
            }
            if (Menu.SelectedItem.ToString() == "Mocha")
            {
                if (typecombo.SelectedItem.ToString() == "Frapp")
                {
                    paytext.Text = (float.Parse(quanitycombo.Text) * 40).ToString();
                }
                if (typecombo.SelectedItem.ToString() == "Ice")
                {
                    paytext.Text = (float.Parse(quanitycombo.Text) * 45).ToString();
                }
                if (typecombo.SelectedItem.ToString() == "Hot")
                {
                    paytext.Text = (float.Parse(quanitycombo.Text) * 35).ToString();
                }
                dataGridView1.Rows.Add(idtext.Text, Menu.Text, typecombo.Text, quanitycombo.Text, paytext.Text);
            }
            if (Menu.SelectedItem.ToString() == "Capuccino")
            {
                if (typecombo.SelectedItem.ToString() == "Frapp")
                {
                    paytext.Text = (float.Parse(quanitycombo.Text) * 40).ToString();
                }
                if (typecombo.SelectedItem.ToString() == "Ice")
                {
                    paytext.Text = (float.Parse(quanitycombo.Text) * 45).ToString();
                }
                if (typecombo.SelectedItem.ToString() == "Hot")
                {
                    paytext.Text = (float.Parse(quanitycombo.Text) * 35).ToString();
                }
                dataGridView1.Rows.Add(idtext.Text, Menu.Text, typecombo.Text, quanitycombo.Text, paytext.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            idtext.Text = " ";
            Menu.Text = " ";
            typecombo.Text = " ";
            quanitycombo.Text = " ";
            paytext.Text = " ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bill bill = new Bill(idtext.Text, Menu.Text, paytext.Text);
            bill.ShowDialog();
        }
        


        private void button4_Click(object sender, EventArgs e)
        {
            {
                openFileDialog1.ShowDialog();
                string file = openFileDialog1.FileName;
                loadProductFromFile(file);
            }
        }

        private void loadProductFromFile(string Npath)
        {
            string[] lines = System.IO.File.ReadAllLines(Npath);
            if (lines.Length > 0)
            {

                for (int i = 1; i < lines.Length; i++)
                {
                    data = lines[i].Split(',');
                    dataGridView1.Rows.Add(data[0], data[1], data[2],data[3],data[4]);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string FNhistoryFile = "file.csv";
            string pathHIstory = Path.Combine(Environment.CurrentDirectory, @"\", FNhistoryFile);
            string fileHIstory = idtext.Text + "," + Menu.Text + "," + typecombo.Text + "," + quanitycombo.Text + "," + paytext.Text;
            StreamWriter sw = File.AppendText(pathHIstory);
            sw.WriteLine(fileHIstory);
            sw.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
        }
        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        //    dataGridView1.Columns.Insert(0, new DataGridViewCheckBoxColumn());

        //}
    } 
}