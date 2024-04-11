using FinancialAid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialAdvisor
{
    public class RiskTolerance : User
    {
        public struct RiskToleranceData
        {
            public string Goal;
            public string Timeline;
            public string IntendedRisk;
            public string Income;
            public string SpendingHabits;
            public string Cashflow;
            public string RealEstate;
        }

        private string _goal;
        private string _timeline;
        private string _intendedRisk;
        private string _income;
        private string _spendingHabits;
        private string _cashflow;
        private string _realEstate;

        public string Goal
        {
            get
            {
                return _goal;
            }
            set
            {
                _goal = value;
            }
        }

        public string Timeline
        {
            get
            {
                return _timeline;
            }
            set
            {
                _timeline = value;
            }
        }

        public string IntendedRisk
        {
            get
            {
                return _intendedRisk;
            }
            set
            {
                _intendedRisk = value;
            }
        }

        public string Income
        {
            get
            {
                return _income;
            }
            set
            {
                _income = value;
            }
        }

        public string SpendingHabits
        {
            get
            {
                return _spendingHabits;
            }
            set
            {
                _spendingHabits = value;
            }
        }

        public string Cashflow
        {
            get
            {
                return _cashflow;
            }
            set
            {
                _cashflow = value;
            }
        }

        public string RealEstate
        {
            get
            {
                return _realEstate;
            }
            set
            {
                _realEstate = value;
            }
        }

        public RiskToleranceData GetRiskToleranceData()
        {
            RiskToleranceData info = new RiskToleranceData

            {
                Goal = this.Goal,
                Timeline = this.Timeline,
                IntendedRisk = this.IntendedRisk,
                Income = this.Income,
                SpendingHabits = this.SpendingHabits,
                Cashflow = this.Cashflow,
                RealEstate = this.RealEstate
            };

            return info;
        }

        public RiskTolerance()
        {

        }
    }
}
