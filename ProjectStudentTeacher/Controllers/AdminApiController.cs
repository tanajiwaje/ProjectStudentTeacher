using System;
using System.Collections.Generic;
using System.Web.Http;
//using System.Web.Mvc;
using ProjectOperationServices.Models;
using ProjectOperationServices.Services.Interface;

namespace ProjectStudentTeacher.Controllers
{
    public class AdminApiController : ApiController
    {
        ITrainingCourseServices trainingService;
        ITrainingTopicsServices topicsService;
        ITopicContentsServices contentsServices;
        IStudentDetailServices studentDetailServices;
        public AdminApiController(ITrainingCourseServices trainingService, ITrainingTopicsServices trainingTopicsService, ITopicContentsServices contentsServices, IStudentDetailServices student)
        {
            this.trainingService = trainingService;
            this.topicsService = trainingTopicsService;
            this.contentsServices = contentsServices;
            this.studentDetailServices = student;
        }

        //ITrainingCourseServices Api Methods //
        //Add 
        [HttpPost]
        [Route("api/Admin/addtrainingCourse")]
        public string AddTrainingCourse(sp_fetch_tbltraining_courses_Result coureobj)
        {
            if (!ModelState.IsValid)
            {
                return "not valid data";
            }
            else
            {
                try
                {
                    trainingService.AddTrainingCourse(coureobj);
                    return "Data Added Successfully";
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                    return "Data exception occure";
                }
            }
        }


        //Update
        [HttpPost]
        [Route("api/Admin/updatetrainingCourse")]
        public string UpdateTrainingCourse(sp_fetch_tbltraining_courses_Result coureobj)
        {
            try
            {
                trainingService.UpdateTrainingCourse(coureobj);
                return "Data Update Successfully";
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                return "exception occure";
            }

        }
        //Detete
        [HttpPost]
        [Route("api/Admin/deletetrainingCourse/{training_id}")]
        public string DeleteTrainingCourse(int training_id)
        {
            try
            {
                trainingService.DeleteTrainingCourse(training_id);
                return "Data delete Successfully";
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                return "exception occure";
            }

        }

        //GetallData
        [HttpGet]
        [Route("api/Admin/getallrainingCoursedata")]
        public List<sp_fetch_tbltraining_courses_Result> Getdata()
        {
            return trainingService.getAll();
        }
        //GetbyId
        [HttpGet]
        [Route("api/Admin/getallrainingCoursedata/{id}")]
        public sp_fetch_tbltraining_courses_Result Getbyid(int id)
        {
            return trainingService.GetTrainingCourseById(id);
        }


        /////////////////////////////////////////////////////////////////////////
        ///Training Topic Services
        ///

        //add
        [HttpPost]
        [Route("api/Admin/addtopic")]
        public string AddTopic(sp_fetch_tbltraining_topics_Result topics)
        {
            topicsService.AddTrainingTopics(topics);
            return "Data Added Successfully";
        }
        //update
        [HttpPost]
        [Route("api/Admin/updatetopic")]
        public string UpdateTopic(sp_fetch_tbltraining_topics_Result topics)
        {
            topicsService.UpdateTrainingTopics(topics);
            return "Data Update Successfully";
        }
        //delete
        [HttpDelete]
        [Route("api/Admin/deletetopic/{id}")]
        public string DeleteTopic(int id)
        {
            topicsService.DeleteTrainingTopics(id);
            return "Data Delete Successfully";
        }
        //getall
        [HttpGet]
        [Route("api/Admin/getalltopic")]
        public List<sp_fetch_tbltraining_topics_Result> GetallTopic()
        {

            return topicsService.getAll();
        }
        //getbyid
        [HttpGet]
        [Route("api/Admin/getalltopic/{id}")]
        public sp_fetch_tbltraining_topics_Result GetallTopicbyid(int id)
        {
            return topicsService.GetTrainingTopicsById(id);
        }

        ////////////////Topic Content Services//////
        ///Add
        [HttpPost]
        [Route("api/Admin/addcontent")]
        public string AddContent(sp_fetch_tbltopic_contents_Result content)
        {
            contentsServices.AddContent(content);
            return "Data Added Successfully";
        }
        ///Update
        [HttpPost]
        [Route("api/Admin/updatecontent")]
        public string UpdateContent(sp_fetch_tbltopic_contents_Result content)
        {
            contentsServices.UpdateContent(content);
            return "Data Update Successfully";
        }
        ///Delete
        [HttpDelete]
        [Route("api/Admin/deletecontent/{id}")]
        public string DeleteContent(int id)
        {
            contentsServices.DeleteContent(id);
            return "Data Delete Successfully";
        }
        ///GetAll
        [HttpGet]
        [Route("api/Admin/getallcontent")]
        public List<sp_fetch_tbltopic_contents_Result> GetAllContent()
        {
            return contentsServices.getAll();

        }
        ///GetByID
        [HttpGet]
        [Route("api/Admin/getcontentbyid/{id}")]
        public sp_fetch_tbltopic_contents_Result GetContentById(int id)
        {
            return contentsServices.GetContentById(id);

        }


        /////////Student details 
        ///Add
        [HttpPost]
        [Route("api/Admin/addstudent")]
        public string AddStdentDetails(sp_fetch_tblstudent_details_Result students)
        {
            studentDetailServices.AddStudentDetails(students);
            return "Data Added Successfully";
        }
        ///Update
        [HttpPost]
        [Route("api/Admin/updatestudent")]
        public string UpdateStdentDetails(sp_fetch_tblstudent_details_Result students)
        {
            studentDetailServices.UpdateStudentDetails(students);
            return "Data Added Successfully";
        }
        ///Delete
        [HttpDelete]
        [Route("api/Admin/deletestudent/{id}")]
        public string DeleteStdentDetails(int id)
        {
            studentDetailServices.DeleteStudentDetails(id);
            return "Data Added Successfully";
        }
        ///GetAll
        [HttpGet]
        [Route("api/Admin/getallstudent")]
        public List<sp_fetch_tblstudent_details_Result> GetAllStdentDetails()
        {
            return studentDetailServices.getAll();
        }
        ///GetById
        [HttpGet]
        [Route("api/Admin/getstudentbyid/{id}")]
        public sp_fetch_tblstudent_details_Result GetStdentDetailsById(int id)
        {
            return studentDetailServices.GetStudentDetailById(id);
        }
    }
}
