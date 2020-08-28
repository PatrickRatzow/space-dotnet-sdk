// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
#pragma warning disable CS0108

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    public sealed class TDWorkingDays
         : IPropagatePropertyAccessPath
    {
        public TDWorkingDays() { }
        
        public TDWorkingDays(string id, WorkingDaysSpec workingDaysSpec, SpaceDate? dateStart = null, SpaceDate? dateEnd = null)
        {
            Id = id;
            DateStart = dateStart;
            DateEnd = dateEnd;
            WorkingDaysSpec = workingDaysSpec;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(TDWorkingDays), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get { return _id.GetValue(); }
            set { _id.SetValue(value); }
        }
    
        private PropertyValue<SpaceDate?> _dateStart = new PropertyValue<SpaceDate?>(nameof(TDWorkingDays), nameof(DateStart));
        
        [JsonPropertyName("dateStart")]
        public SpaceDate? DateStart
        {
            get { return _dateStart.GetValue(); }
            set { _dateStart.SetValue(value); }
        }
    
        private PropertyValue<SpaceDate?> _dateEnd = new PropertyValue<SpaceDate?>(nameof(TDWorkingDays), nameof(DateEnd));
        
        [JsonPropertyName("dateEnd")]
        public SpaceDate? DateEnd
        {
            get { return _dateEnd.GetValue(); }
            set { _dateEnd.SetValue(value); }
        }
    
        private PropertyValue<WorkingDaysSpec> _workingDaysSpec = new PropertyValue<WorkingDaysSpec>(nameof(TDWorkingDays), nameof(WorkingDaysSpec));
        
        [Required]
        [JsonPropertyName("workingDaysSpec")]
        public WorkingDaysSpec WorkingDaysSpec
        {
            get { return _workingDaysSpec.GetValue(); }
            set { _workingDaysSpec.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _dateStart.SetAccessPath(path, validateHasBeenSet);
            _dateEnd.SetAccessPath(path, validateHasBeenSet);
            _workingDaysSpec.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
