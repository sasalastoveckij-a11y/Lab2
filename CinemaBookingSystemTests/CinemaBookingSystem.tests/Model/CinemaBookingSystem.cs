namespace CinemaBookingSystemTests.Model;

public class CinemaBookingSystem
{
    public CinemaBookingSystem(uint sitCount)
    {
        SitCount = sitCount;
    }

    private List<uint> _bookedSits = new();

    public uint SitCount { get; private init; }

    public uint BookedSitsCount 
    { 
        get => (uint)_bookedSits.Count(); 
    }

    public void BookSit(uint sitNumber) 
    {
        if (SitIsBooked(sitNumber) || SitCount == _bookedSits.Count)
            throw new InvalidOperationException($"Sit {sitNumber} is already booked");
        _bookedSits.Add(sitNumber);
    }

    public bool SitIsBooked(uint sitNumber) => _bookedSits.Contains(sitNumber);

    public void CancelBooking(uint sitNumber) 
    {
        if(!SitIsBooked(sitNumber))
            throw new InvalidOperationException($"Sit {sitNumber} is not booked");
        _bookedSits.Remove(sitNumber);
    }
}
