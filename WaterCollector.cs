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
        public double _weight;
        public double _thickness;
    }

    //波片
    class WavePlate
    {
        public double _length;
        public double _weight;
        public double _density;
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
            wavePlate = new WavePlate();
            bendingPlate = new BendingPlate();
            threadingRod = new ThreadingRod();
            nut = new Nut();
        }
        public WavePlate wavePlate;
        public BendingPlate bendingPlate;
        public ThreadingRod threadingRod;
        public Nut nut;

        public event PropertyChangedEventHandler PropertyChanged;
        //片密度
        public double PlateDensity
        {
            get { return wavePlate._density; }
            set
            {
                wavePlate._density = value;
                if(PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("PlateDensity"));
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
        private BendingPlate _bendingplate;
        public BendingPlate BendingPlate
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
        //弯板数量
        public int _bpnum;
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

    }
}
