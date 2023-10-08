namespace ChecksWrapperApi.Models;

public class NationalIdentificationOcrGetOutputData
{
    public string userInfo { get; set; }
    public string sessionId { get; set; }
    public string mrzCode { get; set; }
    public string surname { get; set; }
    public string name { get; set; }
    public string country { get; set; }
    public string nationality { get; set; }
    public string birth_date { get; set; }
    public string expiry_date { get; set; }
    public string sex { get; set; }
    public string document_type { get; set; }
    public string document_number { get; set; }
    public string optional_data { get; set; }
    public string birth_date_hash { get; set; }
    public string expiry_date_hash { get; set; }
    public string document_number_hash { get; set; }
    public string optional_data_hash { get; set; }
    public string final_hash { get; set; }
}



