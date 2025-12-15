using CinemaBookingSystemTests.Model;

var cinema = new CinemaBookingSystem(50);

Console.WriteLine($"Booking sit 1 ...");
cinema.BookSit(1);
DisplayBookedSits();

Console.WriteLine($"Booking sit 4 ...");
cinema.BookSit(4);
DisplayBookedSits();

Console.WriteLine($"Booking sit 5 ...");
cinema.BookSit(5);
DisplayBookedSits();

Console.WriteLine($"Unbooking sit 4 ...");
cinema.CancelBooking(4);
DisplayBookedSits();


void DisplayBookedSits() 
{
    Console.Write("Booked Sits: ");
    foreach (var sit in cinema.BookedSits)
    {
        Console.Write($"{sit}, ");
    }
    Console.WriteLine();
}