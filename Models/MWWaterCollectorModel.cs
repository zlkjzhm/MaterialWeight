using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialWeight.Models
{
    //弯板
    class BendingPlate
    {
        public string _typeName;
        public double _weight = 19 / 1000;
        //public double _thickness;
    }

    //波片
    class WavePlate
    {
        public double _length;
        //public double _weight;
        public double _density;
        public double _thickness;
    }
    //穿杆
    class ThreadingRod
    {
        public double _length;
        public double _weight = 0.09f;
    }

    //螺帽
    class Nut
    {
        public double _weight = 1 / 1000;
    }
    class MWWaterCollectorModel
    {
        public MWWaterCollectorModel()
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
        
        public double _allweight;

        public bool IsValid()
        {
            return true;
        }
    }
}
