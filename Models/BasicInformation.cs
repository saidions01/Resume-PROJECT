namespace ResumeProject.Models
{
    public class BasicInformation
    {
        private int iD;
        private string name;
        private string email;
        private string phoneNumber;

        public int ID {
            get { return this.iD; }
            set { this.iD = value; }
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }
        public string PhoneNumber
        {
            get { return this.phoneNumber; }
            set { this.phoneNumber = value; }
        }

        public BasicInformation(int id, string name, string email, string phoneNumber)
        {
            ID = id;
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
          
        }
        public BasicInformation() { }


        public BasicInformation(string name) : this( -1 ,name, "N/A", "N/A") { }
}
      
    }

