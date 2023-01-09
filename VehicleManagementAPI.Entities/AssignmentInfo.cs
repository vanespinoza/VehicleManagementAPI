namespace VehicleManagementAPI.Entities
{
    public class AssignmentInfo
    {
        public string AssignmentId { get; set; } = default!;
        public string BrandVehicle { get; set; } = default!;
        public string ModelVehicle { get; set; } = default!;
        public string LicensePlate { get; set; } = default!;
        public string DriverName { get; set; } = default!;
        public string StartDate { get; set; } = default!;
        public string EndDate { get; set; } = default!;
        public string Amount { get; set; } = default!;
    }
}