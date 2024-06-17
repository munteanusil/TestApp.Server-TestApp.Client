using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.DataAccess.Dto;
using TestApp.DataAccess.Dto.Common;

namespace TestApp.DataAccess;

public class SqlDataAccess : IDataAccess
{
    private readonly IDbConnection dbConnection;

    public string? ConnectionString { get; } = "Server=localhost;Database=testapp;Uid=testapp;Pwd=abc123;";

    public SqlDataAccess(IDbConnection dbConnection)
    {
        this.dbConnection = dbConnection;
        dbConnection.ConnectionString = ConnectionString;
    }

    public Task<DataAccessReponse> DeleteAsync(string query, dynamic? data = null)
    {
        Console.WriteLine(query);
        return null;
    }

    public async Task<DataAccessReponse> InsertAsync(string query, dynamic data)
    {
        Console.WriteLine(query);
        return null;
    }

    public async Task<DataAccessReponse<TDto>> SelectAsync<TDto>(string query, object? data = null) where TDto : IStorageDto
    {
        DataAccessReponse<TDto> response = new();
        try
        {
            IEnumerable<TDto> result = dbConnection.Query<TDto>(query, data);
            response.Data = result.ToArray();
        }
        catch (Exception ex)
        {
            response.Error = ex.Message;
        }
        return response;
    }

    public async Task<DataAccessReponse> UpdateAsync(string query, dynamic? data = null)
    {
        Console.WriteLine(query);
        return null;
    }
}