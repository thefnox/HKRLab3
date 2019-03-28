﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebRole2.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SaveStudent", ReplyAction="http://tempuri.org/IService1/SaveStudentResponse")]
        void SaveStudent(int studentId, string courseNumber, string courseTitle, float hp, string coursePeriod, string studentName, string email, int grade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SaveStudent", ReplyAction="http://tempuri.org/IService1/SaveStudentResponse")]
        System.Threading.Tasks.Task SaveStudentAsync(int studentId, string courseNumber, string courseTitle, float hp, string coursePeriod, string studentName, string email, int grade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateStudent", ReplyAction="http://tempuri.org/IService1/UpdateStudentResponse")]
        bool UpdateStudent(int studentId, string courseNumber, string email, int grade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateStudent", ReplyAction="http://tempuri.org/IService1/UpdateStudentResponse")]
        System.Threading.Tasks.Task<bool> UpdateStudentAsync(int studentId, string courseNumber, string email, int grade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CoursesCompleted", ReplyAction="http://tempuri.org/IService1/CoursesCompletedResponse")]
        int CoursesCompleted(int studentId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CoursesCompleted", ReplyAction="http://tempuri.org/IService1/CoursesCompletedResponse")]
        System.Threading.Tasks.Task<int> CoursesCompletedAsync(int studentId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteStudent", ReplyAction="http://tempuri.org/IService1/DeleteStudentResponse")]
        bool DeleteStudent(int studentId, string courseNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteStudent", ReplyAction="http://tempuri.org/IService1/DeleteStudentResponse")]
        System.Threading.Tasks.Task<bool> DeleteStudentAsync(int studentId, string courseNumber);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WebRole2.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WebRole2.ServiceReference1.IService1>, WebRole2.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void SaveStudent(int studentId, string courseNumber, string courseTitle, float hp, string coursePeriod, string studentName, string email, int grade) {
            base.Channel.SaveStudent(studentId, courseNumber, courseTitle, hp, coursePeriod, studentName, email, grade);
        }
        
        public System.Threading.Tasks.Task SaveStudentAsync(int studentId, string courseNumber, string courseTitle, float hp, string coursePeriod, string studentName, string email, int grade) {
            return base.Channel.SaveStudentAsync(studentId, courseNumber, courseTitle, hp, coursePeriod, studentName, email, grade);
        }
        
        public bool UpdateStudent(int studentId, string courseNumber, string email, int grade) {
            return base.Channel.UpdateStudent(studentId, courseNumber, email, grade);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateStudentAsync(int studentId, string courseNumber, string email, int grade) {
            return base.Channel.UpdateStudentAsync(studentId, courseNumber, email, grade);
        }
        
        public int CoursesCompleted(int studentId) {
            return base.Channel.CoursesCompleted(studentId);
        }
        
        public System.Threading.Tasks.Task<int> CoursesCompletedAsync(int studentId) {
            return base.Channel.CoursesCompletedAsync(studentId);
        }
        
        public bool DeleteStudent(int studentId, string courseNumber) {
            return base.Channel.DeleteStudent(studentId, courseNumber);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteStudentAsync(int studentId, string courseNumber) {
            return base.Channel.DeleteStudentAsync(studentId, courseNumber);
        }
    }
}
