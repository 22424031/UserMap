namespace Sakila.Application.Dtos.Common
{
    public class BaseResponse<T>
    {
        public T Data { get; set; }
        public int Status { get; set; }
        public bool IsError { get; set; } = false;
        public string ErrorMessage { get; set; }
    }
}
