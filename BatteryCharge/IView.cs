using System;
using System.Collections.Generic;


namespace BatteryCharge
{
    /// <summary>
    /// Интерфейс формы, для взаимодействия формы и контроллера
    /// </summary>
    interface IView
    {
        /// <summary>
        /// Событие таймера, вызывает сбор данных и перерисовку
        /// </summary>
        event EventHandler<EventArgs> Tick;

        /// <summary>
        /// Событие смены диапазона выборки данных
        /// </summary>
        event EventHandler<EventArgs> ChangeSelect;

        /// <summary>
        /// Передача процента зарядки батареи 
        /// </summary>
        /// <param name="value">Значение от 0.0 до 1.0</param>
        void SetBatteryPercent(float value);

        /// <summary>
        /// Передача строки - cостояния заряда батареи
        /// </summary>
        /// <param name="value"></param>
        void SetBatteryStatus(string value);

        /// <summary>
        /// Передача строки-cостояния подключения к сети
        /// </summary>
        /// <param name="value"></param>
        void SetPowerStatus(string value);

        /// <summary>
        /// Передача времени сбора информации о батареи
        /// </summary>
        /// <param name="value">Дата и время</param>
        void SetCurrent(DateTime value);

        /// <summary>
        /// Передача диапазона данных батареи
        /// </summary>
        /// <param name="listTable"></param>
        void SetListDataBattery(List<DataTableType> listTable);
    }
}
