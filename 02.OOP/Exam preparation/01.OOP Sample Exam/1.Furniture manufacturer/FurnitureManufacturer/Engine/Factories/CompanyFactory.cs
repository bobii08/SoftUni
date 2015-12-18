namespace FurnitureManufacturer.Engine.Factories
{
    using System;
    using Interfaces;
    using Interfaces.Engine;
    using Models;

    public class CompanyFactory : ICompanyFactory
    {
        public ICompany CreateCompany(string name, string registrationNumber)
        {
            var company = new Company(name, registrationNumber);
            return company;
        }
    }
}
