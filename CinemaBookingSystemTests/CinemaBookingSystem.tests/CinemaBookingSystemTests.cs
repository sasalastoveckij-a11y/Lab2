using CinemaBookingSystemTests.Model;

namespace CinemaBookingSystemTests;

public class CinemaBookingSystemTests
{
    private CinemaBookingSystem _cinema = new(50); 

    [Fact]
    public void BookSit_BookingSit_IncreasesBookedSitsCount()
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

    [Fact]
    public void CancelBooking_BookedSit_DecreasesBookedSitsCount()
    {
        _cinema.BookSit(3);
        var initialCount = _cinema.BookedSitsCount;
        _cinema.CancelBooking(3);
        Assert.Equal(1u, initialCount - _cinema.BookedSitsCount);
    }

    [Fact]
    public void CancelBooking_NotBookedSit_ThrowsInvalidOperation()
    {
        Assert.Throws<InvalidOperationException>(() => _cinema.CancelBooking(5));
    }

    [Fact]
    public void BookSit_BookingMoreSists_ThrowsInvalidOperation()
    {
        for (uint i = 0; i < 51; i++) 
        {
            try 
            {
                _cinema.BookSit(i);
            }
            catch (InvalidOperationException) 
            {
                continue;
            }
        }
        Assert.Throws<InvalidOperationException>(() => _cinema.BookSit(51));
    }
}
