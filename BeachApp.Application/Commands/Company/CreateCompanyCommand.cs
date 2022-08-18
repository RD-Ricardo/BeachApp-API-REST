using BeachApp.Application.Commands.Interfaces;
using Flunt.Notifications;
using Flunt.Validations;

namespace BeachApp.Application.Commands.Company
{
    public class CreateCompanyCommand  : Notifiable,  ICommand
    {
       public string NameCompany { get; set; } 
       public string Login { get; set; } 
       public string Password { get; set; }

        public void Validate()
        {
            AddNotifications(
               new Contract()
                .Requires()
            );
        }
    }
}