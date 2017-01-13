using MongoDB.Driver;
using System;
using System.Configuration;

namespace CrudMVC_MongoDB.Models
{
    public class AlunoDB
    {
        public MongoDatabase Database;
        public string DataBaseName = "AlunoBD";
        string conexaoMongoDB = "";

        public AlunoDB()
        {
            conexaoMongoDB = ConfigurationManager.ConnectionStrings["conexaoMongoDB"].ConnectionString;
            var cliente = new MongoClient(conexaoMongoDB);
            var server = cliente.GetServer();
            Database = server.GetDatabase(DataBaseName);
        }

        public MongoCollection<Aluno> Alunos
        {
            get
            {
                var Alunos = Database.GetCollection<Aluno>("Alunos");
                return Alunos;
            }
        }
    }
}
