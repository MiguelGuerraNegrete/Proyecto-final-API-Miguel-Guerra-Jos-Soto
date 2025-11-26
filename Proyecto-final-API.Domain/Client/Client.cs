namespace Proyecto_final_API.Domain.Client;

public class Client
{
    public Guid? ClientId { get; set; }
    public string? Identification { get; set; }
    public string? Name { get; set; }
    public double? AvailableBalance { get; set; }
}