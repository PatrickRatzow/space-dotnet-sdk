// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    public sealed class BillingInfoDto
         : IPropagatePropertyAccessPath
    {
        public BillingInfoDto() { }
        
        public BillingInfoDto(BilledItemsDto billedItems, PlanLimitsDto planLimits, SpaceDate orgCreationDate, MoneyDto? overdraft = null)
        {
            BilledItems = billedItems;
            PlanLimits = planLimits;
            OrgCreationDate = orgCreationDate;
            Overdraft = overdraft;
        }
        
        private PropertyValue<BilledItemsDto> _billedItems = new PropertyValue<BilledItemsDto>(nameof(BillingInfoDto), nameof(BilledItems));
        
        [Required]
        [JsonPropertyName("billedItems")]
        public BilledItemsDto BilledItems
        {
            get { return _billedItems.GetValue(); }
            set { _billedItems.SetValue(value); }
        }
    
        private PropertyValue<PlanLimitsDto> _planLimits = new PropertyValue<PlanLimitsDto>(nameof(BillingInfoDto), nameof(PlanLimits));
        
        [Required]
        [JsonPropertyName("planLimits")]
        public PlanLimitsDto PlanLimits
        {
            get { return _planLimits.GetValue(); }
            set { _planLimits.SetValue(value); }
        }
    
        private PropertyValue<SpaceDate> _orgCreationDate = new PropertyValue<SpaceDate>(nameof(BillingInfoDto), nameof(OrgCreationDate));
        
        [Required]
        [JsonPropertyName("orgCreationDate")]
        public SpaceDate OrgCreationDate
        {
            get { return _orgCreationDate.GetValue(); }
            set { _orgCreationDate.SetValue(value); }
        }
    
        private PropertyValue<MoneyDto?> _overdraft = new PropertyValue<MoneyDto?>(nameof(BillingInfoDto), nameof(Overdraft));
        
        [JsonPropertyName("overdraft")]
        public MoneyDto? Overdraft
        {
            get { return _overdraft.GetValue(); }
            set { _overdraft.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _billedItems.SetAccessPath(path, validateHasBeenSet);
            _planLimits.SetAccessPath(path, validateHasBeenSet);
            _orgCreationDate.SetAccessPath(path, validateHasBeenSet);
            _overdraft.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
