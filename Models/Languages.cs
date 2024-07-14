namespace ResumeProject.Models
{
    public class Languages
    {
        private int iD;
        private string languageName;
        private string proficiencyLevel;

        public int ID
        {
            get { return this.iD; }
            set { this.iD = value; }
        }
        public string LanguageName
        {
            get { return this.languageName; }
            set { this.languageName = value; }
        }
        public string ProficiencyLevel
        {
            get { return this.proficiencyLevel; }
            set { this.proficiencyLevel = value; }
        }

        public Languages(int id, string languageName, string proficiencyLevel)
        {
            ID = id;
            LanguageName = languageName;
            ProficiencyLevel = proficiencyLevel;
        }

        public Languages() { }

        public Languages(string languageName) : this(-1, languageName, "N/A") { }
    }
}

