using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;


namespace MojRobot
{
    class DapperFunctions
    {
        public SqlConnection conn;

        public DapperFunctions()
        {
            string path = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|RobotBaza.mdf;Integrated Security=True;Connect Timeout=30;Integrated Security=True;Connect Timeout=30";
            SqlConnection _conn = new SqlConnection(@"" + path);
            conn = _conn;
        }


        //#region Artikal
        //public List<Artikal> GetAll_Artikal()
        //{

        //    List<Artikal> artikli = conn.Query<Artikal>("SELECT * FROM Artikal").ToList();

        //    return artikli;
        //}

        //public List<Artikal> GetAll_Artikal(string WhichColumn, string Value)
        //{

        //    List<Artikal> artikli = conn.Query<Artikal>("SELECT * FROM Artikal WHERE " + WhichColumn + " LIKE '" + Value + "%'").ToList();

        //    return artikli;
        //}

        //public void Insert_Artikal(Artikal artikal)
        //{
        //    conn.Execute("INSERT INTO Artikal (Proizvod,Proizvodac,Stanje,Cijena,BarKod,Detalji) VALUES (@Proizvod,@Proizvodac,@Stanje,@Cijena,@BarKod,@Detalji)", artikal);
        //}

        //public void Update_Artikal(Artikal artikal)
        //{
        //    conn.Execute("UPDATE Artikal SET Proizvod = @Proizvod, Proizvodac = @Proizvodac, Stanje = @Stanje, Cijena = @Cijena, BarKod = @BarKod, Detalji = @Detalji WHERE Id = @Id", artikal);
        //}

        //public void Delete_Artikal(int id)
        //{
        //    conn.Execute("DELETE FROM Artikal WHERE Id=@ID", new { ID = id });
        //}

        //bool ArtikalTwoWay;
        //public List<Artikal> Get_AllSorted_Artikal(string ColumnName)
        //{
        //    if (ArtikalTwoWay)
        //    {
        //        List<Artikal> artikli = conn.Query<Artikal>("SELECT * FROM Artikal ORDER BY " + ColumnName).ToList();
        //        ArtikalTwoWay = false;
        //        return artikli;
        //    }
        //    else
        //    {
        //        List<Artikal> artikli = conn.Query<Artikal>("SELECT * FROM Artikal ORDER BY " + ColumnName + " DESC").ToList();
        //        ArtikalTwoWay = true;
        //        return artikli;
        //    }
        //}

        //#endregion Artikal


        #region Motor
        public List<VrijednostiMotora> GetAll_Motor()
        {

            List<VrijednostiMotora> motor = conn.Query<VrijednostiMotora>("SELECT * FROM Motori").ToList();

            return motor;
        }


        public void Insert_VrijednostiMotor(VrijednostiMotora motor)
        {
            ResetIds_VrijednostiMotor();

            conn.Execute($"INSERT INTO Motori (MotorHvataljka,MotorZglob1,MotorZglob2,MotorZglob3,MotorZglobHvataljka,MotorPlatforma) VALUES (@MotorHvataljka,@MotorZglob1,@MotorZglob2,@MotorZglob3,@MotorZglobHvataljka,@MotorPlatforma)", motor);
        }

        public void Update_VrijednostiMotor(VrijednostiMotora motor)
        {
            conn.Execute($"UPDATE Motori SET MotorHvataljka = @MotorHvataljka, MotorZglob1=@MotorZglob1, MotorZglob2=@MotorZglob2,MotorZglob3=@MotorZglob3,MotorZglobHvataljka=@MotorZglobHvataljka,MotorPlatforma=@MotorPlatforma WHERE Id = @Id", motor);
        }

        public void Delete_VrijednostiMotor(int id)
        {
            conn.Execute($"DELETE FROM Motori WHERE Id=@ID", new { ID = id });
        }

        #endregion
        public void ResetIds_VrijednostiMotor()
        {
            conn.Execute($"declare @max int select @max=max([Id]) from [Motori] if @max IS NULL SET @max = 0 DBCC CHECKIDENT ('[Motori]', RESEED, @max)");
        }
        

    }
}