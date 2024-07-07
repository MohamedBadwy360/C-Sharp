namespace _02_ReturnMultipleValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Using Class DS");
            var facilityName = FacilityDistanceCalculator.GetFacilityLocationInfoV1("Hospital");
            Console.WriteLine(facilityName);

            Console.WriteLine();
            Console.WriteLine("Using out Parameter");

            // local variables in main method will be assigned values from the out parameters in the method call below
            string name = "";
            double distanceInKm = 0;

            FacilityDistanceCalculator
                .GetFacilityLocationInfoV2("Hospital", out name, out distanceInKm);

            Console.WriteLine($"{name} ....... {distanceInKm.ToString("F2")} km");
            Console.ReadKey();
        }
    }
}
