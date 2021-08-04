using CoffeeBrowser.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeBrowser.Services
{

    public interface ICoffeeDataService
    {
        Task<IEnumerable<Coffee>> LoadCoffees();
    }

    public class CoffeeDataService : ICoffeeDataService
    {
        public async Task<IEnumerable<Coffee>> LoadCoffees()
        {
            await Task.Delay(100); // Simulate a bit of server work

            return new[]
            {
        new Coffee{Name="Cappuccino",Description="Espresso with streamed milk and with milk foam"},
        new Coffee{Name="Doppio",Description="Double espresso"},
        new Coffee{Name="Espresso",Description="Pure coffee to keep you awake! :-)"},
        new Coffee{Name="Latte",Description="Cappuccino with more streamed milk"},
        new Coffee{Name="Latte Special",Description="Cappuccino with special streamed milk"}
      };
        }
    }

}
