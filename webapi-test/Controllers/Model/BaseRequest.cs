using System.ComponentModel.DataAnnotations;

namespace webapi_test.Controllers.Model
{
    public class BaseRequest<T>
    {
        [Display(Name = "id")]
        public T Id { get; set; }
    }
}