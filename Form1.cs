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
            // ��������� ���� �������
            comboBox1.Items.Add("��������");
            // ��������� ����� ���������
            comboBox1.Items.AddRange(new string[] { "�������", "�������" });
            // ��������� ���� ������� �� ������������ �������
            comboBox1.Items.Insert(1, "�������");
        }
    }
}