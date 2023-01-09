namespace VehicleManagementAPI.Dto.Response;

public class AssignmentDtoResponse
{
    public string VehicleInfo { get; set; } = default!;
    public string DriverFullName { get; set; } = default!;
    public string StartDate { get; set; } = default!;
    public string EndDate { get; set; } = default!;
    public string Amount { get; set; } = default!;
}
