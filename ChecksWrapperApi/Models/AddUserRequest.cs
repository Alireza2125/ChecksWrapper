namespace ChecksWrapperApi.Models;

public class AddUserRequest
{
    public string name { get; set; }
    public string callBackUrl { get; set; }
    public bool KycUser { get; set; }
    public bool PassportOcrUser { get; set; }
    public bool NationaDocOcrUser { get; set; }
    public bool NationalDocUser { get; set; }
}


public class AddUserResponse
{
    public int status { get; set; }
    public string name { get; set; }
    public string callBackUrl { get; set; }
    public string businessId { get; set; }
    public string businessToken { get; set; }
}
