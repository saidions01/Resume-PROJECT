namespace ResumeProject.Models
{
    public class Skill
    {
        private int iD;
        private string skillName;
        private string proficiencyLevel;

        public int ID
        {
            get { return this.iD; }
            set { this.iD = value; }
        }
        public string SkillName
        {
            get { return this.skillName; }
            set { this.skillName = value; }
        }
        public string ProficiencyLevel
        {
            get { return this.proficiencyLevel; }
            set { this.proficiencyLevel = value; }
        }

        public Skill(int id, string skillName, string proficiencyLevel)
        {
            ID = id;
            SkillName = skillName;
            ProficiencyLevel = proficiencyLevel;
        }

        public Skill() { }

        public Skill(string skillName) : this(-1, skillName, "N/A") { }
    }
}
