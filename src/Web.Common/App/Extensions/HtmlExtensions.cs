using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using Common;
using Common.Extensions;
using Microsoft.Web.Mvc;

namespace Web.Common.App.Extensions
{
    public static class HtmlExtensions
    {
        public static MvcForm BeginForm<TController>(this HtmlHelper helper, Expression<Action<TController>> action, object htmlAttributes = null)
            where TController : Controller
        {
            var attrs = htmlAttributes == null ? new Dictionary<string, object>() : htmlAttributes.ToDictionary();
            attrs.Add("action", helper.BuildUrlFromExpression(action));

            return helper.BeginForm(null, null, FormMethod.Post, attrs);
        }

        public static MvcHtmlString ActionLink<TController>(this HtmlHelper helper, Expression<Action<TController>> action, string linkText)
            where TController : Controller
        {
            return ActionLink(helper, action, linkText, null);
        }

        public static MvcHtmlString ActionLink<TController>(this HtmlHelper helper, Expression<Action<TController>> action, string linkText, object htmlAttributes)
            where TController : Controller
        {
            return Microsoft.Web.Mvc.LinkExtensions.ActionLink(helper, action, linkText, htmlAttributes);
        }

        public static IHtmlString RawJson(this HtmlHelper helper, object value)
        {
            if (value == null)
                return helper.Raw("null");

            var json = value.ToJson();
            if (!json.IsEmpty())
                json = json.Replace("</script", "\\x3c/script").Replace(RegexLib.BreakingJsStringSymbol, "");

            return helper.Raw(json);
        }

        public static void RenderAction<TController>(this HtmlHelper helper, Expression<Action<TController>> action) where TController : Controller
        {
            if (helper == null)
                throw new ArgumentNullException(nameof(helper));

            if (action == null)
                throw new ArgumentNullException(nameof(action));

            TryRenderAction(helper, action);
        }

        public static void RenderAction<TController>(this HtmlHelper helper, Expression<Action<TController>> action, Type implementorType) where TController : Controller
        {
            if (helper == null)
                throw new ArgumentNullException(nameof(helper));

            if (action == null)
                throw new ArgumentNullException(nameof(action));

            if (implementorType == null)
                throw new ArgumentNullException(nameof(implementorType));

            if (implementorType == typeof(TController))
            {
                TryRenderAction(helper, action);
                return;
            }

            var builder = typeof(HtmlExtensions).GetMethod(nameof(TryRenderAction), BindingFlags.NonPublic | BindingFlags.Static)?.MakeGenericMethod(implementorType);
            var obj = Expression.Parameter(implementorType, action.Parameters.First().Name);
            var body = ((MethodCallExpression)action.Body).Update(obj, ((MethodCallExpression)action.Body).Arguments);

            var lambda = typeof(Expression).GetMethods().First(m => m.Name == nameof(Expression.Lambda) && m.IsGenericMethod).MakeGenericMethod(typeof(Action<>).MakeGenericType(implementorType));

            builder?.Invoke(null, new[] { helper, lambda.Invoke(null, new object[] { body, new[] { obj } }) });
        }

        private static void TryRenderAction<TController>(this HtmlHelper helper, Expression<Action<TController>> action) where TController : Controller
        {
            bool IsErrorController(ViewContext vc) => vc != null && IsErrorController(vc.ParentActionViewContext);

            if (!IsErrorController(helper.ViewContext))
            {
                ViewExtensions.RenderAction(helper, action);
                return;
            }

            try
            {
                ViewExtensions.RenderAction(helper, action);
            }
            catch
            {
                // ignored
            }
        }

        public static string BuildUrlFromExpression<TController>(this HtmlHelper helper, Expression<Action<TController>> action, bool replaceDefaultsWithPlaceholder = false, object routeData = null)
            where TController : Controller
        {
            return ((Controller)helper.ViewContext.Controller).BuildUrlFromExpression(action, replaceDefaultsWithPlaceholder, routeData);
        }
    }
}