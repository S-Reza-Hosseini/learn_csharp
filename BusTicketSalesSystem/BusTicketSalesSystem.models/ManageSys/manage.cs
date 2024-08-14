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
    private readonly List<Customer> _customers = new();
    
    public void RegesterTravel(
        string beginning,
        string destination,
        DateTime dateTravel,
        int busId)
    {
        var bus = _buses[busId - 1];
        _travels.Add(new Travel(beginning, destination, dateTravel, bus));
    }

    public void RegesterCostumer(string name, string family,string phoneNumber ,int nationalId)
    {
        _customers.Add(new Customer(name, family, nationalId, phoneNumber));
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

    public void Sale(int travelId)
    {
        var travel = _travels[travelId - 1];
        var customer = _customers[0];
        if (travel.Capacity > 0)
        {
            _tickets.Add(new Ticket(
                customer.Name,
                customer.Family,
                customer.NationalId,
                customer.PhoneNumber,
                travel.Beginning,
                travel.Destination,
                travel.DateTravel,
                TypePay.Sell,
                travel.Fee));

            travel.Capacity -= 1;
        }
        else
        {
            WriteLine("cant do this !!Capacity of travel is full !!");
            return;
        }
    }

    public void ReservationTicket(int travelId)
    {
        var customer = _customers[0];
        var travel = _travels[travelId - 1];
        if (travel.Capacity > 0)
        {
            _tickets.Add(new Ticket(
                customer.Name,
                customer.Family,
                customer.NationalId,
                customer.PhoneNumber,
                travel.Beginning,
                travel.Destination,
                travel.DateTravel,
                TypePay.Reserve,
                travel.Fee));

            travel.Capacity -= 1;
        }
        else
        {
            WriteLine("cant do this !!Capacity of travel is full !!");
            return;
        }
    }

    public double CanselTraveling(int nationalId, int travelId)
    {
        var ticket = _tickets.Find(_ => _.NationalId == nationalId);
        var travel = _travels[travelId - 1];
        
        var refundAount = 0.0;

        if (ticket.PayMethod == TypePay.Sell)
        {
            refundAount = ticket.TotalPay * 0.80;
        }

        travel.Capacity += 1;

        return refundAount;
    }

    public void ShowSellBus()
    {
        
    }

    public string ShowMustIncomingPassenger()
    
        => _travels.Select(_ => _.Destination)
            .ToList()
            .OrderByDescending(word => word.Count())
            .FirstOrDefault();

    public string HighestNumberOfPassengers()

        => _travels.Select(_ => _.Beginning)
            .ToList()
            .OrderByDescending(word => word.Count())
            .FirstOrDefault();

    public List<ShowTicketsDto> ShowTickets()
    {
        return _tickets.Select((ticket, index) => new ShowTicketsDto()
        {
            Id  = index+1,
            Name = ticket.Name,
            Family = ticket.Family,
            PhoneNumber = ticket.PhoneNumber,
            Beginning = ticket.Beginning,
            Destination = ticket.Destination,
            DateTime = ticket.DateTime,
            TotalPay = ticket.TotalPay
        }).ToList();
    }

}