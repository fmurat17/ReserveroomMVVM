using Reserveroom.Exceptions;
using Reserveroom.Models;
using Reserveroom.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Reserveroom
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel()
            };
            MainWindow.Show();

            base.OnStartup(e);
        }
    }
}

            //Hotel hotel = new Hotel("Malibu Hotel");

            //try
            //{
            //    hotel.MakeReservation(new Reservation(
            //                          new RoomID(1, 2),
            //                          new DateTime(2000, 1, 1),
            //                          new DateTime(2000, 1, 2),
            //                          "Fatih"));

            //    hotel.MakeReservation(new Reservation(
            //                          new RoomID(1, 3),
            //                          new DateTime(2000, 1, 3),
            //                          new DateTime(2000, 1, 4),
            //                          "Murat"));

            //}catch(ReservationConflictException ex)
            //{

            //}

            //hotel.GetReservations();