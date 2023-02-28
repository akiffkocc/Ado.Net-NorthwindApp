using KuzeyYeli.ORM.Entity;
using KuzeyYeli.ORM.Facade;

namespace KuzeyYeli_WinForm
{
    public partial class CategoriesFrom : Form
    {
        public CategoriesFrom()
        {
            InitializeComponent();
        }

        private void CategoriesFrom_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            dataGridView1.DataSource = Categories.Listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Category k = new Category();
            k.CategoryName=txtCategoryName.Text;
            k.Description=txtDescription.Text;
            if(!Categories.Ekle(k))
                MessageBox.Show("Kategori Eklenemedi.");
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            Category k = new Category();
            k.CategoryId = (int)dataGridView1.CurrentRow.Cells["CategoryId"].Value;
            if(!Categories.Sil(k))
                MessageBox.Show("Kategori Silinemedi.");
            Listele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            txtCategoryName.Text = dataGridView1.CurrentRow.Cells["CategoryName"].Value.ToString();
            txtDescription.Text = dataGridView1.CurrentRow.Cells["Description"].Value.ToString();
            txtCategoryName.Tag = dataGridView1.CurrentRow.Cells["CategoryId"].Value;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Category k = new Category();
            k.CategoryName= txtCategoryName.Text;
            k.Description=txtDescription.Text;
            k.CategoryId = (int)txtCategoryName.Tag;
            if(!Categories.Guncelle(k))
                MessageBox.Show("Güncelleme Başarısız.");
            Listele();
        }
    }
}
