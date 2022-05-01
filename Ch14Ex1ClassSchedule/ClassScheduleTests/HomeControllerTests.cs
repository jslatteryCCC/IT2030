using System;
using Xunit;
using Moq;
using Microsoft.AspNetCore.Mvc;
using ClassSchedule.Models;
using ClassSchedule.Controllers;
using Microsoft.AspNetCore.Http;


namespace ClassScheduleTests {
    public class HomeControllerTests {
        [Fact]
        public void IndexActionMethod_ReturnsAViewResult() {

            var unit = new Mock<IClassScheduleUnitOfWork>();
            var http = new Mock<IHttpContextAccessor>();
            var classes = new Mock<IRepository<Class>>();
            var days = new Mock<IRepository<Day>>();
            unit.Setup(u => u.Classes).Returns(classes.Object);
            unit.Setup(u => u.Days).Returns(days.Object);

            var controller = new HomeController(unit.Object, http.Object);

            var result = controller.Index(0);

            Assert.IsType<ViewResult>(result);

        }
    }
}
