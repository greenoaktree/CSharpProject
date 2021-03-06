﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MutiTableSelect
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void btn_Select_Click(object sender, EventArgs e)
        {
            dgv_Message.DataSource = GetMessage();//设置数据源
            dgv_Message.Columns[0].HeaderText = "信息";//设置列名称
            dgv_Message.Columns[0].Width = 500;//设置列宽度
        }

        /// <summary>
        /// 查询数据库信息
        /// </summary>
        /// <returns>方法返回DataTable对象</returns>
        private DataTable GetMessage()
        {
            string P_Str_ConnectionStr = string.Format(//创建数据库连接字符串
                @"server=WIN-GI7E47AND9R\LS;database=db_TomeTwo;uid=sa;Pwd=hbyt2008!@#;");
            string P_Str_SqlStr = string.Format(//创建SQL查询字符串
                @"SELECT 学生姓名 FROM tb_Student UNION SELECT CONVERT(VARCHAR(20),总分)
FROM tb_grade WHERE 总分>570
UNION SELECT 课程名称 FROM tb_Course");
            SqlDataAdapter P_SqlDataAdapter = new SqlDataAdapter(//创建数据适配器
                P_Str_SqlStr, P_Str_ConnectionStr);
            DataTable P_dt = new DataTable();//创建数据表
            P_SqlDataAdapter.Fill(P_dt);//填充数据表
            return P_dt;//返回数据表
        }

    }
}
