using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaucherJenkins;
using MaucherJenkinsData;
using System.Data.Common;
using System.Collections;
using System.Data.SqlTypes;
using System.Data.SqlClient;



namespace DatevExport
{
    public partial class Export : Form
    {
        public Export()
        {
            InitializeComponent();
        }

        //private static List<T> ConvertDataTable<T>(DataTable dt)
        //{
        //    List<T> data = new List<T>();
        //    foreach (DataRow row in dt.Rows)
        //    {
        //        T item = GetItem<T>(row);
        //        data.Add(item);
        //    }
        //    return data;
        //}

        //private static T GetItem<T>(DataRow dr)
        //{
        //    Type temp = typeof(T);
        //    T obj = Activator.CreateInstance<T>();

        //    foreach (DataColumn column in dr.Table.Columns)
        //    {
        //        foreach (PropertyInfo pro in temp.GetProperties())
        //        {
        //            if (pro.Name == column.ColumnName)
        //                pro.SetValue(obj, dr[column.ColumnName], null);
        //            else
        //                continue;
        //        }
        //    }
        //    return obj;
        //}
        private void Button1_Click(object sender, EventArgs e)
        {
            MJDataConnection dc = new MJDataConnection(@"EXEC dbo.udsp_CostsDataRev_Munich '104806,104854'");

            dc.GetRows()

            //NotesDump nd = new NotesDump();
            ////SqlDataReader dr;
            //SqlDataReader dr = nd.InvoiceChargesReader();

            //while (dr.Read())
            //{
            //    tbOutPut.Text = dr["InvoiceNo"].ToString();
            //}




            //tbOutPut.Text = dr.HasRows.ToString();

            //if(dr.HasRows)
            //{
            //    while(dr.Read())
            //    {
            //        tbOutPut.Text = dr["InvoiceNo"].ToString();
            //    }
            //}


            //dt = ConvertDataTable(nd.InvoiceCharges());
            //InvoiceCharges ics = new InvoiceCharges(dt);

            //foreach (DataRow row in dt.Rows)
            //{


            //}

            //Invoice invoice = new Invoice()
            //{
            //    InvoiceNumber = "320067"
            //};
            //TimeCharge timeCharge = new TimeCharge()
            //{
            //    ChargeTotal = 41.02,
            //    ChargeCreated = DateTime.Now // "2019-09-23"
            //};
            //invoice.InvoiceCharges.AddInvoiceCharge(timeCharge);

            //NotesDump nd = new NotesDump();

            //MJDataConnection nd = new MJDataConnection();
            //nd.ConnectIt();
            //InvoiceCharge v = new InvoiceCharge;
            //tbOutPut.Text = invoice.InvoiceNumber;
            //tbOutPut.Text = timeCharge.Amount.ToString();
            //tbOutPut.Text = timeCharge.InvoiceChargeType.ToString() + " " + timeCharge.ChargeTotal.ToString();
            //tbOutPut.Text = invoice.InvoiceCharges.Count() + " " + timeCharge.InvoiceChargeType.ToString() + " " + timeCharge.ChargeTotal.ToString();
            //tbOutPut.Text = nd.Connected.ToString();
        }
    }
}
