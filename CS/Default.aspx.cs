using DevExpress.Data.Filtering;
using DevExpress.Web;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Init(object sender, EventArgs e)
    {
        DataTable dt = new DataTable();
        dt.Columns.Add("OrderID");
        dt.Columns.Add("EmployeeID");
        dt.Columns.Add("OrderDate", typeof(DateTime));
        dt.Rows.Add(1, 5,new DateTime(2016, 9, 20, 5, 23, 1));
        dt.Rows.Add(2, 6,new DateTime(2016, 10, 20, 10, 23, 2));
        dt.Rows.Add(3, 6, new DateTime(2016, 10, 20, 10, 24, 0));
        dt.Rows.Add(4, 2,new DateTime(2016, 11, 12, 10, 23, 2));
        dt.Rows.Add(5, 2, new DateTime(2016, 8, 17, 9, 11, 3));
        dt.Rows.Add(6, 2, new DateTime(2016, 10, 20, 10, 23, 2));
        ASPxGridView1.DataSource = dt;
        ASPxGridView1.DataBind();
    }

    string displayText = String.Empty;
    DateTime curDate;
    protected void ASPxGridView1_ProcessColumnAutoFilter(object sender, DevExpress.Web.ASPxGridViewAutoFilterEventArgs e)
    {
        if (e.Column.FieldName != "OrderDate")
            return;

        if (e.Kind == DevExpress.Web.GridViewAutoFilterEventKind.CreateCriteria)
            if (DateTime.TryParse(e.Value, CultureInfo.InvariantCulture, DateTimeStyles.None, out curDate))
            {
                BinaryOperator op1 = new BinaryOperator("OrderDate", curDate, BinaryOperatorType.GreaterOrEqual);
                BinaryOperator op2 = new BinaryOperator("OrderDate", curDate.AddMinutes(1), BinaryOperatorType.Less);
                GroupOperator grOp = new GroupOperator(GroupOperatorType.And, op1, op2);
                e.Criteria = grOp;
                displayText = curDate.ToString("dd-MMMM-yyyy hh:mm");
            }

        if (e.Kind == DevExpress.Web.GridViewAutoFilterEventKind.ExtractDisplayText)
            e.Value = displayText;
    }
    protected void ASPxGridView1_AutoFilterCellEditorInitialize(object sender, DevExpress.Web.ASPxGridViewEditorEventArgs e)
    {
        if (e.Column.FieldName != "OrderDate")
            return;
        ASPxDateEdit ed = e.Editor as ASPxDateEdit;
        ed.TimeSectionProperties.Visible=true;
        ed.TimeSectionProperties.TimeEditProperties.EditFormatString="hh:mm";
    }
}