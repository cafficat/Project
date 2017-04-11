using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GIDIPCR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnXuLie_Click(object sender, EventArgs e)
        {
            System.IO.FileStream fs = new System.IO.FileStream("二进制序列化.dat", System.IO.FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();

            Well2 stu1 = new Well2("A01", null, "Absolute Quantification", "",
                                       null, "", null, "", false, false,
                                       null, null, null, null, null,
                                       null, null, null, null, null,
                                       null, null, null, null,
                                       null, null, null, null,
                                       0, null, null, null, null, null,
                                       null, null, null, null, null,
                                       null, null, null, null, null,
                                       false, 20f, 0.85f, 2u, 1u, 1u, 1u, 0);
            Well2 stu2 = new Well2("A01", null, "Absolute Quantification", "",
                                       null, "", null, "", false, false,
                                       null, null, null, null, null,
                                       null, null, null, null, null,
                                       null, null, null, null,
                                       null, null, null, null,
                                       0, null, null, null, null, null,
                                       null, null, null, null, null,
                                       null, null, null, null, null,
                                       false, 20f, 0.85f, 2u, 1u, 1u, 1u, 0);
            Well2 stu3 = new Well2("A01", null, "Absolute Quantification", "",
                                       null, "", null, "", false, false,
                                       null, null, null, null, null,
                                       null, null, null, null, null,
                                       null, null, null, null,
                                       null, null, null, null,
                                       0, null, null, null, null, null,
                                       null, null, null, null, null,
                                       null, null, null, null, null,
                                       false, 20f, 0.85f, 2u, 1u, 1u, 1u, 0);

            bf.Serialize(fs, stu1);
            bf.Serialize(fs, stu2);
            bf.Serialize(fs, stu3);

            fs.Close();

            richTextBox1.AppendText("二进制 序列化 成功\r\n");
        }

        private void btnFanXuLie_Click(object sender, EventArgs e)
        {

            System.IO.FileStream defs = new System.IO.FileStream("二进制序列化.dat", System.IO.FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            Well2 s1 = (Well2)bf.Deserialize(defs);
            Well2 s2 = (Well2)bf.Deserialize(defs);
            Well2 s3 = (Well2)bf.Deserialize(defs);
            defs.Close();
            richTextBox1.AppendText("二进制 反序列化 成功\r\n");
        }
    }
}
