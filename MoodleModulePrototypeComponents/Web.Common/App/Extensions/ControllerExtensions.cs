using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Text;
using System.Web.Mvc;

namespace Web.Common.App.Extensions
{
    public static class ControllerExtensions
    {
        #region [BuildUrlFromExpression]

        public static string BuildUrlFromExpression<TController>(this Controller controller, Expression<Action<TController>> action, bool replaceDefaultsWithPlaceholder = false, object routeData = null)
            where TController : Controller
        {
            if (controller is TController)
                return ((TController)controller).BuildUrlFromExpression(action, replaceDefaultsWithPlaceholder, routeData);

            var implementorType = !typeof(TController).IsAbstract ? typeof(TController) : controller.ResolveImplementorFor<TController>();
            return controller.Request.BuildUrlFromExpression(action, implementorType, replaceDefaultsWithPlaceholder, routeData);
        }

        public static string BuildUrlFromExpression<TController>(this TController controller, Expression<Action<TController>> action, bool replaceDefaultsWithPlaceholder = false, object routeData = null)
            where TController : Controller
        {
            // support class inheritance
            if (typeof(TController) != controller.GetType())
            {
                var implementorType = controller.ResolveImplementorFor<TController>();
                return controller.Request.BuildUrlFromExpression(action, implementorType, replaceDefaultsWithPlaceholder, routeData);
            }

            return controller.Request.BuildUrlFromExpression(action, replaceDefaultsWithPlaceholder, routeData);
        }

        public static string BuildAbsoluteUrlFromExpression<TController>(this Controller controller, Expression<Action<TController>> action, bool replaceDefaultsWithPlaceholder = false, object routeData = null)
            where TController : Controller
        {
            return controller.BuildUrlFromExpression(action, replaceDefaultsWithPlaceholder, routeData).ToAbsoluteUrlWith(controller.Request.GetRootUrl());
        }

        public static string BuildAbsoluteUrlFromExpression<TController>(this TController controller, Expression<Action<TController>> action, bool replaceDefaultsWithPlaceholder = false, object routeData = null)
            where TController : Controller
        {
            return controller.BuildUrlFromExpression(action, replaceDefaultsWithPlaceholder, routeData).ToAbsoluteUrlWith(controller.Request.GetRootUrl());
        }

        #endregion

        public static Type ResolveImplementorFor<T>(this ControllerBase controller, bool throwExceptionIfNotFound = true)
            where T : class
        {
            if (controller is T)
                return controller.GetType();

            if (controller.ControllerContext.ParentActionViewContext != null)
                return controller.ControllerContext.ParentActionViewContext.Controller.ResolveImplementorFor<T>(throwExceptionIfNotFound);

            if (throwExceptionIfNotFound)
                throw new InvalidOperationException($"Failed to resolve '{typeof(T).Name}'.");

            return null;
        }

        public static HttpStatusCodeResult Ok(this Controller controller)
        {
            return new HttpStatusCodeResult(HttpStatusCode.OK);
        }
    }
}