﻿namespace VladimirKolchinKt_41_22.Models
{
    public class AcademicDegree
    {
        public int AcademicDegreeId { get; set; }
        public string Name { get; set; }
        public List<Teacher> Teachers { get; set; } = new List<Teacher>();
    }
}
