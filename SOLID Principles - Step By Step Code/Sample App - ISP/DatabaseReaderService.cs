﻿namespace SOLID.SampleApp
{
	public class DatabaseReaderService
	{
		public string GetMessageBody()
		{
			//pretend you see some database connection going on here. :)
			//SqlConnection conn = new SqlConnection("connection string info"); etc. etc. etc.
			return "pretend this came from a database. :)";			
		}
	}
}
