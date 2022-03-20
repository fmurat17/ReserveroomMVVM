using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserveroom.Models
{
    public class Reservation
    {
        public RoomID RoomID { get; }
        public string Username { get; }
        public DateTime StartDate { get; }
        public DateTime EndDate { get; }
        public TimeSpan Length => EndDate.Subtract(StartDate);

        public Reservation(RoomID roomID, DateTime startDate, DateTime endData, string username)
        {
            RoomID = roomID;
            StartDate = startDate;
            EndDate = endData;
            Username = username;
        }

        public bool Conflicts(Reservation reservation)
        {
            if (reservation.RoomID.Equals(RoomID)) return true;

            return !(reservation.StartDate < EndDate && reservation.EndDate > StartDate);
        }
    }
}
