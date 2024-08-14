namespace BusTicketSalesSystem.models.Customers;

class Customer(
    string name,
    string family,
    int nationalId,
    string phoneNumber
    )
{
    public string Name { get; } = name;
    public string Family { get; } = family;
    public string PhoneNumber { get; } = phoneNumber;
    public int NationalId { get; } = nationalId;
    
}