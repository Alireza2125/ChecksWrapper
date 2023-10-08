namespace ChecksWrapperApi.Models;

public class StartKycWithNationalCodeAndDownloadLinkRequest
{
    public string nationalId { get; set; }
    public string nationalIdSerial { get; set; }
    public string gender { get; set; }
    public string birthDate { get; set; }
    public string downloadLink { get; set; }
}

