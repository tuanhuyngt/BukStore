﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Dapper;
using BukStore.AbpZeroTemplate.Helpers.Dto;
using System.Linq;

namespace BukStore.AbpZeroTemplate.Helpers
{
    public interface IProcedureHelper
    {
        List<T> GetData<T>(string procedureName, object parameter);
    }

    public class ProcedureHelper : IProcedureHelper
    {
        private readonly string connectionString;
        public ProcedureHelper()
        {
            connectionString = "Data Source=35.240.139.201;Initial Catalog=DbPratice;User ID=tuanhuyngt;Password=tuanhuy1231;";
        }

        private List<ProcedureParamInfo> GetParamInfos(IDbConnection conn, string procedureName)
        {
            var rr = conn.Query<ProcedureParamInfo>($"select PARAMETER_NAME, PARAMETER_MODE, DATA_TYPE, CHARACTER_MAXIMUM_LENGTH from information_schema.parameters where specific_name = '{procedureName}'");
            return rr.ToList();
        }

        public List<T> GetData<T>(string procedureName, object parameter)
        {
            List<T> result;

            using (IDbConnection con = new SqlConnection(connectionString))
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                var paramsInfo = GetParamInfos(con, procedureName);

                DynamicParameters parameters = new DynamicParameters();

                var properties = parameter.GetType().GetProperties();

                foreach (var param in paramsInfo)
                {
                    var property = properties
                                    .Where(x => x.Name.ToLower() == param.PARAMETER_NAME.Replace("@", "").ToLower())
                                    .FirstOrDefault();
                    if (property == null)
                    {
                        continue;
                    }
                    parameters.Add(param.PARAMETER_NAME, property.GetValue(parameter));
                }

                result = con.Query<T>(procedureName, parameters, null, true, null, System.Data.CommandType.StoredProcedure).ToList();
            }

            return result;
        }
    }
}
