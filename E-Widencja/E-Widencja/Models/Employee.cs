using C_OreDB;
using C_OreDB.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace E_Widencja.Models
{ 
    public class Employee : ModelsInterface
    {
        private string _firstName;
        [Display(Name = "Imię")]
        public string firstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }

        private string _surname;
        [Display(Name = "Nazwisko")]
        public string surname
        {
            get
            {
                return _surname;
            }
            set
            {
                _surname = value;
            }
        }

        private DateTime? _dateOfBirth;
        [Display(Name = "Data urodzenia")]
        public DateTime? dateOfBirth
        {
            get
            {
                return _dateOfBirth;
            }
            set
            {
                _dateOfBirth = value;
            }
        }

        Employee(int id)
        {
            EmployeeDB employee = new EmployeeDB(id);
            firstName = employee.firstName;
            surname = employee.surname;
        }

        public void save()
        {

        }
    }
}