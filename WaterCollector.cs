using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialWeight
{
    class BendingPlate
    {
        public string _typeName;
        public double _weight;
    }
    class WaterCollector : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        //弯板
        private string _bendingplate;
        public string BendingPlate
        {
            get { return _bendingplate; }
            set
            {
                _bendingplate = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("BendingPlate"));
                }
            }
        }


    }
}
