using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using System.Collections.ObjectModel;

namespace MVVMDemo
{
    public class ViewModel : ViewModelBase
    {
        private Lines _txtlines;
        private ObservableCollection<Lines> _lines;
        private ICommand _SubmitCommand;

        public Lines txtlines
        {
            get
            {
                return _txtlines;
            }
            set
            {
                _txtlines = value;
                NotifyPropertyChanged("txtlines");
            }
        }
        public ObservableCollection<Lines> lines
        {
            get
            {
                return _lines;
            }
            set
            {
                _lines = value;
                NotifyPropertyChanged("lines");
            }
        }

        public ICommand SubmitCommand
        {
            get
            {
                if (_SubmitCommand == null)
                {
                    _SubmitCommand = new RelayCommand(param => this.Submit(),
                        null);
                }
                return _SubmitCommand;
            }
        }


        public ViewModel()
        {
            
                txtlines = new Lines();
                lines = new ObservableCollection<Lines>();
                lines.CollectionChanged += new System.Collections.Specialized.NotifyCollectionChangedEventHandler(Lines_CollectionChanged);
                Submit();
            
        }

        void Lines_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            NotifyPropertyChanged("Lines");
        }
        
        private void Submit()
        {
            int i = 1;
            TextFileReader textFileReader = new TextFileReader();
            String[] lins = textFileReader.ReadLines();
            foreach (string line in lins)
            {
                txtlines.Content = line;
                txtlines.Lno = i++;
                
                txtlines.color = (line.ToLower().Equals(line)) ?"white":"red";
                lines.Add(txtlines);
                txtlines = new Lines();
            }
        }
    }
}
