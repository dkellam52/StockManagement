namespace StoreManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //panel1.Hide();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddItem form3 = new AddItem();
            form3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FindSupplier form4 = new FindSupplier();
            form4.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EditSupplier form5 = new EditSupplier();
            form5.ShowDialog();
        }
    }
}