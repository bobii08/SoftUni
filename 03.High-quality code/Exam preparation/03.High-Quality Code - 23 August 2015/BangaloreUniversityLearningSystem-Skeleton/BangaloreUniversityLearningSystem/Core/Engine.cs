namespace BangaloreUniversityLearningSystem.Core
{
    using System;
    using System.Linq;
    using System.Reflection;

    using BangaloreUniversityLearningSystem.Controllers;
    using BangaloreUniversityLearningSystem.Interfaces;

    public class Engine : IEngine
    {
        public Engine(IBangaloreUniversityData database)
        {
            this.Database = database;
        }

        public IBangaloreUniversityData Database { get; private set; }

        public IUser CurrentUser { get; private set; }

        public void Run()
        {
            while (true)
            {
                string str = Console.ReadLine();
                if (str == null)
                {
                    break;
                }

                var route = new Route(str);
                var controllerType =
                    Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(type => type.Name == route.ControllerName);
                var controller = Activator.CreateInstance(controllerType, this.Database, this.CurrentUser) as Controller;//TODO interface
                var action = controllerType.GetMethod(route.ActionName);
                object[] parameters = MapParameters(route, action);
                try
                {
                    var view = action.Invoke(controller, parameters) as IView;
                    Console.WriteLine(view.Display());
                    this.CurrentUser = controller.User;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.InnerException.Message);
                }
            }
        }

        private static object[] MapParameters(Route route, MethodInfo action)
        {
            return action.GetParameters().Select<ParameterInfo, object>(
                p =>
                    {
                        if (p.ParameterType == typeof(int))
                        {
                            return int.Parse(route.Parameters[p.Name]);
                        }

                        return route.Parameters[p.Name];
                    }).ToArray();
        }
    }
}