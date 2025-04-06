namespace VladimirKolchinKt_41_22.Models
{
    public class Discipline
    {
        public int DisciplineId { get; set; }
        public string Name { get; set; }

        public List<WorkLoad> Workloads { get; set; } = new List<WorkLoad>();
    }
}
