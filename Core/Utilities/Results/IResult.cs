using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public interface IResult
    {
        bool Success { get; } //sadece get koymanın sebebi sadece okunabilir bişey olması.

        string Message { get; }

    }
}
