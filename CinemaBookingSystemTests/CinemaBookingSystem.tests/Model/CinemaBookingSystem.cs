namespace CinemaBookingSystem.tests.Model;

public class CinemaBookingSystem
{
    public int SitCount { get; set; }
    public int BookedSitsCount { get; set; }

    public void BookSit(int sitNumber) { }

    public bool SitIsBooked(int sitNumber) => false;
}
