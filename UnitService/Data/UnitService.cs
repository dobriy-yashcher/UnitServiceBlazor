namespace UnitService.Data
{
    public class UnitService
    {
        private static readonly string[] Names = new[]
        {
            "Shamil",
            "Kamil",
            "Roman",
            "Bulat",
            "Riaz",
            "Rinat",
            "Radmir",
            "Nikita",
            "Danil",
            "Ilgam"
        };

        public Task<Unit[]> GetForecastAsync()
        {
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new Unit
            {
                Name = Names[Random.Shared.Next(Names.Length)],
                DateBirthDay = RandomDay()
            }).ToArray());
        }

        private static DateTime start = new DateTime(1995, 1, 1);
        private static int range = (DateTime.Now - new DateTime(1995, 1, 1)).Days;

        private static DateTime RandomDay()
        {
            return start.AddDays(Random.Shared.Next(range));
        }
    }
}
