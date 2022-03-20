using Reserveroom.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Reserveroom.ViewModels
{
    class ReservationListingViewModel : ViewModelBase
    {
        private readonly ObservableCollection<ReservationViewModel> _reservations;
        public IEnumerable<ReservationViewModel> Reservations => _reservations;
        public ICommand MakeReservationCommmand { get; }

        public ReservationListingViewModel()
        {
            _reservations = new ObservableCollection<ReservationViewModel>();

            _reservations.Add(new ReservationViewModel(new Reservation(new RoomID(1, 2), DateTime.Now, DateTime.Now, "Fatih")));
            _reservations.Add(new ReservationViewModel(new Reservation(new RoomID(1, 3), DateTime.Now, DateTime.Now, "Murat")));
            _reservations.Add(new ReservationViewModel(new Reservation(new RoomID(1, 4), DateTime.Now, DateTime.Now, "fmurat")));
        }
    }
}
