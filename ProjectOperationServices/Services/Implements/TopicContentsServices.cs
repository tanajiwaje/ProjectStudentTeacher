using ProjectOperationServices.Models;
using ProjectOperationServices.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOperationServices.Services.Implements
{
    public class TopicContentsServices : ITopicContentsServices
    {
        private readonly IRepository<sp_fetch_tbltopic_contents_Result> _content;
        public TopicContentsServices(IRepository<sp_fetch_tbltopic_contents_Result> content)
        {
            _content = content;
        }

        public void AddContent(sp_fetch_tbltopic_contents_Result contents)
        {
            try
            {
                string sp_name = "[sp_tbltopic_contents]{0},{1},{2},{3}";
                object[] parameters = { "Insert", contents.content_id, contents.topic_id, contents.content_name };
                _content.ExecuteCommnad(sp_name, parameters);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        public void UpdateContent(sp_fetch_tbltopic_contents_Result contents)
        {
            try
            {
                string sp_name = "[sp_tbltopic_contents]{0},{1},{2},{3}";
                object[] parameters = { "Update", contents.content_id, contents.topic_id, contents.content_name };
                _content.ExecuteCommnad(sp_name, parameters);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        public void DeleteContent(int content_id)
        {
            try
            {
                string sp_name = "[sp_tbltopic_contents]{0},{1},{2},{3}";
                object[] parameters = { "delete",content_id, 0, "" };
                _content.ExecuteCommnad(sp_name, parameters);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        public List<sp_fetch_tbltopic_contents_Result> getAll()
        {
            try
            {
                string sp_name = "[sp_fetch_tbltopic_contents]{0}";
                object[] parameters = { 0 };
                return _content.ExecuteQuery(sp_name, parameters);

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                return null;
            }
        }

        public sp_fetch_tbltopic_contents_Result GetContentById(int content_id)
        {
            try
            {
                string sp_name = "[sp_fetch_tbltopic_contents]{0}";
                object[] parameters = { 0 };
                return _content.ExecuteQuery(sp_name, parameters).First() ;

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                return null;
            }
        }

       
    }
}
