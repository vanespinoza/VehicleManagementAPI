namespace VehicleManagementAPI.Dto.Request;

public record AssignmentDtoRequest(string StartDate, string EndDate, string DriverId, string VehicleId);
