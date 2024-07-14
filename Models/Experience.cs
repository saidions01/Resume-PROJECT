namespace ResumeProject.Models
{
    public class Experience
    {
        private int iD;
        private string jobTitle;
        private string company;
        private string startDate;
        private string endDate;
        private string responsibilities;

        public int ID
        {
            get { return this.iD; }
            set { this.iD = value; }
        }
        public string JobTitle
        {
            get { return this.jobTitle; }
            set { this.jobTitle = value; }
        }
        public string Company
        {
            get { return this.company; }
            set { this.company = value; }
        }
        public string StartDate
        {
            get { return this.startDate; }
            set { this.startDate = value; }
        }
        public string EndDate
        {
            get { return this.endDate; }
            set { this.endDate = value; }
        }
        public string Responsibilities
        {
            get { return this.responsibilities; }
            set { this.responsibilities = value; }
        }

        public Experience(int id, string jobTitle, string company, string startDate, string endDate, string responsibilities)
        {
            ID = id;
            JobTitle = jobTitle;
            Company = company;
            StartDate = startDate;
            EndDate = endDate;
            Responsibilities = responsibilities;
        }

        public Experience() { }

        public Experience(string jobTitle) : this(-1, jobTitle, "N/A", "N/A", "N/A", "N/A") { }
    }
}

