using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using demo5.CLASSES;

namespace demo5.UTILS
{
    internal class DataWork
    {
        private static readonly string ConnStr = ConnectionString.Connection;

        public static DataSet GetClientEntries(int page, int pageSize, string filter, string sort, string searchString, string searchCategory, bool showBirthday)
        {
            using (SqlConnection conn = new SqlConnection(ConnStr))
            {
                DataSet ds = new DataSet();

                conn.Open();
                string sql = "select Client.ID as Идентификатор, Client.Gender as Пол, Client.FirstName as Фамилия, Client.LastName as Имя, Client.Patronymic as Отчество, " +
                             " Client.Birthday as [Дата рождения], Client.Phone as Телефон, Client.Email as Email, Client.RegistrationDate as [Дата регистрации], " +
                             " (select top 1 ClientService.StartTime from ClientService where ClientService.ClientID = Client.ID order by StartTime desc) as [Последнее посещение]," +
                             " (select COUNT(*) from ClientService where ClientService.ClientID = Client.ID) as [Количество посещений]" +
                             " from Client, ClientService";
                if (!string.IsNullOrEmpty(filter))
                {
                    sql += $" WHERE Client.Gender = '{filter}'";
                }

                switch (searchCategory)
                {
                    case "ФИО":
                    {
                        sql += string.IsNullOrEmpty(filter) ? " WHERE" : " AND";
                        sql += $" CONCAT(Client.LastName,' ', Client.FirstName,' ', Client.Patronymic) like '%{searchString}%'";
                        break;
                    }
                    case "Email":
                    {
                        sql += string.IsNullOrEmpty(filter) ? " WHERE" : " AND";
                        sql += $" Email like '%{searchString}%'";
                        break;
                    }
                    case "Телефон":
                    {
                        sql += string.IsNullOrEmpty(filter) ? " WHERE" : " AND";
                        sql += $" Phone like '%{searchString}%'";
                        break;
                        }
                }

                if (showBirthday)
                {
                    sql += string.IsNullOrEmpty(filter) && string.IsNullOrEmpty(searchCategory) ? " WHERE" : " AND";
                    sql += " month(Client.Birthday) = month(getdate())";
                }

                sql += " group by Client.ID, Client.FirstName, Client.LastName, Client.Patronymic, Client.Birthday, Client.Email, Client.Gender, Client.Phone, Client.PhotoPath, Client.RegistrationDate";

                switch (sort)
                {
                    case "Фамилии":
                    {
                        sql += " ORDER BY Client.LastName";
                        break;
                    }
                    case "Дате последнего посещения":
                    {
                        sql += " ORDER BY [Последнее посещение] desc";
                        break;
                    }
                    case "Количеству посещений":
                    {
                        sql += " ORDER BY [Количество посещений] desc";
                        break;
                    }
                    default:
                    {
                        sql += " ORDER BY Client.ID";
                        break;
                    }
                }

                if (pageSize > 0)
                {
                    sql += $" offset {(page - 1) * pageSize} rows fetch next {pageSize} rows only";
                }

                SqlDataAdapter ada = new SqlDataAdapter(sql, conn);
                try
                {
                    ada.Fill(ds);
                    ds.Tables[0].Columns.Add("Тэги", typeof (List<string>));
                    return ds;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

        public static int GetEntryNumber(int page, int pageSize, string filter, string sort, string searchString, string searchCategory, bool showBirthday)
        {
            using (SqlConnection conn = new SqlConnection(ConnStr))
            {
                conn.Open();
                string sql = "select count(*) from" +
                             "(select Client.ID as Идентификатор, Client.Gender as Пол, Client.FirstName as Фамилия, Client.LastName as Имя, Client.Patronymic as Отчество, " +
             " Client.Birthday as [Дата рождения], Client.Phone as Телефон, Client.Email as Email, Client.RegistrationDate as [Дата регистрации], " +
             " (select top 1 ClientService.StartTime from ClientService where ClientService.ClientID = Client.ID order by StartTime desc) as [Последнее посещение]," +
             " (select COUNT(*) from ClientService where ClientService.ClientID = Client.ID) as [Количество посещений]" +
             " from Client, ClientService";
                if (!string.IsNullOrEmpty(filter))
                {
                    sql += $" WHERE Client.Gender = '{filter}'";
                }

                switch (searchCategory)
                {
                    case "ФИО":
                        {
                            sql += string.IsNullOrEmpty(filter) ? " WHERE" : " AND";
                            sql += $" CONCAT(Client.LastName,' ', Client.FirstName,' ', Client.Patronymic) like '%{searchString}%'";
                            break;
                        }
                    case "Email":
                        {
                            sql += string.IsNullOrEmpty(filter) ? " WHERE" : " AND";
                            sql += $" Email like '%{searchString}%'";
                            break;
                        }
                    case "Телефон":
                        {
                            sql += string.IsNullOrEmpty(filter) ? " WHERE" : " AND";
                            sql += $" Phone like '%{searchString}%'";
                            break;
                        }
                }


                if (showBirthday)
                {
                    sql += (string.IsNullOrEmpty(filter) && string.IsNullOrEmpty(searchCategory)) ? " WHERE" : " AND";
                    sql += " month(Client.Birthday) = month(getdate())";
                }


                sql += " group by Client.ID, Client.FirstName, Client.LastName, Client.Patronymic, Client.Birthday, Client.Email, Client.Gender, Client.Phone, Client.PhotoPath, Client.RegistrationDate) as [Количество записей]";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    int count = reader.GetInt32(0);
                    return count;
                }
                else
                    throw new Exception();
            }
        }

        public static Client GetClientByID(int ID)
        {
            using (SqlConnection conn = new SqlConnection(ConnStr))
            {
                conn.Open();
                string sql = "select * from Client where ID = @ID";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("ID", ID);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Client client = new Client
                    {
                        ID = reader.GetInt32(0),
                        FirstName = reader.GetString(1),
                        LastName = reader.GetString(2),
                        Patronymic = reader.GetString(3),
                        Birthdate = reader.GetDateTime(4),
                        RegistrationDate = reader.GetDateTime(5),
                        Email = reader.GetString(6),
                        Phone = reader.GetString(7),
                        Gender = reader.GetString(8),
                        PhotoPath = reader.GetString(9)
                    };
                    return client;
                }
                throw new Exception();
            }
        }

        public static bool CanDeleteClient(int ID)
        {
            using (SqlConnection conn = new SqlConnection(ConnStr))
            {
                conn.Open();
                string sql = "select * from ClientService where ClientID = @ID";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("ID", ID);
                SqlDataReader reader = cmd.ExecuteReader();
                bool canDelete = !reader.Read();
                return canDelete;
            }
        }

        public static void DeleteClientTags(int ID)
        {
            using (SqlConnection conn = new SqlConnection(ConnStr))
            {
                conn.Open();
                string sql = "delete from TagOfClient where ClientID = @ID";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("ID", ID);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

        public static void DeleteClient(int ID)
        {
            using (SqlConnection conn = new SqlConnection(ConnStr))
            {
                conn.Open();
                string sql = "delete from Client where ID = @ID";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("ID", ID);
                try
                {
                    cmd.ExecuteNonQuery();
                    DeleteClientTags(ID);
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

        public static void AddClient(Client client)
        {
            using (SqlConnection conn = new SqlConnection(ConnStr))
            {
                conn.Open();
                string sql = "insert into Client(LastName, FirstName, Patronymic, Birthday, Phone, Email, RegistrationDate, Gender, PhotoPath)" +
                             " values(@LastName, @FirstName, @Patronymic, @Birthday, @Phone, @Email, @RegistrationDate, @Gender, @PhotoPath)";
                SqlCommand cmd = new SqlCommand(sql,conn);
                cmd.Parameters.AddWithValue("LastName", client.LastName);
                cmd.Parameters.AddWithValue("FirstName", client.FirstName);
                cmd.Parameters.AddWithValue("Patronymic", client.Patronymic);
                cmd.Parameters.AddWithValue("Birthday", client.Birthdate);
                cmd.Parameters.AddWithValue("Phone", client.Phone);
                cmd.Parameters.AddWithValue("Email", client.Email);
                cmd.Parameters.AddWithValue("RegistrationDate", client.RegistrationDate);
                cmd.Parameters.AddWithValue("Gender", client.Gender);
                cmd.Parameters.AddWithValue("PhotoPath", client.PhotoPath);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

        public static void UpdateClient(Client client)
        {
            using (SqlConnection conn = new SqlConnection(ConnStr))
            {
                conn.Open();
                string sql = "update Client " +
                             "set LastName = @LastName, FirstName = @FirstName, Patronymic = @Patronymic, " +
                             " Birthday = @Birthday, Phone = @Phone, Email = @Email, RegistrationDate = @RegistrationDate, Gender = @Gender, PhotoPath = @PhotoPath " +
                             "where ID = @ID";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("ID", client.ID);
                cmd.Parameters.AddWithValue("LastName", client.LastName);
                cmd.Parameters.AddWithValue("FirstName", client.FirstName);
                cmd.Parameters.AddWithValue("Patronymic", client.Patronymic);
                cmd.Parameters.AddWithValue("Birthday", client.Birthdate);
                cmd.Parameters.AddWithValue("Phone", client.Phone);
                cmd.Parameters.AddWithValue("Email", client.Email);
                cmd.Parameters.AddWithValue("RegistrationDate", client.RegistrationDate);
                cmd.Parameters.AddWithValue("Gender", client.Gender);
                cmd.Parameters.AddWithValue("PhotoPath", client.PhotoPath);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

        public static List<ClientService> GetClientServiceList(int ClientID)
        {
            using (SqlConnection conn = new SqlConnection(ConnStr))
            {
                conn.Open();
                string sql = "  select [Service].Title, ClientService.StartTime, " +
                             "(select COUNT(*) from[DocumentByService] where ClientServiceID = @ID) as [count] " +
                             "from[Service],ClientService " +
                             "where[Service].ID = ClientService.ServiceID " +
                             "and ClientService.ClientID = @ID";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("ID", ClientID);
                SqlDataReader reader = cmd.ExecuteReader();
                List<ClientService> list = new List<ClientService>();
                while (reader.Read())
                {
                    ClientService clientService = new ClientService
                    {
                        Title = reader.GetString(0),
                        StartTime = reader.GetDateTime(1),
                        DocumentCount = reader.GetInt32(2),
                    };
                        list.Add(clientService);
                }

                return list;
            }
        }
    }
}
