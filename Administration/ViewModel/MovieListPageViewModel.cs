using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Windows;
using Administration.Editors;
using Administration.Properties;
using Administration.View;
using DataAccess.Model;
using DataAccess.Repository;

namespace Administration.ViewModel
{
    public class MovieListPageViewModel
    {
        private readonly MovieListPage view;
        private readonly IMovieRepository repository;

        public ObservableCollection<Movie> Movies { get; private set; } 

        public MovieListPageViewModel(MovieListPage view, IMovieRepository repository)
        {
            this.view = view;
            this.repository = repository;

            RetrieveData();
        }

        private void RetrieveData()
        {
            if (Movies == null)
            {
                Movies = new ObservableCollection<Movie>();
                Movies.CollectionChanged += MoviesOnCollectionChanged;
            }

            var movies = repository.GetMovies().ToList();

            Movies.Clear();
            movies.ForEach(movie => Movies.Add(movie));
        }

        private void MoviesOnCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            view.ListCount = Movies.Count;
        }

        public void OpenEditor(Movie movie)
        {
            try
            {
                if (movie != null)
                {
                    repository.GetMovieDetails(movie);
                    movie = movie.Clone();
                }

                var editor = new MovieEditorWindow(movie);
                var result = editor.ShowDialog();

                if (result.HasValue && result.Value)
                {
                    RetrieveData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Delete(Movie movie)
        {
            var result = MessageBox.Show(
                string.Format(Resources.DeleteMovieConfirmationText, movie.Title),
                Resources.DeleteConfirmationCaption,
                MessageBoxButton.YesNo);

            if (result == MessageBoxResult.Yes)
            {
                try
                {
                    repository.Delete(movie);
                    RetrieveData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}