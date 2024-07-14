namespace ResumeProject.Models
{
    public class Certifications
    {
        private int iD;
        private string certificationName;
        private string issuingOrganization;
        private string dateObtained;

        public int ID
        {
            get { return this.iD; }
            set { this.iD = value; }
        }
        public string CertificationName
        {
            get { return this.certificationName; }
            set { this.certificationName = value; }
        }
        public string IssuingOrganization
        {
            get { return this.issuingOrganization; }
            set { this.issuingOrganization = value; }
        }
        public string DateObtained
        {
            get { return this.dateObtained; }
            set { this.dateObtained = value; }
        }

        public Certifications(int id, string certificationName, string issuingOrganization, string dateObtained)
        {
            ID = id;
            CertificationName = certificationName;
            IssuingOrganization = issuingOrganization;
            DateObtained = dateObtained;
        }

        public Certifications() { }

        public Certifications(string certificationName) : this(-1, certificationName, "N/A","unknown") { }
    }
}

