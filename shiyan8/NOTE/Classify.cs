﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using JKLibrary;

namespace NOTE
{
    public partial class Classify : Form
    {
        public Classify()
        {
            InitializeComponent();
        }

        private void Classify_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“noteDataSet2.NoteInfo”中。您可以根据需要移动或删除它。
            this.noteInfoTableAdapter.Fill(this.noteDataSet2.NoteInfo);
            // TODO: 这行代码将数据加载到表“noteDataSet2.UsersInfo”中。您可以根据需要移动或删除它。
            this.usersInfoTableAdapter.Fill(this.noteDataSet2.UsersInfo);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet dt = SQLHelper.GetDataSet("select * from NoteInfo ", null);
            string conn = "Data Source=.;Initial Catalog=Note;Integrated Security=True";
            SqlConnection mycon = new SqlConnection(conn);
            mycon.Open();
            string sql = "delete from [Note].[dbo].[NoteInfo] where Classify='" + textBox1.Text + "' and Title ='"+textBox2.Text+"'";
            SqlCommand mycom = new SqlCommand(sql, mycon);           //定义对象并连接数据库
            mycom.ExecuteNonQuery();                           //执行插入语句
            mycon.Close();                //关闭对象并释放所占内存空间    
            mycon.Dispose();
            if (dt.Tables[0].Rows.Count > 0)
            {
            MessageBox.Show("修改成功！");
            return;
            }
            else
            {
                MessageBox.Show("修改失败！");
                return;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView1.Visible = true;
        }


    }
}
