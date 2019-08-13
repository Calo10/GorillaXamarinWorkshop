using System;
using System.Collections.ObjectModel;

namespace GorillaTest.Model
{
    public class MenuModel
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }


        public static ObservableCollection<MenuModel> GetMenu()
        {
            ObservableCollection<MenuModel> lstMenu = new ObservableCollection<MenuModel> 
            { 
                new MenuModel {Id=1, Name="Contact", Icon=""},
                new MenuModel {Id=2, Name="Students", Icon=""},
                new MenuModel {Id=3, Name="Map", Icon=""}
            };

            return lstMenu;
        }

        public MenuModel()
        {
        }
    }
}
