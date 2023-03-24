using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics;

namespace FormationMVC.Filter
{
    public class ResponseHeaderAttribute:ActionFilterAttribute
    {
        private readonly string _name;
        private readonly string _value;
        private readonly Stopwatch _stopwatch;

        public ResponseHeaderAttribute(string name, string value)
        {
            _name = name;
            _value = value;
            _stopwatch = new Stopwatch();
        }
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            _stopwatch.Stop();

            base.OnActionExecuted(context);
        }
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            _stopwatch.Start();

            base.OnActionExecuting(context);
        }
        public override void OnResultExecuting(ResultExecutingContext context)
        {


            context.HttpContext.Response.Headers.Add(_name, _value);

            
            var responseTime = _stopwatch.ElapsedMilliseconds;

            context.HttpContext.Response.Headers.Add("Response-Time", responseTime.ToString());

            base.OnResultExecuting(context);
        }
    }
}
