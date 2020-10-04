﻿using System;
using System.Windows.Forms;
using System.Globalization;
using System.Diagnostics;
using System.Drawing;

namespace SimpleCoordTranslator
{
    public partial class DMS_DecDeg : Form
    {

        public static double DecLatitude = 0;
        public static double DecLongitude = 0;

        string DMSLatitude = string.Empty;
        string DMSLongitude = string.Empty;

        string SCTLatitude = string.Empty;
        string SCTLongitude = string.Empty;

        string DecFormat = "0,0.000000";

        public DMS_DecDeg()
        {
            InitializeComponent();
        }

        private void UpdateBoxes()
        {
            LatDecTextBox.Text = decimal.Round(Convert.ToDecimal(DecLatitude), 6, MidpointRounding.AwayFromZero).ToString();
            LonDecTextBox.Text = decimal.Round(Convert.ToDecimal(DecLongitude), 6, MidpointRounding.AwayFromZero).ToString();
            DMSLatitude = Common.DecDeg2DMS(DecLatitude, true);
            LatDMSTextBox.Text = DMSLatitude;
            DMSLongitude = Common.DecDeg2DMS(DecLongitude, false);
            LonDMSTextBox.Text = DMSLongitude;
            SCTLatitude = Common.DecDeg2SCT(DecLatitude, true);
            LatSCTTextBox.Text = SCTLatitude;
            SCTLongitude = Common.DecDeg2SCT(DecLongitude, false);
            LonSCTTextBox.Text = SCTLongitude;
            UpdateStrings();
        }

        private void UpdateStrings()
        {
            if ((DMSLongitude.Length != 0) && (DMSLatitude.Length != 0))
                ToSingleLine(DMSLatitude, DMSLongitude, DMSTextBox);
            if ((SCTLatitude.Length != 0) && (SCTLongitude.Length != 0))
                ToSingleLine(SCTLatitude, SCTLongitude, SCTTextBox);
            ToSingleLine(DecLatitude.ToString(DecFormat),
                DecLongitude.ToString(DecFormat), DECTextBox);
        }

        private void ResetAllBoxes()
        {
            DecLatitude = DecLongitude = 0.0;
            DMSLatitude = DMSLongitude = SCTLatitude = SCTLongitude = string.Empty;
            DMSTextBox.BackColor = LatDMSTextBox.BackColor = LonDMSTextBox.BackColor = Color.White;
            SCTTextBox.BackColor = LatSCTTextBox.BackColor = LonSCTTextBox.BackColor = Color.White;
            DECTextBox.BackColor = LatDecTextBox.BackColor = LonDecTextBox.BackColor = Color.White;
            UpdateBoxes();
        }

        private void ToSingleLine(string Lat, string Lon, TextBox tb)
        {
            if ((Lat.Length != 0) && (Lon.Length != 0))
            {
                tb.Text = Lat + " " + Lon;
            }
        }

        private void PasteButton_Click(object sender, EventArgs e)
        {
            string text = Clipboard.GetText().Trim();
            if (text.Length != 0)
            {
                SCTTextBox.Text = text;
                SCTTextBox.Modified = true;
                SCTTextBox.Refresh();
                ValidateTextBox(SCTTextBox);
            }
            else Common.SendMessage("Clipboard is empty.");
        }

        private void SendToClipboard(TextBox tb)
        {
            tb.SelectAll();
            Clipboard.SetText(tb.Text);
        }

        private void LatDecTextBox_DoubleClick(object sender, EventArgs e)
        {
            SendToClipboard(LatDecTextBox);
        }
        private void LonDecTextBox_DoubleClick(object sender, EventArgs e)
        {
            SendToClipboard(LonDecTextBox);
        }

        private void LatSCTTextBox_DoubleClick(object sender, EventArgs e)
        {
            SendToClipboard(LatSCTTextBox);
        }

        private void LonSCTTextBox_DoubleClick(object sender, EventArgs e)
        {
            SendToClipboard(LonSCTTextBox);
        }

        private void DMSTextBox_DoubleClick(object sender, EventArgs e)
        {
            SendToClipboard(LonSCTTextBox);
        }

        private void DECTextBox_DoubleClick(object sender, EventArgs e)
        {
            SendToClipboard(DECTextBox);
        }

        private void SCTTextBox_DoubleClick(object sender, EventArgs e)
        {
            SendToClipboard(SCTTextBox);
        }

        private void ValidateTextBox(TextBox tb)
        {
            if (tb.Modified)            // Don't mess with textbox unless 'dirty'
            { 
                if (tb.TextLength != 0) // If empty, don't process, but return to white default
                { 
                    if (ValidateDMS(tb)) UpdateBoxes();
                }
                else
                {
                    tb.BackColor = Color.White;
                }
            }
        }

        private void DECTextBox_Validated(object sender, EventArgs e)
        {
            ValidateTextBox(DECTextBox);
        }

        private void LatDecTextBox_Validated(object sender, EventArgs e)
        {
            ValidateTextBox(LatDecTextBox);
        }

        private void LonDecTextBox_Validated(object sender, EventArgs e)
        {
            ValidateTextBox(LonDecTextBox);
        }

        private void DMSTextBox_Validated(object sender, EventArgs e)
        {
            ValidateTextBox(DMSTextBox);
        }

        private void LatDMSTextBox_Validated(object sender, EventArgs e)
        {
            ValidateTextBox(LatDMSTextBox);
        }

        private void LonDMSTextBox_Validated(object sender, EventArgs e)
        {
            ValidateTextBox(LonDMSTextBox);
        }

        private void SCTTextBox_Validated(object sender, EventArgs e)
        {
            ValidateTextBox(SCTTextBox);
        }

        private void LatSCTTextBox_Validated(object sender, EventArgs e)
        {
            ValidateTextBox(LatSCTTextBox);
        }

        private void LonSCTTextBox_Validated(object sender, EventArgs e)
        {
            ValidateTextBox(LonSCTTextBox);
        }

        private void LatDecTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumberFormatInfo fi = CultureInfo.CurrentCulture.NumberFormat;
            char[] d = fi.NumberDecimalSeparator.ToCharArray();
            char c = e.KeyChar;
            if (c == '-')
            {
                if (LatDecTextBox.TextLength > 0)
                    e.Handled = true;
            }
            else
            {
                if (!char.IsControl(c) && !char.IsDigit(c) && !(c == d[0]))
                    e.Handled = true;
            }
        }

        private void LonDecTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumberFormatInfo fi = CultureInfo.CurrentCulture.NumberFormat;
            char[] d = fi.NumberDecimalSeparator.ToCharArray();
            char c = e.KeyChar;
            if (c == '-')
            {
                if (LonDecTextBox.TextLength > 0)
                    e.Handled = true;
            }
            else
            {
                if (!char.IsControl(c) && !char.IsDigit(c) && !(c == d[0]))
                    e.Handled = true;
            }
        }

        private void DMSHelpButton_Click(object sender, EventArgs e)
        {
            Form info = new DMShelp();
            info.ShowDialog();
        }

        private bool ValidateDMS(TextBox tb)
        {
            bool result = LatLons.TryParseAnyDMS(tb);
            if (result)
            {
                tb.BackColor = Color.White;
            }
            else
            {
                tb.BackColor = Color.Yellow;
            }
            return result;
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ResetAllBoxes();
        }
    }
}

