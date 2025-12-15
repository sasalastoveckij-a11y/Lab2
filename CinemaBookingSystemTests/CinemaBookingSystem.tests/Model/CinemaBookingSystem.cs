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
        _bookedSits.Add(sitNumber);
    }

    public bool SitIsBooked(uint sitNumber) => false;
}
