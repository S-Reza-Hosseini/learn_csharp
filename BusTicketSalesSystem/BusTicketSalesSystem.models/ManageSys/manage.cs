using BusTicketSalesSystem.models.Buses;
using BusTicketSalesSystem.models.Customers;
using BusTicketSalesSystem.models.ManageSys.Contract;
using BusTicketSalesSystem.models.ManageSys.Tools;
using BusTicketSalesSystem.models.Tickets;
using BusTicketSalesSystem.models.Travels;
using static System.Console;

namespace BusTicketSalesSystem.models.ManageSys;


public class Manage
{
    private readonly List<Travel> _travels = new();
    private readonly List<Bus> _buses = new();
    private readonly List<Ticket> _tickets = new();
    private readonly List<Customer> _traveler = new();
    
    public void RegesterTravel(
        string beginning,
        string destination,
        DateTime dateTravel,
        decimal fee,
        int busId)
    {
        var bus = _buses[busId - 1];
        _travels.Add(new Travel(beginning, destination, dateTravel,fee, bus));
    }

    public void RegesterCostumer(string name, string family,string phoneNumber ,int nationalId)
    {
        _traveler.Add(new Customer(name, family, nationalId, phoneNumber));
    }

    public void RegesterBus(string licensePlate, TypeBus type)
    {
        if (_buses.Any(_ => _.LicensePlate.ToStandard() == licensePlate.ToStandard()))
            return;
        _buses.Add(new Bus(licensePlate, type));
    }

    public List<ShowTravelDto> ShowTravels()
    {
        return _travels.Select((travel, index) => new ShowTravelDto()
        {
            Id = index + 1,
            Beginning = travel.Beginning,
            Destination = travel.Destination,
            DateTravel = travel.DateTravel,
            Fee = travel.Fee,
            Capacity = travel.Capacity
            
        }).ToList();
    }

    public List<ShowBusDto> ShowBuses()
    {
        return _buses.Select((bus, index) => new ShowBusDto()
        {
        Id = index+1,
        LicensePlate = bus.LicensePlate,
        Type = bus.Type
        }).ToList();
    }

    public void Sale(int travelId, int travelerId)
    {
        var travel = _travels[travelId - 1];
        var traveler = _traveler[travelerId - 1];

        if (SellCondition(travel))
        {
            Ticket ticket = new Ticket(traveler, travel, TypePay.Sell, travel.Fee);
             
            travel.AddTicket(ticket);
            
            travel.Bus.Income += travel.Fee;
            
            return;
        }
        return;
    }

    public void ReservationTicket(int travelId, int travelerId)
    {
        var travel = _travels[travelId - 1];
        var traveler = _traveler[travelerId - 1];

        if (SellCondition(travel))
        {
            Ticket ticket = new Ticket(traveler, travel, TypePay.Reserve, travel.Fee);
             
            travel.AddTicket(ticket);
            
            travel.Bus.Income += travel.Fee * 0.3M;
            
            return;
        }
        
        return;

    }

    public decimal CanselTraveling(int nationalId, int travelId)
    {
        var travel = _travels[travelId - 1];
        var ticket = _tickets.Find(_ => _.Customer.NationalId == nationalId);

        decimal refundAmount = 0;
        
        if (ticket.PayMethod == TypePay.Sell)
        {
            refundAmount = ticket.TotalPay * 0.8M;
            travel.Bus.Income -= refundAmount;
        }

       
        travel.RemoveTicket(ticket);

        return refundAmount;
    }

    public List<ShowBusDto> ShowIncomingBus()
    {
        return _buses.OrderByDescending(bus => bus.Income).Select((bus, index) => new ShowBusDto()
        {
            Id = index+1,
            LicensePlate = bus.LicensePlate,
            Type = bus.Type,
            Income = bus.Income
        }).ToList();
    }

    public string ShowMostIncomingPassenger()

        => _travels.GroupBy(_ => _.Destination).Select(_ => new
        {
            City = _.Key,
            PassengersCount = _.Sum(C => C.Bus.Capacity-C.Capacity)
        }).OrderByDescending(_ => _.PassengersCount).Select(_ => _.City).FirstOrDefault();
    public string HighestNumberOfPassengers()

        => _travels.GroupBy(_ => _.Beginning).Select(_ => new
        {
            City = _.Key,
            PassengersCount = _.Sum(C => C.Bus.Capacity-C.Capacity)
        }).OrderByDescending(_ => _.PassengersCount).Select(_ => _.City).FirstOrDefault();


   
    private bool SellCondition(Travel travel)
    {
       
        if (travel.Capacity <= 0 && DateTime.Now > travel.DateTravel)
            return false;
        return true;
    }
    
    
    
    
}