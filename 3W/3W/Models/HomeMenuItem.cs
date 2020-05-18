using System;
using System.Collections.Generic;
using System.Text;

namespace _3W.Models
{
    public enum MenuItemType
    {
        Home,
        Settings,
        About        
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
