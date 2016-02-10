namespace BookingSystem.Views.ErrorPages
{
    using System.Text;

    public class Error : View
    {
        public Error(string message)
            : base(message)
        {
        }

        protected override void BuildViewResult(StringBuilder viewResult)
        {
            var message = this.Model as string;
            viewResult
                .AppendLine("Something happened!!1")
                .AppendLine(message);
        }
    }
}
