using BookingSystem.Views.ErrorPages;

namespace BookingSystem.Controllers
{
    using BookingSystem.Models;
    using Utilities;
    using System;
    using System.Diagnostics;
    using System.Linq;
    using System.Reflection;
    using BookingSystem.Enums;
    using BookingSystem.Exceptions;
    using BookingSystem.Interfaces;

    /// <summary>
    /// Controlls the interaction between the models and the view
    /// </summary>
    public class Controller
    {
        protected Controller(IHotelBookingSystemData data, User user)
        {
            this.Data = data;
            this.CurrentUser = user;
        }

        public User CurrentUser { get; set; }

        public bool HasCurrentUser
        {
            get { return CurrentUser != null; }
        }

        protected IHotelBookingSystemData Data { get; private set; }

        protected IView GetView(object model)
        {
            string fullNamespace = this.GetType().Namespace;
            int firstSeparatorIndex = fullNamespace.IndexOf(Constants.NamespaceSeparator);
            string baseNamespace = fullNamespace.Substring(0, firstSeparatorIndex);
            string controllerName = this.GetType().Name.Replace(Constants.ControllerSuffix, string.Empty);
            string actionName = new StackTrace().GetFrame(1).GetMethod().Name;
            string fullPath = string.Join(
                Constants.NamespaceSeparator,
                new[] { baseNamespace, Constants.ViewsFolder, controllerName, actionName });
            var viewType = Assembly
                .GetExecutingAssembly()
                .GetType(fullPath);
            return Activator.CreateInstance(viewType, model) as IView;
        }

        protected IView NotFound(string message)
        {
            return new Error(message);
        }

        protected void Authorize(params Roles[] roles)
        {
            if (!HasCurrentUser)
            {
                throw new ArgumentException("There is no currently logged in user.");
            }

            if (!roles.Any(role => CurrentUser.IsInRole(role)))
            {
                throw new AuthorizationFailedException("The currently logged in user doesn't have sufficient rights to perform this operation.", CurrentUser);
            }
        }
    }
}
