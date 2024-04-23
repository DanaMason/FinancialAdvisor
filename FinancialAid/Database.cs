using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialAid
{
    public class Database
    {
        private Dictionary<string, Dictionary<string, int>> adjustments;
        private Dictionary<string, Dictionary<string, int>> adjustmentsRE;
        private string realEstate = null;
        public Database(string RE)
        {
            realEstate = RE;
            Adjustments();
            AdjustmentsRE();
        }
        public Dictionary<string, int> GetCategoryAdjustments(string category)
        {
            if (realEstate == "No")
            {
                if (adjustments.ContainsKey(category))
                {
                    return adjustments[category];
                }
            }
            else if (realEstate == "Yes")
            {
                if (adjustmentsRE.ContainsKey(category))
                {
                    return adjustmentsRE[category];
                }
            }
            return null;
        }

        private void Adjustments()
        {
            adjustments = new Dictionary<string, Dictionary<string, int>>
            {
                {"StableInvestments", new Dictionary<string, int>
                    {
                        {"Growth/Value", -15},
                        {"Dividends", 5},
                        {"Retirement", 0},
                        {"Diversifying", 0},
                        {"<5 Years", 10},
                        {"5 - 15 Years", -2},
                        {"15+ Years", -10},
                        {"Low Risk Tolerance", 10},
                        {"Moderate Risk Tolerance", 0},
                        {"High Risk Tolerance", -10},
                        {"I can control myself", -2},
                        {"I have a problem...", 2},
                        {"Yes", 2},
                        {"No", -2}
                    }
                },

                {"RiskyInvestments", new Dictionary<string, int>
                    {
                        {"Growth/Value", 15},
                        {"Dividends", -5},
                        {"Retirement", 0},
                        {"Diversifying", 0},
                        {"<5 Years", -10},
                        {"5 - 15 Years", 2},
                        {"15+ Years", 10},
                        {"Low Risk Tolerance", -10},
                        {"Moderate Risk Tolerance", 0},
                        {"High Risk Tolerance", 10},
                        {"I can control myself", 2},
                        {"I have a problem...", -2},
                        {"Yes", -2},
                        {"No", 2}
                    }
                },

                {"Stocks", new Dictionary<string, int>
                    {
                        {"Growth/Value", 10},
                        {"Dividends", -8},
                        {"Retirement", -8},
                        {"Diversifying", -10},
                        {"<5 Years", -8},
                        {"5 - 15 Years", 0},
                        {"15+ Years", 8},
                        {"Low Risk Tolerance", -5},
                        {"Moderate Risk Tolerance", 0},
                        {"High Risk Tolerance", 5},
                        {"I can control myself", 1},
                        {"I have a problem...", -1},
                        {"Yes", -1},
                        {"No", 1}
                    }
                },

                {"ETFs", new Dictionary<string, int>
                    {
                        {"Growth/Value", 5},
                        {"Dividends", 3},
                        {"Retirement", 8},
                        {"Diversifying", 10},
                        {"<5 Years", -2},
                        {"5 - 15 Years", 2},
                        {"15+ Years", 2},
                        {"Low Risk Tolerance", -5},
                        {"Moderate Risk Tolerance", 0},
                        {"High Risk Tolerance", 5},
                        {"I can control myself", 1},
                        {"I have a problem...", -1},
                        {"Yes", -1},
                        {"No", 1}
                    }
                }
            };
        }
            private void AdjustmentsRE()
            {
                adjustmentsRE = new Dictionary<string, Dictionary<string, int>>
                {
                    {"StableInvestments", new Dictionary<string, int>
                        {
                            {"Growth/Value", -16},
                            {"Dividends", 5},
                            {"Retirement", 0}, 
                            {"Diversifying", 0}, 
                            {"<5 Years", 21},
                            {"5 - 15 Years", -5},
                            {"15+ Years", -21},
                            {"Low Risk Tolerance", 10},
                            {"Moderate Risk Tolerance", 0}, 
                            {"High Risk Tolerance", -10},
                            {"Almost Nothing", 0}, 
                            {"Low", 0}, 
                            {"Moderate", 0}, 
                            {"High", 0}, 
                            {"I can control myself", -2},
                            {"I have a problem...", 2},
                            {"Yes", 1},
                            {"No", -1},
                            {"Real Estate", 0}
                        }
                    },
                    {"RiskyInvestments", new Dictionary<string, int>
                        {
                            {"Growth/Value", 16},
                            {"Dividends", -5},
                            {"Retirement", 0}, 
                            {"Diversifying", 0},
                            {"<5 Years", -21},
                            {"5 - 15 Years", 5},
                            {"15+ Years", 21},
                            {"Low Risk Tolerance", -10},
                            {"Moderate Risk Tolerance", 0},
                            {"High Risk Tolerance", 10},
                            {"Almost Nothing", 0}, 
                            {"Low", 0}, 
                            {"Moderate", 0}, 
                            {"High", 0}, 
                            {"I can control myself", 2},
                            {"I have a problem...", -2},
                            {"Yes", -1},
                            {"No", 1},
                            {"Real Estate", 0} 
                        }
                    },
                    {"Stocks", new Dictionary<string, int>
                        {
                            {"Growth/Value", 7},
                            {"Dividends", -5},
                            {"Retirement", -5},
                            {"Diversifying", -5},
                            {"<5 Years", -8},
                            {"5 - 15 Years", 0}, 
                            {"15+ Years", 8},
                            {"Low Risk Tolerance", -5},
                            {"Moderate Risk Tolerance", 0}, 
                            {"High Risk Tolerance", 7},
                            {"Almost Nothing", 0}, 
                            {"Low", 0}, 
                            {"Moderate", 0}, 
                            {"High", 0}, 
                            {"I can control myself", 1},
                            {"I have a problem...", -1},
                            {"Yes", -1},
                            {"No", 1},
                            {"Real Estate", 0} 
                        }
                    },
                    {"ETFs", new Dictionary<string, int>
                        {
                            {"Growth/Value", 5},
                            {"Dividends", -8},
                            {"Retirement", 5},
                            {"Diversifying", 4},
                            {"<5 Years", -7},
                            {"5 - 15 Years", 5},
                            {"15+ Years", 7},
                            {"Low Risk Tolerance", -4},
                            {"Moderate Risk Tolerance", 0}, 
                            {"High Risk Tolerance", 2},
                            {"Almost Nothing", 1}, 
                            {"Low", 1}, 
                            {"Moderate", 0}, 
                            {"High", 0}, 
                            {"I can control myself", 0}, 
                            {"I have a problem...", 0}, 
                            {"Yes", -1},
                            {"No", 1},
                            {"Real Estate", 0} 
                        }
                    },
                    {"Real Estate", new Dictionary<string, int>
                        {
                            {"Growth/Value", 4},
                            {"Dividends", 8},
                            {"Retirement", 0}, 
                            {"Diversifying", 1},
                            {"<5 Years", -6},
                            {"5 - 15 Years", 0}, 
                            {"15+ Years", 6},
                            {"Low Risk Tolerance", -1},
                            {"Moderate Risk Tolerance", 0}, 
                            {"High Risk Tolerance", 1},
                            {"Almost Nothing", -1}, 
                            {"Low", -1}, 
                            {"Moderate", 0}, 
                            {"High", 0}, 
                            {"I can control myself", 1},
                            {"I have a problem...", -1},
                            {"Yes", 1},
                            {"No", -1},
                            {"Real Estate", 0} 
                        }
                    }
                };
            }
    }
}
