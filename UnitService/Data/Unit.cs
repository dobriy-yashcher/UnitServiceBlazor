namespace UnitService.Data
{
    public class Unit
    {
        public string? Name { get; set; }

        public DateTime DateBirthDay { get; set; }

        public int Age => DateTime.Now.Year - DateBirthDay.Year;
    }
}
