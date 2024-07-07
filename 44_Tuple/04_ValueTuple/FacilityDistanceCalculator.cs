namespace _04_ValueTuple
{
    internal class FacilityDistanceCalculator
    {
        private static Random random = new Random();


        // ValueTuple.Create is a factory method that creates a ValueTuple instance with the specified elements.
        public static ValueTuple<string, string> CalculateFacilityDistance(string facilityName)
        {
            return ValueTuple.Create(facilityName, ($"{(random.NextDouble() * 10.0).ToString("F2")} km"));
        }

        // Implicitly named tuple elements => ValueTuple allows you to create a tuple with implicitly named elements.
        public static (string, string) CalculateFacilityDistanceV2(string facilityName)
        {
            return ValueTuple.Create(facilityName, ($"{(random.NextDouble() * 10.0).ToString("F2")} km"));
        }

        // Explicitly named tuple elements => ValueTuple allows you to create a tuple with explicitly named elements.
        public static (string Name, string DistanceInKm) CalculateFacilityDistanceV3(string facilityName)
        {
            return ValueTuple.Create(facilityName, ($"{(random.NextDouble() * 10.0).ToString("F2")} km"));
        }
    }
}
