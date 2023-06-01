namespace _12th_Time_Battle_App.ViewModel
{
    public class Faction
    {
        public string Name
        {
            get; set;
        }
        public string Description
        {
            get; set;
        }
        public Faction(string name)
        {
            Name = name;
        }
        public Faction(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
