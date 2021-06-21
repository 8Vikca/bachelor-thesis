# Bachelor Thesis

In case you are member of organization VUT you can download working virtual machine with web application integrated from [Google Drive](https://drive.google.com/drive/folders/1KVkOSS4HEcpgYRN-5qQGOuz7_Xhd18Fu?usp=sharing). 

The demonstration of experimental workplace and explanation of web application's functions are available in youtube video [here](https://youtu.be/GIMIsmXUMkk).

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

