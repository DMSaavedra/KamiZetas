using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kmisetas
{
    class BaseDatos
    {
        static string url = "workstation id=KmisetasDB.mssql.somee.com;packet size=4096;user id=DiegoMSA_SQLLogin_1;pwd=lajipo62mb;data source=KmisetasDB.mssql.somee.com;persist security info=False;initial catalog=KmisetasDB";
        int valor = 0;
        SqlConnection con = new SqlConnection(url);

        public int Ingresar(string usuario, string contrasenia)
        {
            string consulta = "SELECT usu_nomlogin,usu_password,tusu_id FROM Tbl_Usuario WHERE usu_nomlogin ='" + usuario + "'and usu_password='" + contrasenia + "' ";
            valor = 0;
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            SqlDataReader rs = cmd.ExecuteReader();

            while (rs.Read())
            {
                if (rs["usu_nomlogin"].ToString().Equals(usuario) && rs["usu_password"].ToString().Equals(contrasenia))
                {
                    if (rs["tusu_id"].ToString().Equals("1"))
                    {
                        valor = 1;
                    }
                    if (rs["tusu_id"].ToString().Equals("2"))
                    {
                        valor = 2;
                    }
                    if (rs["tusu_id"].ToString().Equals("3"))
                    {
                        valor = 1;
                    }
                }
                else
                {
                    valor = 0;
                }
            }
            rs.Close();
            con.Close();
            return valor;
        }

        public void registrarUsuarios(string nombre, string cedula, string nomLog, string psswrd, string direccion, int telefono, string correo, int tipoUs)
        {
            string consulta = "INSERT INTO Tbl_Usuario (usu_nombre,usu_cedula,usu_nomlogin,usu_password,usu_direccion,usu_telefono,usu_correo,tusu_id,usu_estado) " +
                "VALUES(@Nom, @Ced, @NomLog, @Pssw, @Dir, @Tlf, @Mail, @Tusu, @Est)";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);

            cmd.Parameters.Add("@Nom", SqlDbType.VarChar, 100).Value = nombre;
            cmd.Parameters.Add("@Ced", SqlDbType.VarChar, 10).Value = cedula;
            cmd.Parameters.Add("@NomLog", SqlDbType.VarChar, 100).Value = nomLog;
            cmd.Parameters.Add("@Pssw", SqlDbType.VarChar, 100).Value = psswrd;
            cmd.Parameters.Add("@Dir", SqlDbType.VarChar, 250).Value = direccion;
            cmd.Parameters.Add("@Tlf", SqlDbType.Int, 10).Value = telefono;
            cmd.Parameters.Add("@Mail", SqlDbType.VarChar, 250).Value = correo;
            cmd.Parameters.Add("@Tusu", SqlDbType.Int, 1).Value = tipoUs;
            cmd.Parameters.Add("@Est", SqlDbType.Char, 1).Value = 'A';

            cmd.CommandType = CommandType.Text;

            cmd.ExecuteReader();
            con.Close();
        }
        public void eliminarUsuarios(string userLog)
        {
            string consulta = "DELETE FROM Tbl_Usuario WHERE usu_nomlogin='" + userLog + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);

            cmd.ExecuteReader();
            con.Close();
        }

        public void modificarUsuario(string nombre, string cedula)
        {
            string consulta = "UPDATE Tbl_Usuario SET usu_nombre='" + nombre + "'WHERE usu_cedula='" + cedula + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);

            cmd.ExecuteReader();
            con.Close();
        }
    }
}