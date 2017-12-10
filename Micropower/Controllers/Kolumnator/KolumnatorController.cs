using Micropower.Interfaces;
using Micropower.Models;
using Micropower.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Micropower.Controllers
{
    public class ColumnController : ApiController
    {
        IRepository<Column> repository = new Repository<Column>("Kolumnator");
        // GET api/<controller>
        public Column Get() //Return Column Object
        {
            return repository.List().FirstOrDefault();
        }

        // GET api/<controller>/5
        public object Get(string id) //Return Column Param
        {
            var response = repository.List().FirstOrDefault();
            return response.GetType().GetProperty(id).GetValue(response, null);
        }

        // POST api/<controller>
        public string Post([FromBody]string value)
        {
            //T1:2211,T2:3355,T3:4477,T4:6699,OS1:0,OS2:1,CS:2
            var column = repository.List().FirstOrDefault();
            ColumnState columnState = new ColumnState();
            var tab = value.Split(',');
            foreach (var item in tab)
            {
                var param = item.Split(':');
double paramValueD;
                int paramValueI;
                bool paramValueB;
                switch (param[0])
                {
                    case "T1":
                        
                        Double.TryParse(param[1], out paramValueD);
                        columnState.Temperature1 = paramValueD / 100;
                        break;
                    case "T2":

                        Double.TryParse(param[1], out paramValueD);
                        columnState.Temperature2 = paramValueD / 100;
                        break;
                    case "T3":

                        Double.TryParse(param[1], out paramValueD);
                        columnState.Temperature3 = paramValueD / 100;
                        break;
                    case "T4":
                        Double.TryParse(param[1], out paramValueD);
                        columnState.Temperature4 = paramValueD / 100;
                        break;
                    case "OS1":
                        Boolean.TryParse(param[1], out paramValueB);
                        columnState.OverflowSensor1 = paramValueB;
                        break;
                    case "OS2":
                        Boolean.TryParse(param[1], out paramValueB);
                        columnState.OverflowSensor2 = paramValueB;
                        break;
                    case "CS":
                        Int32.TryParse(param[1], out paramValueI);
                        columnState.ColumnStep = (Column.State)paramValueI;
                        break;
                    default:
                        break;
                }
            }
            column.ColumnCurrentState=columnState;
            repository.Update(column);
            return "";
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}