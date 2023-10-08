namespace ChecksWrapperApi.Models;

public class GetOutputRequest
{
    public string sessionId { get; set; }

}

public class GetOutputType1Response
{
    public int statusCode { get; set; }
    public bool completed { get; set; }
    public bool verified { get; set; }
    public string message { get; set; }
}

public class AuthenticationStatus
{
    public string state { get; set; }
    public string reason { get; set; }
}

public class BirthDate
{
    public string year { get; set; }
    public string month { get; set; }
    public string day { get; set; }
}

public class GetOutputType2Response
{
    public Status status { get; set; }
    public string sessionId { get; set; }
    public bool completed { get; set; }
    public bool video_is_live { get; set; }
    public string similarity { get; set; }
    public string liveness_score { get; set; }
    public bool verified { get; set; }
    public UserInformation userInformation { get; set; }
    public AuthenticationStatus authenticationStatus { get; set; }
}

public class Status
{
    public int code { get; set; }
    public string message { get; set; }
    public List<object> details { get; set; }
}

public class UserInformation
{
    public string nationalId { get; set; }
    public string nationalIdSerial { get; set; }
    public BirthDate birthDate { get; set; }
    public string sex { get; set; }
}

