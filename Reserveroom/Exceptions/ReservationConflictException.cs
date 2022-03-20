using Reserveroom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Reserveroom.Exceptions
{
    class ReservationConflictException : Exception
    {
        public Reservation ExistingReservation { get; }
        public Reservation IncomingReservation { get; }
        public ReservationConflictException(Reservation existingReservation, Reservation ıncomingReservation)
        {
            ExistingReservation = existingReservation;
            IncomingReservation = ıncomingReservation;
        }

        public ReservationConflictException(string message, Reservation existingReservation, Reservation ıncomingReservation) : base(message)
        {
            ExistingReservation = existingReservation;
            IncomingReservation = ıncomingReservation;
        }

        public ReservationConflictException(string message, Exception innerException, Reservation existingReservation, Reservation ıncomingReservation) : base(message, innerException)
        {
            ExistingReservation = existingReservation;
            IncomingReservation = ıncomingReservation;
        }
    }
}
