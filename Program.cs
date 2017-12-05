/*
 * Created by SharpDevelop.
 * User: Owner
 * Date: 12/1/2017
 * Time: 9:08 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Reflection; //Assembly.GetExecutingAssembly() etc

namespace DeepInstall
{
	class Program
	{
		public static string dat_path = null;
		public static void Main(string[] args)
		{
			dat_path = Assembly.GetExecutingAssembly().Location;
		}
	}
}