using Financiamientos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Financiamientos.Utility;
using Financiamientos.Models.QueryBuilding;

namespace Financiamientos.Models.Entities
{
    public class CUser:CEntity
    {
        public readonly string name;
        public readonly string idNumber;
        public readonly string userName;
        public readonly string password;
        public readonly string userType;
        public readonly string state;

        public CUser(string name, string idNumber,string userName, string password, string userType, string state,string code=null):base(code)
        {
            #region Validations
            if (!name.isValidName())
                throw new Exception($"El nombre {name} es invalido");
            #endregion Validations

            #region Setting Values
            this.name = name;
            this.idNumber = idNumber;
            this.userName = userName;
            this.password = password;
            this.userType = userType;
            this.state = state;

            SqlParameter Code = new SqlParameter("@CODIGO", SqlDbType.Char, 5);
            SqlParameter Name = new SqlParameter("@NOMBRE", SqlDbType.VarChar, 50);
            SqlParameter IdNumber = new SqlParameter("@CEDULA", SqlDbType.Char, 11);
            SqlParameter UserName = new SqlParameter("@NOMBRE_USUARIO",SqlDbType.VarChar,50);
            SqlParameter Password = new SqlParameter("@CLAVE", SqlDbType.VarChar, 50);
            SqlParameter UserType = new SqlParameter("@TIPO_USUARIO", SqlDbType.VarChar, 50);
            SqlParameter State = new SqlParameter("@ESTADO", SqlDbType.VarChar, 50);

            Name.Value = this.name;
            IdNumber.Value = this.idNumber;
            UserName.Value = this.userName;
            Password.Value = this.password;
            UserType.Value = this.userType;
            State.Value = this.state;
            Code.Value=this.code;

            parameters = (Code.Value != null) ?
                new List<SqlParameter>() { Code, Name, IdNumber, UserName, Password, UserType, State } :
                new List<SqlParameter>() { Name, IdNumber, UserName, Password, UserType, State };

            #endregion SettingValues
        }

        public override async Task<int> Insert() =>
            await IQueryExecutor.IntReturnerExecutor(new string[] { @"EXEC INSERTA_USUARIO
                @NOMBRE,@CEDULA,@NOMBRE_USUARIO,@CLAVE,@TIPO_USUARIO,@ESTADO"},parameters.ToArray());

        public async Task<int> Update(string newUsername,string newPassword)
        {
            SqlParameter NewUserName = new SqlParameter("@NEW_USERNAME", SqlDbType.VarChar, 50);
            SqlParameter NewPassword = new SqlParameter("@NEW_PASSWORD", SqlDbType.VarChar, 50);

            NewUserName.Value = newUsername;
            NewPassword.Value = newPassword;

            parameters.AddRange(new List<SqlParameter>() { NewUserName, NewPassword });

            return await IQueryExecutor.IntReturnerExecutor(new string[] 
                {"EXEC ACTUALIZA_USUARIO @NOMBRE_USUARIO,@CLAVE,@NEW_USERNAME,@NEW_PASSWORD"}
                ,parameters.ToArray());
        }


    }
}
