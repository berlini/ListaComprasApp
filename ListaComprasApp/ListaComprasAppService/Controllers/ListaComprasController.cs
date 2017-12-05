using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.OData;
using Microsoft.Azure.Mobile.Server;
using ListaComprasAppService.DataObjects;
using ListaComprasAppService.Models;

namespace ListaComprasAppService.Controllers
{
    public class ListaComprasController : TableController<ListaCompras>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            ListaComprasAppContext context = new ListaComprasAppContext();
            DomainManager = new EntityDomainManager<ListaCompras>(context, Request);
        }

        // GET tables/ListaCompras
        public IQueryable<ListaCompras> GetAllItem()
        {
            return Query();
        }

        // GET tables/ListaCompras/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<ListaCompras> GetItem(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/ListaCompras/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<ListaCompras> PatchItem(string id, Delta<ListaCompras> patch)
        {
            return UpdateAsync(id, patch);
        }

        // POST tables/ListaCompras
        public async Task<IHttpActionResult> PostItem(ListaCompras lista)
        {
            ListaCompras current = await InsertAsync(lista);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/ListaCompras/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteItem(string id)
        {
            return DeleteAsync(id);
        }
    }
}