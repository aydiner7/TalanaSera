//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TalanaWebApi.Models.Orm
{
    using System;
    using System.Collections.Generic;
    
    public partial class SuMotorLog
    {
        public int SuMotorLog_ID { get; set; }
        public int SuMotor_ID { get; set; }
        public string SuMotorLog_PwmDeger { get; set; }
        public byte[] SuMotorLog_MotorAkim { get; set; }
        public string SuMotorLog_AkisDeger { get; set; }
        public string SuMotorLog_BasincDeger { get; set; }
        public System.DateTime SuMotorLog_Tarih { get; set; }
    
        public virtual SuMotor SuMotor { get; set; }
    }
}
