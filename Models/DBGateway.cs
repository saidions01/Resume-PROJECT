
using Microsoft.Data.SqlClient;
using Dapper;


namespace ResumeProject.Models

{
    public class DBGateway
    {
        private readonly string connectionString;
        private IConfiguration configuration;

        
        public DBGateway(IConfiguration iconfig)
        {
            this.configuration = iconfig;
            this.connectionString = configuration.GetValue<string>("ConnectionStrings:DefaultConnection");

        }
        public string ConnectionString
        {
            get { return connectionString; }
        }

        public List<About> GetAbout()
        {
            string sql = "SELECT Content FROM About;";
            List<About> Abouts;

            using (var connection = new SqlConnection(ConnectionString))
            {
               Abouts = connection.Query<About>(sql).ToList();
            }
            return Abouts;
        }


        public List<About> GetAbout(int id) 
        {
            string sql = "SELECT Content FROM About  where ID = " + id;
            List<About> Abouts;

            using (var connection = new SqlConnection(ConnectionString))
            {
                Abouts = connection.Query<About>(sql).ToList();
            }
            return Abouts;
        }

        public void InsertAbout( string content, string time)
        {
            string sql = "insert into About( Content, DateCreated)values( '" + content + "', '" + time +"');";

            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Execute(sql);
            }
        }

