## Requirements
In order to run the project you will need 
- Visual Studio
- PostgreSQL 
- pgAdmin
	
## Project setup
1. Clone the project to your local machine
2. Open the project with VS and compile the project
3. In pgAdmin register a local server 
4. Based on server credentials update the ConnectionStrings in appsettings.json (under TestApplication.Web)
5. In VS click Tool -> NuGet Package Manager -> Package Manager Console
6. In opened console select 'Default project' as TestApplication.Web
7. In the console execute command Update-Database
8. After the command execution, in pgAdmin under your local server you should see form_app DB and 4 tables (history, sector, user, and user_sector)

## Extra
The default session idle time is 5 minutes. You can change the timeout in Program.cs (line 14) file.
After the session expires, any further action (submit, resubmit, refresh) will redirect you to the form page with all fields cleared.

## Further potential improvements:
- For simplicity the sessionId type is string. To improve the performance it could be converted to Guid  
- Use some framework (Angular, React, etc.) for simpler styling and validation
- Unit Tests
- Notify the User of session expiration