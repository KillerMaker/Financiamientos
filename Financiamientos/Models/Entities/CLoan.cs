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

            SqlParameter Code = new SqlParameter("@CODIGO", SqlDbType.Char, 7);
            SqlParameter CustomerCode = new SqlParameter("@CODIGO_CLIENTE", SqlDbType.Char, 7);
            SqlParameter UserCode = new SqlParameter("@CODIGO_USUARIO", SqlDbType.Char, 5);
            SqlParameter Date = new SqlParameter("@FECHA", SqlDbType.DateTime);

            SqlParameter CapitalAmmount = new SqlParameter("@MONTO_CAPITAL", SqlDbType.Decimal,24);
            CapitalAmmount.Scale = 4;
            CapitalAmmount.Precision = 24;

            SqlParameter InstallsmentNumber = new SqlParameter("@NO_CUOTAS", SqlDbType.Int);
            SqlParameter State = new SqlParameter("@ESTADO", SqlDbType.VarChar, 50);

            SqlParameter InterestRate = new SqlParameter("@TASA_INTERES", SqlDbType.Decimal, 14);
            InterestRate.Scale = 4;
            InterestRate.Precision = 14;

            Code.Value = this.code;
            CustomerCode.Value = this.customerCode;
            UserCode.Value = this.userCode;
            Date.Value = this.date;
            CapitalAmmount.Value = this.capitalAmmount;
            InstallsmentNumber.Value = this.installsmentNumber;
            State.Value = this.state;
            InterestRate.Value = this.interestRate;

            parameters = (Code.Value != null) ?
                new List<SqlParameter>() { Code, CustomerCode, UserCode, Date, CapitalAmmount, InstallsmentNumber, State, InterestRate } :
                 new List<SqlParameter>() { CustomerCode, UserCode, Date, CapitalAmmount, InstallsmentNumber, State, InterestRate };

        }

        public override async Task<int> Insert()
            => await IQueryExecutor.IntReturnerExecutor(new string[] 
            {"EXEC INSERTA_PRESTAMO @CODIGO_CLIENTE,@CODIGO_USUARIO,@FECHA,@MONTO_CAPITAL,@NO_CUOTAS,@TASA_INTERES,@ESTADO"},parameters.ToArray());
    }
}
