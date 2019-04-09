using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab05.DB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lab05.APIRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidosController : ControllerBase
    {

        ModelNorthwind db;

       // GET: api/Pedidos
       [HttpGet]
        public IEnumerable<Orders> Get(int? id = null, string nombre = "", string pais = "all")
        {
            if(id == null && nombre == "" && pais == "all")
            {
                var orders = db.Orders.Include(o=>o.ShipViaNavigation).ToList();
                if (orders != null)
                {
                    return orders;
                }
            }
            else if(id == null && nombre == "" && pais != "all")
            {
                var orders = db.Orders.Include(o => o.ShipViaNavigation).Where(o => o.ShipCountry == pais).ToList();
                if (orders != null)
                {
                    return orders;
                }
            }
            else if(id == null && nombre != "" && pais == "all")
            {
                var orders = db.Orders.Include(o => o.ShipViaNavigation).Where(o => db.Order_Details
                    .Where(od => od.Product.ProductName.Contains(nombre)).Select(od => od.OrderID).Contains(o.OrderID)).ToList();
                if (orders != null)
                {
                    return orders;
                }
            }
            else if(id == null && nombre != "" && pais != "all")
            {
                var orders = db.Orders.Include(o => o.ShipViaNavigation).Where(o => db.Order_Details
                    .Where(od => od.Product.ProductName.Contains(nombre)).Select(od => od.OrderID).Contains(o.OrderID) && o.ShipCountry == pais).ToList();
                if (orders != null)
                {
                    return orders;
                }
            }
            else if (id != null && nombre == "" && pais == "all")
            {
                var orders = db.Orders.Include(o => o.ShipViaNavigation).Where(o => o.OrderID == id).ToList();
                if (orders != null)
                {
                    return orders;
                }
            }
            else if (id != null && nombre == "" && pais != "all")
            {
                var orders = db.Orders.Include(o => o.ShipViaNavigation).Where(o => o.OrderID == id && o.ShipCountry == pais).ToList();
                if (orders != null)
                {
                    return orders;
                }
            }
            else if (id != null && nombre != "" && pais == "all")
            {
                var orders = db.Orders.Include(o => o.ShipViaNavigation).Where(o => db.Order_Details
                    .Where(od => od.Product.ProductName.Contains(nombre)).Select(od => od.OrderID).Contains(o.OrderID) 
                    && o.OrderID == id).ToList();
                if (orders != null)
                {
                    return orders;
                }
            }
            else if (id != null && nombre != "" && pais != "all")
            {
                var orders = db.Orders.Include(o => o.ShipViaNavigation).Where(o => db.Order_Details
                    .Where(od => od.Product.ProductName.Contains(nombre)).Select(od => od.OrderID).Contains(o.OrderID)
                    && o.OrderID == id && o.ShipCountry == pais).ToList();
                if (orders != null)
                {
                    return orders;
                }
            }

            
            return new List<Orders>();
        }

        public PedidosController()
        {
            db = new ModelNorthwind();
        }
    }
}
