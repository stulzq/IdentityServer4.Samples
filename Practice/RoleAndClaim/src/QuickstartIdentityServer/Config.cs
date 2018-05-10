// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using IdentityServer4.Models;
using IdentityServer4.Test;
using System.Collections.Generic;
using System.Security.Claims;
using IdentityModel;
using IdentityServer4;

namespace QuickstartIdentityServer
{
    public class Config
    {
	    public static IEnumerable<IdentityResource> GetIdentityResourceResources()
	    {
		    var customProfile = new IdentityResource(
			    name: "custom.profile",
			    displayName: "Custom profile",
			    claimTypes: new[] { "role"});

			return new List<IdentityResource>
		    {
			    new IdentityResources.OpenId(), 
			    new IdentityResources.Profile(),
			    customProfile
			};
	    }
		// scopes define the API resources in your system
		public static IEnumerable<ApiResource> GetApiResources()
        {
            return new List<ApiResource>
            {
//                new ApiResource("api1", "My API")
                new ApiResource("api1", "My API",new List<string>(){JwtClaimTypes.Role})
            };
        }

        // clients want to access resources (aka scopes)
        public static IEnumerable<Client> GetClients()
        {
            // client credentials client
            return new List<Client>
            {
                new Client
                {
                    ClientId = "client",
                    AllowedGrantTypes = GrantTypes.ClientCredentials,

                    ClientSecrets = 
                    {
                        new Secret("secret".Sha256())
                    },
                    AllowedScopes = { "api1" ,IdentityServerConstants.StandardScopes.OpenId, 
	                    IdentityServerConstants.StandardScopes.Profile}
                },

                // resource owner password grant client
                new Client
                {
                    ClientId = "ro.client",
                    AllowedGrantTypes = GrantTypes.ResourceOwnerPassword,

                    ClientSecrets = 
                    {
                        new Secret("secret".Sha256())
                    },
                    AllowedScopes = { "api1" ,IdentityServerConstants.StandardScopes.OpenId, 
	                    IdentityServerConstants.StandardScopes.Profile,"custom.profile"}
                }
            };
        }

        public static List<TestUser> GetUsers()
        {
            return new List<TestUser>
            {
                new TestUser
                {
                    SubjectId = "1",
                    Username = "alice",
                    Password = "password",
	                Claims = new List<Claim>(){new Claim(JwtClaimTypes.Role,"superadmin") }
				},
                new TestUser
                {
                    SubjectId = "2",
                    Username = "bob",
                    Password = "password",
					
					Claims = new List<Claim>(){new Claim(JwtClaimTypes.Role,"admin") },
						
                }
            };
        }
    }
}