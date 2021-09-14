using Financiamientos.Models;
using Financiamientos.Utility;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Financiamientos.Models.QueryBuilding;

namespace Financiamientos.Models.Entities
{
    public class CLoan:CEntity
    {
        public readonly string customerCode;
        public readonly string userCode;
        public readonly DateTime date;
        public readonly decimal capitalAmmount;
        public readonly int installsmentNumber;
        public readonly string state;
        public readonly decimal interestRate;

        public CLoan(string customerCode,string userCode,DateTime date,decimal capitalAmmount,int installsmentNumber,string state,decimal interestRate,string code=null):base(code)
        {
            if (!date.isValidDate())
                throw new Exception($"La fecha {date} es invalida");
            if(capitalAmmount<0||installsmentNumber<0||interestRate<0)
                throw new Exception($"El numero de cuotas: {installsmentNumber} o el monto capital: {capitalAmmount} o la tasa de interes {interestRate} es incorrecto");

            this.customerCode = customerCode;
            this.userCode = userCode;
            this.date = date;
            this.capitalAmmount = capitalAmmount;
            this.installsmentNumber = installsmentNumber;
            this.state = state;
            this.interestRate = interestRate;

            parameters = setParameters();

        }

        public override async Task<int> Insert()
            => await IQueryExecutor.ExecuteQuery(new string[] 
            {"EXEC INSERTA_PRESTAMO @CODIGO_CLIENTE,@CODIGO_USUARIO,@FECHA,@MONTO_CAPITAL,@NO_CUOTAS,@TASA_INTERES,@ESTADO"},parameters.ToArray());

       
        /// <summary>
        /// Obtiene la deuda total (capital + interes + mora)
        /// </summary>
        /// <param name="table">Tabla de donde se tomara la informacion</param>
        /// <returns>La deuda total</returns>
        public static float getTotalDebt(DataTable table)
        {
            var debts = from rows in table.AsEnumerable()
                        where rows.Field<string>("Estado") == "Activa"
                        select new
                        {
                            total =
                            float.Parse(rows.Field<string>(4)) + //Capital
                            float.Parse(rows.Field<string>(5)) + //Interes
                            float.Parse(rows.Field<string>(6)), //Mora   
                        }.total;

            return debts.Sum();
        }

        /// <summary>
        /// Obtiene la cantidad de moras
        /// </summary>
        /// <param name="table">Tabla de donde se tomara la informacion</param>
        /// <returns>La cantidad de moras</returns>
        public static int getTotalAmmountOfArrears(DataTable table)
        {
            var arrears = from rows in table.AsEnumerable()
                          select new { total = int.Parse(rows.Field<string>(3)) }.total;

            return arrears.Sum();
        }

        /// <summary>
        /// Obtiene el total del capital pagado en un prestamo
        /// </summary>
        /// <param name="table">Tabla de donde se tomara la informacion</param>
        /// <returns>El total de capital pagado</returns>
        public static float GetpaidCapital(DataTable table)
        {
            var paidCapital = from rows in table.AsEnumerable()
                              select new { total = float.Parse(rows.Field<string>(7)) }.total;

            return paidCapital.Sum();
        }

        /// <summary>
        /// Obtiene el total del interes pagado en un prestamo
        /// </summary>
        /// <param name="table">Tabla de donde se tomara la informacion</param>
        /// <returns>El total de interes pagado</returns>
        public static float GetpaidInterest(DataTable table)
        {
            var paidInterest = from rows in table.AsEnumerable()
                               select new { total = float.Parse(rows.Field<string>(6)) }.total;

            return paidInterest.Sum();
        }
        /// <summary>
        /// Obtiene el total de la mora pagada en un presatmo
        /// </summary>
        /// <param name="table">Tabla de donde se tomara la informacion</param>
        /// <returns>El total de la mora pagada</returns>
        public static float GetpaidArrears(DataTable table)
        {
            var paidArrears = from rows in table.AsEnumerable()
                              select new { total = float.Parse(rows.Field<string>(5)) }.total;

            return paidArrears.Sum();
        }

        protected override IEnumerable<SqlParameter> setParameters()
        {
            SqlParameter Code = new SqlParameter("@CODIGO", SqlDbType.Char, 7);
            SqlParameter CustomerCode = new SqlParameter("@CODIGO_CLIENTE", SqlDbType.Char, 7);
            SqlParameter UserCode = new SqlParameter("@CODIGO_USUARIO", SqlDbType.Char, 5);
            SqlParameter Date = new SqlParameter("@FECHA", SqlDbType.DateTime);

            SqlParameter CapitalAmmount = new SqlParameter("@MONTO_CAPITAL", SqlDbType.Decimal, 24);
            CapitalAmmount.Scale = 4;
            CapitalAmmount.Precision = 24;

            SqlParameter InstallsmentNumber = new SqlParameter("@NO_CUOTAS", SqlDbType.Int);
            SqlParameter State = new SqlParameter("@ESTADO", SqlDbType.VarChar, 50);

            SqlParameter InterestRate = new SqlParameter("@TASA_INTERES", SqlDbType.Decimal, 14);
            InterestRate.Scale = 4;
            InterestRate.Precision = 14;

            Code.Value = code;
            CustomerCode.Value = customerCode;
            UserCode.Value = userCode;
            Date.Value = date;
            CapitalAmmount.Value = capitalAmmount;
            InstallsmentNumber.Value = installsmentNumber;
            State.Value = state;
            InterestRate.Value = interestRate;

            return (Code.Value != null) ?
                new List<SqlParameter>() { Code, CustomerCode, UserCode, Date, CapitalAmmount, InstallsmentNumber, State, InterestRate } :
                 new List<SqlParameter>() { CustomerCode, UserCode, Date, CapitalAmmount, InstallsmentNumber, State, InterestRate };
        }
    }
}
