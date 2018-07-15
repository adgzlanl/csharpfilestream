using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using FilestreamExample;


namespace FilestreamExample
{
    public partial class Form1 : Form
    {
        string path = @"C:\Program Files (x86)\pfluka\FileManagement\DTBM.cfg";
        FileStreamManager fileStreamManager= new FileStreamManager();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
          
            if (!File.Exists(path))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(path));
                File.Create(path).Dispose();
                fileStreamManager.InitParam();
                fileStreamManager.WriteFile(path);

            }

            else
            {
                fileStreamManager.ReadFile(path);
                textBox1.Text = fileStreamManager.Params[0];
                textBox2.Text = fileStreamManager.Params[1];
                textBox3.Text = fileStreamManager.Params[2];
                textBox4.Text = fileStreamManager.Params[3];
                textBox5.Text = fileStreamManager.Params[4];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fileStreamManager.Params[0] = textBox1.Text;
            fileStreamManager.Params[1] = textBox2.Text;
            fileStreamManager.Params[2] = textBox3.Text;
            fileStreamManager.Params[3] = textBox4.Text;
            fileStreamManager.Params[4] = textBox5.Text;
            fileStreamManager.WriteFile(path);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!File.Exists(path))
            {
                    Directory.CreateDirectory(Path.GetDirectoryName(path));
                    File.Create(path).Dispose();
                    fileStreamManager.InitParam();
                    fileStreamManager.WriteFile(path);

            }

            else
            {
                fileStreamManager.ReadFile(path);
                textBox1.Text = fileStreamManager.Params[0];
                textBox2.Text = fileStreamManager.Params[1];
                textBox3.Text = fileStreamManager.Params[2];
                textBox4.Text = fileStreamManager.Params[3];
                textBox5.Text = fileStreamManager.Params[4];
            }
        }
    }
}
