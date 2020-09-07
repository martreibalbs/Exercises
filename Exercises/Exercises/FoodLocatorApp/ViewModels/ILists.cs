using Exercises.FoodLocatorApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.FoodLocatorApp.ViewModels
{
    public interface ILists
    {
        Task<List<PlaceModel>> getplaces();
        Task<List<ListModel>> getlists();
    }
}
