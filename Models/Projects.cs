namespace ResumeProject.Models
{
    public class Projects
    {
        private int iD;
        private string projectName;
        private string description;
        private string technologiesUsed;
        private int duration;

        public int ID
        {
            get { return this.iD; }
            set { this.iD = value; }
        }
        public string ProjectName
        {
            get { return this.projectName; }
            set { this.projectName = value; }
        }
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }
        public string TechnologiesUsed
        {
            get { return this.technologiesUsed; }
            set { this.technologiesUsed = value; }
        }
        public int Duration
        {
            get { return this.duration; }
            set { this.duration = value; }
        }

        public Projects(int id, string projectName, string description, string technologiesUsed, int duration)
        {
            ID = id;
            ProjectName = projectName;
            Description = description;
            TechnologiesUsed = technologiesUsed;
            Duration = duration;
        }

        public Projects() { }

        public Projects(string projectName) : this(-1, projectName, "N/A", "N/A", 0) { }
    }
}

