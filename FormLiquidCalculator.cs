//using Helper;
namespace Liquid_Rechner
{
    public partial class FormLiquidCalculator : Form
    {
        public FormLiquidCalculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GlobalVariables.BootleSize = 0;
            GlobalVariables.NicotineContent_Shot = 0;
            GlobalVariables.Aroma_Amount = 0;
            GlobalVariables.Target_Nicotine = 0;
            GlobalVariables.isAromaInMilliliter = true;
        }

        #region "Textboxes and Radio Buttons
        private void TxtBottleSize_TextChanged(object sender, EventArgs e)
        {
            //If Textbox is empty write "0"
            if (TxtBottleSize.Text == "")
            {
                TxtBottleSize.Text = "0";
            }
        //Only Numbers(Signle) are allowed
        try
                {
                GlobalVariables.BootleSize = Convert.ToSingle(TxtBottleSize.Text);
            }
        catch
                {
                GlobalVariables.BootleSize = 0;
                TxtBottleSize.Text = "0";
            }

        LblMaxNicotine.Text = "(max. " + Math.Round(Helper.GetMaxNicotine(), 3) + " mg/ml möglich)";
        }

        private void TxtNicotineContent_Shot_TextChanged(object sender, EventArgs e)
        {
            //If Textbox is empty write "0"
            if (TxtNicotineContent_Shot.Text == "") TxtNicotineContent_Shot.Text = "0";

            //Only Numbers(Signle) are allowed
            try
            { GlobalVariables.NicotineContent_Shot = Convert.ToSingle(TxtNicotineContent_Shot.Text); }
            catch
            {
                GlobalVariables.NicotineContent_Shot = 0;
                TxtNicotineContent_Shot.Text = "0"; 
            }


            //Target 'Nicotine can't be more than the max Nicotine Amount
            Double MaxNicotine = Helper.GetMaxNicotine();

        if (GlobalVariables.Target_Nicotine > MaxNicotine) TxtTargetNicotine.Text = Math.Round(MaxNicotine,3).ToString();


            LblMaxNicotine.Text = "(max. " + Math.Round(MaxNicotine, 3) + " mg/ml möglich)";

            //Target Nicotine only enabled if the Shot contains Nicotine
            if (GlobalVariables.NicotineContent_Shot > 0)
            { TxtTargetNicotine.Enabled = true;
            }
            else 
            { 
            TxtTargetNicotine.Enabled = false;
            }
        }

        private void TxtAromaAmount_TextChanged(object sender, EventArgs e)
        {
            //If Textbox is empty write "0"
        if (TxtAromaAmount.Text == "") TxtAromaAmount.Text = "0";

            //Only Numbers(Signle) are allowed
            try
            {
                GlobalVariables.Aroma_Amount = Convert.ToSingle(TxtAromaAmount.Text);
            }
            catch
            {
                GlobalVariables.Aroma_Amount = 0;
                TxtAromaAmount.Text = "0";
            }


            LblMaxNicotine.Text = "(max. " + Math.Round(Helper.GetMaxNicotine(), 3) + " mg/ml möglich)";
            }

        private void TxtTargetNicotine_TextChanged(object sender, EventArgs e)
        {
            //If Textbox is empty write "0"
        if (TxtTargetNicotine.Text == "") TxtTargetNicotine.Text = "0";

            //Only Numbers(Signle) are allowed
            try
            {
                GlobalVariables.Target_Nicotine = Convert.ToSingle(TxtTargetNicotine.Text);
            }
            catch
            {
                GlobalVariables.Target_Nicotine = 0;
                TxtTargetNicotine.Text = "0";
            }

            //Target 'Nicotine can't be more than the max Nicotine Amount
            Double MaxNicotine = Helper.GetMaxNicotine();
    
        if (GlobalVariables.Target_Nicotine > MaxNicotine)   TxtTargetNicotine.Text = Math.Round(MaxNicotine,3).ToString();
           
    
        LblMaxNicotine.Text = "(max. " + Math.Round(MaxNicotine, 3) + " mg/ml möglich)";
            }

        private void Rb_AromaIn_percent_CheckedChanged(object sender, EventArgs e)
        {
            Rb_AromaIn_ml.Checked = false;
            Lbl_Aroma.Text = "%";
            GlobalVariables.isAromaInMilliliter = false;
        }

        private void Rb_AromaIn_ml_CheckedChanged(object sender, EventArgs e)
        {
            Rb_AromaIn_percent.Checked = false;
            Lbl_Aroma.Text = "ml";
            GlobalVariables.isAromaInMilliliter = true;
        }
        #endregion

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            string Text1 = string.Format("Für {0} ml fertiges Liquid mit einer Nikotinstärke von {1} mg/ml werden benötigt:", TxtBottleSize.Text, TxtTargetNicotine.Text);
            string Text2 = string.Format("* {0} ml Aroma", Helper.GetAromaAmount());
            string Text3 = string.Format("* {0} Nikotinshot(s) bzw. {1} ml mit {2} mg/ml Nikotinstärke", Helper.GetNumberOfNicShots(), Helper.GetNicotineAmount(), TxtNicotineContent_Shot.Text);
            string Text4 = string.Format("* {0} ml Base", Helper.GetSteamBaseAmount());

            TxtResult.Text = Text1 + Environment.NewLine + Environment.NewLine + Text2 + Environment.NewLine + Text3 + Environment.NewLine + Text4;
        }
    }

    public static class GlobalVariables
    {
    public static Single BootleSize;
    public static Single NicotineContent_Shot;
    public static Single Aroma_Amount;
    public static Single Target_Nicotine;
    public static bool isAromaInMilliliter;
    }
}