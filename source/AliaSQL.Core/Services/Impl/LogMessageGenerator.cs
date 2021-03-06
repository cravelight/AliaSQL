
using AliaSQL.Core.Model;

namespace AliaSQL.Core.Services.Impl
{
	
	public class LogMessageGenerator : ILogMessageGenerator
	{
		public string GetInitialMessage(TaskAttributes taskAttributes)
		{
            var scriptFolder = taskAttributes.RequestedDatabaseAction != RequestedDatabaseAction.Drop
															? string.Format(" using scripts from {0}", taskAttributes.ScriptDirectory)
															: string.Empty;

            var logMessage = string.Format("{0} {1} on {2}{3}\n", taskAttributes.RequestedDatabaseAction,taskAttributes.ConnectionSettings.Database, taskAttributes.ConnectionSettings.Server, scriptFolder);

			return logMessage;
		}
	}
}