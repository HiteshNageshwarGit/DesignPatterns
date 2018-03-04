﻿using DesignPatterns.Employee_Manager;
using DesignPatterns.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatterns.FactoryMethod
{
    public class ContractEmployeeFactory : BaseEmployeeFactory
    {
        public ContractEmployeeFactory(Employee emp) : base(emp)
        {
        }

        public override IEmployeeManager Create()
        {
            ContractEmployeeManager manager = new ContractEmployeeManager();
            _emp.MedicalAllowance = manager.GetMedicalAllowance();
            return manager;
        }
    }
}