using System;
using System.Collections.Generic;
using System.Data;

namespace Financiamientos.Models.QueryBuilding
{
    public enum Conditions
    {
        Equals,
        Different,
        Less,
        Greater,
        LessOrEqual,
        GreaterOrEqual,
        Like
    }
    public enum Tables
    {
        Customer,
        User,
        Loan,
        Payment,
        Fee
    }
    public enum Operators
    {
        And,
        Or,
    }
    public enum ColumnNames
    {
        All,
        CustomerCode,
        UserCode,
        LoanCode,
        PaymentCode,
        FeeCode,
        CapitalAmmount,
        RemaningCapitalAmmount,
        PaidInCapital,
        InterestAmmount,
        RemaningInteresAmmount,
        PaidInInterest,
        ArrearsAmmount,
        RemaningArrearsAmmount,
        PaidInArrears,
        InterestRate,
        LoanDate,
        PaymentDate,
        FeeDate,
        ArrearsNumber,
        InstallsmentNumber,
        State,
        PaymentMethod,
        UserName,
        UserType,
        Password,
        Name,
        IdNumber,
        BirthDate,
        Phone,
        Adress,
        Ammount,
    }
    public enum JoinType
    {
        Inner,
        Full,
        Left,
        Right,
        Self,
        Outer
    }
    public static class QueryObjectsSetter
    {
        public static void setColumns(IEnumerable<Tables> tables, ColumnNames column, ref string ColumnName,ref string alias)
        {
            foreach(Tables table in tables)
            {
                if (column == ColumnNames.All)
                {
                    ColumnName = "*";
                }
                else
                {
                    switch (table)
                    {
                        case Tables.Customer:
                            switch (column)
                            {
                                case ColumnNames.CustomerCode:
                                    ColumnName = "CLI.CODIGO";
                                    alias = "[Codigo Cliente]";
                                    break;
                                case ColumnNames.Name:
                                    ColumnName = "CLI.NOMBRE";
                                    alias = "[Nombre Cliente]";
                                    break;
                                case ColumnNames.IdNumber:
                                    ColumnName = "CLI.CEDULA";
                                    alias = "[Cedula Cliente]";
                                    break;
                                case ColumnNames.BirthDate:
                                    ColumnName = "CLI.FECHA_NAC";
                                    alias = "[Fecha Nac. Cliente]";
                                    break;
                                case ColumnNames.Phone:
                                    ColumnName = "CLI.TELEFONO";
                                    alias = "[Telefono Cliente]";
                                    break;
                                case ColumnNames.Adress:
                                    ColumnName = "CLI.DIRECCION";
                                    alias = "[Direccion Cliente]";
                                    break;
                               

                            }
                            break;
                        case Tables.User:
                            switch (column)
                            {
                                case ColumnNames.UserCode:
                                    ColumnName = "USU.CODIGO";
                                    alias = "[Codigo Usuario]";
                                    break;
                                case ColumnNames.Name:
                                    ColumnName = "USU.NOMBRE";
                                    alias = "[Nombre Usuario]";
                                    break;
                                case ColumnNames.IdNumber:
                                    ColumnName = "USU.CEDULA";
                                    alias = "[Cedula Usuario]";
                                    break;
                                case ColumnNames.UserName:
                                    ColumnName = "USU.NOMBRE_USUARIO";
                                    alias = "[UserName Usuario]";
                                    break;
                                case ColumnNames.Password:
                                    ColumnName = "USU.CLAVE";
                                    alias = "[Clave Usuario]";
                                    break;
                                case ColumnNames.UserType:
                                    ColumnName = "USU.TIPO_USUARIO";
                                    alias = "[Tipo de Usuario]";
                                    break;
                                case ColumnNames.State:
                                    ColumnName = "ESTADO_USUARIO";
                                    alias = "[Estado Usuario]";
                                    break;
                               
                            }
                            break;
                        case Tables.Payment:
                            switch (column)
                            {
                                case ColumnNames.PaymentCode:
                                    ColumnName = "PAG.CODIGO";
                                    alias = "[Codigo Pago]";
                                    break;
                                case ColumnNames.Ammount:
                                    ColumnName = "PAG.ABONO";
                                    alias = "[Monto Pago]";
                                    break;
                                case ColumnNames.PaymentDate:
                                    ColumnName = "PAG.FECHA";
                                    alias = "[Fecha Pago]";
                                    break;
                                case ColumnNames.PaymentMethod:
                                    ColumnName = "PAG.METODO_PAGO";
                                    alias = "[Metodo de Pago]";
                                    break;
                                case ColumnNames.LoanCode:
                                    ColumnName = "PAG.CODIGO_PRESTAMO";
                                    alias = "[Codigo Prestamo]";
                                    break;
                                case ColumnNames.PaidInArrears:
                                    ColumnName = "PAG.MORA_PAGADA";
                                    alias = "[Mora Pagada]";
                                    break;
                                case ColumnNames.PaidInInterest:
                                    ColumnName = "PAG.INTERES_PAGADO";
                                    alias = "[Interes Pagado]";
                                    break;
                                case ColumnNames.PaidInCapital:
                                    ColumnName = "PAG.CAPITAL_PAGADO";
                                    alias = "[Capital Pagado]";
                                    break;
                               
                            }
                            break;
                        case Tables.Fee:
                            switch (column)
                            {
                                case ColumnNames.FeeCode:
                                    ColumnName = "CUO.CODIGO";
                                    alias = "[Codigo Cuota]";
                                    break;
                                case ColumnNames.LoanCode:
                                    ColumnName = "CUO.CODIGO_PRESTAMO";
                                    alias = "[Codigo Prestamo]";
                                    break;
                                case ColumnNames.FeeDate:
                                    ColumnName = "CUO.FECHA";
                                    alias = "[Fecha Cuota]";
                                    break;
                                case ColumnNames.ArrearsNumber:
                                    ColumnName = "CUO.NUMERO_MORA";
                                    alias = "[Numero Mora]";
                                    break;
                                case ColumnNames.RemaningCapitalAmmount:
                                    ColumnName = "CUO.MONTO_CAPITAL_RESTANTE";
                                    alias = "[Monto Capital Restante]";
                                    break;
                                case ColumnNames.RemaningInteresAmmount:
                                    ColumnName = "CUO.MONTO_INTERES_RESTANTE";
                                    alias = "[Monto Interes Restante]";
                                    break;
                                case ColumnNames.RemaningArrearsAmmount:
                                    ColumnName = "CUO.MONTO_MORA";
                                    alias = "[Monto Mora Restante]";
                                    break;
                                case ColumnNames.State:
                                    ColumnName = "CUO.ESTADO";
                                    alias = "[Estado Cuota]";
                                    break;
                                
                            }
                            break;
                        case Tables.Loan:
                            switch (column)
                            {
                                case ColumnNames.LoanCode:
                                    ColumnName = "PRE.CODIGO";
                                    alias = "[Codigo Prestamo]";
                                    break;
                                case ColumnNames.CustomerCode:
                                    ColumnName = "PRE.CODIGO_CLIENTE";
                                    alias = "[Codigo Cliente]";
                                    break;
                                case ColumnNames.UserCode:
                                    ColumnName = "PRE.CODIGO_USUARIO";
                                    alias = "[Codigo Usuario]";
                                    break;
                                case ColumnNames.LoanDate:
                                    ColumnName = "PRE.FECHA";
                                    alias = "[Fecha Prestamo]";
                                    break;
                                case ColumnNames.CapitalAmmount:
                                    ColumnName = "PRE.MONTO_CAPITAL";
                                    alias = "[Monto Capital]";
                                    break;
                                case ColumnNames.InstallsmentNumber:
                                    ColumnName = "PRE.NO_CUOTAS";
                                    alias = "[Numero de Cuotas]";
                                    break;
                                case ColumnNames.State:
                                    ColumnName = "PRE.ESTADO";
                                    alias = "[Estado Prestamo]";
                                    break;
                                case ColumnNames.InterestRate:
                                    ColumnName = "PRE.PORCIENTO_INTERES_MENSUAL";
                                    alias = "[Tasa Interes]";
                                    break;
                               
                            }
                            break;
                    }
                }
            }
                
        }
        public static void setParametersProperties(ColumnNames column,ref SqlDbType type,ref int length,ref byte scale)
        {
            switch(column)
            {
                #region Loan
                case ColumnNames.LoanCode:
                    type = SqlDbType.Char;
                    length = 7;
                    break;
                case ColumnNames.LoanDate:
                    type = SqlDbType.DateTime;
                    break;
                case ColumnNames.CapitalAmmount:
                    type = SqlDbType.Decimal;
                    length = 24;
                    scale = 4;
                    break;
                case ColumnNames.InstallsmentNumber:
                    type = SqlDbType.Int;
                    break;
                case ColumnNames.InterestRate:
                    type = SqlDbType.Decimal;
                    length = 14;
                    scale = 4;
                    break;
                #endregion Loan
                #region Customer
                case ColumnNames.CustomerCode:
                    type = SqlDbType.Char;
                    length = 7;
                    break;
                case ColumnNames.Name:
                    type = SqlDbType.VarChar;
                    length = 50;
                    break;
                case ColumnNames.IdNumber:
                    type = SqlDbType.Char;
                    length = 11;
                    break;
                case ColumnNames.BirthDate:
                    type = SqlDbType.Date;
                    break;
                case ColumnNames.Phone:
                    type = SqlDbType.Char;
                    length = 10;
                    break;
                case ColumnNames.Adress:
                    type = SqlDbType.VarChar;
                    length = 200;
                    break;
                #endregion Customer
                #region User
                case ColumnNames.UserCode:
                    type = SqlDbType.Char;
                    length = 5;
                    break;
                case ColumnNames.UserName:
                    type = SqlDbType.VarChar;
                    length = 50;
                    break;
                case ColumnNames.Password:
                    type = SqlDbType.VarChar;
                    length = 50;
                    break;
                case ColumnNames.UserType:
                    type = SqlDbType.VarChar;
                    length = 50;
                    break;
                #endregion User
                #region Fee
                case ColumnNames.FeeCode:
                    type = SqlDbType.Char;
                    length = 10;
                    break;
                case ColumnNames.FeeDate:
                    type = SqlDbType.Date;
                    break;
                case ColumnNames.ArrearsNumber:
                    type = SqlDbType.Int;
                    break;
                case ColumnNames.RemaningCapitalAmmount:
                    type = SqlDbType.Decimal;
                    length = 24;
                    scale = 4;
                    break;
                case ColumnNames.RemaningInteresAmmount:
                    type = SqlDbType.Decimal;
                    length = 24;
                    scale = 4;
                    break;
                case ColumnNames.RemaningArrearsAmmount:
                    type = SqlDbType.Decimal;
                    length = 24;
                    scale = 4;
                    break;
                #endregion Fee
                #region Payment
                case ColumnNames.PaymentCode:
                    type = SqlDbType.Char;
                    length = 14;
                    break;
                case ColumnNames.Ammount:
                    type = SqlDbType.Decimal;
                    length = 24;
                    scale = 4;
                    break;
                case ColumnNames.PaymentDate:
                    type = SqlDbType.DateTime;
                    break;
                case ColumnNames.PaymentMethod:
                    type = SqlDbType.VarChar;
                    length = 50;
                    break;
                case ColumnNames.PaidInCapital:
                    type = SqlDbType.Decimal;
                    length = 24;
                    scale = 4;
                    break;
                case ColumnNames.PaidInInterest:
                    type = SqlDbType.Decimal;
                    length = 24;
                    scale = 4;
                    break;
                case ColumnNames.PaidInArrears:
                    type = SqlDbType.Decimal;
                    length = 24;
                    scale = 4;
                    break;
                    #endregion
            }

        }
        public static string setTables(Tables table)=>
            table switch
            {
                Tables.Customer => "CLIENTE CLI",
                Tables.User => "USUARIO USU",
                Tables.Payment => "PAGO PAG",
                Tables.Fee => "CUOTA CUO",
                Tables.Loan => "PRESTAMO PRE",
                _ => ""
            };
        public static string setConditions(Conditions condition)=>
            condition switch
            {
                Conditions.Equals => "=",
                Conditions.Different => "!=",
                Conditions.Less => "<",
                Conditions.Greater => ">",
                Conditions.LessOrEqual => "<=",
                Conditions.GreaterOrEqual => ">=",
                _ => ""
            };
        public static string setOperators(Operators operators) => (operators == Operators.And) ? "AND" : "OR";
        public static string setJoin(JoinType join)=>
            join switch
            {
                JoinType.Full => "FULL JOIN",
                JoinType.Inner => "INNER JOIN",
                JoinType.Left => "LEFT JOIN",
                JoinType.Right => "RIGHT JOIN",
                JoinType.Self => "SELF JOIN",
                JoinType.Outer => "FULL OUTER JOIN",
                _ => ""
            };
    }
}
