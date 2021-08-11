using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Financiamientos.Utility;
using Financiamientos.Models.QueryBuilding;


namespace Financiamientos.Models.Entities
{
    public class CCustomer:CEntity
    {
        public readonly string name;
        public readonly string idNumber;
        public readonly DateTime birthDate;
        public readonly string phone;
        public readonly string adress;

        private readonly List<SqlParameter> Parameters;

        public CCustomer(string name,string idNumber,DateTime birthDate,string phone,string adress,string code=null):base(code)
        {
            #region Validations
            if (!birthDate.isGreaterThan18())
                throw new Exception("La Edad de la persona es menor que 18");

            if (!name.isValidName())
                throw new Exception($"El nombre {name} es invalido");

            if(!phone.isValidPhone())
                throw new Exception($"El telefono es invalido");
            #endregion Validations

            #region Setting Values
            this.name = name.MayusCadaEspacio();
            this.idNumber = idNumber.Replace("-","");
            this.birthDate = birthDate;
            this.phone = phone.Replace("-","");
            this.adress = adress;

            SqlParameter Name = new SqlParameter("@NOMBRE", SqlDbType.VarChar, 50);
            SqlParameter IdNumber = new SqlParameter("@CEDULA", SqlDbType.Char, 11);
            SqlParameter BirthDay = new SqlParameter("@FECHA_NACIMIENTO", SqlDbType.Date);
            SqlParameter Phone = new SqlParameter("@TELEFONO", SqlDbType.Char, 10);
            SqlParameter Adress = new SqlParameter("@DIRECCION", SqlDbType.VarChar, 200);
            SqlParameter Code = new SqlParameter(@"CODIGO", SqlDbType.Char, 7);

            Name.Value = this.name;
            IdNumber.Value = this.idNumber;
            BirthDay.Value = this.birthDate;
            Phone.Value = this.phone;
            Adress.Value = this.adress;
            Code.Value = this.code;

            Parameters = (Code.Value != null) ?
                new List<SqlParameter>() { Code, Name, IdNumber, BirthDay, Phone, Adress } :
                new List<SqlParameter>() { Name, IdNumber, BirthDay, Phone, Adress };

            #endregion Setting Values
        }

        public async Task<int> Update()
            => await IQueryExecutor.IntReturnerExecutor(new string[] {"EXEC ACTUALIZA_CLIENTE @CODIGO,@TELEFONO,@DIRECCION"}, Parameters.ToArray());

        public override async Task<int> Insert()
            => await IQueryExecutor.IntReturnerExecutor(new string[] 
            {@"EXEC INSERTA_CLIENTE @NOMBRE,@CEDULA,@FECHA_NACIMIENTO,@TELEFONO,@DIRECCION"},Parameters.ToArray());

    }
}
