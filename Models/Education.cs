namespace ResumeProject.Models
{
    public class Education
    {
        private int iD;
        private string degree;
        private string school;
        private int graduationYear;
        private float gpa;

        public int ID
        {
            get { return this.iD; }
            set { this.iD = value; }
        }
        public string Degree
        {
            get { return this.degree; }
            set { this.degree = value; }
        }
        public string School
        {
            get { return this.school; }
            set { this.school = value; }
        }
        public int GraduationYear
        {
            get { return this.graduationYear; }
            set { this.graduationYear = value; }
        }
        public float GPA
        {
            get { return this.gpa; }
            set { this.gpa = value; }
        }

        public Education(int id, string degree, string school, int graduationYear, float gpa)
        {
            ID = id;
            Degree = degree;
            School = school;
            GraduationYear = graduationYear;
            GPA = gpa;
        }

        public Education() { }

        public Education(string degree) : this(-1, degree, "N/A", 0, 0.0f) { }
    }
}

