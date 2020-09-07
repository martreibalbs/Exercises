using Exercises.FoodLocatorApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.FoodLocatorApp.ViewModels
{
    public class Lists:ILists
    {
        List<PlaceModel> myData;
        List<ListModel> myList;
        public Lists()
        {
            myList = new List<ListModel>();

            myList.Add(new ListModel() { First = "Welcome", Fmiddle = "to my", Smiddle = "UI Design" });
            myList.Add(new ListModel() { First = "Taste", Fmiddle = "something", Smiddle = "different.", Last = "FIND BEST RESTAURANTS NEAR YOU" });
            myList.Add(new ListModel() { First = "Click", Fmiddle = "get started", Smiddle = "to begin" });


            myData = new List<PlaceModel>();

            myData.Add(new PlaceModel() { id = 0, Latitude = 10.290063, Longitude = 123.965158, RestaurantImage = "first.png", RestaurantName = "Jollibee", RestaurantFood = "Fast Food | Any Varity", RestaurantDetail = "Jollibee Foods Corp. is engaged in developing, operating, and franchising fast food stores under the trade name Jollibee. " });
            myData.Add(new PlaceModel() { id = 1, Latitude = 11.290063, Longitude = 124.965158, RestaurantImage = "second.png", RestaurantName = "Mc Donalds", RestaurantFood = "Fast Food | Any Varity", RestaurantDetail = "McDonald’s (MCD) is a fast food, limited service restaurant with more than 35,000 restaurants in over 100 countries. " });
            myData.Add(new PlaceModel() { id = 2, Latitude = 12.290063, Longitude = 125.965158, RestaurantImage = "third.png", RestaurantName = "Night Restaurant", RestaurantFood = "Pizza | Italian Food", RestaurantDetail = "This is a detail gjfdgodjaiadgajgoij igj iojaiog jdaiogj daopgjd aoijgoidaj gpoiaj iodjaio joi jodpjdioasjifodsj." });
            myData.Add(new PlaceModel() { id = 3, Latitude = 13.290063, Longitude = 126.965158, RestaurantImage = "third.png", RestaurantName = "Night Restaurant", RestaurantFood = "Pizza | Italian Food", RestaurantDetail = "This is a detail gjfdgodjaiadgajgoij igj iojaiog jdaiogj daopgjd aoijgoidaj gpoiaj iodjaio joi jodpjdioasjifodsj." });

        }

        public async Task<List<ListModel>> getlists()
        {
            return await Task.FromResult(myList);

        }
        public async Task<List<PlaceModel>> getplaces()
        {
            return await Task.FromResult(myData);
        }
    }
}
