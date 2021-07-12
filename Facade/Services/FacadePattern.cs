namespace Facade.Services
{
    public class FacadePattern
    {
        public void SendMessage(string nationalCode)
        {
            var customerService = new CustomerService();
            var customer = customerService.GetByNationalCode(nationalCode);
            var textService = new TextService();
            var text = textService.Get();
            var messageService = new SendMessageService();
            messageService.Send(customer, text);
        }
    }
}
