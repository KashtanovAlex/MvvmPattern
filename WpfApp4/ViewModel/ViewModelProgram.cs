using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfApp4.Model;
using WpfApp4.ViewModel.Commands;
using WpfApp4.ViewModels;

namespace WpfApp4.ViewModel
{
    class ViewModelProgram : ViewModelBase
    {
        bool statusBoolValue = false;
        // Команды для взаимодействия с OPM box.
        private ICommand _pressButtonCommand;
        public ICommand PressButtonCommand
        {
            get
            {
                return _pressButtonCommand ??
                    (_pressButtonCommand = new RelayCommand(
                        p => true,//IsOPMBoxConnected
                        p => SomeFunction()));
            }
        }

        private string _textBoxValue;
        public string TextBoxValue
        {
            get { return _textBoxValue; }
            set
            {
                _textBoxValue = value;
                OnPropertyChanged();
            }
        }

        private void SomeFunction()
        {
            var a = new ModelProgram();
            statusBoolValue = a.FuncionRead(statusBoolValue);
            TextBoxValue = Convert.ToString(statusBoolValue);
        }
    }
}
