<!-- default file list -->
*Files to look at*:

* [Window1.xaml](./CS/DXGrid_ConditionalFormatting/Window1.xaml) (VB: [Window1.xaml](./VB/DXGrid_ConditionalFormatting/Window1.xaml))
* [Window1.xaml.cs](./CS/DXGrid_ConditionalFormatting/Window1.xaml.cs) (VB: [Window1.xaml.vb](./VB/DXGrid_ConditionalFormatting/Window1.xaml.vb))
<!-- default file list end -->
# How to make many updates per second


<p>If the GridControl DataSource is updated quite often, for example, 100 times per second, the GridControl itself does not have time to finish its updates. To prevent an unresponsive state, or any artifacts, we suggest the following technique to receive many updates.</p>
<p>Assign the IList DataSource to the GridControl.DataSource. By default, the IList collection doesn't send any notification about changes, to the GridControl (objects in the collection shouldn't implement the INotifyPropertyChanged interface either). As a result, the GridControl won't perform any updates until you call the RefreshData method. The best time to call this method is when the application is in the idle state. Call the RefreshData method via the Dispatcher, with a low priority. Please note that in the sample, new values for cells are assigned using the SetValue method, because using the PropertyDescriptor decreases performance. Also, the sample shows the GridControl number of updates per second.</p>
<p>Another approach is to create two collections. The first one should be assigned to the GridControl.DataSource, and the second one should be updated when necessary. Then when the application is in the idle state, synchronize the GridControl.DataSource collection with the second collection (use the BeginDataUpdate/EndDataUpdate methods to improve the grid's performance).<br /><br /></p>
<p><strong>Update: For now we have a <a href="https://documentation.devexpress.com/#CoreLibraries/clsDevExpressDataRealTimeSourcetopic">RealTimeSource</a> data source, which was created to accomplish this task. You can see it in action in our demo center: WPF - DataGrid - RealTime Data Processing.</strong></p>

<br/>


