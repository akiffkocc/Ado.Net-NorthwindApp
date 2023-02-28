using KuzeyYeli.ORM.Entity;
using KuzeyYeli.ORM.Facade;

namespace KuzeyYeli_WinForm
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource= Products.Listele();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Product entity = new Product();
            entity.ProductName = txtUrunAdi.Text;
            entity.UnitPrice=numFiyat.Value;
            entity.UnitInStock =(short) numStok.Value;
            if(!Products.Ekle(entity))
                MessageBox.Show("Ürün Eklenemedi");

            dataGridView1.DataSource = Products.Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count==0) return;

            Product silinecek = new Product();
            silinecek.ProductId = (int)dataGridView1.CurrentRow.Cells["ProductId"].Value;
            if(!Products.Sil(silinecek))
                MessageBox.Show("Silinemedi");

            dataGridView1.DataSource=Products.Listele();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            txtUrunAdi.Text = row.Cells["ProductName"].Value.ToString();
            txtUrunAdi.Tag = row.Cells["ProductId"].Value;
            numFiyat.Value = (decimal)row.Cells["UnitPrice"].Value;
            numStok.Value = Convert.ToDecimal(row.Cells["UnitsInStock"].Value);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Product guncelle = new Product();
            guncelle.ProductId = (int)txtUrunAdi.Tag;
            guncelle.ProductName= txtUrunAdi.Text;
            guncelle.UnitPrice= numFiyat.Value;
            guncelle.UnitInStock=(short) numStok.Value;
            if(!Products.Guncelle(guncelle))
                MessageBox.Show("Güncelleme Baþarýsýz.");
            dataGridView1.DataSource=Products.Listele();
        }
    }
}