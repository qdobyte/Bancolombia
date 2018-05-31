using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Descripción breve de CreditosModel
/// </summary>
public class CreditosModel
{
    public int IdCredito;
    public string Nombre;
    public int Monto;
    public int Plazo;
    public float Tea;
    public float Tnm;
    public int TotalInteres;
    public int TotalMontoInteres;

    public string Error;

    private ConexionSQL conexionSQL = null;
    private SqlCommand sqlCommand;
    
    public CreditosModel()
    {
        this.conexionSQL = new ConexionSQL();
        this.sqlCommand = new SqlCommand();
    }

    public bool InsertarCredito(string producto, int plazo, int monto, int idCliente)
    {

        float tea = this.GetTEA(producto);
        float tnm = this.GetTNM(tea);
        int anualidad = this.CalculateAnualidad(monto, plazo, tnm);
        int totalInteres = this.CalculateTotalInteres(anualidad, plazo, monto);
        int totalMontoIntereses = monto + totalInteres;

        sqlCommand.CommandType = CommandType.StoredProcedure;
        sqlCommand.CommandText = "crearCredito";
        sqlCommand.Parameters.AddWithValue("@Plazo", plazo); 
        sqlCommand.Parameters.AddWithValue("@Monto", monto); 
        sqlCommand.Parameters.AddWithValue("@TotalInteres", totalInteres); 
        sqlCommand.Parameters.AddWithValue("@Anualidad", anualidad); 
        sqlCommand.Parameters.AddWithValue("@Tnm", tnm); 
        sqlCommand.Parameters.AddWithValue("@Tea", tea); 
        sqlCommand.Parameters.AddWithValue("@IdCliente", idCliente); 
        sqlCommand.Parameters.AddWithValue("@TotalMontoIntereses", totalMontoIntereses); 

        bool consultaExitosa = conexionSQL.ExecuteStoreProcedure(sqlCommand);
        sqlCommand = null;

        if (consultaExitosa)
        {
            return true;
        }
        else
        {
            this.Error = conexionSQL.ErrorMessage;
            return false;
        }
    }

    public List<CreditosModel> ConsultarProductosPorCliente(string cedula)
    {
        sqlCommand.CommandType = CommandType.StoredProcedure;
        sqlCommand.CommandText = "consultarProductosPorCliente";
        sqlCommand.Parameters.AddWithValue("@Cedula", cedula);

        bool consultaExitosa = conexionSQL.ExecuteStoreProcedure(sqlCommand);
        sqlCommand = null;
        List<CreditosModel> lista = new List<CreditosModel> { };
        if (consultaExitosa)
        {
            if (conexionSQL.data.Rows.Count > 0)
            {
                foreach (DataRow row in conexionSQL.data.Rows)
                {
                    lista.Add(new CreditosModel()
                    {
                        IdCredito = Int32.Parse(row["id_credito"].ToString()),
                        Nombre = row["nombre"].ToString(),
                        Monto = Int32.Parse(row["monto"].ToString()),
                        Plazo = Int32.Parse(row["plazo"].ToString()),
                        Tea = float.Parse(row["tea"].ToString()),
                        Tnm = float.Parse(row["tnm"].ToString()),
                        TotalInteres = Int32.Parse(row["total_interes"].ToString()),
                        TotalMontoInteres = Int32.Parse(row["total_monto_intereses"].ToString()),
                    });
                }
            }
            else
            {
                lista.Add(new CreditosModel() { Error = "No se encontraron creditos para el cliente seleccionado" });
            }
        }
        else
        {
            lista.Add(new CreditosModel() { Error = conexionSQL.ErrorMessage });
        }
        return lista;
    }

    #region Calculos
    private float GetTEA(string producto) {
        float tea;
        switch (producto) {
            case "libreInversion":
                tea = 32;
                break;
            case "vehiculo":
                tea = 24;
                break;
            case "vivienda":
                tea = 12;
                break;
            default:
                tea = 0;
                break;
        }
        return tea;
    }

    private float GetTNM(float tnm) {
        switch (tnm)
        {
            case 32:
                tnm = 2.34f;
                break;
            case 24:
                tnm = 1.8f;
                break;
            case 12:
                tnm = 0.94f;
                break;
            default:
                tnm = 0;
                break;
        }
        return tnm;
    }

    private int CalculateAnualidad(int monto, int plazo, float tnm) {
        float exponencial = (float) Math.Pow( (tnm / 100) + 1 , plazo);
        return Convert.ToInt32(  monto * (exponencial * (tnm/100)) / (exponencial - 1) );
    }

    private int CalculateTotalInteres(int anualidad, int plazo, int monto) {
        return ( anualidad * plazo ) - monto;
    }
    #endregion
}