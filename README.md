# jQuery-Autocomplete-with-SQL-on-C-ASP.NET

Database saved to AutoCom.mdf file. To connect this database you have to edit Web.config file connectionString section AttachDbFileName to change to the right path!

<connectionStrings>
    <add name="AutoConn" connectionString="Data Source=   (localdb)\v11.0;AttachDbFileName=C:\Web\AutoComplete\Code_Offline\AutoCom.mdf;Integrated Security=True"   providerName="System.Data.SqlClient"/>
</connectionStrings>

After when connectionString is right you can connect to Database in 'Data Connections' on Server Explorer.

Sample data in IF_AutoComplete table!

Sql query in IF_READ_AUTO_COMPLETE at Stored Procedures!

All required sql commands in AutoCom.sql file!

Enjoy !
