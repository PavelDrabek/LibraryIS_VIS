using System.Windows.Forms;
using LibraryIS_WinForm.Views;
using LibraryIS_WinForm.Controllers;
using LIS.Entities;
using LIS.Services;
using System.Collections.Generic;

namespace LibraryIS_WinForm.Forms
{
    public partial class BookDetail : UserControl, IBookView
    {
        BookController controller;

        AuthorService authorService;
        GenreService genreService;
        PublisherService publisherService;

        int id;
        Author _author;
        Genre _genre;
        Publisher _publisher;

        List<Author> authors;
        List<Genre> genres;
        List<Publisher> publishers;

        public BookDetail()
        {
            InitializeComponent();

            authorService = new AuthorService();
            genreService = new GenreService();
            publisherService = new PublisherService();

            authors = authorService.GetAll();
            genres = genreService.GetAll();
            publishers = publisherService.GetAll();

            cbAuthor.Items.AddRange(authors.ToArray());
            cbGenre.Items.AddRange(genres.ToArray());
            cbPublisher.Items.AddRange(publishers.ToArray());
        }

        public void SetController(BookController controller)
        {
            this.controller = controller;
        }

        public string Title
        {
            get { return tbTitle.Text; }
            set { tbTitle.Text = value; }
        }

        public string ISBN
        {
            get { return tbIsbn.Text; }
            set { tbIsbn.Text = value; }
        }

        public Publisher publisher
        {
            get { return _publisher; }
            set { cbPublisher.SelectedIndex = (value == null) ? -1 : publishers.FindIndex(x => x.ID == value.ID); }
        }
        
        public Genre genre
        {
            get { return _genre; }
            set { cbGenre.SelectedIndex = (value == null) ? -1 : genres.FindIndex(x => x.ID == value.ID ); }
        }

        public Author author
        {
            get { return _author; }
            set { cbAuthor.SelectedIndex = (value == null) ? -1 : authors.FindIndex(x => x.ID == value.ID); }
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public int Pages
        {
            get { return int.Parse(tbPages.Text); }
            set { tbPages.Text = value.ToString(); }
        }

        private void cbAuthor_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (cbAuthor.SelectedIndex >= 0) {
                _author = authors[cbAuthor.SelectedIndex];
            } else {
                _author = null;
            }
        }

        private void cbGenre_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (cbGenre.SelectedIndex >= 0) {
                _genre = genres[cbGenre.SelectedIndex];
            } else {
                _genre = null;
            }
        }
        
        private void cbPublisher_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (cbPublisher.SelectedIndex >= 0) {
                _publisher = publishers[cbPublisher.SelectedIndex];
            } else {
                _publisher = null;
            }
        }
    }
}
