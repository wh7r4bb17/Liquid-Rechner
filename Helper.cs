using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Liquid_Rechner
{
    public static class Helper
    {
        public static Double GetMaxNicotine()
            {
            return GlobalVariables.NicotineContent_Shot * (100 - GetAromainPercent()) / 100;   //Nicshot * Amount of NicLiquid in %
            }

        public static Double GetSteamBaseAmount()
        {
            Double LiquidInput_All = GlobalVariables.BootleSize - GetAromaAmount();

            return Math.Round(LiquidInput_All - GetNicotineAmount(), 2);
        }

        public static Double GetNicotineAmount()
        {
            double LiquidInput_All = GlobalVariables.BootleSize - GetAromaAmount();
            return Math.Round(LiquidInput_All * (100 / (GetMaxNicotine() / GlobalVariables.Target_Nicotine) / 100), 2);
        }

        public static Double GetNumberOfNicShots()
        {
            return Math.Round(GetNicotineAmount() / 10, 2);
        }

        public static Double GetAromainPercent()
        {
            Double AromaInPercent =1;
            try
            {
                if (GlobalVariables.isAromaInMilliliter == false)
                {
                    AromaInPercent = GlobalVariables.Aroma_Amount;
                }
                else
                { AromaInPercent = 100 / GlobalVariables.BootleSize * GlobalVariables.Aroma_Amount; }
            }
            catch
            { }
            return AromaInPercent;
        }

        public static Double GetAromaAmount()
        {
            Double AromaAmount =0.0;
            try
            {
                if (GlobalVariables.isAromaInMilliliter)
                { AromaAmount = GlobalVariables.Aroma_Amount; }
                else
                { AromaAmount = GlobalVariables.BootleSize / 100 * GlobalVariables.Aroma_Amount; }
            }
            catch
            { }
            return Math.Round(AromaAmount, 2);
        }

    }
}
