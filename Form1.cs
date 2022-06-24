namespace _3004
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // добавляем один элемент
            comboBox1.Items.Add("Парагвай");
            // добавляем набор элементов
            comboBox1.Items.AddRange(new string[] { "Уругвай", "Эквадор" });
            // добавляем один элемент на определенную позицию
            comboBox1.Items.Insert(1, "Боливия");
        }
    }
}