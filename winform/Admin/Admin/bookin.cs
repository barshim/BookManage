using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Admin
{
    public partial class bookin : Form
    {
        public bookin()
        {
            InitializeComponent();
        }

        private void vnumup_ValueChanged(object sender, EventArgs e)
        {
            int upvnum = Convert.ToInt16(vnumup.Value);
            vindata.RowCount = upvnum;
        }

        private void bookin_Load(object sender, EventArgs e)
        {
            vindata.RowCount = 1;
        }

        private void btdpl_Click(object sender, EventArgs e)
        {
            if (txtisbn.Text.Trim() == "")
            {
                MessageBox.Show("ISBN不能为空");
                return;
            }

            string sqlStr = "select * from caseBook where isbn='" + txtisbn.Text.Trim() + "'";
            DataSet ds = new DataSet();
            Cdatabase.conn.ConnectionString = Cdatabase.connStr;
            Cdatabase.conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, Cdatabase.conn);
            adapter.Fill(ds);
            Cdatabase.conn.Close();
            if (ds.Tables[0].Rows.Count == 0)
                MessageBox.Show("之前未被录入");
            else 
            {

            }
        }
    }
}
