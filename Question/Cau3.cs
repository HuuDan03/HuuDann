using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Question
{
    public partial class Cau3 : Form
    {
        string path = @"D:\form.xml";
        public Cau3()
        {
            InitializeComponent();
        }
        //private
            void Write(InfoWindown iw)
        {
            XmlSerializer writer=new XmlSerializer(typeof(InfoWindown));
            StreamWriter file= new StreamWriter(path);
            writer.Serialize(file, iw);
            file.Close();
        }
        private void Cau3_Load(object sender, EventArgs e)
        {
           
            
        }
    }
}
