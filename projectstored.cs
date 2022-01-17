using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace projectsp
{
    class projectstored
    {
        SqlMethods sql = new SqlMethods();

        public bool InsertNewProduct(string Name = " ", double price = -1, int Category_ID = -1)
        {
            return (bool)sql.sqlExecute("InsertNewProduct", "N'" + Name + "','" + price + "','" + Category_ID + "'");
        }
        public bool UpdateProduct(int id = -1, string Name = " ", double price = -1, int Category_ID = -1)
        {
            return (bool)sql.sqlExecute("UpdateProduct", "'" + id + "',N'" + Name + "','" + price + "','" + Category_ID + "'");
        }
        public void DeleteProduct(int id)
        {
            sql.sqlExecute("DeleteProduct", "'" + id + "'   ");
        }
        public DataTable GetProducts(string key = "1", string value = "1")
        {
            SqlDataAdapter check = new SqlDataAdapter(sql.command("getData 'Products','" + key + "',N'" + value + "'"));
            DataTable Dt = new DataTable();
            check.Fill(Dt);
            return Dt;
        }
        public bool InsertNewUser(string Name = " ", string Pass = " ",int type=0)
        {
            return (bool)sql.sqlExecute("InsertNewUser", "N'" + Name + "','" + Pass + "','" + type + "'");
        }
        public bool UpdateUser(int id = -1, string Name = " ", string Pass = " ",int type=0)
        {
            return (bool)sql.sqlExecute("UpdateUser", "'" + id + "',N'" + Name + "','" + Pass + "','" + type + "'");
        }
        public void DeleteUser(int id)
        {
            sql.sqlExecute("DeleteUser", "'" + id + "'");
        }
        public DataTable Getusers(string key = "1", string value = "1")
        {
            SqlDataAdapter check = new SqlDataAdapter(sql.command("getData 'users','" + key + "',N'" + value + "'"));
            DataTable Dt = new DataTable();
            check.Fill(Dt);
            return Dt;
        }
        public bool InsertNewCategory(string Name = " ")
        {
            return (bool)sql.sqlExecute("InsertNewCategory", "N'" + Name + "'");
        }
        public bool UpdateCategory(int id = -1, string Name = " ")
        {
            return (bool)sql.sqlExecute("UpdateCategory", "'" + id + "',N'" + Name + "'");
        }
        public int InsertNewInvoice(int ShiftID = -1, int OrderNo = -1, decimal Discount = -1, decimal Tax = -1, decimal Total = -1, decimal TotalNet = -1, string Notes = " ")
        {
            return (int)sql.sqlExecute("InsertNewInvoice", "'" + ShiftID + "','" + OrderNo + "','" + Discount + "','" + Tax + "','" + Total + "','" + TotalNet + "',N'" + Notes + "'");
        }
        public bool InsertNewInvoiceDetail(int InvoiceID = -1, int ItemID = -1, int Quantity = -1,decimal Price=-1)
        {
            return (bool)sql.sqlExecute("InsertNewInvoiceDetail", "'" + InvoiceID + "','" + ItemID + "','" + Quantity + "','" + Price + "'");
        }
        public bool StartShift()
        {
            return (bool)sql.sqlExecute("StartShift");
        }
        public bool EndShift()
        {
            return (bool)sql.sqlExecute("EndShift");
        }
        public void IncrementOrderNumber()
        {
            sql.sqlExecute("IncrementOrderNumber");
        }
        public void ResetOrderNumber()
        {
            sql.sqlExecute("ResetOrderNumber");
        }
        public int GetCurrentShift()
        {
            return (int)sql.sqlExecute("GetCurrentShift");
        }
        public int getOrderNumber()
        {
            return (int)sql.sqlExecute("getOrderNumber");
        }


        public void DeleteCategory(int id)
        {
            sql.sqlExecute("DeleteCategory", "'" + id + "'");
        }
        public DataTable GetCategories(string key = "1", string value = "1")
        {
            SqlDataAdapter check = new SqlDataAdapter(sql.command("getData 'Categories','" + key + "',N'" + value + "'"));
            DataTable Dt = new DataTable();
            check.Fill(Dt);
            return Dt;
        }
        public DataTable GetShifts(string key = "1", string value = "1")
        {
            SqlDataAdapter check = new SqlDataAdapter(sql.command("getData 'Shifts','" + key + "',N'" + value + "'"));
            DataTable Dt = new DataTable();
            check.Fill(Dt);
            return Dt;
        }
        public DataTable GetInvoices(string key = "1", string value = "1")
        {
            SqlDataAdapter check = new SqlDataAdapter(sql.command("getData 'Invoices','" + key + "',N'" + value + "'"));
            DataTable Dt = new DataTable();
            check.Fill(Dt);
            return Dt;
        }
        public DataTable GetCategoriesOrdered()
        {
            SqlDataAdapter check = new SqlDataAdapter(sql.command("select * from Categories order by Category_ID"));
            DataTable Dt = new DataTable();
            check.Fill(Dt);
            return Dt;
        }
        public DataTable GetInvoiceDetails(int id)
        {
            SqlDataAdapter check = new SqlDataAdapter(sql.command("[dbo].[Report_InvoiceDetails] " +id));
            DataTable Dt = new DataTable();
            check.Fill(Dt);
            return Dt;
        }
        public void fillcombo(System.Windows.Forms.ComboBox cm, DataTable dt1, string displaymember, string valuemember, string firstrow)
        {

            DataRow dr1 = dt1.NewRow();
            dr1[displaymember] = firstrow;
            dr1[valuemember] = -1;
            dt1.Rows.InsertAt(dr1, 0);
            cm.DataSource = dt1;
            cm.DisplayMember = displaymember;
            cm.ValueMember = valuemember;
            //cm.BindingContext = this.BindingContext;
        }

        public void filllistbox(System.Windows.Forms.ListBox cm, DataTable dt1, string displaymember, string valuemember)
        {
            cm.DataSource = dt1;
            cm.DisplayMember = displaymember;
            cm.ValueMember = valuemember;
        }


    }
}
