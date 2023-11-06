using ProjectOperationServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOperationServices.Services.Interface
{
    public interface ITrainingTopicsServices
    {
        void AddTrainingTopics(sp_fetch_tbltraining_topics_Result topics);
        void UpdateTrainingTopics(sp_fetch_tbltraining_topics_Result topics);
        void DeleteTrainingTopics(int topics_id);
        List<sp_fetch_tbltraining_topics_Result> getAll();
        sp_fetch_tbltraining_topics_Result GetTrainingTopicsById(int topics_id);
    }
}
