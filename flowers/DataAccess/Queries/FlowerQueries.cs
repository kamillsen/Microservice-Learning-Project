using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Queries
{
    public class FlowerQueries
    {

        internal const string GET_FLOWER_INFORMATIONS = @"
                                                        SELECT *
                                                        FROM [flower].[Flowers]";
    }
}
