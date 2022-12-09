using Microsoft.AspNetCore.Mvc;
using webapi_test.Service.Response;

namespace webapi_test.Controllers
{
    public abstract class BaseController : ControllerBase
    {
        private IEnumerable<string> GetModelStateError()
        {
            return ModelState.Values
                .SelectMany(v => v.Errors)
                .Select(e => e.ErrorMessage).ToList();
        }

        protected JsonResult GetBasicSuccessJson()
        {
            return Json(new { IsSuccess = true });
        }

        protected JsonResult GetSuccessJson(BasicResponse response, object value)
        {
            return Json(new
            {
                IsSuccess = true,
                MessageInfoTextArray = response.GetMessageInfoTextArray(),
                Value = value
            });
        }

        protected JsonResult GetErrorJson(string[] messages)
        {
            return Json(new
            {
                IsSuccess = false,
                MessageErrorTextArray = messages
            });
        }

        protected JsonResult GetErrorJson(string message)
        {
            var messageArray = new[] { message };
            return Json(new
            {
                IsSuccess = false,
                MessageErrorTextArray = messageArray
            });
        }

        protected JsonResult GetErrorJson(BasicResponse response)
        {
            return Json(new
            {
                IsSuccess = false,
                MessageErrorTextArray = response.GetMessageErrorTextArray()
            });
        }

        protected JsonResult GetErrorJsonFromModelState()
        {
            return GetErrorJson(GetModelStateError().ToArray());
        }

        [NonAction]
        protected virtual JsonResult Json(object data)
        {
            return new JsonResult(data);
        }
    }
}