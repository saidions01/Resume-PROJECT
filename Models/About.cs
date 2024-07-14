namespace ResumeProject.Models
{
    public class About
    {
        private int iD;
        private string content;
        private string dateCreated;

        public int ID
        {
            get { return this.iD; }
            set { this.iD = value; }
        }
        public string Content
        {
            get { return this.content; }
            set { this.content = value; }
        }
        public string DateCreated
        {
            get { return this.dateCreated; }
            set { this.dateCreated = value; }
        }

        public About(int id, string content, string dateCreated)
        {
            ID = id;
            Content = content;
            DateCreated = dateCreated;
        }

        public About() { }

        public About(string content, string dateCreated) : this(-1, content, dateCreated) { }
    }
}

