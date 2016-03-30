using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parsing
{
    public class Book : ObservableObject
    {
        private int _pages;
        
        public string Title { get; set; }
    
        public int Pages
        {
            get { return _pages; }
            set
            {
                _pages = value;
                RaisePropertyChanged(() => Pages);
            }
        }
    }
}
