//
// IssuedTokenParametersElement.cs
//
// Author:
//	Atsushi Enomoto <atsushi@ximian.com>
//
// Copyright (C) 2006 Novell, Inc.  http://www.novell.com
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Configuration;
using System.Net;
using System.Net.Security;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.IdentityModel.Claims;
using System.IdentityModel.Policy;
using System.IdentityModel.Tokens;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Diagnostics;
using System.ServiceModel.Dispatcher;
using System.ServiceModel.MsmqIntegration;
using System.ServiceModel.PeerResolvers;
using System.ServiceModel.Security;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;

namespace System.ServiceModel.Configuration
{
	public sealed class IssuedTokenParametersElement
		 : ConfigurationElement
	{
		public IssuedTokenParametersElement ()
		{
		}


		// Properties

		[ConfigurationProperty ("additionalRequestParameters",
			 Options = ConfigurationPropertyOptions.None)]
		public XmlElementElementCollection AdditionalRequestParameters {
			get { return (XmlElementElementCollection) base ["additionalRequestParameters"]; }
		}

		[ConfigurationProperty ("claimTypeRequirements",
			 Options = ConfigurationPropertyOptions.None)]
		public ClaimTypeElementCollection ClaimTypeRequirements {
			get { return (ClaimTypeElementCollection) base ["claimTypeRequirements"]; }
		}

		[ConfigurationProperty ("issuer",
			 Options = ConfigurationPropertyOptions.None)]
		public IssuedTokenParametersEndpointAddressElement Issuer {
			get { return (IssuedTokenParametersEndpointAddressElement) base ["issuer"]; }
		}

		[ConfigurationProperty ("issuerMetadata",
			 Options = ConfigurationPropertyOptions.None)]
		public EndpointAddressElementBase IssuerMetadata {
			get { return (EndpointAddressElementBase) base ["issuerMetadata"]; }
		}

		[ConfigurationProperty ("keySize",
			 Options = ConfigurationPropertyOptions.None,
			 DefaultValue = "0")]
		[IntegerValidator ( MinValue = 0,
			MaxValue = int.MaxValue,
			ExcludeRange = false)]
		public int KeySize {
			get { return (int) base ["keySize"]; }
			set { base ["keySize"] = value; }
		}

		[ConfigurationProperty ("keyType",
			 Options = ConfigurationPropertyOptions.None,
			 DefaultValue = "SymmetricKey")]
		public SecurityKeyType KeyType {
			get { return (SecurityKeyType) base ["keyType"]; }
			set { base ["keyType"] = value; }
		}

		protected override ConfigurationPropertyCollection Properties {
			get { return base.Properties; }
		}

		[StringValidator ( MinLength = 0,
			MaxLength = int.MaxValue,
			 InvalidCharacters = null)]
		[ConfigurationProperty ("tokenType",
			 Options = ConfigurationPropertyOptions.None,
			 DefaultValue = "")]
		public string TokenType {
			get { return (string) base ["tokenType"]; }
			set { base ["tokenType"] = value; }
		}

		[MonoTODO]
		public bool UseStrTransform {
			get {
				throw new NotImplementedException ();
			}
			set {
				throw new NotImplementedException ();
			}
		}


	}

}
