# aspnetSqlServerWithDocker

# step 1
    docker pull mcr.microsoft.com/mssql/server:2019-latest

    docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=2Secure*Password2" -p 1450:1433 --name sqlserverdb -h mysqlserver -d mcr.microsoft.com/mssql/server:2019-latest


# step 2

-   logon ssms
        -   server name: localhost, 1450
        -   login name: SA
        -   password: 2Secure*Password2

# step 3

-   set up web app with sql server based on sql server info above

# step 4

-   add docker compose (linux)
