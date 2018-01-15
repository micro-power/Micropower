using Micropower.Interfaces;
using Micropower.Models;
using Micropower.Models.DTO;
using Micropower.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Micropower.Controllers
{
    [RoutePrefix("api/Kolumnator")]
    public class KolumnatorController : ApiController
    {
        IRepository<Column> repository = new Repository<Column>("Kolumnator");
        // GET api/<controller>
        //public Column Get() //Return Column Object
        //{
        //    return repository.List().FirstOrDefault();
        //}

        //// GET api/<controller>/5
        //public object Get(string id) //Return Column Param
        //{
        //    var response = repository.List().FirstOrDefault();
        //    return response.GetType().GetProperty(id).GetValue(response, null);
        //}

        // POST api/<controller>
        [Route("Time")]
        [HttpGet]
        public string Time()
        {
            var time = string.Format("$time^{0:H:mm:ss}#",DateTime.Now);
            return time;
        }

        [Route("Send")]
        [HttpPost]
        public string Send([FromBody]ColumnBindingModel value)
        {
            //T1:2211,T2:3355,T3:4477,T4:6699,OS1:0,OS2:1,CS:2,CmdOk:1
            var column = repository.List().FirstOrDefault();
            if (column == null)
            {
                column = new Column();
                repository.Add(column);
            }
            ColumnState columnState = new ColumnState();
            if (columnState.Temperature1.IsAvailable = value.T1 > -6000)
            {
                columnState.Temperature1.Value = value.T1 / 100.0;
            }
            if (columnState.Temperature2.IsAvailable = value.T2 > -6000)
            {
                columnState.Temperature2.Value = value.T2 / 100.0;
            }
            if (columnState.Temperature3.IsAvailable = value.T3 > -6000)
            {
                columnState.Temperature3.Value = value.T3 / 100.0;
            }
            if (columnState.Temperature4.IsAvailable = value.T4 > -6000)
            {
                columnState.Temperature4.Value = value.T4 / 100.0;
            }
            columnState.OverflowSensor1 = value.OS1 != 0;
            columnState.OverflowSensor2 = value.OS2 != 0;
            columnState.ColumnStep = value.CS;
            column.ColumnCurrentState = columnState;
            ColumnParamsSet columnParams = new ColumnParamsSet();
            if(columnParams.IsCommandRecived = value.CmdOk != 0&& columnParams.Commands.Count>0)
            {
                columnParams.Commands.RemoveAt(0);
            }
            var toReturn = "";
            var temp = columnParams.Commands.FirstOrDefault();
            if(temp != null)
            {
                columnParams.IsCommandRecived = false;
                toReturn = temp;
            }
            column.ColumnWorkingParams = columnParams;
            repository.Update(column);
            return toReturn;
        }

        //// PUT api/<controller>/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/<controller>/5
        //public void Delete(int id)
        //{
        //}
    }
}