using Financiamientos.Models;
using Financiamientos.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Financiamientos.Models.QueryBuilding;

namespace Financiamientos.Models.Entities
{
    public class CPayment:CEntity
    {
        public readonly decimal ammount;
        public readonly DateTime date;
        public readonly string loanCode;
        public readonly string paymentMethod;
        public readonly decimal? paidInArrears;
        public readonly decimal? paidInInteres;
        public readonly decimal? paidInCapital;


        public CPayment(decimal ammount,DateTime date,string loanCode,string paymentMethod,decimal? paidInArrears=null,decimal? paidInInteres=null, decimal? paidInCapital=null,string code=null):base(code)
        {
            if (ammount <= 0)
                throw new Exception($"Monto dado menor o igual a '0' : {ammount}");
            if(!date.isValidDate())
                throw new Exception($"La fecha ingresada no es valida: {date}");

            this.ammount = ammount;
            this.date = date;
            this.loanCode = loanCode;
            this.paymentMethod = paymentMethod;
            this.paidInArrears = paidInArrears;
            this.paidInInteres = paidInInteres;
            this.paidInCapital = paidInCapital;

            parameters = setParameters();
        }

        public override async Task<int> Insert()
            => await IQueryExecutor.ExecuteQuery
            (new string[] {"EXEC INSERTA_PAGO @CODIGO_PRESTAMO,@MONTO,@FECHA,@METODO_PAGO"}, parameters.ToArray());

        protected override IEnumerable<SqlParameter> setParameters()
        {
            SqlParameter Code = new SqlParameter("@CODIGO", SqlDbType.Char, 14);
            SqlParameter Ammount = new SqlParameter("@MONTO", SqlDbType.Decimal, 24);
            Ammount.Scale = 4;
            Ammount.Precision = 24;
            SqlParameter Date = new SqlParameter("@FECHA", SqlDbType.Date);
            SqlParameter LoanCode = new SqlParameter("@CODIGO_PRESTAMO", SqlDbType.Char, 7);
            SqlParameter PaymentMethod = new SqlParameter("@METODO_PAGO", SqlDbType.VarChar, 50);

            Code.Value = code;
            Ammount.Value = ammount;
            Date.Value = date;
            LoanCode.Value = loanCode;
            PaymentMethod.Value = paymentMethod;

            return (Code.Value != null) ?
                new List<SqlParameter>() { Code, Ammount, Date, LoanCode, PaymentMethod } :
                new List<SqlParameter>() { Ammount, Date, LoanCode, PaymentMethod };
        }


    }
}
