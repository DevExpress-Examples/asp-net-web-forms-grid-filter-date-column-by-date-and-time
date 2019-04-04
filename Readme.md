<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/Default.aspx) (VB: [Default.aspx](./VB/Default.aspx))
* [Default.aspx.cs](./CS/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/Default.aspx.vb))
<!-- default file list end -->
# ASPxGridView - How to filter a date column by both date and time in the auto filter row


By default, GridViewDataDateColumn filters data by string and cuts off information about minutes and seconds (keeping only the hour part). <br>As a solution, you can modify the filter criteria in the <a href="https://documentation.devexpress.com/#AspNet/DevExpressWebASPxGridView_ProcessColumnAutoFiltertopic">ASPxGridView.ProcessColumnAutoFilter</a> event handler to keep the time part in the filter row date values and take the time part into account when filtering.<br><br>To allow the user to define both date and time in the filter row not only by manually typing them in the input but also by using the date editor shown in the drop down, use the <a href="https://documentation.devexpress.com/#AspNet/DevExpressWebASPxGridView_AutoFilterCellEditorInitializetopic">ASPxGridView.AutoFilterCellEditorInitialize</a> event. Access the default ASPxDateEdit control displayed in the drop down and enable its time section by setting the TimeSectionProperties.Visible property to true.

<br/>


