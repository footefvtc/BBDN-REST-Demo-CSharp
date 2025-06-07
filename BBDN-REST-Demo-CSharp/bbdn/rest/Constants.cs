using System;

namespace BBDNRESTDemoCSharp
{
	public class Constants
	{
		public static string HOSTNAME = "https://fvtcsdev.blackboard.com";
		public static string KEY = "1bd8a5a8-b77a-4117-bec0-ec1ac8ba0a47"; 
		public static string SECRET = "QwB48XHYeE0n1lZjVjAwoVugKfQgXK06";

		public static string AUTH_PATH = "/learn/api/public/v1/oauth2/token";

		public static string DATASOURCE_PATH = "/learn/api/public/v1/dataSources";
		public static string DATASOURCE_ID = "BBDN-DSK-CSHARP";
		public static string DATASOURCE_DESCRIPTION = "Demo Data Source used for REST CSharp Demo";

		public static string TERM_PATH = "/learn/api/public/v1/terms";
		public static string TERM_ID = "BBDN-TERM-CSHARP";
		public static string TERM_NAME = "REST Demo Term - CSharp";
		public static string TERM_RAW = "Term Used For REST Demo - CSharp";
		public static string TERM_DISPLAY = "Term Used For REST Demo - CSharp";

		public static string COURSE_PATH = "/learn/api/public/v1/courses";
		public static string COURSE_ID = "10152125-1-2025spring";
		public static string COURSE_NAME = "Course Used For REST Demo - CSharp";
		public static string COURSE_DESCRIPTION = "Course Used For REST Demo - CSharp";

		public static string USER_PATH = "/learn/api/public/v1/users";
		public static string USER_ID = "500202940";
		public static string USER_NAME = "restcsharpuser";
		public static string USER_PASS = "Bl@ckb0ard!";
		public static string USER_FIRST = "CSharp";
		public static string USER_LAST = "Restdemo";
		public static string USER_EMAIL = "developers@blackboard.com";	

	}
}

