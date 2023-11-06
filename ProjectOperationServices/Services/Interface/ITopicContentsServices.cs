using ProjectOperationServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOperationServices.Services.Interface
{
   public interface ITopicContentsServices
    {
        void AddContent(sp_fetch_tbltopic_contents_Result contents);
        void UpdateContent(sp_fetch_tbltopic_contents_Result contents);
        void DeleteContent(int content_id);
        List<sp_fetch_tbltopic_contents_Result> getAll();
        sp_fetch_tbltopic_contents_Result GetContentById(int content_id);
    }
}
