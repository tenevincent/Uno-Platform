using CoffeeBrowser.Models;
using CoffeeBrowser.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeBrowser.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private readonly ICoffeeDataService _coffeeDataProvider;
        private Coffee _selectedCoffee;

        public MainPageViewModel(ICoffeeDataService coffeeDataProvider)
        {
            _coffeeDataProvider = coffeeDataProvider;
        }
         
        public Coffee SelectedCoffee
        {
            get { return _selectedCoffee; }
            set
            {
                if (_selectedCoffee != value)
                {
                    _selectedCoffee = value;
                    RaisePropertyChanged();
                }
            }
        }



        public ObservableCollection<Coffee> Coffees { get; } = new ObservableCollection<Coffee>();

        public async Task Load()
        {
            Coffees.Clear();
            var coffees = await _coffeeDataProvider.LoadCoffees();
            foreach (var coffee in coffees)
            {
                Coffees.Add(coffee);
            }

            SelectedCoffee = Coffees.FirstOrDefault();
        }

        public void Next()
        {
            if (Coffees.Any())
            {
                if (SelectedCoffee == null)
                {
                    SelectedCoffee = Coffees.First();
                }
                else
                {
                    var index = Coffees.IndexOf(SelectedCoffee) + 1;

                    if (index > Coffees.Count - 1)
                    {
                        index = 0;
                    } 
                    SelectedCoffee = Coffees[index];
                }
            }
        }

        public void Previous()
        {
            if (Coffees.Any())
            {
                if (SelectedCoffee == null)
                {
                    SelectedCoffee = Coffees.Last();
                }
                else
                {
                    var index = Coffees.IndexOf(SelectedCoffee) - 1;

                    if (index < 0)
                    {
                        index = Coffees.Count - 1;
                    }

                    SelectedCoffee = Coffees[index];
                }
            }
        }

    }
}
