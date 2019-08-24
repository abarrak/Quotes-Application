using System;

namespace QuotesApp.Application.DTOs
{
    public class ApiResultOutput
    {
        public bool Success { get; set; }
        public int Code { get; set; }
        public string Message { get; set; }
    }
}
