using System;

namespace API.Errors
{
    public class ApiErrorResponse
    {
    public ApiErrorResponse(int statusCode, string message, string? details)
        {
            StatusCode = statusCode;
            Message = message;
            Details = details;
        }
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public string? Details { get; set; }
         
    }
}
