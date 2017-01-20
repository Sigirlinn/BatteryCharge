using System;
using System.Collections.Generic;

namespace BatteryCharge
{
    public struct DataTableType
    {
        public DateTime Current;
        public float BatteryPercent;
        public string BatteryStatus;
        public string PowerStatus;
        public DataTableType(DateTime current, float batteryPercent, string batteryStatus, string powerStatus)
        {
            Current = current;
            BatteryPercent = batteryPercent;
            BatteryStatus = batteryStatus;
            PowerStatus = powerStatus;
        }
    }

    class Presenter
    {
        
        private View view;
        private Battery battery = new Battery();
        private SqlDB sqlBD = new SqlDB();
        private List<DataTableType> listTable;
        private int typeSelect = 0;   


        public Presenter(View view)
        {
            this.view = view;
            this.view.Tick += View_tick;
            this.view.ChangeSelect += View_changeSelect;
        }

        private void View_changeSelect(object sender, EventArgs e)
        {
            typeSelect = (int)sender;
        }

        private void View_tick(object sender, EventArgs e)
        {
            battery.GatherData();
            view.SetBatteryPercent(battery.BatteryPercent);
            view.SetBatteryStatus(battery.BatteryStatus);
            view.SetCurrent(battery.Current);
            view.SetPowerStatus(battery.PowerStatus);
            sqlBD.Create();
            sqlBD.Insert(battery.Current, battery.BatteryPercent, battery.BatteryStatus, battery.PowerStatus);
            switch (typeSelect)
            {
                case 0:
                    {
                        listTable = sqlBD.Select();
                        break;
                    }
                case 1:
                    {
                        listTable = sqlBD.Select(DateTime.Now.AddHours(-1), DateTime.Now);
                        break;
                    }
                case 2:
                    {
                        listTable = sqlBD.Select(DateTime.Now.AddHours(-24), DateTime.Now);
                        break;
                    }
            }
            view.SetListDataBattery(listTable);
            
        }
    }
}
