using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            summaryIP();
        }

        protected void summaryIP()
        {
            string ipAdd = inputIP.Text;
            string strPrefix = inputPrefix.Text;

            bool checkIP = checkIPValid(ipAdd);
            bool checkPrefix = checkPrefixValid(strPrefix);          

            if(checkPrefix && checkIP) 
            {
                string strIP = IpToBinary(ipAdd);
                string netId = netzIDBro(strIP, strPrefix, 0);
                string strPref = PrefToNetzmaske(strPrefix);
                string netMask = BinaryToInt(strPref);
                string ipAll = ipRechner(strPrefix);
                string nutzIp = kugilium(strPrefix);
                string strBroad = netzIDBro(strIP, strPrefix, 1);
                string firstIp = firstLastIp(netId, 1);
                string lastIp = firstLastIp(strBroad, -1);

                txtNetzmaske.Text = netMask;              
                ipNumbs.Text = ipAll;
                nutzbareIp.Text = nutzIp;
                txtBroadcast.Text = strBroad;
                lblIPBinary.Text = strIP;
                bxNetId.Text = netId;
                txtFirstIp.Text = firstIp;
                txtLastIp.Text = lastIp;


            }
            else
            {
                MessageBox.Show("Bitte geben Sie eine echte IP-Adresse oder ein Präfix ein!");
            }
        }
        protected bool checkIPValid(string strIP)
        {
            string[] arrOctets = strIP.Split('.');
            //Check that array lentth is 3
            if(arrOctets.Length != 4)
            {
                return false;
            }

            //Check each substring checking that the int value is less than 255
            Int16 MAXVALUE = 255;
            Int32 temp;
            foreach (string strOctet in arrOctets)
            {
                if (strOctet.Length > 3)
                {
                    return false;
                }

                temp = int.Parse(strOctet);
                if (temp > MAXVALUE)
                {
                    return false;
                }
            }
            return true;
        }

        protected bool checkPrefixValid(string strPrefix)
        {
            int intPrefix = 0;

            try
            {
                intPrefix = Convert.ToInt32(strPrefix);
            }
            catch
            {
                MessageBox.Show("Not number");
            }

            if(intPrefix > 32 || intPrefix < 8)
            {
                return false;
            }
            return true;
        }

        protected string IpToBinary(string input)
        {
            return String.Join(".", (input.Split('.').Select(x => Convert.ToString(Int32.Parse(x), 2).PadLeft(8, '0'))).ToArray());
        }

        protected string PrefToNetzmaske(string strPrefix)
        {
            int maxPrefix = 32;
            int prefix = Convert.ToInt32(strPrefix);
            int mask = maxPrefix - prefix;

            string prefixStr = new string('1', prefix) + new string('0', mask);
                /*
                string temp = "";
                int intPref = Convert.ToInt32(strPrefix);

                for (int i = 0; i < intPref; i++)
                {
                    temp += "1";
                }
                for (int i = 0; i < 32 - intPref; i++)
                {
                    temp += "0";
                }
                */
                for (int i = 8; i <= prefixStr.Length; i += 8)
                {
                    prefixStr = prefixStr.Insert(i, ".");
                    i++;
                }

            return prefixStr;
        }

        protected string BinaryToInt(string input)
        {
            string[] arrayInput = input.Split('.');
            int arrayInt1 = Convert.ToInt32(arrayInput[0], 2);
            int arrayInt2 = Convert.ToInt32(arrayInput[1], 2);
            int arrayInt3 = Convert.ToInt32(arrayInput[2], 2);
            int arrayInt4 = Convert.ToInt32(arrayInput[3], 2);

            string allInt = Convert.ToString(arrayInt1) + "." + Convert.ToString(arrayInt2) + "."
                + Convert.ToString(arrayInt3) + "." + Convert.ToString(arrayInt4);

            return allInt;
        }

        protected string ipRechner(string input)
        {
            int secondPotenz = 32 - Convert.ToInt32(input);
            double ipNumbers = Math.Pow(2, secondPotenz);
            return Convert.ToString(ipNumbers);
        }

        protected string kugilium(string input)
        {
            string nutzIp = ipRechner(input);
            int converteInput = Convert.ToInt32(nutzIp);
            int nutzIntIp;
            nutzIntIp = converteInput - 2;
            if(nutzIntIp < 0)
            {
                nutzIntIp += 1;
            }

            return Convert.ToString(nutzIntIp);
        }

        protected string netzIDBro(string inputIp, string inputPref, int value)
        {
            string[] arraySplit = inputIp.Split('.');
            int prefInt = Convert.ToInt32(inputPref);
            string allItemarray = arraySplit[0] + arraySplit[1]+ arraySplit[2] + arraySplit[3];
            StringBuilder sb = new StringBuilder(allItemarray);
            
            sb.Remove(prefInt, 32-prefInt);
            allItemarray = sb.ToString();
            
            for (int i = 0; i <= 31-prefInt; i++)
            {
                allItemarray += Convert.ToString(value);
            }
            
            allItemarray = allItemarray.Insert(8, ".");
            allItemarray = allItemarray.Insert(17, ".");
            allItemarray = allItemarray.Insert(26, ".");
            
            string result = BinaryToInt(allItemarray);
            
            return result; //Convert.ToString(allItemarray.Length)
        }

        protected string firstLastIp(string inputIp, int value)
        {
            string[] arrayInt = inputIp.Split('.');
            int mod = Convert.ToInt32(arrayInt[3]) + value;
            string newArray = arrayInt[0] + "." + arrayInt[1] + "."
                + arrayInt[2] + "." + Convert.ToString(mod);
            return newArray;
        }
    }
}
