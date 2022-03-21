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

        /// <summary>
        /// Adds reservation to reservationbook
        /// </summary>
        /// <param name="reservation"></param>
        /// <exception cref="ReservationConflictException">qwe</exception>
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
