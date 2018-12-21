using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Stream_Analyzer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string file_name = openFileDialog1.FileName;
            //string read_file = FileDialog.
        }

        [DllImport("DLL_Stream_Analyzer")]
        static extern void test([MarshalAs(UnmanagedType.LPStr)]String data);
        [DllImport("DLL_Stream_Analyzer")]
        static extern IntPtr test2([MarshalAs(UnmanagedType.LPStr)]String data);

        private void button5_Click(object sender, EventArgs e)
        {
            test("calling from WF testing...\r\n");            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            IntPtr str = test2("calling from WF testing...\r\n");
            string str2 =  PtrToStringUtf8(str);
            int xx = 1;
            xx++;
        }


        private static string PtrToStringUtf8(IntPtr ptr) // aPtr is nul-terminated
        {
            if (ptr == IntPtr.Zero)
                return "";
            int len = 0;
            while (System.Runtime.InteropServices.Marshal.ReadByte(ptr, len) != 0)
                len++;
            if (len == 0)
                return "";
            byte[] array = new byte[len];
            System.Runtime.InteropServices.Marshal.Copy(ptr, array, 0, len);
            return System.Text.Encoding.UTF8.GetString(array);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.dataGridView_table.Rows[0].Cells["No"].Value = 1;
        }
    }
}
