namespace ChecksWrapperApi.Models;

public class PostCodeRequest
{
    public string postCode { get; set; }
}

public class PostCodeResponse
{
    public int status_code { get; set; }
    public Address address { get; set; }
}

public class Address
{
    public string avenue { get; set; }
    public string floorNumber { get; set; }
    public string houseNumber { get; set; }
    public string location { get; set; }
    public string parish { get; set; }
    public string postalCode { get; set; }

    public string preAvenue { get; set; }
    public string sideFloor { get; set; }

    public string state { get; set; }
    public string townShip { get; set; }
    public string village { get; set; }
    public string zone { get; set; }
    public string buildingName { get; set; }
    public string description { get; set; }
    public string locationCode { get; set; }
}


