using System;
using System.Data.Entity;
using System.Windows.Forms;
using EntityFrameworkNavigationProperties.Models;

namespace EntityFrameworkNavigationProperties
{
    public partial class MoviesForm : Form
    {
        CSharpAdvancedContext dbContext;

        public MoviesForm()
        {
            InitializeComponent();

            dbContext = new CSharpAdvancedContext();
            dbContext.Movies.Load();

            dgvMovies.DataSource = dbContext.Movies.Local.ToBindingList();
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            var name = tbName.Text;
            var genre = tbGenre.Text;
            var year = int.Parse(tbYear.Text);

            dbContext.Movies.Add(new Movie() { Name = name, Genre = genre, Year = year });
            dbContext.SaveChanges();

            dgvMovies.Refresh();
        }
    }
}
