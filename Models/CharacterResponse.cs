namespace FinalExamApplication.Models
{
    public class CharacterResponse
    {
        public Info Info { get; set; } = new Info();
        public List<Character> Results { get; set; } = new List<Character>();
    }

    public class Info
    {
        public int Count { get; set; }
        public int Pages { get; set; }
        public string? Next { get; set; }
        public string? Prev { get; set; }
    }

    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public string Species { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public Origin Origin { get; set; } = new Origin();
        public Location Location { get; set; } = new Location();
        public string Image { get; set; } = string.Empty;
        public List<string> Episode { get; set; } = new List<string>();
        public string Url { get; set; } = string.Empty;
        public DateTime Created { get; set; }
    }

    public class Origin
    {
        public string Name { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
    }

    public class Location
    {
        public string Name { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
    }
}

