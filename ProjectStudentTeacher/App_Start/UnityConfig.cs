using ProjectOperationServices;
using ProjectOperationServices.Services.Implements;
using ProjectOperationServices.Services.Interface;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace ProjectStudentTeacher
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType(typeof(IRepository<>), typeof(Repository<>));
            container.RegisterType<ITrainingCourseServices,TrainingCourseServices>();
            container.RegisterType<IStudentDetailServices,StudentDetailServices>();
            container.RegisterType<IStudentPaymentServices,StudentPaymentServices>();
            container.RegisterType<IStudentRegistrationServices,StudentRegistrationServices>();
            container.RegisterType<ITopicContentsServices,TopicContentsServices>();
            container.RegisterType<ITrainingCourseFeesServices,TrainingCourseFeesServices>();
            container.RegisterType<ITrainingCourseServices,TrainingCourseServices>();
            container.RegisterType<ITrainingTopicsServices,TrainingTopicsServices>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}