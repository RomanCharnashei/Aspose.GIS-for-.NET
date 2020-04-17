using System;
using System.Data;
using System.Configuration;
using System.Web;

/// <summary>
/// Summary description for Configuration
/// </summary>
namespace Aspose.GIS.Live.Demos.UI.Config
{
	public static class Configuration
	{		
		private static string _appName = ConfigurationManager.AppSettings["AppName"].ToString();
		private static string _asposeGISLiveDemosPath = ConfigurationManager.AppSettings["AsposeGISLiveDemosPath"].ToString();
		private static string _resourceFileSessionName = ConfigurationManager.AppSettings["ResourceFileSessionName"];	      
		private static string _fileViewLink = ConfigurationManager.AppSettings["FileViewLink"];		
		private static string _asposeGISAppsAssetURL = ConfigurationManager.AppSettings["AsposeGISAppsAssetURL"];

		public static string ResourceFileSessionName
		{
			get { return _resourceFileSessionName; }
		}
		/// <summary>
		/// Get Working Directory
		/// </summary>
		public static string WorkingDirectory
		{
			get {
				string sourceFilespath = HttpContext.Current.Server.MapPath("~/Assets/SourceFiles/");
				if ( ! System.IO.Directory.Exists(sourceFilespath))
				{
					System.IO.Directory.CreateDirectory(sourceFilespath);
				}

				return sourceFilespath;
			}
		}

		/// <summary>
		/// Get Working Directory
		/// </summary>
		public static string OutputDirectory
		{
			get
			{
				string OutputFilespath = HttpContext.Current.Server.MapPath("~/Assets/OutputFiles/");
				if (!System.IO.Directory.Exists(OutputFilespath))
				{
					System.IO.Directory.CreateDirectory(OutputFilespath);
				}

				return OutputFilespath;
			}
		}		
		public static string AsposeThreeDLiveDemosPath
		{
			get { return _asposeGISLiveDemosPath; }
		}	
		
		public static string AppName
        {
            get { return _appName; }
        }
        public static string AsposeThreeDAppsAssetURL
		{
            get { return _asposeGISAppsAssetURL; }
        }
        
		public static string FileViewLink
		{
			get { return _fileViewLink; }
		}
	}
}
