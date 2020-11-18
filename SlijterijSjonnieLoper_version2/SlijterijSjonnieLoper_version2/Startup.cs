using Hangfire;
using Microsoft.Owin;
using Owin;
using SlijterijSjonnieLoper_version2.Models;

[assembly: OwinStartupAttribute(typeof(SlijterijSjonnieLoper_version2.Startup))]
namespace SlijterijSjonnieLoper_version2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            GlobalConfiguration.Configuration.UseSqlServerStorage("DefaultConnection");
            app.UseHangfireDashboard();
            RecurringJob.AddOrUpdate(() => HangFire.HangFireDailyCommandos.UpdateIfReservationIsDoneDaily(), Cron.Daily);
            app.UseHangfireServer();

        }
    }
}
