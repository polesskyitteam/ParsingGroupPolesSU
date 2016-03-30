using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Parsing
{
    public class MainWindowView : ViewModelBase
    {
        public string Title { get { return "calc"; } }

        public ObservableCollection<Book> Books { get; private set; }
        public MainWindowView()
        {
            Books = new ObservableCollection<Book>
            {
                new Book{Title = "Qwery", Pages = 123},
                new Book{Title = "sdcd", Pages = 1223},
            };
        }

        //public List<ParsingPolessu> Parsing { get; private set; }



        private ICommand _addCommand;
        private ICommand _parsing;

        public ICommand AddCommand
        {
            get
            {
                return _addCommand ?? (_addCommand = new RelayCommand(()=>
                    {
                        Books.Add(new Book { Title = "sasi", Pages = 32433 });
                    }));
            }
        }

        public ICommand Parsing
        {
            get
            {
                return _parsing ?? (_parsing = new RelayCommand(() =>
                    {
                        //string group = null;
                        ParsingPolessu ParsingGroup = new ParsingPolessu();
                        ParsingGroup.Pars();
                    }));
            }
        }
    }
}
