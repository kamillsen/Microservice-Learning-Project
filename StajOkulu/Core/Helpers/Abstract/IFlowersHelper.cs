using Core.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Helpers.Abstract
{
    public interface IFlowersHelper
    {
        Task<List<GetFlowersInformationResponseDataModel>> GetFlowersInformationAsync();
    }
}
