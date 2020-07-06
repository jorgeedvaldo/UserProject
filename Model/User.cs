using System;
using System.Data.OleDb;

namespace Model
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Pass { get; set; }

        public void Add(User user)
        {
            OleDbConnection cn = new OleDbConnection();
            cn.ConnectionString = Connection.Str;

            OleDbCommand cmd = new OleDbCommand();
            try
            {
                cmd.Connection = cn;
                cmd.CommandText = "INSERT INTO Users(Name, Email, Pass) VALUES(@Name, @Email, @Pass)";
                cmd.Parameters.Add(new OleDbParameter("@Name", user.Name));
                cmd.Parameters.Add(new OleDbParameter("@Email", user.Email));
                cmd.Parameters.Add(new OleDbParameter("@Pass", user.Pass));
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                throw new Exception("Erro ao gravar, verifique se os dados foram inseridos correctamente!");
            }
            finally
            {
                cmd.Connection.Close();
            }
        }
    }
}
