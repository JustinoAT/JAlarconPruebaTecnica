using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Disco
    {
        public static ML.Result Add(ML.Disco disco)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.JAlarconPruebaTecnicaEntities context = new DL.JAlarconPruebaTecnicaEntities())
                {
                    //llamada al stored

                    int RowAffected = context.DiscoAdd(disco.Titulo, disco.Artista, disco.GeneroMusical, disco.Duracion, disco.Año, disco.Distribuidora, disco.Ventas, disco.Disponibilidad);

                    if (RowAffected > 0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }
                }

                
            }catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Exception = ex;

            }
            return (result);
        }

        public static ML.Result GetAll() {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.JAlarconPruebaTecnicaEntities context = new DL.JAlarconPruebaTecnicaEntities())
                {
                    //llamada al stored)
                    var tablaDisco = context.DiscoGetAll().ToList();
                    if (tablaDisco != null) { 

                    
                    foreach (var obj in tablaDisco){

                        ML.Disco disco1 = new ML.Disco();
                        disco1.IdDisco = obj.IdDisco; 
                        disco1.Titulo = obj.Titulo;
                        disco1.Artista = obj.Artista;   
                        disco1.GeneroMusical = obj.GeneroMusical;   
                        disco1.Duracion = obj.Duracion;
                        disco1.Año = obj.Año;
                        disco1.Distribuidora = obj.Distribuidora;
                        disco1.Ventas= obj.Ventas;  
                        disco1.Disponibilidad = obj.Disponibilidad;
                        result.Objects.Add(disco1);
                        
                        }
                        result.Correct = true;

                    }
                    else
                    {
                        result.Correct = false;

                    }
                }


            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Exception = ex;

            }
            return (result);
        }
    }
}
