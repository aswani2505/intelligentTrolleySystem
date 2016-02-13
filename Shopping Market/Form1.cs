using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.Data.OleDb;
namespace ShoppingMarket
{
    public partial class Form1 : Form
    {
        AutoResetEvent receiveNow;
        private OleDbConnection con;
        string strcon, Query, Where;
        DataTable dt;
        #region Open and Close Ports
        //Open Port
        public SerialPort OpenPort(string p_strPortName, int p_uBaudRate, int p_uDataBits)//, int p_uReadTimeout, int p_uWriteTimeout)
        {
            receiveNow = new AutoResetEvent(false);
            try
            {
                port.PortName = p_strPortName;                 //COM3
                port.BaudRate = p_uBaudRate;                   //9600
                port.DataBits = p_uDataBits;                   //8
                port.StopBits = StopBits.One;                  //1
                port.Parity = Parity.None;                     //None
                //port.ReadTimeout = p_uReadTimeout;             //300
                //port.WriteTimeout = p_uWriteTimeout;           //300
                port.Encoding = Encoding.GetEncoding("iso-8859-1");
                port.Open();
                port.DtrEnable = true;
                port.RtsEnable = true;
            }
            catch (Exception ex)
            {
                //throw ex;
            }
            return port;
        }

        //Close Port
        public void ClosePort(SerialPort port)
        {
            try
            {
                port.Close();
                port.DataReceived -= new SerialDataReceivedEventHandler(port_DataReceived);
                port = null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        string st = "", st1 = "";
        bool stop = false, status = false;

        public string ReadResponse(int timeout)
        {
            string buffer = string.Empty;
            try
            {
                if (receiveNow.WaitOne(timeout, false))
                {
                    string t = port.ReadExisting();
                    buffer += t;
                }
            }
            catch (Exception ex)
            {
                //throw ex;
            }
            return buffer;
        }

        public Form1()
        {
            InitializeComponent();
            strcon = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\DBShopping.mdb;Persist Security Info=False";
            con = new OleDbConnection(strcon);
        }

        private bool InsertRecord(string query)
        {
            if (con.State == ConnectionState.Closed || con.State == ConnectionState.Broken)
                con.Open();
            OleDbCommand com = new OleDbCommand();
            com.Connection = con;
            com.CommandText = query;
            try
            {
                com.ExecuteNonQuery();
                return true;
            }
            catch (Exception e) { return false; }
            finally { con.Close(); }
        }

        private DataTable getDataTable(string query)
        {
            if (con.State == ConnectionState.Closed || con.State == ConnectionState.Broken)
                con.Open();
            OleDbCommand com = new OleDbCommand();
            com.Connection = con;
            com.CommandText = query;
            OleDbDataAdapter da = new OleDbDataAdapter(com);
            DataSet ds = new DataSet();
            try
            {
                
                com.ExecuteNonQuery();
                da.Fill(ds);
                return ds.Tables[0];
            }
            catch (Exception e) { return null; }
            finally
            {
                con.Close();
            }
        }

        private void port_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                if (e.EventType == SerialData.Chars)
                {
                    receiveNow.Set();
                    st = ReadResponse(30);
                    if (st.Contains("@") && st.Contains("#"))
                    {
                        st1 = st.Substring(st.IndexOf('@') + 1, st.IndexOf('#') - (st.IndexOf('@') + 1));
                        string[] strArr = st1.Split(',');

                        foreach (string strr in strArr)
                        {
                            if (int.Parse(strr.Substring(0)) > 0)
                            {
                                Where = "";
                                if (string.IsNullOrEmpty(Where))
                                {
                                    Where = "insert into tbl_Order values('" + strr.Substring(0, 1) + "'," + 1 + ")";
                                    InsertRecord(Where);
                                }
                            }
                        }
                        Query = "select t1.product_name as Product, t2.Quantity, t1.Price from tbl_Products t1 inner join tbl_Order t2 on t1.id = t2.id";
                        dt = getDataTable(Query);
                        dt.Columns.Add("Amount", typeof(int));

                        foreach (DataRow row in dt.Rows)
                            row["Amount"] = Convert.ToInt32(row["Quantity"]) * Convert.ToInt32(row["Price"]);

                        DataRow dr = dt.NewRow();
                        dr["Amount"] = dt.Compute("Sum(Amount)", String.Empty);
                        dt.Rows.Add(dr);
                        status = true;

                        Where = "delete * from tbl_Order";
                        InsertRecord(Where);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            cmb_Com.Items.AddRange(SerialPort.GetPortNames());
        }
        int num; string s;
        private void btn_GetBill_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_TroleyNo.Text, out num))
           {
               s = "@T" + txt_TroleyNo.Text + '#';
                port.Write(s);
            }
            else MessageBox.Show("Enter correct no");
        }

        private void btn_EmptyTroley_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_TroleyNo.Text, out num))
            {

                s = "@F" + txt_TroleyNo.Text + '#';
                port.Write(s);
                dt.Rows.Clear();
                gv.DataSource = dt;
            }
            else MessageBox.Show("Enter correct no");
        }

        private void btn_Port_Click(object sender, EventArgs e)
        {
            if (!port.IsOpen)
            {
                OpenPort(cmb_Com.SelectedItem.ToString(), 9600, 8);
                btn_Port.Text = "Close Port";
            }
            else
            {
                btn_Port.Text = "Open Port";
                port.Close();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (status)
            {
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        gv.DataSource = dt;
                        gv.Columns[0].Width = 200;
                        gv.Columns[1].Width = 60;
                        gv.Columns[2].Width = 50;
                        gv.Columns[3].Width = 60;
                        status = false;
                    }
                }
            }
        }
    }
}