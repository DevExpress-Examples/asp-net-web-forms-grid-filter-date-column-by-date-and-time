<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128534195/16.1.7%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T446517)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/Default.aspx) (VB: [Default.aspx](./VB/Default.aspx))
* [Default.aspx.cs](./CS/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/Default.aspx.vb))
<!-- default file list end -->
# ASPxGridView - How to filter a date column by both date and time in the auto filter row
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/t446517/)**
<!-- run online end -->


By default, GridViewDataDateColumn filters data by string and cuts off information about minutes and seconds (keeping only the hour part). <br>As a solution, you can modify the filter criteria in the <a href="https://documentation.devexpress.com/#AspNet/DevExpressWebASPxGridView_ProcessColumnAutoFiltertopic">ASPxGridView.ProcessColumnAutoFilter</a> event handler to keep the time part in the filter row date values and take the time part into account when filtering.<br><br>To allow the user to define both date and time in the filter row not only by manually typing them in the input but also by using the date editor shown in the drop down, use the <a href="https://documentation.devexpress.com/#AspNet/DevExpressWebASPxGridView_AutoFilterCellEditorInitializetopic">ASPxGridView.AutoFilterCellEditorInitialize</a> event. Access the default ASPxDateEdit control displayed in the drop down and enable its time section by setting the TimeSectionProperties.Visible property to true.

<br/>


