using System.Data.SqlClient;
using Dapper;
class BD
{
    private static string _connectionString = @"Server=.;DataBase = BDSeries; Trusted_Connection = True;";

    public static List<Series> ListarSeries(){
        List<Series> _listaseries = new List<Series>();
        using(SqlConnection db = new SqlConnection(_connectionString)){
            string sql="Select * from Series";
            _listaseries=db.Query<Series>(sql).ToList();
            return _listaseries;
        }
    } 

    public static List<Temporadas> ListarTemporadas(int id){
        List<Temporadas> _listaTemporadas=new List<Temporadas>();
        using(SqlConnection db = new SqlConnection(_connectionString)){
            string sql="Select * from Temporadas where IdSerie=@pid";
            _listaTemporadas=db.Query<Temporadas>(sql, new {pid=id}).ToList();
            return _listaTemporadas;
        }
    }

    public static List<Actores> ListarActores(int id){
        List<Actores> _listaActores=new List<Actores>();
        using(SqlConnection db = new SqlConnection(_connectionString)){
            string sql="select * from Actores where IdSerie=@pid";
            _listaActores=db.Query<Actores>(sql, new{pid=id}).ToList();
            return _listaActores;
        }
    }

    public static string GetSinopsis(int id){
        using(SqlConnection db = new SqlConnection(_connectionString)){
            string sql="select Sinopsis from Series where IdSerie=@pid";
            return db.QueryFirstOrDefault<string>(sql,new{pid=id});
    }
    }
}