        public void UpdateAbout(int id, string content, string time)
        {
            string sql = "update About set Content = '" + content + "', " +
                 "DateCreated = '" + time + "' WHERE ID = '" + id + "';";

            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Execute(sql);
            }
        }


        public List<BasicInformation> GetBasicInformation()
        {
            string sql = "select * from BasicInformation";
            List<BasicInformation> BIs;
            using (var connection = new SqlConnection(ConnectionString))
            {
                BIs = connection.Query<BasicInformation>(sql).ToList();
            }
            return BIs;
        }


        public List<BasicInformation> GetBasicInformation(int id)
        {
            string sql = "select * from BasicInformation  where ID = " + id;
            List<BasicInformation> BIs;
            using (var connection = new SqlConnection(ConnectionString))
            {
                BIs = connection.Query<BasicInformation>(sql).ToList();
            }
            return BIs;
        }
        public void InsertBasicInformation( string name, string email, string phoneNumber)
        {
            string sql = "insert into BasicInformation(Name, Email,PhoneNumber)values('" + name + "', '" + email + "','" + phoneNumber + "');";

            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Execute(sql);
            }
        }

        public void UpdateBasicInformation(int id, string name, string email, string phoneNumber)
        {
            string sql = "update BasicInformation set Name = '" + name + "', " +
                 "Email = '" + email + "'," +"PhoneNumber = '" + phoneNumber + "' WHERE ID = '" + id + "';";

            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Execute(sql);
            }
        }

        public List<Certifications> GetCertifications()
        {
            string sql = "select * from Certifications";
            List<Certifications> certifs;
            using (var connection = new SqlConnection(ConnectionString))
            {
                certifs = connection.Query<Certifications>(sql).ToList();
            }
            return certifs;
        }


        public List<Certifications> GetCertifications(int id)
        {
            string sql = "select * from Certifications where ID = " + id;
            List<Certifications> certifs;
            using (var connection = new SqlConnection(ConnectionString))
            {
                certifs = connection.Query<Certifications>(sql).ToList();
            }
            return certifs;
        }

        public void InsertCertification( string certificationName, string issuingOrganization, string dateObtained)
        {
            string sql = "insert into Certifications(CertificationName, IssuingOrganization,DateObtained)values( '" + certificationName + "', '" + issuingOrganization + "','" + dateObtained + "');";

            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Execute(sql);
            }
        }

        
               public void UpdateCertifications(int id, string certificationName, string issuingOrganization, string dateObtained)
        {
            string sql = "update Certifications set CertificationName = '" + certificationName + "', " +
                 "IssuingOrganization = '" + issuingOrganization + "'," + "DateObtained = '" + dateObtained + "' WHERE ID = '" + id + "';";

            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Execute(sql);
            }
        }



        public List<Education> GetEducation()
        {
            string sql = "select * from Education";
            List<Education> edu;
            using (var connection = new SqlConnection(ConnectionString))
            {
                edu = connection.Query<Education>(sql).ToList();
            }
            return edu;
        }

        public List<Education> GetEducation(int id)
        {
            string sql = "select * from Education where ID = " + id;
            List<Education> edu;
            using (var connection = new SqlConnection(ConnectionString))
            {
                edu = connection.Query<Education>(sql).ToList();
            }
            return edu;
        }

        public void InsertEducation(string degree, string school,  int graduationYear, float gpa)
        {
            string sql = "insert into Education(Degree,School,GraduationYear,Gpa)values('" + degree + "', '" + school + "','" + graduationYear + "','" + gpa + "');";

            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Execute(sql);
            }
        }


        public void UpdateEducation(int id, string degree, string school, int graduationYear, float gpa)
        {
            string sql = "update Education set Degree = '" + degree + "', " +
                 "School = '" + school + "'," + "GraduationYear = '" + graduationYear + "'," + "Gpa = '" + gpa +"' WHERE ID = '" + id + "';";

            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Execute(sql);
            }
        }







        public List<Languages> GetLanguages()
        {
            string sql = "select * from Languages";
            List<Languages> LAN;
            using (var connection = new SqlConnection(ConnectionString))
            {
                LAN = connection.Query<Languages>(sql).ToList();
            }
            return LAN;
        }

    

        public List<Languages> GetLanguages(int id)
        {
                string sql = "select * from Languages where ID = " + id;
            List<Languages> LAN;
            using (var connection = new SqlConnection(ConnectionString))
            {
                LAN = connection.Query<Languages>(sql).ToList();
            }
            return LAN;
        }

        public void InsertLanguages(string languageName, string proficiencyLevel)
        {
            string sql = "insert into Languages(LanguageName,ProficiencyLevel)values('" + languageName + "', '" + proficiencyLevel + "');";

            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Execute(sql);
            }
        }


        public void UpdateLanguages(int id, string languageName, string proficiencyLevel)
        {
            string sql = "update Languages set LanguageName = '" + languageName + "', " +
                 "ProficiencyLevel = '" + proficiencyLevel +  "' WHERE ID = '" + id + "';";

            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Execute(sql);
            }
        }







        public List<Projects> GetProjects()
        {
            string sql = "select * from Projects";
            List<Projects> proj;
            using (var connection = new SqlConnection(ConnectionString))
            {
                proj = connection.Query<Projects>(sql).ToList();
            }
            return proj;
        }

        public List<Projects> GetProjects(int id)
        {
            string sql = "select * from Projects where ID = " + id;
            List<Projects> proj;
            using (var connection = new SqlConnection(ConnectionString))
            {
                proj = connection.Query<Projects>(sql).ToList();
            }
            return proj;
        }

        public void InsertProjects(string projectName, string description, string technologiesUsed, int duration)
        {
            string sql = "INSERT INTO Projects (ProjectName, Description, TechnologiesUsed, Duration) VALUES (@ProjectName, @Description, @TechnologiesUsed, @Duration);";

            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Execute(sql, new
                {
                    ProjectName = projectName,
                    Description = description,
                    TechnologiesUsed = technologiesUsed,
                    Duration = duration
                });
            }
        }



        public void UpdateProjects(int id, string projectName, string description, string technologiesUsed, int duration)
        {
            string sql = "update Projects set ProjectName = '" + projectName + "', " +
                 "Description = '" + description + "', " +
                 "TechnologiesUsed = '" + technologiesUsed + "', " +
                 "Duration = '" + duration + "' WHERE ID = '" + id + "';";

            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Execute(sql);
            }
        }



        public List<Skill> GetSkills()
        {
            string sql = "select * from Skills";
            List<Skill> skills;
            using (var connection = new SqlConnection(ConnectionString))
            {
                skills = connection.Query<Skill>(sql).ToList();
            }
            return skills;
        }


        public List<Skill> GetSkills(int id)
        {
            string sql = "select * from Skills where ID = " + id;
            List<Skill> skills;
            using (var connection = new SqlConnection(ConnectionString))
            {
                skills = connection.Query<Skill>(sql).ToList();
            }
            return skills;
        }
        public void InsertSkills( string skillName, string proficiencyLevel)
        {
            string sql = "insert into Skills(SkillName,ProficiencyLevel)values( '" + skillName + "'," +
                " '" + proficiencyLevel + "');";

            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Execute(sql);
            }
        }


        public void UpdateSkills(int id, string skillName, string proficiencyLevel)
        {
            string sql = "update Skills set SkillName = '" + skillName + "', " +
                 "ProficiencyLevel = '" + proficiencyLevel + "', " +
                 "' WHERE ID = '" + id + "';";

            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Execute(sql);
            }
        }




        public List<Experience> GetExperience()
        {
            string sql = "select * from Experience";
            List<Experience> experience;
            using (var connection = new SqlConnection(ConnectionString))
            {
                experience = connection.Query<Experience>(sql).ToList();
            }
            return experience;
        }

        public List<Experience> GetExperience(int id)
        {
            string sql = "select * from Experience where ID = " + id;
            List<Experience> experience;
            using (var connection = new SqlConnection(ConnectionString))
            {
                experience = connection.Query<Experience>(sql).ToList();
            }
            return experience;
        }

        public void InsertExperience(string jobTitle, string company, string startDate, string endDate, string responsibilities)
        {
            string sql = "insert into Experience(JobTitle,Company,StartDate,EndDate,Responsibilities)values( '" + jobTitle + "'," +
                " '" + company + "','" + startDate + "','" + endDate + "','" + responsibilities + "');";

            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Execute(sql);
            }
        }


        public void UpdateExperience(int id, string jobTitle, string company, string startDate, string endDate, string responsibilities)
        {
            string sql = "UPDATE Experience SET " +
            "JobTitle = '" + jobTitle + "', " +
             "Company = '" + company + "', " +
             "StartDate = '" + startDate + "', " +
              "EndDate = '" + endDate + "', " +
              "Responsibilities = '" + responsibilities + "' " +
              "WHERE ID = '" + id + "';";


            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Execute(sql);
            }
        }
    }
}
