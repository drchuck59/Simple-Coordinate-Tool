using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace SimpleCoordTranslator
{
    class Common
    {
        readonly static char DegreeChar = Convert.ToChar(186);

        public static DialogResult SendMessage(string Msg,
        MessageBoxIcon icon = MessageBoxIcon.Warning, MessageBoxButtons buttons = MessageBoxButtons.OK)
        {
            return MessageBox.Show(Msg, "Simple Coord Translator", buttons, icon);
        }
        public static double String2DecDeg(string DMS, string Delim = "")
        /// <summary>
        /// Returns a Decimal degrees value from the OpenAIG formatted string
        ///         where ? is the quadrant
        /// OpenAIG is [#]##:##:##? 
        /// FAA is [#]##-##-##.##?
        /// StarDP is ?ddmmsss The decimal for 3d s is implied
        /// VRC is ?###.##.##.###  (Leading zero for latitudes)
        /// NaviGraph is ? [#]## ##.###
        /// RichText (copy/paste) may be [#]##°##'##"
        /// </summary>
        {
            DMS = DMS.Trim();
            double result = -199; double DD; double MM; double SS; string quadrant;
            string tempDMS; double factor; string DegDelim; string MinDelim; string SecDelim;
            if (DMS.Length > 5)
            {
                // Check that caller didn't "forget" the delim (or may not know it)
                DegDelim = FindDelimiter(DMS);
                // Check that caller didn't send an invalid delim
                if (Delim.Length != 0)
                    if (DegDelim != Delim) return result;       // Result is still -199
                // Sometimes the quadrant is in the front and other times in the back!
                if (DMS.Substring(0, 1).IsNumeric())
                {
                    quadrant = Extensions.Right(DMS, 1);
                    tempDMS = DMS.Substring(0, DMS.Length - 1).Trim();              // Strip off quadrant
                }
                else
                {
                    quadrant = DMS.Substring(0, 1);
                    tempDMS = DMS.Substring(1, DMS.Length - 1).Trim();
                }
                // Now that we know the real Delim, use it to find the values
                if (DegDelim.Length == 0)
                // Truely no delimiter
                {
                    if (quadrant == "W" || quadrant == "E")
                    {
                        // Longitudinal conversion
                        DD = double.Parse(tempDMS.Substring(0, 3));
                        MM = double.Parse(tempDMS.Substring(3, 2));
                        SS = double.Parse(tempDMS.Substring(5, 2));
                        if (DMS.Length > 7)                         // Add fraction of seconds if they exist
                        {
                            factor = (double)Math.Pow(10f, Convert.ToSingle(tempDMS.Length - 7));
                            SS += double.Parse(tempDMS.Substring(6)) / factor;
                        }
                    }
                    else
                    {
                        // Latitude conversion
                        DD = double.Parse(tempDMS.Substring(0, 2));
                        MM = double.Parse(tempDMS.Substring(2, 2));
                        SS = double.Parse(tempDMS.Substring(4, 2));
                        if (DMS.Length > 6)                         // Add fraction of seconds if they exist
                        {
                            factor = (double)Math.Pow(10f, Convert.ToSingle(tempDMS.Length - 6));
                            SS += double.Parse(tempDMS.Substring(5)) / factor;
                        }
                    }
                    result = DMS2DecDeg(DD, MM, SS, quadrant);
                }
                else
                // Has a delimiter
                {
                    if (DegDelim != DegreeChar.ToString()) SecDelim = MinDelim = DegDelim;
                    else { SecDelim = @""; MinDelim = "'"; }
                    int loc1 = tempDMS.IndexOf(DegDelim, 0, tempDMS.Length, StringComparison.CurrentCulture); // end of DD
                    DD = double.Parse(tempDMS.Substring(0, loc1));
                    int loc2 = tempDMS.IndexOf(MinDelim, loc1 + 1, tempDMS.Length - loc1 - 1, StringComparison.CurrentCulture); // End of MM
                    if (loc2 == -1)
                    // This is a Navigraph format (no minutes as decimal, no seconds)
                    {
                        MM = double.Parse(tempDMS.Substring(loc1 + 1));
                        SS = 0;
                    }
                    else
                    {
                        MM = double.Parse(tempDMS.Substring(loc1 + 1, loc2 - loc1 - 1));
                        if (SecDelim == DegreeChar.ToString())
                            tempDMS = tempDMS.Substring(0, tempDMS.Length - 1);
                        SS = double.Parse(tempDMS.Substring(loc2 + 1, tempDMS.Length - loc2 - 1));
                    }
                    result = DMS2DecDeg(DD, MM, SS, quadrant);
                }
                // Last step: Ensure the result value falls within the range of the latitude or longitude
                switch (quadrant)
                {
                    case "N":
                    case "S":
                        if (Math.Abs(result) > 90) result = -199;
                        break;
                    case "E":
                    case "W":
                        if (Math.Abs(result) > 180) result = -199;
                        break;
                }
            }
            return result;
        }

        public static string DecDeg2DMS(double DecDeg, bool IsLatitude)
        {
            string quadrant;
            string result;     // An empty string indicates an error occurred
            double tempDecDeg;
            if (DecDeg < 0)     // Tests for S or W quadrants
            {
                if (IsLatitude)
                {
                    quadrant = "S";
                }
                else
                {
                    quadrant = "W";
                }
            }
            else
            {
                if (IsLatitude)
                {
                    quadrant = "N";
                }
                else
                {
                    quadrant = "E";
                }
            }
            tempDecDeg = Math.Abs(DecDeg);
            int DD = (int)Math.Floor(tempDecDeg);     // Need integer value WITHOUT rounding
            string strDD = DD.ToString("000");          // This cannot be done in one step
            double tmpDecDeg = (tempDecDeg - DD) * 60;
            int MM = (int)Math.Floor(tmpDecDeg);
            string strMM = MM.ToString("00");
            double SS = (tmpDecDeg - MM) * 60;
            string strSS = SS.ToString("00.000");
            result = strDD + "°" + strMM + "'" + strSS + "\"" + quadrant;
            return result;
        }


        public static double DMS2DecDeg(double DD, double MM, double SS, string quadrant)
        {
            double result;
            switch (quadrant)
            {
                case "W":
                    result = -1 * (SS / 3600 + MM / 60 + DD);
                    break;
                case "S":
                    result = -1 * (SS / 3600 + MM / 60 + DD);
                    break;
                case "N":
                    result = SS / 3600 + MM / 60 + DD;
                    break;
                case "E":
                    result = SS / 3600 + MM / 60 + DD;
                    break;
                default:
                    result = -181;
                    break;
            }
            return result;
        }

        public static string DecDeg2SCT(double DecDeg, bool IsLatitude)
        {
            string quadrant;
            string result;     // An empty string indicates an error occurred
            double tempDecDeg;
            if (DecDeg < 0)     // Tests for S or W quadrants
            {
                if (IsLatitude)
                {
                    quadrant = "S";
                }
                else
                {
                    quadrant = "W";
                }
            }
            else
            {
                if (IsLatitude)
                {
                    quadrant = "N";
                }
                else
                {
                    quadrant = "E";
                }
            }
            tempDecDeg = Math.Abs(DecDeg);
            int DD = (int)Math.Floor(tempDecDeg);     // Need integer value WITHOUT rounding
            string strDD = DD.ToString("000");          // This cannot be done in one step
            double tmpDecDeg = (tempDecDeg - DD) * 60;
            int MM = (int)Math.Floor(tmpDecDeg);
            string strMM = MM.ToString("00");
            double SS = (tmpDecDeg - MM) * 60;
            string strSS = SS.ToString("00.000");
            result = quadrant + strDD + "." + strMM + "." + strSS;
            return result;
        }


        private static string FindDelimiter(string DMS)
        {
            // The delimiter must occur within 4 characters (?###^)
            string result = string.Empty;
            if ((DMS.IndexOf('.') > -1) && (DMS.IndexOf('.') < 5)) result = ".";
            if ((DMS.IndexOf(':') > -1) && (DMS.IndexOf(':') < 5)) result = ":";
            if ((DMS.IndexOf('-') > -1) && (DMS.IndexOf('-') < 5)) result = "-";
            if ((DMS.IndexOf(' ') > -1) && (DMS.IndexOf(' ') < 5)) result = " ";
            Debug.WriteLine("Degree char:" + DegreeChar.ToString());
            if (DMS.Contains(DegreeChar)) result = DegreeChar.ToString();
            //if (DMS.Contains(DegreeChar)) result = DegreeChar.ToString();
            return result;
        }
    }
        public static class Extensions
        {
            /// <summary>
            /// Get substring of specified number of characters on the right.
            /// </summary>
            public static string Right(this string value, int length)
            {
                if (string.IsNullOrEmpty(value)) return string.Empty;

                return value.Length <= length ? value : value.Substring(value.Length - length);
            }
            public static bool IsNumeric(this string text)
            {
#pragma warning disable IDE0059 // Unnecessary assignment of a value
                return double.TryParse(text, out double test);
#pragma warning restore IDE0059 // Unnecessary assignment of a value
            }

            public static string Left(this string value, int maxLength)
            {
                if (string.IsNullOrEmpty(value)) return value;
                maxLength = Math.Abs(maxLength);

                return (value.Length <= maxLength
                       ? value
                       : value.Substring(0, maxLength)
                       );
            }

        }
    public static class CrossForm
    {
        public static double Lat { get; set; }
        public static double Lon { get; set; }
        public static double Distance { get; set; }
        public static double Bearing { get; set; }
    }

}

