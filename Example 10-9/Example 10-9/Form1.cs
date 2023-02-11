using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Example_10_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //-----------------------------------------------------------------------
        private string Equivalent3(string s)
        {
            System.Collections.Hashtable arr = new System.Collections.Hashtable();
            //sefr aval return صفر  vali baghi sefrha return ""
            arr.Add(0, ""); arr.Add(1, "یک"); arr.Add(2, "دو"); arr.Add(3, "سه");
            arr.Add(4, "چهار"); arr.Add(5, "پنج"); arr.Add(6, "شش"); arr.Add(7, "هفت");
            arr.Add(8, "هشت"); arr.Add(9, "نه"); arr.Add(10, "ده"); arr.Add(11, "یازده");
            arr.Add(12, "دوازده"); arr.Add(13, "سیزده"); arr.Add(14, "چهارده"); arr.Add(15, "پانزده");
            arr.Add(16, "شانزده"); arr.Add(17, "هفده"); arr.Add(18, "هجده"); arr.Add(19, "نوزده");
            arr.Add(20, "بیست"); arr.Add(30, "سی"); arr.Add(40, "چهل"); arr.Add(50, "پنجاه");
            arr.Add(60, "شصت"); arr.Add(70, "هفتاد"); arr.Add(80, "هشتاد"); arr.Add(90, "نود");
            arr.Add(100, "صد"); arr.Add(200, "دویست"); arr.Add(300, "سیصد");arr.Add(400, "چهارصد");
            arr.Add(500, "پانصد"); arr.Add(600, "ششصد"); arr.Add(700, "هفتصد");
            arr.Add(800, "هشتصد"); arr.Add(900, "نهصد");
            ///////////////
            object o = int.Parse(s);//chon adad bala az no int hastand // agar long bezarim khata darad
            if (!arr.ContainsKey(o))
            {
                int a = int.Parse(s);
                s = "";
                int i = 100;
                while (a != 0)
                {
                    s = s +  arr[a / i * i].ToString()+" ";
                    a = a - a / i * i;
                    i = i / 10;
                }
                return s;
            }
            else
                return arr[o].ToString();
        }
        //-----------------------------------------------------------------------
        private string ConvertToFarsi(string digit)
        {
            if (digit == "0" || digit == "")
            {
                return "صفر";
            }
            digit = Math.Abs(long.Parse(digit)).ToString();
            string result = "";
            int i = 0;
            while (digit != "")
            {
                string s;
                if (digit.Length >= 3)
                    s = digit.Substring(digit.Length - 3, 3);
                else
                    s = digit;
                switch(i)
                {
                    case 0: result = Equivalent3(s) + " " + result; break;
                    case 1: result = Equivalent3(s) == "" ? result : Equivalent3(s) + " هزار " + result; break;
                    case 2: result = Equivalent3(s) == "" ? result : Equivalent3(s) + " میلیون " + result; break;
                    case 3: result = Equivalent3(s) == "" ? result : Equivalent3(s) + " میلیارد " + result; break;
                }
                if (digit.Length >= 3)
                    digit = digit.Remove(digit.Length - 3, 3);
                else
                    digit = "";
                i++;
            }
            return result;
        }
        //-----------------------------------------------------------------------
        private void btnConvertFarsi_Click(object sender, EventArgs e)
        {
            lblResult.Text = ConvertToFarsi(txtInputDigit.Text);
        }
    }
}
