﻿using System.Data;

namespace JSONWebAPI
{
    public interface IServiceAPI
    {
        void CreateNewAccount(string firstName, string lastName, string userName, string password);
        DataTable GetUserDetails(string userName);
        bool UserAuthentication(string userName, string passsword);
        DataTable GetDepartmentDetails();
    }
}