﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.Kurs3
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Выгр док.
    /// </summary>
    // *** Start programmer edit section *** (ВыгрДок CustomAttributes)

    // *** End programmer edit section *** (ВыгрДок CustomAttributes)
    [AutoAltered()]
    [Caption("Выгрузка документа")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ВыгрДокE", new string[] {
            "NewName as \'Новое имя файла\'",
            "Репозиторий as \'Репозиторий\'",
            "Конвертация as \'Конвертация\'",
            "Конвертация.ИмяДок as \'Имя документа\'"}, Hidden=new string[] {
            "Конвертация.ИмяДок"})]
    [MasterViewDefineAttribute("ВыгрДокE", "Конвертация", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "ИмяДок")]
    [View("ВыгрДокL", new string[] {
            "NewName as \'Новое имя файла\'",
            "Репозиторий as \'Репозиторий\'",
            "Конвертация.ИмяДок as \'Имя документа\'"})]
    public class ВыгрДок : ICSSoft.STORMNET.DataObject
    {
        
        private string fNewName;
        
        private string fРепозиторий;
        
        private IIS.Kurs3.Конвертация fКонвертация;
        
        // *** Start programmer edit section *** (ВыгрДок CustomMembers)

        // *** End programmer edit section *** (ВыгрДок CustomMembers)

        
        /// <summary>
        /// NewName.
        /// </summary>
        // *** Start programmer edit section *** (ВыгрДок.NewName CustomAttributes)

        // *** End programmer edit section *** (ВыгрДок.NewName CustomAttributes)
        [StrLen(255)]
        public virtual string NewName
        {
            get
            {
                // *** Start programmer edit section *** (ВыгрДок.NewName Get start)

                // *** End programmer edit section *** (ВыгрДок.NewName Get start)
                string result = this.fNewName;
                // *** Start programmer edit section *** (ВыгрДок.NewName Get end)

                // *** End programmer edit section *** (ВыгрДок.NewName Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ВыгрДок.NewName Set start)

                // *** End programmer edit section *** (ВыгрДок.NewName Set start)
                this.fNewName = value;
                // *** Start programmer edit section *** (ВыгрДок.NewName Set end)

                // *** End programmer edit section *** (ВыгрДок.NewName Set end)
            }
        }
        
        /// <summary>
        /// Репозиторий.
        /// </summary>
        // *** Start programmer edit section *** (ВыгрДок.Репозиторий CustomAttributes)

        // *** End programmer edit section *** (ВыгрДок.Репозиторий CustomAttributes)
        [StrLen(255)]
        public virtual string Репозиторий
        {
            get
            {
                // *** Start programmer edit section *** (ВыгрДок.Репозиторий Get start)

                // *** End programmer edit section *** (ВыгрДок.Репозиторий Get start)
                string result = this.fРепозиторий;
                // *** Start programmer edit section *** (ВыгрДок.Репозиторий Get end)

                // *** End programmer edit section *** (ВыгрДок.Репозиторий Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ВыгрДок.Репозиторий Set start)

                // *** End programmer edit section *** (ВыгрДок.Репозиторий Set start)
                this.fРепозиторий = value;
                // *** Start programmer edit section *** (ВыгрДок.Репозиторий Set end)

                // *** End programmer edit section *** (ВыгрДок.Репозиторий Set end)
            }
        }
        
        /// <summary>
        /// Выгр док.
        /// </summary>
        // *** Start programmer edit section *** (ВыгрДок.Конвертация CustomAttributes)

        // *** End programmer edit section *** (ВыгрДок.Конвертация CustomAttributes)
        [PropertyStorage(new string[] {
                "Конвертация"})]
        [NotNull()]
        public virtual IIS.Kurs3.Конвертация Конвертация
        {
            get
            {
                // *** Start programmer edit section *** (ВыгрДок.Конвертация Get start)

                // *** End programmer edit section *** (ВыгрДок.Конвертация Get start)
                IIS.Kurs3.Конвертация result = this.fКонвертация;
                // *** Start programmer edit section *** (ВыгрДок.Конвертация Get end)

                // *** End programmer edit section *** (ВыгрДок.Конвертация Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ВыгрДок.Конвертация Set start)

                // *** End programmer edit section *** (ВыгрДок.Конвертация Set start)
                this.fКонвертация = value;
                // *** Start programmer edit section *** (ВыгрДок.Конвертация Set end)

                // *** End programmer edit section *** (ВыгрДок.Конвертация Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ВыгрДокE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ВыгрДокE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ВыгрДокE", typeof(IIS.Kurs3.ВыгрДок));
                }
            }
            
            /// <summary>
            /// "ВыгрДокL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ВыгрДокL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ВыгрДокL", typeof(IIS.Kurs3.ВыгрДок));
                }
            }
        }
    }
}
