using System;
using System.Data.SqlClient;


namespace Acciopus.User
{
    enum UserType
    {
        unassigned,
        Admin,
        Worker,
        Employer
    }
    internal class User
    {
        protected int ID;
        protected String Name;
        protected String Surname;
        protected String Password;
        protected String Email;
        protected String PhoneNumber;
        protected DateTime DateOfBirth;
        protected UserType Type;

        public User()
        {
            this.Name = null;
            this.Surname = null;
            this.Password = null;
            this.Email = null;
            this.PhoneNumber = null;


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


        public void setDateOfBirth(DateTime db)
        {
            this.DateOfBirth = db;
        }

        public void setTypetoWorker() {
            this.Type = UserType.Worker;
        }

        public void setTypetoEmployer()
        {
            this.Type = UserType.Employer;
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

        public String getPassword()
        {
            return Password;
        }

        public String getPhoneNumber()
        {
            return PhoneNumber;
        }



        public DateTime getDateofBirth()
        {
            return DateOfBirth;
        }

        public UserType getType()
        {
            return Type;
        }
        

        public void setUserInfo(SqlConnection conn)
        {
            try
            {
                SqlCommand getUserInfoFromEmail = new SqlCommand("Select kullanici_id, kullanici_adi,kullanici_soyadi,kullanici_telefon,kullanici_dogum_tarihi,kullanici_tip from Kullanici as t1 INNER JOIN Kullanici_Tip as t2 ON t1.kullanici_tip_id = t2.kullanici_tip_id where kullanici_mail = @p1", conn);
                getUserInfoFromEmail.Parameters.AddWithValue("@p1", this.Email);
                SqlDataReader reader;
                String Type = "";
                conn.Open();
                reader = getUserInfoFromEmail.ExecuteReader();
                while (reader.Read())
                {
                    ID = Convert.ToInt32(reader["kullanici_id"]);
                    this.Name = reader["kullanici_adi"].ToString();
                    this.Surname = reader["kullanici_soyadi"].ToString();
                    this.PhoneNumber = reader["kullanici_telefon"].ToString();
                    this.DateOfBirth = Convert.ToDateTime(reader["kullanici_dogum_tarihi"]);
                    Type = reader["kullanici_tip"].ToString();
                }

                conn.Close();
                

                if (Type.Equals("Admin"))
                {
                    this.Type = UserType.Admin;
                }
                else if (Type.Equals("Employer"))
                {
                    this.Type = UserType.Employer;
                }
                else if (Type.Equals("Worker"))
                {
                    this.Type = UserType.Worker;
                }
            }catch(Exception e)
            {
                
                SqlCommand sendExceptiontoDatabase = new SqlCommand("Insert into Exception (Exception_Message,Exception_DateTime) values(@p1,@p2)", conn);
                sendExceptiontoDatabase.Parameters.AddWithValue("@p1", e.Message.ToString());
                sendExceptiontoDatabase.Parameters.AddWithValue("@p2", DateTime.Now);
                sendExceptiontoDatabase.ExecuteNonQuery();
                conn.Close();
            }
        }


        public int getID()
        {
            return ID;
        }
    }
}
