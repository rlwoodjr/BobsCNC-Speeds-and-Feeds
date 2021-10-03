﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BobsCNC_Speeds_and_Feeds
{
    public partial class Form1 : Form
    {
        readonly bool[] WMA = new bool[10];
        readonly string[] WarningText = new String[10];
        readonly string[] WarningLabel = new String[10];
        int FluteCount;
        double SFM, RPM, BitDiameter, Chipload, FeedRate, UnitConvert, SFMConvert;
        const bool T = true, F = false;

        public Form1()
        {
            InitializeComponent();

        }

        //*************load form details*********************************************************************************************
        private void Form1_Load(object sender, EventArgs e)
        {

            //Load values from Settings.setting
            CBoxModel.Text = BobsCNC_Speeds_and_Feeds.Properties.Settings.Default.Model;
            CBoxMaterial.Text = BobsCNC_Speeds_and_Feeds.Properties.Settings.Default.Material;
            CBoxUnits.Text = BobsCNC_Speeds_and_Feeds.Properties.Settings.Default.Units;
            CBoxBitDiameter.Text = BobsCNC_Speeds_and_Feeds.Properties.Settings.Default.BitDiameter;
            TBoxDetails.Text = BobsCNC_Speeds_and_Feeds.Properties.Settings.Default.Details;

            //Load Warning messages from Settings.settings
            WarningText[0] = BobsCNC_Speeds_and_Feeds.Properties.Settings.Default.Details;
            WarningText[1] = BobsCNC_Speeds_and_Feeds.Properties.Settings.Default.WMA1;
            WarningText[2] = BobsCNC_Speeds_and_Feeds.Properties.Settings.Default.WMA2;
            WarningText[3] = BobsCNC_Speeds_and_Feeds.Properties.Settings.Default.WMA3;
            WarningText[4] = BobsCNC_Speeds_and_Feeds.Properties.Settings.Default.WMA4;
            WarningText[5] = BobsCNC_Speeds_and_Feeds.Properties.Settings.Default.WMA5;
            WarningText[6] = BobsCNC_Speeds_and_Feeds.Properties.Settings.Default.WMA6;
            WarningText[7] = BobsCNC_Speeds_and_Feeds.Properties.Settings.Default.WMA7;
            WarningText[8] = BobsCNC_Speeds_and_Feeds.Properties.Settings.Default.WMA8;

            WarningLabel[0] = "";
            WarningLabel[1] = "Cutting aluminum requires additional set up.";
            WarningLabel[2] = "The RPM spindle is fixed for the E series CNC's.";
            WarningLabel[3] = "Smaller bits require extra setup information";
            WarningLabel[4] = "Larger bits require extra setup information  ";
            WarningLabel[5] = "3 or more flutes are not recommended for routers";
            WarningLabel[6] = "Large chip load require extra setup information";
            WarningLabel[7] = "The RPM has been adjusted maximum RPM.";
            WarningLabel[8] = "The RPM has been adjusted minimum RPM.";
            WarningLabel[9] = "1 flute is recommend for cutting Aluminum.";



            CheckUnits();
            UnitConvert = Convert.ToDouble(TBoxUnitConvert.Text);
            SFMConvert = Convert.ToDouble(TBoxSFMConvert.Text);
            UpdateValues();
        }


        //*************Update Form Values************************************************************************************************
        private void UpdateValues()
        {
            double x;

            BitDiameter = Convert.ToDouble(CBoxBitDiameter.Text);
            SFMConvert = Convert.ToDouble(TBoxSFMConvert.Text);
            UnitConvert = Convert.ToDouble(TBoxUnitConvert.Text);

            x = BitDiameter / UnitConvert;  //Polynomial equation is FrameStyle inches only. 
            switch ((string)CBoxMaterial.SelectedItem)  // assign values for calculating ( Select material for the SFM, then CNC model, then the bit diameter)
            {
                case "Aluminum":
                    SFM = 350;
                    TBoxFactor.Text = "5";
                    WMA[1] = T;
                    break;
                case "Acrylic (hard)":
                    SFM = 500;
                    TBoxFactor.Text = "1.05";
                    break;
                case "Acetal (soft)":
                    SFM = 450;
                    TBoxFactor.Text = "0.95";
                    break;
                case "Foam Board":
                    SFM = 1500;
                    TBoxFactor.Text = ".5";
                    break;
                case "Hardwood":
                    SFM = 600;
                    TBoxFactor.Text = "1.1";
                    break;
                case "Plywood":
                    SFM = 400;
                    TBoxFactor.Text = "1";
                    break;
                case "MDF":
                    SFM = 1000;
                    TBoxFactor.Text = "1";
                    break;
                case "Softwood":
                    SFM = 950;
                    TBoxFactor.Text = ".9";
                    break;
            }

            double DFactor = Convert.ToDouble(TBoxFactor.Text);
            switch ((string)CBoxModel.SelectedItem)
            {

                case "E Series":
                    LabelRouterName.Text = "";
                    labelDial.Text = "";
                    TBoxChipLoad.Text = Convert.ToString(String.Format("{0:0.0000}", (0.007 * BitDiameter / UnitConvert + SFM / 10000000) * UnitConvert));
                    labelDOC.Text = Convert.ToString(String.Format("{0:0.000}", 0.0119 * Math.Pow(x, -0.564) * UnitConvert / DFactor));
                    break;

                case "Evolution Series - Makita":
                    LabelRouterName.Text = "Makita Dial:";
                    TBoxChipLoad.Text = Convert.ToString(String.Format("{0:0.0000}", (0.025 * BitDiameter / UnitConvert + SFM / 5000000) * UnitConvert));
                    labelDOC.Text = Convert.ToString(String.Format("{0:0.000}", (-0.1414 * Math.Pow(x, 6) + 1.0412 * Math.Pow(x, 5)
                                                    - 3.0450 * Math.Pow(x, 4) + 4.444 * Math.Pow(x, 3)
                                                    - 3.2646 * Math.Pow(x, 2) + 0.9803 * x + 0.0005) * UnitConvert / DFactor));
                    break;
                case "Evolution Series - DeWalt":
                    LabelRouterName.Text = "DeWalt Dial:";
                    TBoxChipLoad.Text = Convert.ToString(String.Format("{0:0.0000}", (0.025 * BitDiameter / UnitConvert + SFM / 5000000) * UnitConvert));
                    labelDOC.Text = Convert.ToString(String.Format("{0:0.000}", (-0.1414 * Math.Pow(x, 6) + 1.0412 * Math.Pow(x, 5)
                                                    - 3.0450 * Math.Pow(x, 4) + 4.444 * Math.Pow(x, 3)
                                                    - 3.2646 * Math.Pow(x, 2) + 0.9803 * x + 0.0005) * UnitConvert / DFactor));
                    break;
                case "KL7 Series - Makita":
                    LabelRouterName.Text = "Makita Dial:";
                    TBoxChipLoad.Text = Convert.ToString(String.Format("{0:0.0000}", (0.035 * BitDiameter / UnitConvert + SFM / 1000000) * UnitConvert));
                    labelDOC.Text = Convert.ToString(String.Format("{0:0.000}", (0.1606 * Math.Pow(x, 5) - 0.9537 * Math.Pow(x, 4)
                                                      + 2.0856 * Math.Pow(x, 3) - 2.0053 * Math.Pow(x, 2)
                                                      + 0.7268 * x + 0.015) * UnitConvert / DFactor));
                    break;
                case "KL7 Series - DeWalt":
                    LabelRouterName.Text = "DeWalt Dial:";
                    TBoxChipLoad.Text = Convert.ToString(String.Format("{0:0.0000}", (0.035 * BitDiameter / UnitConvert + SFM / 1000000) * UnitConvert));
                    labelDOC.Text = Convert.ToString(String.Format("{0:0.000}", (0.1606 * Math.Pow(x, 5) - 0.9537 * Math.Pow(x, 4)
                                                      + 2.0856 * Math.Pow(x, 3) - 2.0053 * Math.Pow(x, 2)
                                                      + 0.7268 * x + 0.015) * UnitConvert / DFactor));
                    break;
                case "Revolution":
                    LabelRouterName.Text = "Makita Dial:";
                    TBoxChipLoad.Text = Convert.ToString(String.Format("{0:0.0000}", (0.025 * BitDiameter / UnitConvert + SFM / 5000000) * UnitConvert));
                    labelDOC.Text = Convert.ToString(String.Format("{0:0.000}", (-0.1414 * Math.Pow(x, 6) + 1.0412 * Math.Pow(x, 5)
                                                    - 3.0450 * Math.Pow(x, 4) + 4.444 * Math.Pow(x, 3)
                                                    - 3.2646 * Math.Pow(x, 2) + 0.9803 * x + 0.0005) * UnitConvert / DFactor));
                    break;
                case "Other":
                    TBoxChipLoad.Text = Convert.ToString(String.Format("{0:0.0000}", (0.025 * BitDiameter / UnitConvert + SFM / 5000000) * UnitConvert));
                    labelDOC.Text = Convert.ToString(String.Format("{0:0.000}", (-0.1414 * Math.Pow(x, 6) + 1.0412 * Math.Pow(x, 5)
                                                    - 3.0450 * Math.Pow(x, 4) + 4.444 * Math.Pow(x, 3)
                                                    - 3.2646 * Math.Pow(x, 2) + 0.9803 * x + 0.0005) * UnitConvert / DFactor));
                    break;
            }


            // Get Form Values
            RPM = SFM / (0.261799 * BitDiameter) * UnitConvert;
            TBSurfaceSpeed.Text = Convert.ToString(SFM * SFMConvert);

            if (LabelRouterName.Text == "Makita Dial:")  // Get Dial number on router based on RPM ( use liner equation y=mx+b)
            {
                if (RPM > 30000)
                {
                    labelDial.Text = "6.0";
                    TBoxRPMratio.Text = Convert.ToString(RPM / 30000);
                    TBoxRPM.Text = "30000";
                    WMA[7] = T;
                }
                else if (RPM < 10000)
                {
                    labelDial.Text = "1.0";
                    TBoxRPMratio.Text = Convert.ToString(RPM / 10000);
                    TBoxRPM.Text = "10000";
                    WMA[8] = T;
                }
                else
                {
                    labelDial.Text = Convert.ToString(String.Format("{0:0.0}", RPM * 0.00025 - 1.5));
                    TBoxRPM.Text = Convert.ToString(String.Format("{0:0}", RPM));
                    TBoxRPMratio.Text = "1.0";
                    WMA[0] = T;
                }

            }
            else if (LabelRouterName.Text == "DeWalt Dial:")
            {
                if (RPM > 27000)
                {
                    labelDial.Text = "6.0";
                    TBoxRPMratio.Text = Convert.ToString(RPM / 27000);
                    TBoxRPM.Text = "27000";
                    WMA[7] = T;
                }
                else if (RPM < 17000)
                {
                    labelDial.Text = "1.0";
                    TBoxRPMratio.Text = Convert.ToString(RPM / 17000);
                    TBoxRPM.Text = "17000";
                    WMA[8] = T;
                }
                else
                {
                    labelDial.Text = Convert.ToString(String.Format("{0:0.0}", RPM * 0.0005 - 7.5));
                    TBoxRPM.Text = Convert.ToString(String.Format("{0:0}", RPM));
                    TBoxRPMratio.Text = "1.0";
                    WMA[0] = T;
                }
            }
            else if (LabelRouterName.Text == "Spindle RPM:")
            {
                labelDial.Text = Convert.ToString(String.Format("{0:0}", RPM));
                TBoxRPM.Text = Convert.ToString(String.Format("{0:0}", RPM));
                labelWarning.Text = "";
            }
            else if (LabelRouterName.Text == "")
            {

                TBoxRPMratio.Text = Convert.ToString(RPM / 30000);
                TBoxRPM.Text = "30000";
                WMA[2] = T;
            }

            CheckWarningMessages();


            //Get CalculateValues values

            RPM = Convert.ToDouble(TBoxRPM.Text);
            FluteCount = Convert.ToInt16(CBoxFluteCount.Text);
            Chipload = Convert.ToDouble(TBoxChipLoad.Text);
            //Calcualte
            FeedRate = RPM * FluteCount * Chipload*Convert.ToDouble(TBoxRPMratio.Text);

            // Write values to labels:
            labelFR.Text = Convert.ToString(String.Format("{0:0}", FeedRate));
            labelPR.Text = Convert.ToString(String.Format("{0:0}", FeedRate / 2));
            labelSO.Text = Convert.ToString(String.Format("{0:0.000}", BitDiameter * .3));
        }

        //************Comboboxes changed*************************************************************************************************
        private void CBoxModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateValues();
        }

        private void CBoxMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateValues();
        }

        private void CBoxUnits_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckUnits();
            UpdateValues();
        }

        private void CBoxBitDiameter_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateValues();
        }

        private void CBoxFluteCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateValues();
        }
        //***************check errors****************************************************************************************************

        private void CheckWarningMessages()
            {
            int n;

            if (CBoxFluteCount.SelectedIndex > 1)
            {
                WMA[5] = T;
            }
            if (CBoxFluteCount.SelectedIndex > 0 && CBoxMaterial.Text=="Aluminum")
            {
                WMA[9] = T;
            }

            if (Convert.ToDouble(CBoxBitDiameter.Text) > 0.3 * UnitConvert) //bit too big
            {
                WMA[4] = T;
            }
            else if (Convert.ToDouble(CBoxBitDiameter.Text) < 0.125 * UnitConvert) //bit too small
            {
                WMA[3] = T;
            }

            // Display warning messages.
            TBoxDetails.Text = "";
            labelWarning.Text = WarningLabel[0];
            n = 0;
            labelWarning.Text += "Warning: ";
            for (int i = 1; i < 10; i++)
            {
                if (WMA[i] == T)
                {
                    TBoxDetails.Text += "\n\n" + WarningText[i];
                    labelWarning.Text += "\n" + WarningLabel[i];
                    WMA[i] = F;
                    n += 1;
                }
            }
            labelWarning.Text += "\nSee Details.";

            if (n > 0)
            {

                this.Width = 1050;
                labelWarning.Visible = T;

            }
            else
            {
                TBoxDetails.Text = WarningText[0];
                labelWarning.Visible = F;
            }
        }
    

        //************Key press validation to keep from geeting an error when tying in new data******************************************
        private void KeyPressControl(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
               e.Handled = true;
            }
        }
   
     
        private void Valid_Chipload(object sender, CancelEventArgs e)
        {
            if (TBoxChipLoad.Text.Length == 0 || !double.TryParse(TBoxChipLoad.Text, out double _))
            {
                e.Cancel = true;
                labelWarning.Text = "Warning:  Please enter a valid chip load.";
            }
            else if (Convert.ToDouble(TBoxChipLoad.Text) > 0.04* UnitConvert)
            {
                labelWarning.Text = "Warning:  The chip load is too large.";
                WMA[6] = true;
            }
            else   
            {
                labelWarning.Text = "";
                WMA[6] = false;
                UpdateOverideValues();

            }

        }
        private void ValidRPM(object sender, CancelEventArgs e)
        {
            if (TBoxRPM.Text.Length == 0 || !double.TryParse(TBoxRPM.Text, out double _))
            {
                e.Cancel = true;
                labelWarning.Text = "Warning: Please enter a valid RPM." ;
            }
            else
            {
                labelWarning.Text = "";
                UpdateOverideValues();
            }
           
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox1.Checked==T)
            {
                TBoxChipLoad.ReadOnly = F;
                TBoxRPM.ReadOnly = F;
                TBoxChipLoad.TabStop = T;
                TBoxRPM.TabStop = T;
            }
            else
            {
                TBoxChipLoad.ReadOnly = T;
                TBoxRPM.ReadOnly =T;
                TBoxChipLoad.TabStop = F;
                TBoxRPM.TabStop = F;
                UpdateValues();
            }
        }


        //****************Unit Change and show detals  functons**************************************************************************
        private void CheckUnits()
            {
            int pick = CBoxBitDiameter.SelectedIndex;
            CBoxBitDiameter.Items.Clear();

            if ((string)CBoxUnits.SelectedItem == "mm")
            {
                labelChipLoad.Text = "mm";
                labelSFM.Text = "mm/minite";
                labelUnits.Text = "mm";
                labelFRUnit.Text = "mm/minute";
                labelPRUnit.Text = "mm/minute";
                labelSOUnit.Text = "mm";
                labelDOCUnit.Text = "mm";
                TBoxUnitConvert.Text = "25.4";
                TBoxSFMConvert.Text = "304.8";
                CBoxBitDiameter.Items.Insert(0, "0.5");
                CBoxBitDiameter.Items.Insert(1, "1.0");
                CBoxBitDiameter.Items.Insert(2, "2.0");
                CBoxBitDiameter.Items.Insert(3, "3.0");
                CBoxBitDiameter.Items.Insert(4, "4.0");
                CBoxBitDiameter.Items.Insert(5, "5.0");
                CBoxBitDiameter.Items.Insert(6, "6.0");
                CBoxBitDiameter.Items.Insert(7, "8.0");
                CBoxBitDiameter.Items.Insert(8, "10.0");
                CBoxBitDiameter.Items.Insert(9, "12.0");
                CBoxBitDiameter.Items.Insert(10, "15.0");
                CBoxBitDiameter.Items.Insert(11, "20.0");
                CBoxBitDiameter.Items.Insert(12, "50.0");
            }
            else
            {
                labelChipLoad.Text = "inches";
                labelSFM.Text = "feet/minite";
                labelUnits.Text = "inches";
                labelFRUnit.Text = "inches/minute";
                labelPRUnit.Text = "inches/minute";
                labelSOUnit.Text = "inches";
                labelDOCUnit.Text = "inches";
                TBoxUnitConvert.Text = "1.0";
                TBoxSFMConvert.Text = "1.0";
                CBoxBitDiameter.Items.Insert(0, "0.0313");
                CBoxBitDiameter.Items.Insert(1, "0.0625");
                CBoxBitDiameter.Items.Insert(2, "0.125");
                CBoxBitDiameter.Items.Insert(3, "0.250");
                CBoxBitDiameter.Items.Insert(4, "0.375");
                CBoxBitDiameter.Items.Insert(5, "0.500");
                CBoxBitDiameter.Items.Insert(6, "0.625");
                CBoxBitDiameter.Items.Insert(7, "0.750");
                CBoxBitDiameter.Items.Insert(8, "1.000");
                CBoxBitDiameter.Items.Insert(9, "1.250");
                CBoxBitDiameter.Items.Insert(10, "1.500");
                CBoxBitDiameter.Items.Insert(11, "2.000");

            }
            CBoxBitDiameter.SelectedIndex = pick;
        }

        //***********************Only updating chipload or RPM ( allows  overide the default values) ************************************

        private void UpdateOverideValues()
        {
            // Get Form Values
            RPM = Convert.ToDouble(TBoxRPM.Text);
            TBSurfaceSpeed.Text = Convert.ToString(SFM * SFMConvert);

            if (LabelRouterName.Text == "Makita Dial:")  // Get Dial number on router based on RPM ( use liner equation y=mx+b)
            {
                if (RPM > 30000)
                {
                    labelDial.Text = "6.0";
                    TBoxRPMratio.Text = Convert.ToString(RPM / 30000);
                    TBoxRPM.Text = "30000";
                    WMA[7] = T;
                }
                else if (RPM < 10000)
                {
                    labelDial.Text = "1.0";
                    TBoxRPMratio.Text = Convert.ToString(RPM / 10000);
                    TBoxRPM.Text = "10000";
                    WMA[8] = T;
                }
                else
                {
                    labelDial.Text = Convert.ToString(String.Format("{0:0.0}", RPM * 0.00025 - 1.5));
                    TBoxRPM.Text = Convert.ToString(String.Format("{0:0}", RPM));
                    TBoxRPMratio.Text = "1.0";
                    WMA[0] = T;
                }

            }
            else if (LabelRouterName.Text == "DeWalt Dial:")
            {
                if (RPM > 27000)
                {
                    labelDial.Text = "6.0";
                    TBoxRPMratio.Text = Convert.ToString(RPM / 27000);
                    TBoxRPM.Text = "27000";
                    WMA[7] = T;
                }
                else if (RPM < 17000)
                {
                    labelDial.Text = "1.0";
                    TBoxRPMratio.Text = Convert.ToString(RPM / 17000);
                    TBoxRPM.Text = "17000";
                    WMA[8] = T;
                }
                else
                {
                    labelDial.Text = Convert.ToString(String.Format("{0:0.0}", RPM * 0.0005 - 7.5));
                    TBoxRPM.Text = Convert.ToString(String.Format("{0:0}", RPM));
                    TBoxRPMratio.Text = "1.0";
                    WMA[0] = T;
                }
            }
            else if (LabelRouterName.Text == "Spindle RPM:")
            {
                labelDial.Text = Convert.ToString(String.Format("{0:0}", RPM));
                TBoxRPM.Text = Convert.ToString(String.Format("{0:0}", RPM));
                labelWarning.Text = "";
            }
            else if (LabelRouterName.Text == "")
            {

                TBoxRPMratio.Text = Convert.ToString(RPM / 30000);
                TBoxRPM.Text = "30000";
                WMA[2] = T;
            }

            CheckWarningMessages();


            //Get CalculateValues values

            RPM = Convert.ToDouble(TBoxRPM.Text);
            Chipload = Convert.ToDouble(TBoxChipLoad.Text);
            //Calcualte
            FeedRate = RPM * FluteCount * Chipload;

            // Write values to labels:
            labelFR.Text = Convert.ToString(String.Format("{0:0}", FeedRate));
            labelPR.Text = Convert.ToString(String.Format("{0:0}", FeedRate / 2));
         
        

    }

        //*******Save vaues and close form***********************************************************************************************
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            //Save settings
            BobsCNC_Speeds_and_Feeds.Properties.Settings.Default.Model = CBoxModel.Text;
            BobsCNC_Speeds_and_Feeds.Properties.Settings.Default.Material = CBoxMaterial.Text;
            BobsCNC_Speeds_and_Feeds.Properties.Settings.Default.Units = CBoxUnits.Text;
            BobsCNC_Speeds_and_Feeds.Properties.Settings.Default.BitDiameter = CBoxBitDiameter.Text;
            BobsCNC_Speeds_and_Feeds.Properties.Settings.Default.Save();
        }


    }

}
