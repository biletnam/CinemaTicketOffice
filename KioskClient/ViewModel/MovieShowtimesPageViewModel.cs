using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Timers;
using DataAccess.Model;
using DataAccess.Repository;
using KioskClient.View;

namespace KioskClient.ViewModel
{
    public class MovieShowtimesPageViewModel : ViewModelBase, IDisposable
    {
        private readonly ShowtimeRepository repository;

        public ObservableCollection<Showtime> Showtimes { get; set; }
        public Movie Movie { get; set; }

        private Timer showtimesUpdaterTimer;

        private MovieShowtimesPage view 
        {
            get { return (MovieShowtimesPage) base.view; }
        }

        public MovieShowtimesPageViewModel(MovieShowtimesPage view, ShowtimeRepository repository, Movie movie)
        {
            base.view = view;
            this.repository = repository;
            Movie = movie;

            SetUpTimer();

            RetrieveData();
        }

        private void SetUpTimer()
        {
            showtimesUpdaterTimer = new Timer
            {
                Interval = TimeSpan.FromSeconds(1).TotalMilliseconds,
                AutoReset = true
            };

            showtimesUpdaterTimer.Elapsed += ShowtimesUpdaterTimerWaitForSync;
            showtimesUpdaterTimer.Start();
        }

        private void ShowtimesUpdaterTimerWaitForSync(object sender, ElapsedEventArgs elapsedEventArgs)
        {
            if (DateTime.Now.Second == 0)
            {
                view.Dispatcher.Invoke(() =>
                {
                    view.UnwireHandlers();
                    RetrieveData();
                    view.WireHandlers();
                });

                showtimesUpdaterTimer.Stop();
                showtimesUpdaterTimer.Elapsed -= ShowtimesUpdaterTimerWaitForSync;
                showtimesUpdaterTimer.Interval = TimeSpan.FromMinutes(1).TotalMilliseconds;
                showtimesUpdaterTimer.Elapsed += ShowtimesUpdaterTimerOnElapsed;
                showtimesUpdaterTimer.Start();
            }
        }

        private void ShowtimesUpdaterTimerOnElapsed(object sender, ElapsedEventArgs elapsedEventArgs)
        {
            view.Dispatcher.Invoke(() =>
            {
                view.UnwireHandlers();
                RetrieveData();
                view.WireHandlers();
            });
        }

        private void RetrieveData()
        {
            if (Showtimes == null)
            {
                Showtimes = new ObservableCollection<Showtime>();
            }

            var showtimes = repository.GetPendingShowtimes(Movie.Id).ToList();

            Showtimes.Clear();
            showtimes.ForEach(showtime => Showtimes.Add(showtime));
        }

        public void GoBack()
        {
            Window.NavigateBack();
        }

        public void Dispose()
        {
            showtimesUpdaterTimer.Elapsed -= ShowtimesUpdaterTimerOnElapsed;
            showtimesUpdaterTimer.Stop();
        }

        public void GoToShowtimeDetails(Showtime showtime)
        {
            Window.NavigateToAuditoriumMap(showtime);
        }
    }
}