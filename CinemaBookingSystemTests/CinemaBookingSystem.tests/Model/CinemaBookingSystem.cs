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
        if (_bookedSits.Contains(sitNumber))
            throw new InvalidOperationException($"Sit {sitNumber} is already booked");
        _bookedSits.Add(sitNumber);
    }

    public bool SitIsBooked(uint sitNumber) => false;
}
