using CinemaBookingSystemTests.Model;

namespace CinemaBookingSystemTests;

public class CinemaBookingSystemTests
{
    private CinemaBookingSystem _cinema = new(50); 

    [Fact]
    public void BookSit_BookingSit_IcreasesBookedSitsCount()
    {
        var initialCount = _cinema.BookedSitsCount;
        _cinema.BookSit(1);
        Assert.Equal(1u, _cinema.BookedSitsCount - initialCount);
    }

    [Fact]
    public void BookSit_BookingBookedSit_ThrowsInvalidOpertaion()
    {
        Assert.Throws<InvalidOperationException>(() =>
        {
            _cinema.BookSit(1);
            _cinema.BookSit(1);
        });
    }

    [Fact]
    public void SitIsBooked_BookedSitNumber_True() 
    {
        _cinema.BookSit(2);
        Assert.True(_cinema.SitIsBooked(2));
    }
    
}
