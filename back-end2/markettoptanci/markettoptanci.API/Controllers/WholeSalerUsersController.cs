using markettoptanci.Business.Abstract;
using markettoptanci.Business.Concrete;
using markettoptanci.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace markettoptanci.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WholeSalerUsersController
    {
        private IWholeSalerUserService _wholeSalerUserService;
        public WholeSalerUsersController()
        {
            _wholeSalerUserService = new WholeSalerUserManager();
        }


        [HttpGet]
        public List<WholeSalerUser> GetAllWholeSalerUsers()
        {
            return _wholeSalerUserService.GetAllWholeSalerUsers();
        }

        [HttpGet("{id}")]
        public WholeSalerUser GetWholeSalerUserById(int id)
        {
            return _wholeSalerUserService.GetWholeSalerUserById(id);
        }

        [HttpPost]
        public WholeSalerUser CreateWholeSalerUser([FromBody] WholeSalerUser wholeSalerUser)
        {
            return _wholeSalerUserService.CreateWholeSalerUser(wholeSalerUser);
        }

        [HttpPut]
        public WholeSalerUser UpdateWholeSalerUser([FromBody] WholeSalerUser wholeSalerUser)
        {
            return _wholeSalerUserService.UpdateWholeSalerUser(wholeSalerUser);
        }

        [HttpDelete("{id}")]
        public WholeSalerUser DeleteWholeSalerUser(int id)
        {
            return _wholeSalerUserService.DeleteWholeSalerUser(id);
        }
    }
}
