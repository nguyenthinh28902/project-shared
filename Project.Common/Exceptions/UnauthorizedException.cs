using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Common.Exceptions
{
    public class UnauthorizedException : Exception
    {
        public int StatusCode { get; }

        public UnauthorizedException()
            : base("Yêu cầu không được xác thực.")
        {
            StatusCode = StatusCodes.Status401Unauthorized;
        }

        public UnauthorizedException(string message)
            : base(message)
        {
            StatusCode = StatusCodes.Status401Unauthorized;
        }

        public UnauthorizedException(string message, Exception innerException)
            : base(message, innerException)
        {
            StatusCode = StatusCodes.Status401Unauthorized;
        }
    }
}
