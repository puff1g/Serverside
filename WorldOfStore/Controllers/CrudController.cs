using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace WorldOfStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CrudController : ControllerBase
    {
        public class CRUDController : ControllerBase
        {
            SqlConnection conn = new SqlConnection(new SqlConnectionStringBuilder()
            {
                DataSource = "",
                InitialCatalog = "",
                UserID = "",
                Password = ""
            }.ConnectionString);

        }
    }
}
