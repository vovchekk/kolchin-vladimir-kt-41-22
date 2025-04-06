namespace VladimirKolchinKt_41_22.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public string Name { get; set; }
        public List<Teacher> Teachers { get; set; } = new List<Teacher>();
    }
}
