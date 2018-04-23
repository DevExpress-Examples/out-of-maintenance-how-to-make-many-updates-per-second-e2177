using System.Collections.Generic;
using System.Windows;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Markup;
using System.Windows.Media;
using System.ComponentModel;
using System;
using System.Windows.Threading;
using System.Windows.Forms;
using DevExpress.Data;


namespace DXGrid_ConditionalFormatting {
    public partial class Window1 : Window {
        const int DataSourceRowCount = 10000;
        const int RefreshDataIntervalInMilliseconds = 1;
        const int UpdatedCellsCount = 10000;

        List<SampleData> list = new List<SampleData>();
        Random rnd = new Random();
        Timer timer = new Timer();
        long lastSecond = Environment.TickCount;
        int refreshCount;
        public Window1() {
            InitializeComponent();
            for(int i = 0; i < DataSourceRowCount; i++) {
                list.Add(new SampleData());
            }
            grid.DataSource = list;
            Loaded += new RoutedEventHandler(Window1_Loaded);
        }

        void Window1_Loaded(object sender, RoutedEventArgs e) {
            timer.Interval = RefreshDataIntervalInMilliseconds;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        void timer_Tick(object sender, EventArgs e) {
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(SampleData));
            for(int i = 0; i < UpdatedCellsCount; i++) {
                list[rnd.Next(list.Count)].SetValue(rnd.Next(properties.Count), rnd.Next(100000));
            }
            if(!refreshQueued) {
                refreshQueued = true;
                grid.Dispatcher.BeginInvoke(new Action(RefreshData), DispatcherPriority.ApplicationIdle);
            }
        }
        bool refreshQueued;
        void RefreshData() {
            refreshQueued = false;
            grid.RefreshData();
            int currentTickCount = Environment.TickCount;
            if(currentTickCount - lastSecond > TimeSpan.FromSeconds(1).TotalMilliseconds) {
                refreshCountTextBlock.Text = " " + refreshCount;
                refreshCount = 0;
                lastSecond = currentTickCount;
            }
            refreshCount++;
        }
    }
    public class SampleData {
        int[] values = new int[100];
        #region properties
        public int Property0 { get { return values[0]; } }
        public int Property1 { get { return values[1]; } }
        public int Property2 { get { return values[2]; } }
        public int Property3 { get { return values[3]; } }
        public int Property4 { get { return values[4]; } }
        public int Property5 { get { return values[5]; } }
        public int Property6 { get { return values[6]; } }
        public int Property7 { get { return values[7]; } }
        public int Property8 { get { return values[8]; } }
        public int Property9 { get { return values[9]; } }
        public int Property10 { get { return values[10]; } }
        public int Property11 { get { return values[11]; } }
        public int Property12 { get { return values[12]; } }
        public int Property13 { get { return values[13]; } }
        public int Property14 { get { return values[14]; } }
        public int Property15 { get { return values[15]; } }
        public int Property16 { get { return values[16]; } }
        public int Property17 { get { return values[17]; } }
        public int Property18 { get { return values[18]; } }
        public int Property19 { get { return values[19]; } }
        public int Property20 { get { return values[20]; } }
        public int Property21 { get { return values[21]; } }
        public int Property22 { get { return values[22]; } }
        public int Property23 { get { return values[23]; } }
        public int Property24 { get { return values[24]; } }
        public int Property25 { get { return values[25]; } }
        public int Property26 { get { return values[26]; } }
        public int Property27 { get { return values[27]; } }
        public int Property28 { get { return values[28]; } }
        public int Property29 { get { return values[29]; } }
        public int Property30 { get { return values[30]; } }
        public int Property31 { get { return values[31]; } }
        public int Property32 { get { return values[32]; } }
        public int Property33 { get { return values[33]; } }
        public int Property34 { get { return values[34]; } }
        public int Property35 { get { return values[35]; } }
        public int Property36 { get { return values[36]; } }
        public int Property37 { get { return values[37]; } }
        public int Property38 { get { return values[38]; } }
        public int Property39 { get { return values[39]; } }
        public int Property40 { get { return values[40]; } }
        public int Property41 { get { return values[41]; } }
        public int Property42 { get { return values[42]; } }
        public int Property43 { get { return values[43]; } }
        public int Property44 { get { return values[44]; } }
        public int Property45 { get { return values[45]; } }
        public int Property46 { get { return values[46]; } }
        public int Property47 { get { return values[47]; } }
        public int Property48 { get { return values[48]; } }
        public int Property49 { get { return values[49]; } }
        public int Property50 { get { return values[50]; } }
        public int Property51 { get { return values[51]; } }
        public int Property52 { get { return values[52]; } }
        public int Property53 { get { return values[53]; } }
        public int Property54 { get { return values[54]; } }
        public int Property55 { get { return values[55]; } }
        public int Property56 { get { return values[56]; } }
        public int Property57 { get { return values[57]; } }
        public int Property58 { get { return values[58]; } }
        public int Property59 { get { return values[59]; } }
        public int Property60 { get { return values[60]; } }
        public int Property61 { get { return values[61]; } }
        public int Property62 { get { return values[62]; } }
        public int Property63 { get { return values[63]; } }
        public int Property64 { get { return values[64]; } }
        public int Property65 { get { return values[65]; } }
        public int Property66 { get { return values[66]; } }
        public int Property67 { get { return values[67]; } }
        public int Property68 { get { return values[68]; } }
        public int Property69 { get { return values[69]; } }
        public int Property70 { get { return values[70]; } }
        public int Property71 { get { return values[71]; } }
        public int Property72 { get { return values[72]; } }
        public int Property73 { get { return values[73]; } }
        public int Property74 { get { return values[74]; } }
        public int Property75 { get { return values[75]; } }
        public int Property76 { get { return values[76]; } }
        public int Property77 { get { return values[77]; } }
        public int Property78 { get { return values[78]; } }
        public int Property79 { get { return values[79]; } }
        public int Property80 { get { return values[80]; } }
        public int Property81 { get { return values[81]; } }
        public int Property82 { get { return values[82]; } }
        public int Property83 { get { return values[83]; } }
        public int Property84 { get { return values[84]; } }
        public int Property85 { get { return values[85]; } }
        public int Property86 { get { return values[86]; } }
        public int Property87 { get { return values[87]; } }
        public int Property88 { get { return values[88]; } }
        public int Property89 { get { return values[89]; } }
        public int Property90 { get { return values[90]; } }
        public int Property91 { get { return values[91]; } }
        public int Property92 { get { return values[92]; } }
        public int Property93 { get { return values[93]; } }
        public int Property94 { get { return values[94]; } }
        public int Property95 { get { return values[95]; } }
        public int Property96 { get { return values[96]; } }
        public int Property97 { get { return values[97]; } }
        public int Property98 { get { return values[98]; } }
        public int Property99 { get { return values[99]; } }
        #endregion properties
        public void SetValue(int index, int value) {
            values[index] = value;
        }
    }
}
