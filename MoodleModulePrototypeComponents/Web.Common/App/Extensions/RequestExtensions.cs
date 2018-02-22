using System;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Common.Extensions;
using Microsoft.Web.Mvc;

namespace Web.Common.App.Extensions
{
    public static class RequestExtensions
    {
        public static string BuildAbsoluteUrlFromExpression<TController>(this HttpRequestBase request, Expression<Action<TController>> action, bool replaceDefaultsWithPlaceholder = false, object routeData = null)
             where TController : Controller
        {
            return request.RequestContext.BuildAbsoluteUrlFromExpression(action, replaceDefaultsWithPlaceholder, routeData);
        }

        public static string BuildUrlFromExpression<TController>(this HttpRequestBase request, Expression<Action<TController>> action, bool replaceDefaultsWithPlaceholder = false, object routeData = null)
            where TController : Controller
        {
            return request.RequestContext.BuildUrlFromExpression(action, replaceDefaultsWithPlaceholder, routeData);
        }

        public static string BuildAbsoluteUrlFromExpression<TController>(this RequestContext requestContext, Expression<Action<TController>> action, bool replaceDefaultsWithPlaceholder = false, object routeData = null)
            where TController : Controller
        {
            return requestContext.BuildUrlFromExpression(action, replaceDefaultsWithPlaceholder, routeData).ToAbsoluteUrlWith(requestContext.HttpContext.Request.GetRootUrl());
        }

        public static string BuildUrlFromExpression<TController>(this RequestContext requestContext, Expression<Action<TController>> action, bool replaceDefaultsWithPlaceholder = false, object routeData = null)
            where TController : Controller
        {
            var routeCollection = RouteTable.Routes;

            if (routeData != null)
            {
                var rd = new RouteData();
                rd.Values.AddRange(routeData.ToDictionary().Union(requestContext.RouteData.Values).GroupBy(kv => kv.Key).ToDictionary(g => g.Key, g => g.First().Value));
                requestContext = new RequestContext(requestContext.HttpContext, rd);
            }

            if (!replaceDefaultsWithPlaceholder)
                return LinkBuilder.BuildUrlFromExpression(requestContext, routeCollection, action);

            var parameters = ((MethodCallExpression)action.Body).Method.GetParameters().Where(p =>
                p.ParameterType.IsValueType ||
                typeof(string).IsAssignableFrom(p.ParameterType))
                .ToArray();

            var routeValues = Microsoft.Web.Mvc.Internal.ExpressionHelper.GetRouteValuesFromExpression(action);
            foreach (var param in parameters)
            {
                if (!routeValues.ContainsKey(param.Name) || !Equals(param.ParameterType.GetDefault(), routeValues[param.Name]))
                    continue;

                //use temporary placeholder because '{', '}' would be encoded
                routeValues[param.Name] = $"__{param.Name.ToLower()}__";
            }

            var virtualPathData = routeCollection.GetVirtualPathForArea(requestContext, routeValues);
            if (virtualPathData == null)
                return null;

            foreach (var param in parameters)
            {
                virtualPathData.VirtualPath = virtualPathData.VirtualPath.Replace($"__{param.Name.ToLower()}__", "{{:" + param.Name + "}}");
            }

            return virtualPathData.VirtualPath;
        }

        public static string BuildUrlFromExpression<TBaseController>(this HttpRequestBase request, Expression<Action<TBaseController>> action, Type implementorType, bool replaceDefaultsWithPlaceholder = false, object routeData = null)
            where TBaseController : Controller
        {
            if (!typeof(Controller).IsAssignableFrom(implementorType))
                throw new ArgumentException("implementor must be a controller.");

            var builder = typeof(RequestExtensions).GetMethods()
                .Where(m => m.Name == "BuildUrlFromExpression")
                .Select(m => new
                {
                    Method = m,
                    Params = m.GetParameters(),
                    Args = m.GetGenericArguments()
                }).
                Where(x => x.Params.Length == 4 && x.Args.Length == 1 &&
                    x.Params[0].ParameterType == typeof(HttpRequestBase) &&
                    x.Params[1].ParameterType == typeof(Expression<>).MakeGenericType(typeof(Action<>).MakeGenericType(x.Args[0])) &&
                    x.Params[2].ParameterType == typeof(bool) &&
                    x.Params[3].ParameterType == typeof(object)).ToArray()
                .Select(x => x.Method)
                .First().MakeGenericMethod(implementorType);

            var obj = Expression.Parameter(implementorType, action.Parameters.First().Name);
            var body = ((MethodCallExpression)action.Body).Update(obj, ((MethodCallExpression)action.Body).Arguments);

            var lambda = typeof(Expression).GetMethods().First(m => m.Name == "Lambda" && m.IsGenericMethod).MakeGenericMethod(typeof(Action<>).MakeGenericType(implementorType));
            return (string)builder.Invoke(null, new[] { request, lambda.Invoke(null, new object[] { body, new[] { obj } }), replaceDefaultsWithPlaceholder, routeData });
        }

        public static Uri GetUri(this HttpRequestBase self)
        {
            if (self == null)
                throw new ArgumentNullException(nameof(self));

            if (self.Url == null)
                throw new InvalidOperationException("Request URL is null.");

            return self.Url;
        }
    }
}