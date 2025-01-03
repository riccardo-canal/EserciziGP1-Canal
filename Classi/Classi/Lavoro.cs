namespace Classi
{
    public class Lavoro
    {
        public string JobName { get; set; }
        public string Description { get; set; }

        public Lavoro(string jobName, string description = "Description not available")
        {
            JobName = jobName;
            Description = description;
        }
    }
}
