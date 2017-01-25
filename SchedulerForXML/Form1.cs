using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.IO;
namespace SchedulerForXML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            //XmlDocument xmlDoc = new XmlDocument();

            //xmlDoc.Load("d:\\product.xml");

            //XmlNodeList nodeList = xmlDoc.DocumentElement.SelectNodes("/Table/Product");

            //string proID = "", proName = "", price = "";

            //foreach (XmlNode node in nodeList)

            //{

            //    proID = node.SelectSingleNode("Product_id").InnerText;

            //    proName = node.SelectSingleNode("Product_name").InnerText;

            //    price = node.SelectSingleNode("Product_price").InnerText;

            //    MessageBox.Show(proID + " " + proName + " " + price);

            //}
            //MessageBox.Show(fName+"===>"+Lname);

            GetElementValueByElementName();
        }
        string fName = "";
        string Lname = "";
        public void GetElementValueByElementName()
        {
            string filePath = "D:\\Projects";
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("D:\\Projects\\PR121120161G.xml");

            /*XmlNodeList nodeList = xmlDoc.DocumentElement.SelectNodes("//SrpCode");*/
            XmlNodeList nodeList = xmlDoc.DocumentElement.SelectNodes("//Address");

            
            int count = 0;
            foreach (XmlNode node in nodeList)
            {

                if ((node.SelectSingleNode("Addr1") == null))
                {
                    fName = "NAN";

                }
                else if ((node.SelectSingleNode("City") == null))
                {
                    Lname = "NAN";
                }
                else
                {
                    fName = node.SelectSingleNode("Addr1").InnerText;
                    Lname = node.SelectSingleNode("City").InnerText;


                }
                var csv = new StringBuilder();
               
               var newLine = string.Format("{0},{1}",fName,Lname);
               
                csv.AppendLine(newLine);
               
                File.AppendAllText(filePath + "Vinay1.csv", csv.ToString());
               
            }
            
        }

        //public void GetElementValueBy()
        //{
        //    string filePath = "D:\\Projects";
        //    XmlDocument xmlDoc = new XmlDocument();
        //    xmlDoc.Load("D:\\Projects\\PR121120161G.xml");

        //    /*XmlNodeList nodeList = xmlDoc.DocumentElement.SelectNodes("//SrpCode");*/
        //    XmlNodeList nodeList = xmlDoc.DocumentElement.SelectNodes("//Night");

        //    string fName = "", Lname = "", SCode = "";

        //    foreach (XmlNode node in nodeList)
        //    {
        //        fName = node.SelectSingleNode("Folio").InnerText;
        //        Lname = node.SelectSingleNode("LastName").InnerText;
        //        //SCode = node.SelectSingleNode("SrpCode").InnerText;
        //        fName = node.InnerText;

        //        var csv = new StringBuilder();
        //        var newLine = string.Format("{0},{1}", fName, Lname);
        //        csv.AppendLine(newLine);

        //        File.AppendAllText(filePath + "Vinay.csv", csv.ToString());

        //    }
        //}
    }
}
    
