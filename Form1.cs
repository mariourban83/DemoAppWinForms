using Microsoft.VisualBasic.ApplicationServices;
using System.Data.SqlClient;
using static DemoAppWinForms.Form1;

namespace DemoAppWinForms
{
    public partial class Form1 : Form
    {
        public string connectionString = "Server=localhost,1433;Database=Products;User Id=sa;Password=MyStrong!Passw0rd;TrustServerCertificate=true;";

        public bool isLoading = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            isLoading = true;
            if (string.IsNullOrEmpty(textBoxProductId.Text)
                || string.IsNullOrEmpty(comboBoxColor.Text)
                || string.IsNullOrEmpty(textBoxItemName.Text)
                || string.IsNullOrEmpty(textBoxDesign.Text)
                || string.IsNullOrEmpty(textBoxStock.Text)
                || string.IsNullOrEmpty(textBoxPrice.Text))
            {
                MessageBox.Show("All Fields are required when adding new products");
                isLoading = false;
                return;
            }
            else
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO allProducts VALUES (@ProductId, @Color, @ItemName, @Design, @Stock, @Price)", connection);
                command.Parameters.AddWithValue("@ProductId", int.Parse(textBoxProductId.Text));
                command.Parameters.AddWithValue("@Color", comboBoxColor.Text);
                command.Parameters.AddWithValue("@ItemName", textBoxItemName.Text);
                command.Parameters.AddWithValue("@Design", textBoxDesign.Text);
                command.Parameters.AddWithValue("@Stock", int.Parse(textBoxStock.Text));
                command.Parameters.AddWithValue("@Price", textBoxPrice.Text);

                command.ExecuteNonQuery();
                connection.Close();
                isLoading = false;

                MessageBox.Show(textBoxItemName.Text + " : succesfully added to the database. ✔");
                textBoxProductId.Text = "";
                comboBoxColor.Text = "";
                textBoxItemName.Text = "";
                textBoxDesign.Text = "";
                textBoxStock.Text = "";
                textBoxPrice.Text = "";

            }
        }

        public class Product
        {
            public string productId = "";
            public string? color;
            public string? itemName;
            public string? design;
            public int? stock;
            public int? price;

        }
    }
}