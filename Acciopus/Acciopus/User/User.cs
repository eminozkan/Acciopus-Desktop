using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acciopus.User
{
    enum UserType
    {
        Worker,
        Employer,
        Admin
    }
    internal class User
    {
        private String Name;
        private String Surname;
        private String Password;
        private String Email;
        private String PhoneNumber;
        private String SicilNo;
        private String VergiNo;
        private DateTime DateOfBirth;
        private UserType Type;

        public User()
        {
            this.Name = null;
            this.Surname = null;
            this.Password = null;
            this.Email = null;
            this.PhoneNumber = null;
            this.SicilNo = null;
            this.VergiNo = null;
            this.DateOfBirth = new DateTime(1001, 1, 1);
            this.Type = UserType.Worker;
        }

        public void setName(String name)
        {
            this.Name = name;
        }

        public void setSurname(String surname)
        {
            this.Surname = surname;
        }

        public void setPassword(String Password)
        {
            this.Password = Password;
        }

        public void setEmail(String Email)
        {
            this.Email = Email;
        }

        public void setPhone(String Phone)
        {
            this.PhoneNumber = Phone;
        }

        public void setSicilNo(String SicilNo)
        {
            this.SicilNo = SicilNo;
        }

        public void setVergiNo(String VergiNo)
        {
            this.VergiNo = VergiNo;
        }

        public void setDateOfBirth(DateTime db)
        {
            this.DateOfBirth = db;
        }

        public void setTypetoWorker(UserType u) {
            this.Type = UserType.Worker;
        }

        public void setTypetoEmployer(UserType u)
        {
            this.Type = UserType.Employer;
        }

        public void setTypetoAdmin(UserType u)
        {
            this.Type = UserType.Admin;
        }

        public String getName()
        {
            return Name;
        }

        public String getSurname()
        {
            return Surname;
        }

        public String getEmail()
        {
            return Email;
        }

        public String getPhoneNumber()
        {
            return PhoneNumber;
        }

        public String getSicilNo()
        {
            return SicilNo;
        }

        public String getVergiNo()
        {
            return VergiNo;
        }

        public DateTime getDateofBirth()
        {
            return DateOfBirth;
        }

        public UserType getType()
        {
            return Type;
        }

    }
}
