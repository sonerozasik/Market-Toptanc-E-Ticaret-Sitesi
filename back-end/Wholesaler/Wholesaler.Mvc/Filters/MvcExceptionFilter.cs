using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.Extensions.Hosting;
using System.Data.SqlTypes;
using Wholesaler.Shared.Entities.Concrete;

namespace Wholesaler.Mvc.Filters
{
    public class MvcExceptionFilter : IExceptionFilter
    {
        private readonly IHostEnvironment _environment;
        private readonly IModelMetadataProvider _metadataProvider;

        public MvcExceptionFilter(IHostEnvironment environment, IModelMetadataProvider metadataProvider)
        {
            _environment = environment;
            _metadataProvider = metadataProvider;
        }
        public void OnException(ExceptionContext context)
        {
            if (_environment.IsProduction())
            {
                context.ExceptionHandled = true;
                var mvcErrorModel = new MvcErrorModel();
                ViewResult result;
                switch (context.Exception)
                {
                    case SqlNullValueException:
                        mvcErrorModel.Message = "Beklenmeyen bir veritabanı hatasıyla karşılaşıldı. En kısa sürede çözülecektir.";
                        mvcErrorModel.Detail = context.Exception.Message;
                        result = new ViewResult { ViewName = "Error" };
                        result.StatusCode = 500;
                        break;
                    case NullReferenceException:
                        mvcErrorModel.Message = "İşlem sırasında beklenmeyen bir null verıyle karşılaşıldı. En kısa sürede çözülecektir.";
                        mvcErrorModel.Detail = context.Exception.Message;
                        result = new ViewResult { ViewName = "Error" };
                        result.StatusCode = 403;
                        break;
                    default:
                        mvcErrorModel.Message = "Beklenmeyen bir hatayla karşılaşıldı. En kısa sürede çözülecektir.";
                        result = new ViewResult { ViewName = "Error" };
                        result.StatusCode = 500;
                        break;

                }
                result.ViewData = new ViewDataDictionary (_metadataProvider, context.ModelState);
                result.ViewData.Add("MvcErrorModel", mvcErrorModel);
                
            }
        }
    }
}
