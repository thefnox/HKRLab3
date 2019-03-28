﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        void SaveStudent(int studentId, string courseNumber, string courseTitle, float hp, string coursePeriod, string studentName, string email, int grade);

        [OperationContract]
        bool UpdateStudent(int studentId, string courseNumber, string email, int grade);

        [OperationContract]
        int CoursesCompleted(int studentId);

        [OperationContract]
        bool DeleteStudent(int studentId, string courseNumber);
    }
}
