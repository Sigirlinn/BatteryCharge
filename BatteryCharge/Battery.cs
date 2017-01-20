using System;
using System.Windows.Forms;

namespace BatteryCharge
{
    class Battery
    {
        /// <summary>Cведения о состоянии батареи</summary>
        private PowerStatus batteryState;
        /// <summary>Время снятия показаний батареи</summary>
        private DateTime current;

        /// <summary>Собрать данные о батареи</summary>
        public void GatherData()
        {
            batteryState = SystemInformation.PowerStatus;
            current = DateTime.Now;
        }

        /// <summary> Остаток заряда батареи (0.0 .. 1.0)</summary>
        public float BatteryPercent
        {
            get { return batteryState.BatteryLifePercent; }
        }

        /// <summary>
        /// Состояние заряда батареи: Charging, Critical, 
        /// High, Low, NoSystemBattery, Unknown
        /// </summary>
        public string BatteryStatus
        {
            get { return batteryState.BatteryChargeStatus.ToString(); }
        }

        /// <summary>
        /// Состояние подключения компьютера к электрической сети: Offline, Online, Unknown
        /// </summary>
        public string PowerStatus
        {
            get { return batteryState.PowerLineStatus.ToString(); }
        }

        /// <summary>Время снятия показаний батареи</summary>
        public DateTime Current
        {
            get { return current; }
        }

    }
}
