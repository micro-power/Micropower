using FluentAssertions;
using Micropower.Controllers;
using Micropower.Interfaces;
using Micropower.Models;
using Micropower.Models.Entities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace Micropower.Tests.Models
{
    [TestFixture]
    public class KolumnatorControllerTest
    {
        [TestCase("ColumnCurrentState")]
        [TestCase("ColumnWorkingParams")]
        [TestCase("ColumnAlarms")]
        [TestCase("")]
        public void Get_RequestData_GetObject(string param)
        {
            // Arrange
            var controller = new KolumnatorController();
            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();
            Object response;
// Act
            if (String.IsNullOrEmpty( param)) response = controller.Get();
            else response = controller.Get(param);

            // Assert
            Assert.IsTrue(response != null);
            switch (param)
            {
                case "ColumnCurrentState":
                    response.Should().BeOfType<ColumnState>();
                    break;
                case " ":
                    response.Should().BeOfType<Column>();
                    break;
                case "ColumnAlarms":
                    response.Should().BeOfType<ColumnAlarmSet>();
                    break;
                case "ColumnWorkingParams":
                    response.Should().BeOfType<ColumnParamsSet>();
                    break;
                default:
                    break;
            }            
        }
    }
}
