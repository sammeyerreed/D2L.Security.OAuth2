﻿using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D2L.Security.AuthTokenValidation.PublicKeys;
using D2L.Security.AuthTokenValidation.PublicKeys.Default;
using NUnit.Framework;

namespace D2L.Security.AuthTokenValidation.Tests.Integration {
	
	[TestFixture]
	class TemporaryTest {

		private const string AUTH_SERVER = "https://phwinsl01.proddev.d2l:44333/core/";

		[Test]
		public void TestConnectivity() {
			DefaultPublicKeyProvider provider = new DefaultPublicKeyProvider( AUTH_SERVER );
			SecurityToken token = provider._token;
			//provider.Decode2( "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsIng1dCI6IlA5NmNVbnoxQWcxaWhnRjQ3c0EtWmU4VGxxQSIsImtpZCI6IlA5NmNVbnoxQWcxaWhnRjQ3c0EtWmU4VGxxQSJ9.eyJjbGllbnRfaWQiOiJsb3Jlc19tYW5hZ2VyX2NsaWVudCIsInNjb3BlIjoiaHR0cHM6Ly9hcGkuYnJpZ2h0c3BhY2UuY29tL2F1dGgvbG9yZXMubWFuYWdlIiwiaXNzIjoiaHR0cHM6Ly9hcGkuZDJsLmNvbS9hdXRoIiwiYXVkIjoiaHR0cHM6Ly9hcGkuZDJsLmNvbS9hdXRoL3Jlc291cmNlcyIsImV4cCI6MTQyMDgzMjc4MCwibmJmIjoxNDIwODI5MTgwfQ.SWY0fGQ7x_hDWGLqFvyqrUXQ9DNWFuVo3wTW4ioBi_xcChSIr905kZc4WxfvyvP0abq5UOpdo3GHbuHNrXqh95YaTcID4iO7GYdR6XXZzBHWy0UA3Ixyqw2bJNbg2XwqsW6I4bwHTzh0fzmXkhehZqn7gGuf4hhSuEmrp7v5RqBiC2U3RmsCkDdrsWiLUK8lclkFTZpHU1wlhcdBBMe3rbV8oAPGR5t9pdHlK3mpAE-NvwN5us_hBVuIyMpxBuFSuyv1-Fk3ZwzeXXBfOlCzlI4FzqvYp5Si41W2ICpoNAkUr-SQJAfLoLkZjVR41GcWnZWOTnfd_mD238zPyRpwYw" );
			provider.Decode2( "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsIng1dCI6IlA5NmNVbnoxQWcxaWhnRjQ3c0EtWmU4VGxxQSIsImtpZCI6IlA5NmNVbnoxQWcxaWhnRjQ3c0EtWmU4VGxxQSJ9.eyJjbGllbnRfaWQiOiJsb3Jlc19tYW5hZ2VyX2NsaWVudCIsInNjb3BlIjoiaHR0cHM6Ly9hcGkuYnJpZ2h0c3BhY2UuY29tL2F1dGgvbG9yZXMubWFuYWdlIiwiaXNzIjoiaHR0cHM6Ly9hcGkuZDJsLmNvbS9hdXRoIiwiYXVkIjoiaHR0cHM6Ly9hcGkuZDJsLmNvbS9hdXRoL3Jlc291cmNlcyIsImV4cCI6MTQyMDc1NTk1MiwibmJmIjoxNDIwNzUyMzUyfQ.PYehQ8-B0fDSr_uzNEsXVRbNkZQcxFLe7rzBw8AqhUxpXJayZTwjxeAY91eR7bfZpkSbrUOBCnjgb_3sEfIXLPyQdQ2B1nhZ5NYHLB4oVYMUbuOFESNUavkiTcSJMfohZYrqNtefrxf1ewgC_ZAUC8vgEYPQiNQo1SiveSR4uxS_NI6eb7chN2q3ROVtNlnu7P32VXxFGPDyt-qJ2bv7gtSfm-fGuFmSxz9jWlWEpOHm32YCkxEudF-oJ9l69YoIY7fKYzihySaEPSQDAnvzdMbMqtvIwCvTQuQDpqW4-H3U-5RAOsQStFknHHKXAg8awyhg150ThRgPHS30MunJew" );
		}

		[Test]
		public void CanDownloadCert() {
			IPublicKeyProvider provider = PublicKeyProviderFactory.Create();
		}
	}
}
