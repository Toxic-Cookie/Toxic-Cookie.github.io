using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

public class Neos
{
    [HttpGet()]
    public string GetString()
    {
        return "This is a string.";
    }
}
