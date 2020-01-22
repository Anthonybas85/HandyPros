using System.Collections.Generic;

namespace DataModels.Models
{
    public class AgentsByYearModel
    {
        public AgentsByYearModel()
        {
            MaturityAgents = new List<MaturityAgentsDetailsModel>();
        }

        public List<MaturityAgentsDetailsModel> MaturityAgents { get; set; }
       
    }
}
