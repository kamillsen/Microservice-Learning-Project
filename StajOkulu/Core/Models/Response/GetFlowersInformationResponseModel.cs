using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models.Response
{
    public class GetFlowersInformationResponseModel
    {
        public string? internalMessage { get; set; }    
        public string?userMessage { get; set; }

        public List<GetFlowersInformationResponseDataModel>? data { get; set; } 
    }
}
