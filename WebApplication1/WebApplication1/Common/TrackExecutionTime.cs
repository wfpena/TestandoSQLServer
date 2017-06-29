using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Web.Mvc;
using System.IO; //Para ler e escrever a Data.txt, no folder Data


//Criando um Custom Filter
namespace WebApplication1.Common
{
    public class TrackExecutionTime : ActionFilterAttribute, IExceptionFilter
        //A classe ActionFilterAttribute herda das interfaces IActionFilter e IResultFilter
        //We also want to log exception details, so we need to override OnExceptionMethod, então herda 
        //da interface IExceptionFilter
        //Também criou o folder Data com um txt para guardar o log
    {
        private void LogExecutionTime(string data)
        {
            File.AppendAllText(HttpContext.Current.Server.MapPath("~/Data/Data.txt"), data);
            //data é a string que tem os tempos e informações que a gente quer guardar
            //Server.MapPath define o path do txt onde a gente vai append o data
        }
    }
}