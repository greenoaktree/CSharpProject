﻿// ----- Microsoft ADO.NET 4.0 Step by Step
//       Sample for Chapter 19 - C# Version
//       by Tim Patrick

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Objects.SqlClient;
using System.Data.Objects.DataClasses;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Chapter_19_CSharp
{
    public partial class StatesByYear : Form
    {
        public StatesByYear()
        {
            InitializeComponent();
        }

        private void StatesByYear_Load(System.Object sender, System.EventArgs e)
        {
            // ----- Perform the lookup.
            using (SalesOrderEntities context = new SalesOrderEntities(General.GetConnectionString()))
            {

            }
        }
    }
}
