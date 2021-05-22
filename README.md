# Bachelor Thesis

## Prerequisites
- [Git](https://git-scm.com/download/win)
- [Node.JS](https://nodejs.org/en/download/)
- [Angular CLI](https://angular.io/guide/setup-local)
- [Mircosoft .Net SDK](https://dotnet.microsoft.com/download/visual-studio-sdks)
- [VC_redist](https://support.microsoft.com/en-us/topic/the-latest-supported-visual-c-downloads-2647da03-1eea-4433-9aff-95f26a218cc0)
- [SQL Server LocalDB](https://docs.microsoft.com/en-us/sql/database-engine/configure-windows/sql-server-express-localdb?view=sql-server-ver15)


## Backend

Build any .NET Core sample using the .NET Core CLI, which is installed with the .NET Core SDK. Then run `dotnet build` command from the CLI in the directory bakalarska_praca.
These will install any needed dependencies, build the project, and run the project respectively. Copy database to `/bin/Debug/netcoreapp3.1`. 

### Launch application

Run `dotnet run --urls=https://localhost:44386/` to launch application.

## Frontend

To install the Angular CLI, open a terminal window and run the following command: `npm install -g @angular/cli`.
Run `ng build` to build the project. Run `npm update` in case of failed build due to missing module.

To get more help on the Angular CLI use `ng help` or go check out the [Angular CLI Overview and Command Reference](https://angular.io/cli) page.

### Local server

Run `ng serve` for a dev server. Navigate to `https://localhost:4200/`. Run `ng serve --ssl false` in case you don't have certificate installed.
