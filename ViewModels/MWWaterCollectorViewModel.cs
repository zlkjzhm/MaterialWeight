using MaterialWeight.Commands;
using MaterialWeight.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MaterialWeight.ViewModels
{
    class MWWaterCollectorViewModel : INotifyPropertyChanged
    {
        private MWWaterCollectorModel _watercollector;
        private MWCalculateCommand _calcommand;
        public MWWaterCollectorViewModel()
        {
            _watercollector = new MWWaterCollectorModel();
            _calcommand = new MWCalculateCommand(GetWavePlateWeight, _watercollector.IsValid);
        }

        public ICommand GetWeightCommand
        {
            get
            {
                return _calcommand;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        //片密度
        public double WPDensity
        {
            get { return _watercollector._wavePlate._density; }
            set
            {
                _watercollector._wavePlate._density = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("WPDensity"));
                }
            }
        }
        //波片长度
        public double WPLength
        {
            get { return _watercollector._wavePlate._length; }
            set
            {
                _watercollector._wavePlate._length = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("WPLength"));
                }
            }
        }

        //波片片数
        public int WPNum
        {
            get { return _watercollector._wpnum; }
            set
            {
                _watercollector._wpnum = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("WPNum"));
                }
            }
        }
        //波片厚度
        public double WPThickness
        {
            get { return _watercollector._wavePlate._thickness; }
            set
            {
                _watercollector._wavePlate._thickness = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("WPThickness"));
                }
            }
        }

        //波片总质量
        public double WPWeight
        {
            get { return _watercollector._wpweight; }
            set
            {
                _watercollector._wpweight = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("WPWeight"));
                }
            }
        }

        //弯板数量
        public int BPNum
        {
            get { return _watercollector._bpnum; }
            set
            {
                _watercollector._bpnum = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("BPNum"));
                }
            }
        }

        //弯板类型
        public string BPType
        {
            get { return _watercollector._bendingplate._typeName; }
            set
            {
                _watercollector._bendingplate._typeName = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("BPType"));
                }
            }
        }

        //弯板
        //public BendingPlate BendingPlate
        //{
        //    get { return _bendingplate; }
        //    set
        //    {
        //        _bendingplate = value;
        //        if (PropertyChanged != null)
        //        {
        //            PropertyChanged(this, new PropertyChangedEventArgs("BendingPlate"));
        //        }
        //    }
        //}

        //弯板总质量
        public double BPWeight
        {
            get { return _watercollector._bpweight; }
            set
            {
                _watercollector._bpweight = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("BPWeight"));
                }
            }
        }

        //穿杆长度
        public double TRLength
        {
            get { return _watercollector._threadingRod._length; }
            set
            {
                _watercollector._threadingRod._length = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("TRLength"));
                }
            }
        }

        //穿杆个数
        public int TRNum
        {
            get { return _watercollector._trnum; }
            set
            {
                _watercollector._trnum = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("TRNum"));
                }
            }
        }
        //穿杆总质量
        public double TRWeight
        {
            get { return _watercollector._trweight; }
            set
            {
                _watercollector._trweight = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("TRWeight"));
                }
            }
        }

        //螺帽个数
        public int NutNum
        {
            get { return _watercollector._nutnum; }
            set
            {
                _watercollector._nutnum = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("NutNum"));
                }
            }
        }

        //螺帽总质量
        public double NutWeight
        {
            get { return _watercollector._nutweight; }
            set
            {
                _watercollector._nutweight = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("NutWeight"));
                }
            }
        }

        //收水器总质量
        public double AllWeight
        {
            get { return _watercollector._allweight; }
            set
            {
                _watercollector._allweight = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("AllWeight"));
                }
            }
        }

        public void GetWavePlateWeight()
        {
            AllWeight = 0.25 * 1 * WPThickness / 1000 * WPDensity * WPNum;
            //return ret;
        }
    }
}
