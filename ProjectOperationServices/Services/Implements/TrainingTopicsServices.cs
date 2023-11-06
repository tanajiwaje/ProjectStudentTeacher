using ProjectOperationServices.Models;
using ProjectOperationServices.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOperationServices.Services.Implements
{
   public class TrainingTopicsServices : ITrainingTopicsServices
    {
        private IRepository<sp_fetch_tbltraining_topics_Result> _repository;
        public TrainingTopicsServices(IRepository<sp_fetch_tbltraining_topics_Result> repository)
        {
            _repository = repository;
        }

        public void AddTrainingTopics(sp_fetch_tbltraining_topics_Result topics)
        {
            try
            {
                string sp_name = "[sp_tbltraining_topics]{0},{1},{2}";
                object[] parameters = { "Insert", topics.topic_id, topics.topic_name };
                _repository.ExecuteCommnad(sp_name, parameters);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        public void UpdateTrainingTopics(sp_fetch_tbltraining_topics_Result topics)
        {
            try
            {                        
                string sp_name = "[sp_tbltraining_topics]{0},{1},{2}";
                object[] parameters = { "UPDATE", topics.topic_id, topics.topic_name };
                _repository.ExecuteCommnad(sp_name, parameters);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        public void DeleteTrainingTopics(int topics_id)
        {
            try
            {
                string sp_name = "[sp_tbltraining_topics]{0},{1},{2}";
                object[] parameters = { "Delete",topics_id ,"" };
                _repository.ExecuteCommnad(sp_name, parameters);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        public List<sp_fetch_tbltraining_topics_Result> getAll()
        {
            try
            {
                string sp_name = "[sp_fetch_tbltraining_topics]{0}";
                object[] parameters = { 0 };
                return _repository.ExecuteQuery(sp_name, parameters);

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                return null;
            }
        }

        public sp_fetch_tbltraining_topics_Result GetTrainingTopicsById(int topics_id)
        {
            try
            {
                string sp_name = "[sp_fetch_tbltraining_topics]{0}";
                object[] parameters = {  topics_id };
                return _repository.ExecuteQuery(sp_name, parameters).First() ;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                return null;
            }
        }

       
    }
}
