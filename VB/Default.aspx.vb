Imports Microsoft.VisualBasic
Imports DevExpress.Data.Filtering
Imports DevExpress.Web
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Globalization
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
		Dim dt As New DataTable()
		dt.Columns.Add("OrderID")
		dt.Columns.Add("EmployeeID")
		dt.Columns.Add("OrderDate", GetType(DateTime))
		dt.Rows.Add(1, 5,New DateTime(2016, 9, 20, 5, 23, 1))
		dt.Rows.Add(2, 6,New DateTime(2016, 10, 20, 10, 23, 2))
		dt.Rows.Add(3, 6, New DateTime(2016, 10, 20, 10, 24, 0))
		dt.Rows.Add(4, 2,New DateTime(2016, 11, 12, 10, 23, 2))
		dt.Rows.Add(5, 2, New DateTime(2016, 8, 17, 9, 11, 3))
		dt.Rows.Add(6, 2, New DateTime(2016, 10, 20, 10, 23, 2))
		ASPxGridView1.DataSource = dt
		ASPxGridView1.DataBind()
	End Sub

	Private displayText As String = String.Empty
	Private curDate As DateTime
	Protected Sub ASPxGridView1_ProcessColumnAutoFilter(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewAutoFilterEventArgs)
		If e.Column.FieldName <> "OrderDate" Then
			Return
		End If

		If e.Kind = DevExpress.Web.GridViewAutoFilterEventKind.CreateCriteria Then
			If DateTime.TryParse(e.Value, CultureInfo.InvariantCulture, DateTimeStyles.None, curDate) Then
				Dim op1 As New BinaryOperator("OrderDate", curDate, BinaryOperatorType.GreaterOrEqual)
				Dim op2 As New BinaryOperator("OrderDate", curDate.AddMinutes(1), BinaryOperatorType.Less)
				Dim grOp As New GroupOperator(GroupOperatorType.And, op1, op2)
				e.Criteria = grOp
				displayText = curDate.ToString("dd-MMMM-yyyy hh:mm")
			End If
		End If

		If e.Kind = DevExpress.Web.GridViewAutoFilterEventKind.ExtractDisplayText Then
			e.Value = displayText
		End If
	End Sub
	Protected Sub ASPxGridView1_AutoFilterCellEditorInitialize(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewEditorEventArgs)
		If e.Column.FieldName <> "OrderDate" Then
			Return
		End If
		Dim ed As ASPxDateEdit = TryCast(e.Editor, ASPxDateEdit)
		ed.TimeSectionProperties.Visible=True
		ed.TimeSectionProperties.TimeEditProperties.EditFormatString="hh:mm"
	End Sub
End Class