namespace dotnet_rpg.Models
{
    public class Character
    {
        public int Id { get; set; }
        public int Name { get; set; } = "Barney";
        public int HitPoints { get; set; } = 100;
        public int Strength { get; set; } = 10;
        public int Defense { get; set; } = 10;
        public int Intelligence { get; set; } = 10;
    }
}