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
    /// Серверная.
    /// </summary>
    // *** Start programmer edit section *** (Серверная CustomAttributes)

    // *** End programmer edit section *** (Серверная CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("СервернаяE", new string[] {
            "Протокол as \'Протокол\'",
            "Настройки as \'Настройки\'",
            "IP as \'IP\'",
            "Порт as \'Порт\'",
            "Сотрудник as \'Сотрудник\'",
            "Сотрудник.Имя as \'Имя\'"}, Hidden=new string[] {
            "Сотрудник.Имя"})]
    [AssociatedDetailViewAttribute("СервернаяE", "Контроллер", "КонтроллерE", true, "", "Контроллер", true, new string[] {
            ""})]
    [MasterViewDefineAttribute("СервернаяE", "Сотрудник", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Имя")]
    [View("СервернаяL", new string[] {
            "Протокол as \'Протокол\'",
            "Настройки as \'Настройки\'",
            "IP as \'IP\'",
            "Порт as \'Порт\'",
            "Сотрудник.Имя as \'Имя\'"})]
    public class Серверная : ICSSoft.STORMNET.DataObject
    {
        
        private string fПротокол;
        
        private string fIP;
        
        private string fНастройки;
        
        private int fПорт;
        
        private IIS.12345.Сотрудник fСотрудник;
        
        private IIS.12345.DetailArrayOfКонтроллер fКонтроллер;
        
        // *** Start programmer edit section *** (Серверная CustomMembers)

        // *** End programmer edit section *** (Серверная CustomMembers)

        
        /// <summary>
        /// IP.
        /// </summary>
        // *** Start programmer edit section *** (Серверная.IP CustomAttributes)

        // *** End programmer edit section *** (Серверная.IP CustomAttributes)
        [StrLen(255)]
        public virtual string IP
        {
            get
            {
                // *** Start programmer edit section *** (Серверная.IP Get start)

                // *** End programmer edit section *** (Серверная.IP Get start)
                string result = this.fIP;
                // *** Start programmer edit section *** (Серверная.IP Get end)

                // *** End programmer edit section *** (Серверная.IP Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Серверная.IP Set start)

                // *** End programmer edit section *** (Серверная.IP Set start)
                this.fIP = value;
                // *** Start programmer edit section *** (Серверная.IP Set end)

                // *** End programmer edit section *** (Серверная.IP Set end)
            }
        }
        
        /// <summary>
        /// Настройки.
        /// </summary>
        // *** Start programmer edit section *** (Серверная.Настройки CustomAttributes)

        // *** End programmer edit section *** (Серверная.Настройки CustomAttributes)
        [StrLen(255)]
        public virtual string Настройки
        {
            get
            {
                // *** Start programmer edit section *** (Серверная.Настройки Get start)

                // *** End programmer edit section *** (Серверная.Настройки Get start)
                string result = this.fНастройки;
                // *** Start programmer edit section *** (Серверная.Настройки Get end)

                // *** End programmer edit section *** (Серверная.Настройки Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Серверная.Настройки Set start)

                // *** End programmer edit section *** (Серверная.Настройки Set start)
                this.fНастройки = value;
                // *** Start programmer edit section *** (Серверная.Настройки Set end)

                // *** End programmer edit section *** (Серверная.Настройки Set end)
            }
        }
        
        /// <summary>
        /// Порт.
        /// </summary>
        // *** Start programmer edit section *** (Серверная.Порт CustomAttributes)

        // *** End programmer edit section *** (Серверная.Порт CustomAttributes)
        public virtual int Порт
        {
            get
            {
                // *** Start programmer edit section *** (Серверная.Порт Get start)

                // *** End programmer edit section *** (Серверная.Порт Get start)
                int result = this.fПорт;
                // *** Start programmer edit section *** (Серверная.Порт Get end)

                // *** End programmer edit section *** (Серверная.Порт Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Серверная.Порт Set start)

                // *** End programmer edit section *** (Серверная.Порт Set start)
                this.fПорт = value;
                // *** Start programmer edit section *** (Серверная.Порт Set end)

                // *** End programmer edit section *** (Серверная.Порт Set end)
            }
        }
        
        /// <summary>
        /// Протокол.
        /// </summary>
        // *** Start programmer edit section *** (Серверная.Протокол CustomAttributes)

        // *** End programmer edit section *** (Серверная.Протокол CustomAttributes)
        [StrLen(255)]
        public virtual string Протокол
        {
            get
            {
                // *** Start programmer edit section *** (Серверная.Протокол Get start)

                // *** End programmer edit section *** (Серверная.Протокол Get start)
                string result = this.fПротокол;
                // *** Start programmer edit section *** (Серверная.Протокол Get end)

                // *** End programmer edit section *** (Серверная.Протокол Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Серверная.Протокол Set start)

                // *** End programmer edit section *** (Серверная.Протокол Set start)
                this.fПротокол = value;
                // *** Start programmer edit section *** (Серверная.Протокол Set end)

                // *** End programmer edit section *** (Серверная.Протокол Set end)
            }
        }
        
        /// <summary>
        /// Серверная.
        /// </summary>
        // *** Start programmer edit section *** (Серверная.Сотрудник CustomAttributes)

        // *** End programmer edit section *** (Серверная.Сотрудник CustomAttributes)
        [PropertyStorage(new string[] {
                "Сотрудник"})]
        [NotNull()]
        public virtual IIS.12345.Сотрудник Сотрудник
        {
            get
            {
                // *** Start programmer edit section *** (Серверная.Сотрудник Get start)

                // *** End programmer edit section *** (Серверная.Сотрудник Get start)
                IIS.12345.Сотрудник result = this.fСотрудник;
                // *** Start programmer edit section *** (Серверная.Сотрудник Get end)

                // *** End programmer edit section *** (Серверная.Сотрудник Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Серверная.Сотрудник Set start)

                // *** End programmer edit section *** (Серверная.Сотрудник Set start)
                this.fСотрудник = value;
                // *** Start programmer edit section *** (Серверная.Сотрудник Set end)

                // *** End programmer edit section *** (Серверная.Сотрудник Set end)
            }
        }
        
        /// <summary>
        /// Серверная.
        /// </summary>
        // *** Start programmer edit section *** (Серверная.Контроллер CustomAttributes)

        // *** End programmer edit section *** (Серверная.Контроллер CustomAttributes)
        public virtual IIS.12345.DetailArrayOfКонтроллер Контроллер
        {
            get
            {
                // *** Start programmer edit section *** (Серверная.Контроллер Get start)

                // *** End programmer edit section *** (Серверная.Контроллер Get start)
                if ((this.fКонтроллер == null))
                {
                    this.fКонтроллер = new IIS.12345.DetailArrayOfКонтроллер(this);
                }
                IIS.12345.DetailArrayOfКонтроллер result = this.fКонтроллер;
                // *** Start programmer edit section *** (Серверная.Контроллер Get end)

                // *** End programmer edit section *** (Серверная.Контроллер Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Серверная.Контроллер Set start)

                // *** End programmer edit section *** (Серверная.Контроллер Set start)
                this.fКонтроллер = value;
                // *** Start programmer edit section *** (Серверная.Контроллер Set end)

                // *** End programmer edit section *** (Серверная.Контроллер Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "СервернаяE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View СервернаяE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("СервернаяE", typeof(IIS.12345.Серверная));
                }
            }
            
            /// <summary>
            /// "СервернаяL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View СервернаяL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("СервернаяL", typeof(IIS.12345.Серверная));
                }
            }
        }
    }
}
