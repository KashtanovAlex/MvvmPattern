using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4.Model
{
    class ModelProgram
    {
        public bool FuncionRead(bool value)
        {
            //функция чтения и тут же должен быть возрват не булевых значений, а именно массива байт
            if (value)
                return false;
            else
                return true;
        }
    }
}
