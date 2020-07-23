using System.Management.Automation;

namespace GPS.PowerShell
{
    [Cmdlet(VerbsCommon.Get, "VerbSuggestions")]
    public class GetVerbSuggestions : PSCmdlet
    {
        [Parameter(
            Mandatory = true,
            ValueFromPipeline = true,
            Position = 0,
            HelpMessage = "Verb to find a suitable approved Verb to utilize."
        )]
        public string Verb{get;set;}

        protected override void BeginProcessing(){
            base.BeginProcessing();
        }
        protected override void ProcessRecord(){
            base.ProcessRecord();
        }
        protected override void EndProcessing(){
            base.EndProcessing();
        }
    }
}
