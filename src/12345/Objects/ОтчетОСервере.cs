﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.12345
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Отчет о сервере.
    /// </summary>
    // *** Start programmer edit section *** (ОтчетОСервере CustomAttributes)

    // *** End programmer edit section *** (ОтчетОСервере CustomAttributes)
    [AutoAltered()]
    [Caption("Отчет о сервере")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ОтчетОСервереE", new string[] {
            "Режим as \'Режим\'",
            "Расположение as \'Расположение\'",
            "Расположение.Адрес as \'Адрес\'",
            "Серверная as \'Серверная\'",
            "Серверная.Протокол as \'Протокол\'"}, Hidden=new string[] {
            "Расположение.Адрес",
            "Серверная.Протокол"})]
    [MasterViewDefineAttribute("ОтчетОСервереE", "Расположение", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Адрес")]
    [MasterViewDefineAttribute("ОтчетОСервереE", "Серверная", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Протокол")]
    [View("ОтчетОСервереL", new string[] {
            "Режим as \'Режим\'",
            "Расположение.Адрес as \'Адрес\'",
            "Серверная.Протокол as \'Протокол\'"})]
    public class ОтчетОСервере : ICSSoft.STORMNET.DataObject
    {
        
        private IIS.12345.РежимСервера fРежим;
        
        private IIS.12345.Расположение fРасположение;
        
        private IIS.12345.Серверная fСерверная;
        
        // *** Start programmer edit section *** (ОтчетОСервере CustomMembers)

        // *** End programmer edit section *** (ОтчетОСервере CustomMembers)

        
        /// <summary>
        /// Режим.
        /// </summary>
        // *** Start programmer edit section *** (ОтчетОСервере.Режим CustomAttributes)

        // *** End programmer edit section *** (ОтчетОСервере.Режим CustomAttributes)
        public virtual IIS.12345.РежимСервера Режим
        {
            get
            {
                // *** Start programmer edit section *** (ОтчетОСервере.Режим Get start)

                // *** End programmer edit section *** (ОтчетОСервере.Режим Get start)
                IIS.12345.РежимСервера result = this.fРежим;
                // *** Start programmer edit section *** (ОтчетОСервере.Режим Get end)

                // *** End programmer edit section *** (ОтчетОСервере.Режим Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ОтчетОСервере.Режим Set start)

                // *** End programmer edit section *** (ОтчетОСервере.Режим Set start)
                this.fРежим = value;
                // *** Start programmer edit section *** (ОтчетОСервере.Режим Set end)

                // *** End programmer edit section *** (ОтчетОСервере.Режим Set end)
            }
        }
        
        /// <summary>
        /// Отчет о сервере.
        /// </summary>
        // *** Start programmer edit section *** (ОтчетОСервере.Расположение CustomAttributes)

        // *** End programmer edit section *** (ОтчетОСервере.Расположение CustomAttributes)
        [PropertyStorage(new string[] {
                "Расположение"})]
        [NotNull()]
        public virtual IIS.12345.Расположение Расположение
        {
            get
            {
                // *** Start programmer edit section *** (ОтчетОСервере.Расположение Get start)

                // *** End programmer edit section *** (ОтчетОСервере.Расположение Get start)
                IIS.12345.Расположение result = this.fРасположение;
                // *** Start programmer edit section *** (ОтчетОСервере.Расположение Get end)

                // *** End programmer edit section *** (ОтчетОСервере.Расположение Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ОтчетОСервере.Расположение Set start)

                // *** End programmer edit section *** (ОтчетОСервере.Расположение Set start)
                this.fРасположение = value;
                // *** Start programmer edit section *** (ОтчетОСервере.Расположение Set end)

                // *** End programmer edit section *** (ОтчетОСервере.Расположение Set end)
            }
        }
        
        /// <summary>
        /// Отчет о сервере.
        /// </summary>
        // *** Start programmer edit section *** (ОтчетОСервере.Серверная CustomAttributes)

        // *** End programmer edit section *** (ОтчетОСервере.Серверная CustomAttributes)
        [PropertyStorage(new string[] {
                "Серверная"})]
        [NotNull()]
        public virtual IIS.12345.Серверная Серверная
        {
            get
            {
                // *** Start programmer edit section *** (ОтчетОСервере.Серверная Get start)

                // *** End programmer edit section *** (ОтчетОСервере.Серверная Get start)
                IIS.12345.Серверная result = this.fСерверная;
                // *** Start programmer edit section *** (ОтчетОСервере.Серверная Get end)

                // *** End programmer edit section *** (ОтчетОСервере.Серверная Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ОтчетОСервере.Серверная Set start)

                // *** End programmer edit section *** (ОтчетОСервере.Серверная Set start)
                this.fСерверная = value;
                // *** Start programmer edit section *** (ОтчетОСервере.Серверная Set end)

                // *** End programmer edit section *** (ОтчетОСервере.Серверная Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ОтчетОСервереE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ОтчетОСервереE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ОтчетОСервереE", typeof(IIS.12345.ОтчетОСервере));
                }
            }
            
            /// <summary>
            /// "ОтчетОСервереL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ОтчетОСервереL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ОтчетОСервереL", typeof(IIS.12345.ОтчетОСервере));
                }
            }
        }
    }
}
