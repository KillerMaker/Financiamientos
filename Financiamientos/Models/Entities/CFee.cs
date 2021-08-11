using Financiamientos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Financiamientos.Utility;
using Financiamientos.Models.QueryBuilding;

namespace Financiamientos.Models.Entities
{
    public class CFee
    {
        public readonly string code;
        public readonly string loanCode;
        public readonly int arrearsNumber;
        public readonly decimal capitalAmmount;
        public readonly decimal interesAmmount;
        public readonly decimal arrearsAmmount;
        public readonly string state;

        public CFee(string loanCode, int arrearsNumber, decimal capitalAmmount, decimal interesAmmount, decimal arrearsAmmount, string state,string code=null)
        {
            if (capitalAmmount < 0 || interesAmmount < 0 || arrearsAmmount < 0)
                throw new Exception($"Montos incorrectos Monto capital: {capitalAmmount} o Monto interes: {interesAmmount} o Monto mora: {arrearsAmmount} es invalido.");
            if(arrearsNumber<0)
                throw new Exception($"El Numero de moras no puede ser mayor a 0");

            this.loanCode = loanCode;
            this.arrearsNumber = arrearsNumber;
            this.capitalAmmount = capitalAmmount;
            this.interesAmmount = interesAmmount;
            this.arrearsAmmount = arrearsAmmount;
            this.state = state;
            this.code = code;
        }
    }
}
