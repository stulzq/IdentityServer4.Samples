// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace Api.Controllers
{

	
	[Route("[controller]")]
    
    public class IdentityController : ControllerBase
    {
	    [Authorize(Roles = "superadmin")]
		[HttpGet]
        public IActionResult Get()
        {
            return new JsonResult(from c in HttpContext.User.Claims select new { c.Type, c.Value });
        }

	    [Authorize(Roles = "admin")]
		[Route("{id}")]
	    [HttpGet]
	    public string Get(int id)
	    {
		    return id.ToString();
	    }
	}
}