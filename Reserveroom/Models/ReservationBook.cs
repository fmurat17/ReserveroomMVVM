using Reserveroom.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserveroom.Models
{
    public class ReservationBook
    {
        private readonly List<Reservation> _reservations;

        public ReservationBook()
        {
            _reservations = new List<Reservation>();
        }

        public IEnumerable<Reservation> GetAllReservations()
        {
            return _reservations;
            //_reservations.Where(r => r.Username == "qwe");
        }

        public void AddReservation(Reservation reservation)
        {
            foreach (Reservation existingReservarion in _reservations)
            {
                if (existingReservarion.Conflicts(reservation))
                {
                    throw new ReservationConflictException(existingReservarion, reservation);
                }
            }

            _reservations.Add(reservation);
        }
    }
}
