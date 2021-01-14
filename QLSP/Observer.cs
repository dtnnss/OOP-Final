using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace QLSP
{
    public abstract class Observer
    {
        public Subject subject;
        public abstract string Update();
    }

    public class USDollar : Observer
    {
        public USDollar(Subject subject)
        {
            this.subject = subject;
            this.subject.Attach(this);
        }
        public override string Update()
        {
            return Convert.ToString(Math.Round(subject.getState() / 23089, 3));
        }
    }

    public class Euro : Observer
    {
        public Euro(Subject subject)
        {
            this.subject = subject;
            this.subject.Attach(this);
        }
        public override string Update()
        {
            return Convert.ToString(Math.Round(subject.getState() / 28300, 3));
        }
    }

    public class RMB : Observer
    {
        public RMB(Subject subject)
        {
            this.subject = subject;
            this.subject.Attach(this);
        }
        public override string Update()
        {
            return Convert.ToString(Math.Round(subject.getState() / 3537.14, 3));
        }
    }

    public class Won : Observer
    {
        public Won(Subject subject)
        {
            this.subject = subject;
            this.subject.Attach(this);
        }
        public override string Update()
        {
            return Convert.ToString(Math.Round(subject.getState() / 21.24, 3));
        }
    }

    public class EuroShipFee1 : Observer
    {
        public EuroShipFee1(Subject subject)
        {
            this.subject = subject;
            this.subject.Attach(this);
        }
        public override string Update()
        {
            return Convert.ToString(Math.Round(subject.getState() / 60000, 3));
        }
    }

    public class EuroShipFee2 : Observer
    {
        public EuroShipFee2(Subject subject)
        {
            this.subject = subject;
            this.subject.Attach(this);
        }
        public override string Update()
        {
            return Convert.ToString(Math.Round(subject.getState() / 70000, 3));
        }
    }

    public class EuroShipFee3 : Observer
    {
        public EuroShipFee3(Subject subject)
        {
            this.subject = subject;
            this.subject.Attach(this);
        }
        public override string Update()
        {
            return Convert.ToString(Math.Round(subject.getState() / 80000, 3));
        }
    }

    public class USDShipFee1 : Observer
    {
        public USDShipFee1(Subject subject)
        {
            this.subject = subject;
            this.subject.Attach(this);
        }
        public override string Update()
        {
            return Convert.ToString(Math.Round(subject.getState() / 60000, 3));
        }
    }

    public class USDShipFee2 : Observer
    {
        public USDShipFee2(Subject subject)
        {
            this.subject = subject;
            this.subject.Attach(this);
        }
        public override string Update()
        {
            return Convert.ToString(Math.Round(subject.getState() / 70000, 3));
        }
    }

    public class WonShipFee : Observer
    {
        public WonShipFee(Subject subject)
        {
            this.subject = subject;
            this.subject.Attach(this);
        }
        public override string Update()
        {
            return Convert.ToString(Math.Round(subject.getState() / 100000, 3));
        }
    }

    public class RMBShipFee : Observer
    {
        public RMBShipFee(Subject subject)
        {
            this.subject = subject;
            this.subject.Attach(this);
        }
        public override string Update()
        {
            return Convert.ToString(Math.Round(subject.getState() / 30000, 3));
        }
    }
}