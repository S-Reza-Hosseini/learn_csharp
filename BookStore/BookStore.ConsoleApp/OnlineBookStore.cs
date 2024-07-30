public class OnlineBookStore : BookStore 
{
    public OnlineBookStore(string name, string address, string webAddress,
     bool hasStationary  = false)
     : base(name, address, hasStationary: hasStationary )
    {
        WebAddress = webAddress;
    }

    public string WebAddress {get; set;}





}

