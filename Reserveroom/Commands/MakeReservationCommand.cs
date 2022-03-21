using Reserveroom.Exceptions;
using Reserveroom.Models;
using Reserveroom.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserveroom.Commands
{
    class MakeReservationCommand : CommandBase
    {
        private readonly Hotel _hotel;
        private readonly MakeReservationViewModel _makeReservationViewModel;
        public MakeReservationCommand(MakeReservationViewModel makeReservationViewModel, Hotel hotel)
        {
            _hotel = hotel;
            _makeReservationViewModel = makeReservationViewModel;
        }

        public override void Execute(object parameter)
        {
            Reservation reservation = new Reservation(
                new RoomID(_makeReservationViewModel.FloorNumber, _makeReservationViewModel.RoomNumber),
                _makeReservationViewModel.StartDate,
                _makeReservationViewModel.EndDate,
                _makeReservationViewModel.Username);

            try
            {
                _hotel.MakeReservation(reservation); // ctrl + shift + space
            }
            catch(ReservationConflictException ex)
            {

            }
        }
    }
}
