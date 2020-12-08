// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
#pragma warning disable CS1591
#pragma warning disable CS0108

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client
{
    public sealed class JobExecution
         : IPropagatePropertyAccessPath
    {
        public JobExecution() { }
        
        public JobExecution(string executionId, long executionNumber, string jobId, string jobName, string branch, ExecutionStatus status, long triggeredTime, string changesFromExclude, int changesCount, List<FailureCondition> failureConditions, long? startedTime = null, long? finishedTime = null, Estimation? predictedEndTime = null)
        {
            ExecutionId = executionId;
            ExecutionNumber = executionNumber;
            JobId = jobId;
            JobName = jobName;
            Branch = branch;
            Status = status;
            TriggeredTime = triggeredTime;
            StartedTime = startedTime;
            FinishedTime = finishedTime;
            ChangesFromExclude = changesFromExclude;
            ChangesCount = changesCount;
            PredictedEndTime = predictedEndTime;
            FailureConditions = failureConditions;
        }
        
        private PropertyValue<string> _executionId = new PropertyValue<string>(nameof(JobExecution), nameof(ExecutionId));
        
        [Required]
        [JsonPropertyName("executionId")]
        public string ExecutionId
        {
            get => _executionId.GetValue();
            set => _executionId.SetValue(value);
        }
    
        private PropertyValue<long> _executionNumber = new PropertyValue<long>(nameof(JobExecution), nameof(ExecutionNumber));
        
        [Required]
        [JsonPropertyName("executionNumber")]
        public long ExecutionNumber
        {
            get => _executionNumber.GetValue();
            set => _executionNumber.SetValue(value);
        }
    
        private PropertyValue<string> _jobId = new PropertyValue<string>(nameof(JobExecution), nameof(JobId));
        
        [Required]
        [JsonPropertyName("jobId")]
        public string JobId
        {
            get => _jobId.GetValue();
            set => _jobId.SetValue(value);
        }
    
        private PropertyValue<string> _jobName = new PropertyValue<string>(nameof(JobExecution), nameof(JobName));
        
        [Required]
        [JsonPropertyName("jobName")]
        public string JobName
        {
            get => _jobName.GetValue();
            set => _jobName.SetValue(value);
        }
    
        private PropertyValue<string> _branch = new PropertyValue<string>(nameof(JobExecution), nameof(Branch));
        
        [Required]
        [JsonPropertyName("branch")]
        public string Branch
        {
            get => _branch.GetValue();
            set => _branch.SetValue(value);
        }
    
        private PropertyValue<ExecutionStatus> _status = new PropertyValue<ExecutionStatus>(nameof(JobExecution), nameof(Status));
        
        [Required]
        [JsonPropertyName("status")]
        public ExecutionStatus Status
        {
            get => _status.GetValue();
            set => _status.SetValue(value);
        }
    
        private PropertyValue<long> _triggeredTime = new PropertyValue<long>(nameof(JobExecution), nameof(TriggeredTime));
        
        [Required]
        [JsonPropertyName("triggeredTime")]
        public long TriggeredTime
        {
            get => _triggeredTime.GetValue();
            set => _triggeredTime.SetValue(value);
        }
    
        private PropertyValue<long?> _startedTime = new PropertyValue<long?>(nameof(JobExecution), nameof(StartedTime));
        
        [JsonPropertyName("startedTime")]
        public long? StartedTime
        {
            get => _startedTime.GetValue();
            set => _startedTime.SetValue(value);
        }
    
        private PropertyValue<long?> _finishedTime = new PropertyValue<long?>(nameof(JobExecution), nameof(FinishedTime));
        
        [JsonPropertyName("finishedTime")]
        public long? FinishedTime
        {
            get => _finishedTime.GetValue();
            set => _finishedTime.SetValue(value);
        }
    
        private PropertyValue<string> _changesFromExclude = new PropertyValue<string>(nameof(JobExecution), nameof(ChangesFromExclude));
        
        [Required]
        [JsonPropertyName("changesFromExclude")]
        public string ChangesFromExclude
        {
            get => _changesFromExclude.GetValue();
            set => _changesFromExclude.SetValue(value);
        }
    
        private PropertyValue<int> _changesCount = new PropertyValue<int>(nameof(JobExecution), nameof(ChangesCount));
        
        [Required]
        [JsonPropertyName("changesCount")]
        public int ChangesCount
        {
            get => _changesCount.GetValue();
            set => _changesCount.SetValue(value);
        }
    
        private PropertyValue<Estimation?> _predictedEndTime = new PropertyValue<Estimation?>(nameof(JobExecution), nameof(PredictedEndTime));
        
        [JsonPropertyName("predictedEndTime")]
        public Estimation? PredictedEndTime
        {
            get => _predictedEndTime.GetValue();
            set => _predictedEndTime.SetValue(value);
        }
    
        private PropertyValue<List<FailureCondition>> _failureConditions = new PropertyValue<List<FailureCondition>>(nameof(JobExecution), nameof(FailureConditions));
        
        [Required]
        [JsonPropertyName("failureConditions")]
        public List<FailureCondition> FailureConditions
        {
            get => _failureConditions.GetValue();
            set => _failureConditions.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _executionId.SetAccessPath(path, validateHasBeenSet);
            _executionNumber.SetAccessPath(path, validateHasBeenSet);
            _jobId.SetAccessPath(path, validateHasBeenSet);
            _jobName.SetAccessPath(path, validateHasBeenSet);
            _branch.SetAccessPath(path, validateHasBeenSet);
            _status.SetAccessPath(path, validateHasBeenSet);
            _triggeredTime.SetAccessPath(path, validateHasBeenSet);
            _startedTime.SetAccessPath(path, validateHasBeenSet);
            _finishedTime.SetAccessPath(path, validateHasBeenSet);
            _changesFromExclude.SetAccessPath(path, validateHasBeenSet);
            _changesCount.SetAccessPath(path, validateHasBeenSet);
            _predictedEndTime.SetAccessPath(path, validateHasBeenSet);
            _failureConditions.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
