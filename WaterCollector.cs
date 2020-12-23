using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialWeight
{
    //弯板
    class BendingPlate
    {
        public string _typeName;
        public double _weight = 19/1000;
        //public double _thickness;
    }

    //波片
    class WavePlate
    {
        public double _length;
        public double _weight;
        public double _density;
        public double _thickness;
    }
    //穿杆
    class ThreadingRod
    {
        public double _length;
        public double _weight;
    }

    //螺帽
    class Nut
    {
        public double _weight;
    }
    class WaterCollector : INotifyPropertyChanged
    {
        public WaterCollector()
        {
            _wavePlate = new WavePlate();
            _bendingplate = new BendingPlate();
            _threadingRod = new ThreadingRod();
            _nut = new Nut();
        }
        public WavePlate _wavePlate;
        public int _wpnum;
        public double _wpweight;
        public BendingPlate _bendingplate;
        public int _bpnum;
        public double _bpweight;
        public ThreadingRod _threadingRod;
        public int _trnum;
        public double _trweight;
        public Nut _nut;
        public int _nutnum;
        public double _nutweight;

        public event PropertyChangedEventHandler PropertyChanged;
        //片密度
        public double WPDensity
        {
            get { return _wavePlate._density; }
            set
            {
                _wavePlate._density = value;
                if(PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("WPDensity"));
                }
            }
        }
        //波片长度
        public double WPLength
        {
            get { return _wavePlate._length; }
            set
            {
                _wavePlate._length = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("WPLength"));
                }
            }
        }

        //波片片数
        public int WPNum
        {
            get { return _wpnum; }
            set
            {
                _wpnum = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("WPNum"));
                }
            }
        }
        //波片厚度
        public double WPThickness
        {
            get { return _wavePlate._thickness; }
            set
            {
                _wavePlate._thickness = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("WPThickness"));
                }
            }
        }

        //波片总质量
        public double WPWeight
        {
            get { return _wpweight; }
            set
            {
                _wpweight = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("WPWeight"));
                }
            }
        }

        //弯板数量
        public int BPNum
        {
            get { return _bpnum; }
            set
            {
                _bpnum = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("BPNum"));
                }
            }
        }

        //弯板类型
        public string BPType
        {
            get { return _bendingplate._typeName; }
            set
            {
                _bendingplate._typeName = value;
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
            get { return _bpweight;}
            set
            {
                _bpweight = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("BPWeight"));
                }
            }
        }

        //穿杆长度
        public double TRLength
        {
            get { return _threadingRod._length; }
            set
            {
                _threadingRod._length = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("TRLength"));
                }
            }
        }

        //穿杆个数
        public int TRNum
        {
            get { return _trnum; }
            set
            {
                _trnum = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("TRNum"));
                }
            }
        }
        //穿杆总质量
        public double TRWeight
        {
            get { return _trweight; }
            set
            {
                _trweight = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("TRWeight"));
                }
            }
        }

        //螺帽个数
        public int NutNum
        {
            get { return _nutnum; }
            set
            {
                _nutnum = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("NutNum"));
                }
            }
        }

        //螺帽总质量
        public double NutWeight
        {
            get { return _nutweight; }
            set
            {
                _nutweight = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("NutWeight"));
                }
            }
        }

        public double GetWavePlateWeight(double wpthickness, double wpdensity, int wpnum)
        {
            double ret = 0.25 * 1 * wpthickness / 1000 * wpdensity * wpnum;
            return ret;
        }
    }
}
