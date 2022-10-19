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

        public Task<Unit[]> GetUnitAsync()
        {
            return Task.FromResult(Enumerable.Range(1, Random.Shared.Next(Names.Length)).Select(index => new Unit
            {
                Name = Names[Random.Shared.Next(Names.Length)],
                DateBirthDay = RandomDay()
            }).ToArray());
        }

        private static readonly DateTime start = new DateTime(1995, 1, 1);
        private static readonly int range = (DateTime.Now - new DateTime(1995, 1, 1)).Days;

        private static DateTime RandomDay()
        {
            return start.AddDays(Random.Shared.Next(range));
        }
    }
}
