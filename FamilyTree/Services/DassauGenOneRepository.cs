using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FamilyTree.Models;
using System.Data.SqlClient;
using System.Configuration;
using Dapper;

namespace FamilyTree.Services
{
    public class DassauGenOneRepository
    {
        public bool Create(DassauGenOneDto dassauGenOne)
        {
            using (var db = new SqlConnection(ConfigurationManager.ConnectionStrings["FamilyTree"].ConnectionString))
            {
                db.Open();
                var numberCreated = db.Execute(@"INSERT INTO [dbo].[DassauGenOne]
                           ([FirstName]
                           ,[MiddleName]
                           ,[LastName]
                           ,[BirthDate]
                           ,[BirthCity]
                           ,[BirthState])
                     VALUES
                           (@FirstName
                           ,@MiddleName
                           ,@LastName
                           ,@BirthDate
                           ,@BirthCity
                           ,@BirthState)", dassauGenOne);

                return numberCreated == 1;
            }
        }
    }
}